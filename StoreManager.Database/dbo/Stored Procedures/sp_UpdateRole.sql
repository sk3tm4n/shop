create procedure sp_UpdateRole
@ID int,
@RoleName nvarchar(50),
@RoleCode varchar(3)
as
begin
	set nocount on;

		update Roles
		set RoleName = @RoleName,
		RoleCode = @RoleCode,
		UpdateDate = GETDATE()
		where RoleID = @ID and IsDeleted = 0;

	return 0;
end

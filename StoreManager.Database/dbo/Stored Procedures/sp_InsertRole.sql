create procedure sp_InsertRole
@RoleName nvarchar(50),
@RoleCode char(3),
@ID int out
as
begin
	set nocount on;

		insert into Roles(RoleName, RoleCode)
		values(@RoleName, @RoleCode)

		set @ID = @@IDENTITY;

	return 0;
end

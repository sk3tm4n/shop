CREATE procedure [dbo].[sp_InsertProduct]
@CategoryID int,
@ProductCode varchar(10),
@Name nvarchar(50),
@Description nvarchar(1000),
@UnitPrice money,
@EmployeeID int,
@ID int out
as
begin
	set nocount on;

	declare @RoleCode char(3) = 'ADM';

	declare @HasPermission bit = dbo.HasPermission(1, @RoleCode);

	if @HasPermission = 0
	begin
		raiserror('You not have permission to add product', 16, 401)
		return 1;
	end

	insert into Products(CategoryID, ProductCode, Name, Description, UnitPrice) 
	values (@CategoryID, @ProductCode, @Name, @Description, @UnitPrice);
	
	set @ID = @@IDENTITY;

	return 0;
end
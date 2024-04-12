CREATE procedure sp_InsertSaleDetail
@SaleID int,
@ProductID int,
@UnitPrice money,
@Quantity int
as
begin
	set nocount on;

	    declare @RemainQuantity int;
	    set @RemainQuantity = (Select Quantity from Remains)

	begin try

		insert into SaleDetails(SaleID, ProductID, UnitPrice, Quantity) 
		values (@SaleID, @ProductID, @UnitPrice, @Quantity)

		update Remains set UpdateDate = GetDate(), Quantity = @RemainQuantity - @Quantity

	end try
	begin catch
		
		declare @ErrorMessage varchar(Max);
		set @ErrorMessage = ERROR_MESSAGE();
		
		raiserror(@ErrorMessage, 16,1)
		return 1;

	end catch

	return 0;
end
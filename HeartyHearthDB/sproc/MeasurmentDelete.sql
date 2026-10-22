create or alter proc dbo.MeasurmentDelete
@MeasurmentId int,
@Message varchar(500) = '' output  
as 
begin
declare @return int = 0
select @MeasurmentId = isnull(@MeasurmentId, 0)
    begin try 
        begin tran 
          delete RecipeIngredient where MeasurmentId = @MeasurmentId
          delete Measurment where MeasurmentId = @MeasurmentId
        commit;
    end try 
    begin catch
        select @return = 1, @Message = 'Could not delete Measurment'
		rollback;
		throw
	end catch 
return @return
end
go 
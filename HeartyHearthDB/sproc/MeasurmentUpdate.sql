create or alter proc dbo.MeasurmentUpdate 
@MeasurmentId int output,
@MeasurmentType	varchar	(50)
as 
begin 
declare @return int = 0
select @MeasurmentId = isnull(@MeasurmentId, 0)

if (@MeasurmentId = 0)
    begin 
        insert measurment (measurmenttype)
        values (@MeasurmentType)

        select @MeasurmentId = scope_identity()
    end 
else 
   begin
       update measurment
       set
        MeasurmentType = @MeasurmentType
       where measurmentId = @MeasurmentId
   end 
return @return 
end 
go 
create or alter proc dbo.MeasurementUpdate 
@MeasurementId int output,
@MeasurementType	varchar	(50)
as 
begin 
declare @return int = 0
select @MeasurementId = isnull(@MeasurementId, 0)

if (@MeasurementId = 0)
    begin 
        insert Measurement (Measurementtype)
        values (@MeasurementType)

        select @MeasurementId = scope_identity()
    end 
else 
   begin
       update Measurement
       set
        MeasurementType = @MeasurementType
       where MeasurementId = @MeasurementId
   end 
return @return 
end 
go 
create or alter proc dbo.MeasurementGet
@MeasurementId int = 0, 
@All bit = 0,
@IncludeBlank bit = 0  
as 
begin 
   select @MeasurementId = isnull(@MeasurementId, 0)

   if @IncludeBlank = 1
        begin   
            select m.MeasurementId, m.MeasurementType 
            from Measurement m
            where @MeasurementId = m.MeasurementId 
            or @All = 1 
            union select 0, ' '
            order by MeasurementId 
        end 
   else 
        begin 
            select m.MeasurementId, m.MeasurementType 
            from Measurement m
            where @MeasurementId = m.MeasurementId 
            or @All = 1 
        end 
 end 
go 
--exec dbo.MeasurementGet @INcludeBlank = 1
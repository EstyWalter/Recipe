create or alter proc dbo.MeasurmentGet
@MeasurmentId int = 0, 
@All bit = 0,
@IncludeBlank bit = 0  
as 
begin 
   select @MeasurmentId = isnull(@MeasurmentId, 0)

   if @IncludeBlank = 1
        begin   
            select m.MeasurmentId, m.MeasurmentType 
            from Measurment m
            where @MeasurmentId = m.MeasurmentId 
            or @All = 1 
            union select 0, ' '
            order by MeasurmentId 
        end 
   else 
        begin 
            select m.MeasurmentId, m.MeasurmentType 
            from Measurment m
            where @MeasurmentId = m.MeasurmentId 
            or @All = 1 
        end 
 end 
go 
--exec dbo.MeasurmentGet @INcludeBlank = 1
create or alter proc dbo.MeasurmentGet
@MeasurmentId int = 0, 
@All bit = 0
as 
    begin 
        select @MeasurmentId = isnull(@MeasurmentId, 0)
        select m.MeasurmentId, m.MeasurmentType 
        from Measurment m
        where @MeasurmentId = m.MeasurmentId 
        or @All = 1 
    end 
go 
--exec dbo.MeasurmentGet
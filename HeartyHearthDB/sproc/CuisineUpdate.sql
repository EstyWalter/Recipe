create or alter proc dbo.CuisineUpdate(
@CuisineId	int output,
@CuisineType varchar (45))
as 
begin 
declare @return int = 0 
select @CuisineId = isnull(@CuisineId, 0) 

if (@CuisineId = 0)
    begin 
        insert cuisine (CuisineType)
        values (@CuisineType)

        select CuisineId = scope_identity()
    end 
else 
   begin
       update Cuisine
       set
        CuisineType = @CuisineType
       where cuisineid = @CuisineId 
   end 
return @return 
end 
go 
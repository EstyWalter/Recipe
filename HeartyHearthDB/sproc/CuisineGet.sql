create or alter procedure CuisineGet(@CuisineId int = 0, @All bit = 0, @CuisineType varchar(45) = '')
as 
begin 
select @CuisineType = nullif(@CuisineType, '')
select c.CuisineId, c.CuisineType
from Cuisine c 
where c.CuisineId = @CuisineId
or @All = 1
or c.CuisineType like '%' + @CuisineType+ '%'
end
go

exec CuisineGet

exec CuisineGet @all = 1

exec CuisineGet @cuisineType = 'a'

exec CuisineGet @cuisineType = ''

declare @id int 
select top 1 @id = c.cuisineid from Cuisine c 
exec CuisineGet @cuisineid = @id 
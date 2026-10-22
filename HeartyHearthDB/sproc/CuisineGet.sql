create or alter procedure dbo.CuisineGet(
    @CuisineId int = 0, 
    @All bit = 0,
    @IncludeBlank bit = 0)
as 
    begin 
    select @CuisineId = isnull(@CuisineId, 0)
    if @IncludeBlank = 1 
        begin 
            select c.CuisineId, c.CuisineType
            from Cuisine c 
            where c.CuisineId = @CuisineId
            or @All = 1
            union select 0, ''
            order by c.cuisineid
        end 
    else 
        begin 
            select c.CuisineId, c.CuisineType
            from Cuisine c 
            where c.CuisineId = @CuisineId
            or @All = 1
        end
    end
go

/*
exec CuisineGet

exec CuisineGet @all = 1, @IncludeBlank = 1

exec CuisineGet @cuisineType = 'a'

exec CuisineGet @cuisineType = ''

declare @id int 
select top 1 @id = c.cuisineid from Cuisine c 
exec CuisineGet @cuisineid = @id 
*/
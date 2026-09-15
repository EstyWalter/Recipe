create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar (220)
as
begin 
    declare @value varchar(220)

    select @value = concat(r.RecipeName, ' (', c.CuisineType, ') has ', count(ri.ingredientid), ' ingredients and ', count(d.directionsid), ' steps.')
    from cuisine c 
    left join recipe r 
    on c.cuisineid = r.cuisineid 
    left join Recipeingredient ri 
    on ri.recipeid = r.recipeid 
    left join directions d 
    on r.recipeid = d.recipeid 
    where r.recipeid = @RecipeId
    group by r.recipename, c.CuisineType

    return @value 
    end 
go 

select dbo.RecipeDesc(r.recipeid)
from recipe r  


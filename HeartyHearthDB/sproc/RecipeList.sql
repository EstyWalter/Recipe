create or alter proc dbo.RecipeList
as
begin
    select r.recipeid, RecipeName,
    r.statuses, u.UserName, r.Calories, NumIngredients = count(RecipeIngredientId)
    from recipe r 
    left join RecipeIngredient ri 
    on r.RecipeId = ri.RecipeId
    join Users u 
    on u.UsersId = r.UsersId 
    group by r.recipeid, r.statuses, r.RecipeName, u.Username, r.Calories
    order by r.statuses desc 
end
go
--exec RecipeList



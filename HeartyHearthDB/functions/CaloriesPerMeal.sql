create or alter function dbo.CaloriesPerMeal(@MealId int)
returns int 
as 
begin
    declare @value int = 0

    select @value = sum(r.calories)
    from recipe r 
    join MealCourseRecipe mcr 
    on mcr.recipeid = r.Recipeid
    join mealcourse mc 
    on mcr.mealcourseid = mc.mealcourseid 
    where mc.mealid = @mealid 
    group by mc.mealid

    return @value 
end 
go
select mc.mealid, calories = dbo.CaloriesPerMeal(mc.mealid)
from recipe r 
join MealCourseRecipe mcr 
on mcr.recipeid = r.Recipeid
join mealcourse mc 
on mcr.mealcourseid = mc.mealcourseid 


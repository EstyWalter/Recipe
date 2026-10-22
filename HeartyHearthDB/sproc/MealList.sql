create or alter proc dbo.MealList
as 
    begin
        select m.MealName, u.UserName, SumOfCalories = sum(r.Calories), NumOfRecipes = count(distinct mcr.RecipeId), NumOfCourses = count(distinct mc.courseid)
        from meal m 
        join MealCourse mc 
        on m.mealid = mc.mealid  
        join MealCourseRecipe mcr 
        on mc.MealCourseId = mcr.mealCourseId
        join Recipe r 
        on mcr.RecipeId = r.RecipeId 
        join Users u 
        on m.UsersId = u.UsersId 
        group by m.MealName, u.UserName
        order by m.MealName 
    end 
go 
exec MealList
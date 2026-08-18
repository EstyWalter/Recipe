use HeartyHearthDB
go
 delete CookbookRecipe
 delete Cookbook
 delete MealCourseRecipe
 delete MealCourse
 delete Course
 delete Meal
 delete Directions 
 delete RecipeIngredient
 delete Recipe 
 delete Measurment
 delete Ingredient
 delete Cuisine
 delete Users

go 
insert users(FirstName, LastName, UserName)
select 'Esther', 'Walter', 'Esty'
union select 'Blimy', 'Brody', 'BLims'
union select 'Chaya', 'Shweid', 'Chaya'
union select 'Sarah', 'Pacini', 'Sury'

go
insert cuisine(CuisineType)
select 'American'
union select 'Italian'
union select 'French'
union select 'English'
union select 'African'
union select 'Greek'
union select 'Thai'
 delete CookbookRecipe
 delete Cookbook
 delete MealCourseRecipe
 delete MealCourse
 delete Course
 delete Meal
 delete Directions 
 delete RecipeIngredient
 delete Recipe 
 delete Measurment
 delete Ingredient
 delete Cuisine
 delete Users

go 
insert users(FirstName, LastName, UserName)
select 'Esther', 'Walter', 'Esty'
union select 'Blimy', 'Brody', 'BLims'
union select 'Chaya', 'Shweid', 'Chaya'
union select 'Sarah', 'Pacini', 'Sury'

go
insert cuisine(CuisineType)
select 'American'
union select 'Italian'
union select 'French'
union select 'English'
union select 'African'
union select 'Greek'
union select 'Thai'
go
;
with x as(
select cuisine = 'Italian', UserName = 'Esty',  DateDrafted = '3-1-2026', DatePublished = '3-10-2026', DateArchived = null,  Recipe = 'tomato pasta', calories = 25
union select 'American', 'BLims', '4-12-2025', '7-15-2025', null, 'Chocolate Chip Cookies', 360
union select 'French', 'Chaya', '3-05-2024', '6-18-2024', '12-10-2025', 'Apple Yogurt Smoothie', 190
union select 'English', 'Sury', '8-21-2024', null, '2-10-2026', 'Cheese Bread', 430
union select 'American', 'BLims', '6-03-2025', '8-09-2025', null, 'Butter Muffins', 410
union select 'American', 'Chaya', '5-11-2024', '9-20-2024', null, 'Banana Oat Muffins', 300
union select 'American', 'Sury', '1-17-2026', '2-01-2026', null, 'Strawberry Milkshake', 270
union select 'Italian', 'BLims', '9-09-2025', null, null, 'Garlic Butter Pasta', 520
)
insert Recipe(CuisineId, UsersId, DateDrafted, DatePublished, DateArchived, RecipeName, Calories)
select c.CuisineId, u.UsersId, x.DateDrafted, x.DatePublished, x.DateArchived, x.Recipe, x.calories
from x 
join Cuisine c 
on x.cuisine = c.CuisineType 
join Users u 
on x.UserName = u.UserName


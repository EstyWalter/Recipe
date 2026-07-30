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

go 
insert Ingredient(IngredientName)
select 'coconut flakes'
union select 'honey mustard'
union select 'almond milk'
union select 'sugar'
union select 'oil'
union select 'eggs'
union select 'flour'
union select 'vanilla sugar'
union select 'baking powder'
union select 'baking soda'
union select 'chocolate chips'
union select 'granny smith apples'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'club bread'
union select 'butter'
union select 'shredded cheese'
union select 'garlic'
union select 'black pepper'
union select 'salt'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream cheese'
union select 'oats'
union select 'strawberries'
union select 'milk'
union select 'vanilla ice cream'
union select 'pasta'
union select 'grated cheese'
union select 'olive oil'

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

go
insert Measurment(measurmenttype)
select 'cup'
union select 'Tbsp'
union select 'cloves'
union select 'tsp'
union select 'stick'
union select 'unit'
union select 'oz'
union select 'pound'
union select 'pinch'

go
;
with x as(
select Recipename = 'Garlic Butter Pasta', Ingredientname = 'pasta', ingredientsequence = '1', measurmenttype = 'cup', amount = '2'
union select 'Garlic Butter Pasta', 'butter', 2, 'tbsp', 3
union select 'Garlic Butter Pasta', 'garlic', 3, 'cloves', 2
union select 'Garlic Butter Pasta', 'black pepper', 4, 'tsp', 0.25
union select 'Garlic Butter Pasta', 'salt', 5, 'tsp', 0.5
union select 'Garlic Butter Pasta', 'grated cheese', 6, 'cup', 0.25
union select 'Garlic Butter Pasta', 'olive oil', 7, 'tbsp', 1
union select 'Chocolate Chip Cookies', 'sugar', 1, 'cup', 1
union select 'Chocolate Chip Cookies', 'oil', 2, 'cup', 0.5
union select 'Chocolate Chip Cookies', 'eggs', 3, 'unit', 3
union select 'Chocolate Chip Cookies', 'flour', 4, 'cups', 2
union select 'Chocolate Chip Cookies', 'vanilla sugar', 5, 'tsp', 1
union select 'Chocolate Chip Cookies', 'baking powder', 6, 'tsp', 2
union select 'Chocolate Chip Cookies', 'baking soda', 7, 'tsp', 0.5
union select 'Chocolate Chip Cookies', 'chocolate chips', 8, 'cup', 1
union select 'Apple Yogurt Smoothie', 'granny smith apples', 1, 'unit', 3
union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 2, 'cups', 2
union select 'Apple Yogurt Smoothie', 'sugar', 3, 'tsp', 2
union select 'Apple Yogurt Smoothie', 'orange juice', 4, 'cup', 0.5
union select 'Apple Yogurt Smoothie', 'honey', 5, 'tbsp', 2
union select 'Apple Yogurt Smoothie', 'ice cubes', 6, 'unit', 6
union select 'Cheese Bread', 'club bread', 1, 'unit', 1
union select 'Cheese Bread', 'butter', 2, 'oz', 4
union select 'Cheese Bread', 'shredded cheese', 3, 'oz', 8
union select 'Cheese Bread', 'garlic', 4, 'cloves', 2
union select 'Cheese Bread', 'black pepper', 5, 'tsp', 0.25
union select 'Cheese Bread', 'salt', 6, 'pinch', 1
union select 'Butter Muffins', 'butter', 1, 'stick', 1
union select 'Butter Muffins', 'sugar', 2, 'cups', 3
union select 'Butter Muffins', 'vanilla pudding', 3, 'tbsp', 2
union select 'Butter Muffins', 'eggs', 4, 'unit', 4
union select 'Butter Muffins', 'whipped cream cheese', 5, 'oz', 8
union select 'Butter Muffins', 'sour cream cheese', 6, 'oz', 8
union select 'Butter Muffins', 'flour', 7, 'cups', 1
union select 'Butter Muffins', 'baking powder', 8, 'tsp', 2
union select 'Banana Oat Muffins', 'bananas', 1, 'unit', 2
union select 'Banana Oat Muffins', 'sugar', 2, 'cup', 0.5
union select 'Banana Oat Muffins', 'oil', 3, 'cup', 0.5
union select 'Banana Oat Muffins', 'eggs', 4, 'unit', 2
union select 'Banana Oat Muffins', 'flour', 5, 'cup', 1
union select 'Banana Oat Muffins', 'oats', 6, 'cup', 1
union select 'Banana Oat Muffins', 'vanilla sugar', 7, 'tsp', 1
union select 'Banana Oat Muffins', 'baking powder', 8, 'tsp', 2
union select 'Banana Oat Muffins', 'baking soda', 9, 'tsp', 0.5
union select 'Strawberry Milkshake', 'strawberries', 1, 'cup', 1
union select 'Strawberry Milkshake', 'milk', 2, 'cup', 2
union select 'Strawberry Milkshake', 'vanilla ice cream', 3, 'cup', 1
union select 'Strawberry Milkshake', 'sugar', 4, 'tsp', 2
union select 'Strawberry Milkshake', 'honey', 5, 'tsp', 1
union select 'Strawberry Milkshake', 'ice cubes', 6, 'unit', 5
)
insert Recipeingredient(RecipeId, IngredientId, IngredientSequence, Measurmentid, Amount)
select r.RecipeId, i.IngredientId, x.ingredientsequence, m.MeasurmentId, x.amount
from x 
join Recipe r 
on r.RecipeName = x.Recipename
join RecipeIngredient ri
on r.RecipeId = ri.recipeid 
join Ingredient i 
on ri.ingredientid = i.IngredientId 
join Measurment m 
on m.measurmenttype = x.measurmenttype 

go 
;
with x as(
select Recipename = 'Chocolate Chip Cookies', directionsequence = 1, steps = 'First combine sugar, oil, and eggs in a bowl.'
union select 'Chocolate Chip Cookies', 2, 'Mix well.'
union select 'Chocolate Chip Cookies', 3, 'Add flour, vanilla sugar, baking powder, and baking soda.'
union select 'Chocolate Chip Cookies', 4, 'Beat for 5 minutes.'
union select 'Chocolate Chip Cookies', 5, 'Add chocolate chips.'
union select 'Chocolate Chip Cookies', 6, 'Freeze for 2 hours.'
union select 'Chocolate Chip Cookies', 7, 'Roll into balls and place spread out on a cookie sheet.'
union select 'Chocolate Chip Cookies', 8, 'Bake at 350°F for 10 minutes.'
union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice them.'
union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in a bowl except for apples and ice cubes.'
union select 'Apple Yogurt Smoothie', 3, 'Mix until smooth.'
union select 'Apple Yogurt Smoothie', 4, 'Add apples and ice cubes.'
union select 'Apple Yogurt Smoothie', 5, 'Pour into glasses.'
union select 'Cheese Bread', 1, 'Slit the bread every 3/4 inch.'
union select 'Cheese Bread', 2, 'Combine butter, shredded cheese, garlic, black pepper, and salt in a bowl.'
union select 'Cheese Bread', 3, 'Fill slits in the bread with the cheese mixture.'
union select 'Cheese Bread', 4, 'Wrap bread in foil.'
union select 'Cheese Bread', 5, 'Bake for 30 minutes.'
union select 'Butter Muffins', 1, 'Cream butter with sugars.'
union select 'Butter Muffins', 2, 'Add eggs and mix well.'
union select 'Butter Muffins', 3, 'Slowly add the rest of the ingredients and mix well.'
union select 'Butter Muffins', 4, 'Fill muffin pans 3/4 full.'
union select 'Butter Muffins', 5, 'Bake for 30 minutes.'
union select 'Banana Oat Muffins', 1, 'Mash bananas in a bowl.'
union select 'Banana Oat Muffins', 2, 'Add sugar, oil, and eggs.'
union select 'Banana Oat Muffins', 3, 'Mix well until smooth.'
union select 'Banana Oat Muffins', 4, 'Add flour, oats, vanilla sugar, baking powder, and baking soda.'
union select 'Banana Oat Muffins', 5, 'Beat for 4 to 5 minutes.'
union select 'Banana Oat Muffins', 6, 'Pour mixture into muffin cups.'
union select 'Banana Oat Muffins', 7, 'Bake at 350°F for 18 to 20 minutes.'
union select 'Strawberry Milkshake', 1, 'Wash and slice the strawberries.'
union select 'Strawberry Milkshake', 2, 'Combine milk, ice cream, and sugar in a blender.'
union select 'Strawberry Milkshake', 3, 'Blend until smooth.'
union select 'Strawberry Milkshake', 4, 'Add strawberries and honey.'
union select 'Strawberry Milkshake', 5, 'Blend again for 2 minutes.'
union select 'Strawberry Milkshake', 6, 'Add ice cubes and blend briefly.'
union select 'Strawberry Milkshake', 7, 'Pour into glasses and serve.'
union select 'Garlic Butter Pasta', 1, 'Cook pasta in boiling salted water.'
union select 'Garlic Butter Pasta', 2, 'Drain and set aside.'
union select 'Garlic Butter Pasta', 3, 'Melt butter and olive oil in a pan.'
union select 'Garlic Butter Pasta', 4, 'Add crushed garlic and cook for 1 minutes.'
union select 'Garlic Butter Pasta', 5, 'Add cooked pasta to the pan.'
union select 'Garlic Butter Pasta', 6, 'Season with salt and black pepper.'
union select 'Garlic Butter Pasta', 7, 'Mix well.'
union select 'Garlic Butter Pasta', 8, 'Sprinkle grated cheese before serving.'
) 
insert Directions(Recipeid, DirectionsSequence, Steps)
select  r.Recipeid, x.directionsequence, x.Steps
from x 
join Recipe r 
on r.RecipeName = x.RecipeName 

go 
;
with x as(
select UserName = 'Blims', MealName = 'Breakfast Bash', mealactive =  1
union select 'Chaya', 'Sweet & Savory Feast', 1
union select 'Sury', 'Sweet & Savory Delight', 0
union select 'Blims', 'Comfort Feast', 1
union select 'Esty', 'Morning Boost', 0
)
insert Meal(UsersId, MealName, MealActive)
select u.UsersId, x.MealName, x.MealActive
from x 
join Users u 
on u.UserName = x.UserName 

go
insert Course(CourseName, CourseSequence)
select 'Appetizer', 1
union select 'soup', 2
union select 'fish course', 3
union select 'Main Course', 4
union select 'Drink', 5
union select 'dessert', 6


go
;
with x as(
select mealname = 'Breakfast Bash', course = 'Main Course'
union select 'Breakfast Bash', 'Appetizer'
union select 'Sweet & Savory Feast', 'Main Course'
union select 'Sweet & Savory Feast', 'Appetizer'
union select 'Sweet & Savory Feast', 'Dessert'
union select 'Sweet & Savory Delight', 'Main Course'
union select 'Sweet & Savory Delight', 'Appetizer'
union select 'Comfort Feast', 'Main Course'
union select 'Comfort Feast', 'Appetizer'
union select 'Morning Boost', 'Main Course'
union select 'Morning Boost', 'Appetizer'
union select 'Morning Boost', 'Drink'
union select 'Dessert Extravaganza', 'Dessert'
)
insert MealCourse(mealid, CourseId)
select m.MealId, c.courseId
from x 
join Meal m 
on m.MealName = x.mealname 
join course c 
on c.CourseName = x.course
go 
;
with x as(
select mealname = 'Breakfast Bash', course = 'Main Course', recipename = 'Cheese Bread', maindish = 1
union select 'Breakfast Bash', 'Main Course', 'Butter Muffins', 0
union select 'Breakfast Bash', 'Appetizer', 'Apple Yogurt Smoothie', 1
union select 'Breakfast Bash', 'Appetizer', 'Strawberry Milkshake', 0
union select 'Sweet & Savory Feast', 'Main Course', 'Cheese Bread', 1
union select 'Sweet & Savory Feast', 'Main Course', 'Banana Oat Muffins', 0
union select 'Sweet & Savory Feast', 'Appetizer', 'Apple Yogurt Smoothie', 1
union select 'Sweet & Savory Feast', 'Dessert', 'Chocolate Chip Cookies', 1
union select 'Sweet & Savory Feast', 'Dessert', 'Butter Muffins', 0
union select 'Sweet & Savory Feast', 'Dessert', 'Banana Oat Muffins', 0
union select 'Sweet & Savory Delight', 'Main Course', 'Chocolate Chip Cookies', 1
union select 'Sweet & Savory Delight', 'Main Course', 'Banana Oat Muffins', 0
union select 'Sweet & Savory Delight', 'Appetizer', 'Strawberry Milkshake', 1
union select 'Comfort Feast', 'Main Course', 'Cheese Bread', 1
union select 'Comfort Feast', 'Main Course', 'Butter Muffins', 0
union select 'Comfort Feast', 'Appetizer', 'Apple Yogurt Smoothie', 1
union select 'Morning Boost', 'Main Course', 'Chocolate Chip Cookies', 1
union select 'Morning Boost', 'Main Course', 'Banana Oat Muffins', 0
union select 'Morning Boost', 'Appetizer', 'Strawberry Milkshake', 1
union select 'Morning Boost', 'Drink', 'Apple Yogurt Smoothie', 1
)
insert MealCourseRecipe(mealCourseId, RecipeId, MainDish)
select mc.MealCourseId, r.RecipeId, x.MainDish
from x 
join Meal m 
on m.MealName = x.mealname 
join Course c 
on c.CourseName = x.course
join MealCourse mc 
on c.courseId = mc.courseid 
and m.MealId = mc.MealId 
join Recipe r 
on r.RecipeName = x.recipename 

go 
;
with x as(
select usersname = 'Esty', bookname = 'Treats for Two', price = 30, bookactive = 1
union select 'Blims','Savory Delights', 30, 1
union select 'Chaya','Whisked Away Delights', 28, 0
union select 'Sury','The Tasty Trio Collection', 32, 1
)
insert Cookbook(UsersId, BookName, Price, BookActive)
select u.UsersId, x.bookname, x.price, x.bookactive
from x 
join Users u 
on u.UserName = x.usersname

go
;
with x as(
select bookname = 'Treats for Two', recipename = 'Chocolate Chip Cookies', recipesequence = 1
union select 'Treats for Two', 'Apple Yogurt Smoothie', 2
union select 'Treats for Two', 'Cheese Bread', 3
union select 'Treats for Two', 'Butter Muffins', 4
union select 'Savory Delights', 'Chocolate Chip Cookies', 1
union select 'Savory Delights', 'Apple Yogurt Smoothie', 2
union select 'Savory Delights', 'Cheese Bread', 3
union select 'Savory Delights', 'Butter Muffins', 4
union select 'Savory Delights', 'Strawberry Milkshake', 5
union select 'Savory Delights', 'Garlic Butter Pasta', 6
union select 'Whisked Away Delights', 'Apple Yogurt Smoothie', 1
union select 'Whisked Away Delights', 'Cheese Bread', 2
union select 'Whisked Away Delights', 'Banana Oat Muffins', 3
union select 'Whisked Away Delights', 'Strawberry Milkshake', 4
union select 'The Tasty Trio Collection', 'Chocolate Chip Cookies', 1
union select 'The Tasty Trio Collection', 'Garlic Butter Pasta', 2
)
insert CookbookRecipe(Cookbookid, recipeid, RecipeSequence)
select cb.CookbookId, r.RecipeId, x.recipesequence
from x 
join Cookbook cb 
on cb.BookName = x.bookname
join recipe r 
on r.RecipeName = x.recipename
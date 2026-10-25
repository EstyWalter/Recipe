--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

    -- 1. Delete directions for Blims's recipes
    DELETE d
    FROM Directions d
    JOIN Recipe r ON r.RecipeId = d.RecipeId
    JOIN Users u ON u.UsersId = r.UsersId
    WHERE u.UserName = 'Blims';

    -- 2. Delete ingredients for Blims's recipes
    DELETE ri
    FROM RecipeIngredient ri
    JOIN Recipe r ON r.RecipeId = ri.RecipeId
    JOIN Users u ON u.UsersId = r.UsersId
    WHERE u.UserName = 'Blims';

    -- 3. Delete cookbook references to Blims's recipes
    DELETE cr
    FROM CookbookRecipe cr
    JOIN Recipe r ON r.RecipeId = cr.RecipeId
    JOIN Users u ON u.UsersId = r.UsersId
    WHERE u.UserName = 'Blims';

    -- 4. Delete meal-course references to Blims's recipes
    DELETE mcr
    FROM MealCourseRecipe mcr
    JOIN Recipe r ON r.RecipeId = mcr.RecipeId
    JOIN Users u ON u.UsersId = r.UsersId
    WHERE u.UserName = 'Blims';

    -- 5. Delete remaining meal-course-recipe records
    -- belonging to Blims's meals
    DELETE mcr
    FROM MealCourseRecipe mcr
    JOIN MealCourse mc ON mc.MealCourseId = mcr.MealCourseId
    JOIN Meal m ON m.MealId = mc.MealId
    JOIN Users u ON u.UsersId = m.UsersId
    WHERE u.UserName = 'Blims';

    -- 6. Delete cookbook references in Blims's cookbooks
    DELETE cr
    FROM CookbookRecipe cr
    JOIN Cookbook c ON c.CookbookId = cr.CookbookId
    JOIN Users u ON u.UsersId = c.UsersId
    WHERE u.UserName = 'Blims';

    -- 7. Delete Blims's cookbooks
    DELETE c
    FROM Cookbook c
    JOIN Users u ON u.UsersId = c.UsersId
    WHERE u.UserName = 'Blims';

    -- 8. Delete meal courses belonging to Blims's meals
    DELETE mc
    FROM MealCourse mc
    JOIN Meal m ON m.MealId = mc.MealId
    JOIN Users u ON u.UsersId = m.UsersId
    WHERE u.UserName = 'Blims';

    -- 9. Delete Blims's meals
    DELETE m
    FROM Meal m
    JOIN Users u ON u.UsersId = m.UsersId
    WHERE u.UserName = 'Blims';

    -- 10. Delete Blims's recipes
    DELETE r
    FROM Recipe r
    JOIN Users u ON u.UsersId = r.UsersId
    WHERE u.UserName = 'Blims';

    -- 11. Delete Blims's user record
    DELETE FROM Users
    WHERE UserName = 'Blims';

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name
insert Recipe (CuisineId, UsersId, DateDrafted, DatePublished, DateArchived, RecipeName, Calories)
select r.CuisineId, r.UsersId, r.DateDrafted, r.DatePublished, r.DateArchived, RecipeName = concat(r.RecipeName, ' - Clone'), r.Calories
from Recipe r 
where r.RecipeName = 'Chocolate Chip Cookies'

insert Directions (RecipeId, DirectionsSequence, Steps)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies - clone'), d.DirectionsSequence, d.Steps
from Recipe r
join Directions d 
on r.RecipeId = d.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'

insert RecipeIngredient(RecipeId, IngredientId, IngredientSequence, MeasurementId, Amount)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies - clone'),  
ri.IngredientId, ri.IngredientSequence, m.MeasurementId, ri.Amount
from Recipe r
join recipeIngredient ri 
on r.RecipeId = ri.RecipeId 
join Measurement m 
on m.MeasurementId = ri.MeasurementId 
where r.RecipeName = 'Chocolate Chip Cookies'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
	 
--AS Hardcoding a pk is very bad practice since it can change and then the code would be incorrect. 
--AS The cookbookid you inserted below isn't even being used. Remove in both places. Instead have a where clause on the cookbook name to get back this specific cookbook.
*/

insert Cookbook (UsersId, BookName, Price, BookActive)
select
    u.UsersId,
    concat('Recipes by ', u.FirstName, ' ', u.LastName),
    count(r.RecipeId) * 1.33,
    1
from Users u
join Recipe r
    on u.UsersId = r.UsersId
where u.UserName = 'Chaya'
group by
    u.UsersId,
    u.FirstName,
    u.LastName;

with CookbookInfo as
(
    select
        c.CookbookId
    from Cookbook c
    join Users u
        on c.UsersId = u.UsersId
    where c.BookName = concat('Recipes by ', u.FirstName, ' ', u.LastName)
      and u.UserName = 'Chaya'
)

insert CookbookRecipe
(
    CookbookId,
    RecipeId,
    RecipeSequence
)
select
    ci.CookbookId,
    r.RecipeId,
    ROW_NUMBER() over (order by r.RecipeName)
from CookbookInfo ci
cross join Recipe r
join Users u
    on r.UsersId = u.UsersId
where u.UserName = 'Chaya';

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r 
--select
set r.calories = case 
when  i.ingredientname = 'vanilla sugar' and m.MeasurementType = 'tbsp' then ri.amount * 7 + r.calories 
when i.ingredientname = 'vanilla sugar' and m.MeasurementType = 'tsp' then ri.amount * 5 + r.calories
else r.calories 
end
from recipe r 
join RecipeIngredient ri 
on ri.recipeid = r.recipeid
join Measurement m 
on m.MeasurementId = ri.MeasurementId
join ingredient i 
on i.ingredientid = ri.ingredientid 
where i.IngredientName = 'vanilla sugar'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as(
select AvgDaysToPublish = avg(datediff(hour, r.DateDrafted, r.DatePublished))
from recipe r 
)
select u.FirstName, u.LastName, emailaddress = concat(substring(u.FirstName, 1, 1), u.LastName, '@heartyhearth.com'), 
Alert = concat( 'Your recipe ',  r.recipename, ' is sitting in draft for ',  datediff(hour, datedrafted, getdate()), ' hours That is ', datediff(hour, datedrafted, getdate()) - x.AvgDaysToPublish,' hours more than the average ', x.AvgDaysToPublish, ' hours all other recipes took to be published.')
from Users u 
join Recipe r 
on u.UsersId = r.usersid 
join x 
on x.AvgDaysToPublish < datediff(hour, r.datedrafted, getdate())
where DatePublished is null and DateArchived is null 
/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', count(c.CookbookId), ' books for sale, average price is ', avg(c.Price), ' You can order them all and receive a 25% discount, for a total of ',sum(Price) * 0.75 , '. Click <a href = "www.heartyhearth.com/order/ ', newid(), ' ">here</a> to order. ')
from Cookbook c 

select * from Cookbook c 
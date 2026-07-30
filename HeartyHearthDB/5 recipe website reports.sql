/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select Itemname = 'recipes', count = count(r.recipeid) from recipe r
union select Itemname = 'Meals', count = count(m.mealid) from meal m 
union select Itemname = 'cookbooks', count = count(c.cookbookid) from Cookbook c  
/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. Archived recipes should appear gray on the website.
	In order for the recipe name to be gray on the website, surround the archived recipe names with: <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select RecipeName = case 
when r.statuses = 'archived' then concat('<span style="color:gray">', r.recipename, '</span>')
else r.RecipeName
end, 
r.statuses, datepublished = convert(varchar, r.DatePublished, 101),
datearchived = isnull(convert(varchar, r.DateArchived, 101), ' '), u.UserName, r.Calories, numofingredient = count(RecipeIngredientId)
from recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Users u 
on u.UsersId = r.UsersId 
where r.statuses = 'published' or r.statuses = 'archived'
group by r.statuses, r.RecipeName, r.DatePublished, r.DateArchived, u.Username, r.Calories
order by r.statuses desc 

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
select r.RecipeName, r.Calories, NumOfIngredient = count(distinct ri.RecipeIngredientId), NumOfSteps = count(distinct d.DirectionsId)
from recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Directions d 
on d.RecipeId = r.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
group by r.RecipeName, r.Calories

select ListOfIngredients = concat(ri.Amount, ' ', m.measurmenttype, ' ',i.IngredientName), ri.IngredientSequence
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId 
join Measurment m 
on ri.MeasurmentId = m.MeasurmentId 
join Ingredient i 
on i.IngredientId = ri.IngredientId
where r.RecipeName = 'Chocolate Chip Cookies'
order by ri.IngredientSequence

select d.Steps, d.DirectionsSequence
from Directions d 
join recipe r 
on r.RecipeId = d.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
order by d.DirectionsSequence
/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
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
where m.MealActive = 1
group by m.MealName, u.UserName
order by m.MealName 

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
where m.MealActive = 1
group by m.MealName, u.UserName
order by m.MealName 
/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select m.MealName, u.UserName, m.DateCreated
from meal m 
join users u 
on m.UsersId = u.UsersId
where m.MealName = 'Breakfast Bash'
select RecipesInsideMeals = case 
    when mcr.MainDish = 1 and c.CourseName = 'Main Course' then concat('<b>Main', ': ', c.CourseName, ' - ', r.RecipeName, '</b>')
    when mcr.MainDish = 1 and c.CourseName not like 'Main Course' then concat('Main', ': ', c.CourseName, ' - ', r.RecipeName)
    else concat(c.CourseName, ': ', r.RecipeName)
    end 
from meal m 
join mealcourse mc 
on m.mealid = mc.Mealid 
join Course c 
on mc.courseId = c.courseId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.mealCourseId
join Recipe r 
on mcr.RecipeId = r.RecipeId 
where m.MealName = 'Breakfast Bash'
/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.BookActive, c.BookName, u.UserName, NumOfRecipes = count(cr.recipeid)
from cookbook c 
join CookbookRecipe cr 
on c.Cookbookid =  cr.Cookbookid
join Users u 
on c.UsersId = u.UsersId 
where c.BookActive = 1
group by c.BookActive, c.BookName, u.UserName
order by c.BookName
/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
select c.BookName, u.UserName, c.DateCreated, c.Price, NumOfRecipes = count(cr.recipeid) 
from Cookbook c 
join Users u 
on c.UsersId = u.UsersId 
join CookbookRecipe cr 
on c.Cookbookid =  cr.Cookbookid
where c.BookName = 'Treats for Two'
group by c.BookName, u.UserName, c.DateCreated, c.Price

select r.RecipeName, e.CuisineType, cr.RecipeSequence, NumOfIngredients = count(distinct ri.IngredientId), NumOfSteps = count(distinct d.DirectionsId) 
from Cookbook c 
join cookbookrecipe cr 
on c.CookbookId = cr.Cookbookid
join Recipe r 
on cr.RecipeId = r.recipeid
join RecipeIngredient ri 
on ri.RecipeId = r.RecipeId 
join Directions d 
on r.RecipeId = d.RecipeId 
join Cuisine e 
on r.CuisineId = e.CuisineId
where c.BookName = 'Treats for Two'
group by r.RecipeName, e.CuisineType, cr.RecipeSequence
order by cr.RecipeSequence
/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/

;
with x as(
select RecipeName = concat(upper(substring(reverse(r.RecipeName), 1, 1)), lower(substring(reverse(r.RecipeName), 2, 100))), r.RecipeId 
from recipe r 
)
select PictureRecipe = concat(substring(r.picturerecipe, 1, 7), replace(x.RecipeName, ' ', '_'), '.jpg'), x.RecipeName
from x 
join recipe r 
on r.recipeid = x.recipeid 


--AS you are doing max on a string value, this doesn't work
--AS Show it once as it would for each time you click. Don't repeat for each recipe
;
with x as
(
    select
        d.RecipeId,
        d.Steps,
        rn = ROW_NUMBER() over
        (
            partition by d.RecipeId
            order by d.DirectionsSequence desc
        )
    from Directions d
)

select
    Steps
from x
where rn = 1;

/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/

select  u.UserName, r.statuses, NumOfRecipes = count(r.RecipeId)
from Users u 
left join Recipe r 
on u.UsersId = r.UsersId 
group by u.username, r.statuses

select r.usersid, numofrecipes = count(distinct r.RecipeId), avgdaystopublish =  avg(datediff(day, DateDrafted, DatePublished))
from Recipe r 
group by r.UsersId 
 
select m.usersid,
Active = isnull(sum(case when m.mealActive = 1 then 1 end),0),
InActive = isnull(sum(case when m.mealActive = 0 then 1 end),0),
NumOfMeals = count(m.MealId)
from meal m 
group by m.usersid 

select c.usersid, Active = isnull(sum(case when c.bookActive = 1 then 1 end),0),
InActive = isnull(sum(case when c.BookActive = 0 then 1 end),0),
NumOfBooks = count(c.BookActive)
from Cookbook c  
group by c.usersid  

select r.RecipeName, DayToArchived = datediff(day, DateDrafted, DateArchived)
from Recipe r 
where r.DatePublished is null and r.DateArchived is not null
/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
select itemname = 'cookbook', count = count(distinct c.CookbookId)
from Cookbook c 
join Users u 
on c.UsersId = u.UsersId 
where u.UserName = 'Esty'
group by u.UserName
union select 'Recipe', count(distinct r.RecipeId)
from Recipe r 
join Users u 
on r.UsersId = u.UsersId 
where u.UserName = 'Esty'
group by u.UserName
union select 'Meal', count(distinct m.mealid)
from meal m 
join Users u 
on m.UsersId = u.UsersId 
where u.UserName = 'Esty'
group by u.UserName

select  r.RecipeName, r.Statuses, HoursToStatus = 
        case 
            when r.Statuses = 'published' 
                then datediff(hour, r.DateDrafted, r.DatePublished)

            when r.Statuses = 'archived'
                then datediff(hour, isnull(r.DatePublished, r.DateDrafted), r.DateArchived)
        end
from Recipe r
join Users u
on r.UsersId = u.UsersId
where r.Statuses <> 'drafted'
and u.UserName = 'Esty';
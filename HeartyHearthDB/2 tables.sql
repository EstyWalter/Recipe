
go
drop table if exists CookbookRecipe
drop table if exists Cookbook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Course
drop table if exists Meal
drop table if exists Directions 
drop table if exists RecipeIngredient
drop table if exists Measurment
drop table if exists Recipe 
drop table if exists Ingredient
drop table if exists Cuisine
drop table if exists Users

go  
create table dbo.Users(
    UsersId int not null identity primary key,
    FirstName varchar(50) not null 
    constraint Users_First_Name_not_blank check(FirstName <> ''), 
    LastName varchar(50) not null
    constraint Users_Last_Name_not_blank check(LastName <> ''),
    UserName varchar(50) not null 
    constraint U_Users_User_Name unique 
    constraint Users_User_Name_not_blank check(UserName <> ''),
)
go  
create table dbo.Cuisine(
    CuisineId int identity not null primary key,
    CuisineType varchar(45) not null 
    constraint U_Cuisine_Cuisine_Type unique
    constraint Cuisine_Cuisine_Type_not_blank check(cuisinetype <> '')
)
go
create table dbo.Ingredient(
    IngredientId Int not null identity primary key,
    IngredientName varchar (50) not null 
    constraint U_Ingredient_Ingredient_Name unique
    constraint Ingredient_Ingredient_Name_not_blank check(IngredientName <> ''),
    PictureIngredient as concat('Ingredient_', replace(ingredientname, ' ', '_' ), '.jpg')
)
--AS Remove all this commented out code

go 
create table dbo.Recipe(
    RecipeId Int not null identity primary key,
    CuisineId  int not null constraint F_Recipe_Cuisine foreign key references Cuisine(Cuisineid),
    UsersId int not null constraint F_Recipe_Users foreign key references users(Usersid),
    DateDrafted datetime2 not null
    constraint Recipe_Date_Drafted_between_creation_Of_website_and_current_date check(DateDrafted between '1999-01-01' and getdate()),
    DatePublished datetime2 null
    constraint Recipe_Date_published_not_in_the_future check(DatePublished <= getdate()),
    DateArchived datetime2 null
    constraint Recipe_Date_Archived_not_in_the_future check(DateArchived <= getdate()),
    RecipeName varchar (100) not null 
    Constraint U_Recipe_Recipe_Name unique
    constraint Recipe_Recipe_Name_not_blank check(RecipeName <> ''),
    Calories int not null constraint Recipe_Calories_may_not_be_neg check(Calories > 0),
    constraint Recipe_Date_archived_is_after_Date_drafted check(DateArchived is null or DateDrafted <= DateArchived),
    constraint Recipe_Date_Published_is_after_Date_drafted check(DatePublished is null or DateDrafted <= DatePublished),
    constraint Recipe_Date_Published_before_Date_Archived check(DateArchived is null or DatePublished is null or DatePublished <= DateArchived),
    statuses as case 
        when DateArchived is not null then 'Archived'
        when DatePublished is not null then 'Published'
        else 'Drafted'
    end,
    PictureRecipe as concat('Recipe_', replace(RecipeName, ' ', '_' ), '.jpg')
)
go
create table dbo.Measurment(
    MeasurmentId int not null identity primary key, 
    MeasurmentType varchar(50) not null
    constraint Measurment_Type_not_blank check(MeasurmentType <> ''),
    constraint U_Measurment_Measurment_Type unique(MeasurmentType)
)
go 
create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint F_Recipe_Ingredient_Recipe foreign key references Recipe(Recipeid),
    IngredientId int not null constraint F_Recipe_Ingredient_Ingredient foreign key references Ingredient(Ingredientid),
    IngredientSequence int not null
    constraint Ingredient_Ingredient_Sequence_not_neg check(IngredientSequence > 0),
    MeasurmentId int not null constraint F_Recipe_Ingredient_Measurment foreign key references Measurment(MeasurmentId),
    Amount decimal(4,2) not null
    constraint Ingredient_Amount_not_neg check(Amount > 0),
    constraint U_Ingredient_sequence_RecipeId unique(IngredientSequence, RecipeId)
)
go 
create table dbo.Directions(
    DirectionsId int not null identity primary key,
    RecipeId int not null constraint F_Directions_Recipe foreign key references Recipe(Recipeid),
    DirectionsSequence int not null
    constraint Directions_Direction_Sequence_not_neg check(directionssequence > 0),
    Steps varchar(500) not null
    constraint Directions_Steps_not_blank check(Steps <> ''),
    constraint U_Direction_Direction_Sequence unique(directionssequence, RecipeId)
)
go 
create table dbo.Meal(
    MealId int not null identity primary key,
    UsersId int not null constraint F_Meal_Users foreign key references users(Usersid),
    MealName varchar (50) 
    constraint U_Meal_Meal_Name unique
    constraint Meal_Meal_Name_not_blank check(MealName <> ''),
    MealActive bit not null,
    DateCreated datetime default getdate()
    constraint Meal_Date_Created_between_creation_of_website_and_current_date check((Datecreated between '1999-01-01' and getdate())),
    PictureMeal as concat('Meal_', replace(MealName, ' ', '_' ), '.jpg')
)
go 
create table dbo.Course(
    courseId int not null identity primary key,
    CourseName varchar(50) not null 
    constraint U_Course_Course_Name unique 
    constraint Course_Course_Name_not_blank check(CourseName <> ''),
    CourseSequence int not null
    constraint U_Course_course_Sequence unique 
    constraint Course_Course_Sequence_not_neg check(coursesequence > 0)
)
go 
create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint F_Meal_Course_Meal foreign key references Meal(mealid),
    CourseId int not null constraint F_Meal_Course_Course foreign key references Course(Courseid),
    constraint U_Meal_Course_Mealid_Courseid unique(mealid, courseId)
)
go 
create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    mealCourseId int not null constraint F_Meal_Course_Recipe_Meal_Course foreign key references MealCourse(mealCourseid),
    RecipeId int not null constraint F_Meal_Course_Recipe_Recipe foreign key references Recipe(Recipeid),
    MainDish bit not null 
    constraint U_Meal_Course_Recipe_Meal_CourseId_RecipeId unique(Mealcourseid, recipeid)
)
go 
create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    UsersId int not null constraint F_Cookbook_Users foreign key references users(Usersid),
    BookName varchar(100) not null 
    constraint U_Cookbook_Book_Name unique 
    constraint Cookbook_Book_Name_not_blank check(BookName <> ''),
    Price Decimal(5,2) not null 
    constraint cookbook_price_not_neg check(Price > 0),
    BookActive bit not null,
    DateCreated date default getdate(),
    PictureCookbook as concat('Recipe_', replace(BookName, ' ', '_' ), '.jpg')
)
go 
create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    Cookbookid int not null constraint F_Cookbook_Recipe_Cookbook foreign key references Cookbook(Cookbookid),
    recipeid int not null constraint F_Cookbook_Recipe_Recipe foreign key references Recipe(Recipeid),
    RecipeSequence int not null 
    constraint cookbook_Recipe_Recipe_Sequence_not_neg check(RecipeSequence > 0),
    constraint U_Cookbook_Recipe_Cookbookid_Recipeid unique(cookbookid, recipeid)
)
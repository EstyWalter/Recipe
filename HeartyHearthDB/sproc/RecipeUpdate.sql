create or alter proc dbo.RecipeUpdate(
@RecipeId int output,
@CuisineId int,
@UsersID int,
@DateDrafted datetime output,
@DatePublished datetime output,
@DateArchived datetime output,
@Statuses varchar (9) output,
@RecipeName varchar (100),
@Calories int
)
as 
begin 
declare @return int = 0

select @CuisineId = nullif(@CuisineId, 0), @UsersId = nullif(@UsersId, 0), @RecipeId = isnull(@RecipeId, 0);

if @RecipeId = 0
begin
    select @DateDrafted = SYSDATETIMEOFFSET() AT TIME ZONE 'Eastern Standard Time'
    insert Recipe(CuisineId, UsersID, DateDrafted, DatePublished, DateArchived, RecipeName, Calories)
    values(@CuisineId, @UsersID, @DateDrafted, @DatePublished, @DateArchived, @RecipeName, @Calories)

    select @RecipeId = scope_identity()
end 
else 
begin 

    update Recipe
    set 
        CuisineId = @CuisineId,
        UsersID = @UsersID,
        DateDrafted = @DateDrafted,
        DatePublished = @DatePublished,
        DateArchived = @DateArchived,
        RecipeName = @RecipeName,
        Calories = @Calories
        where recipeid = @RecipeId
    end 
return @return 
end 

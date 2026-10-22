create or alter proc dbo.CookbookRecipeUpdate(
@CookbookRecipeId int output,
@CookbookId int,
@RecipeId int,
@RecipeSequence int 
)
as 
begin 
declare @return int = 0

select @CookbookRecipeId = isnull(@CookbookRecipeId, 0), @CookbookId = nullif(@CookbookId, 0), @RecipeId = nullif(@RecipeId, 0)

if @CookbookRecipeId = 0
begin
    insert CookbookRecipe(cookbookid, RecipeId, RecipeSequence)
    values (@CookbookId, @RecipeId, @RecipeSequence)

    select @CookbookRecipeId = scope_identity()
end 
else 
begin 

    update CookbookRecipe
    set 
        CookbookId = @CookbookId,
        RecipeId = @RecipeId,
        RecipeSequence = @RecipeSequence 
        where CookbookRecipeid = @CookbookRecipeId
    end 
return @return 
end 



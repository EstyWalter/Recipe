create or alter procedure dbo.CookbookRecipeGet(
    @All bit = 0, 
    @CookbookId int)
as 
    begin 
        select  @CookbookId = isnull(@CookbookId,0)
        
        select CookbookRecipeId, CookbookId, RecipeId, recipesequence 
        from CookbookRecipe
        where @CookbookId = CookbookId
        or @All = 1
    end
go

/*
exec CookbookRecipeGet

exec CookbookRecipeGet @all = 1

declare @id int 
select top 1 @id = c.Cookbookid from CookbookRecipe c 
exec CookbookRecipeGet @Cookbookid = @id 
*/














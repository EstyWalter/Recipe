create or alter proc dbo.CookbookRecipeDelete
@CookbookRecipeId int 
as 
begin 
     declare @return int = 0
     select @CookbookRecipeId = isnull(@CookbookRecipeId, 0)
     delete CookbookRecipe where CookbookRecipeId = @CookbookRecipeId
end 
go 
	
create or alter proc dbo.RecipeIngredientDelete
@RecipeIngredientId int 
as 
begin 
     declare @return int = 0
     delete RecipeIngredient where RecipeIngredientId = @RecipeIngredientId
     return @Return 
end 
go 
	
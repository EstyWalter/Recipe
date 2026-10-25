create or alter proc dbo.RecipeIngredientGet
@RecipeId int = 0,
@IncludeBlank bit = 0
as
    begin
        select @RecipeId = isnull(@RecipeId, 0)
        select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId, ri.IngredientSequence, ri.MeasurementId, ri.amount
        from RecipeIngredient ri 
        where @RecipeId = ri.RecipeId
    end
go 

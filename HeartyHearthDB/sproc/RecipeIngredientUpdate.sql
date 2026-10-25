create or alter proc dbo.RecipeIngredientUpdate
@RecipeIngredientId int output,
@RecipeId int,
@IngredientId int,
@IngredientSequence int,
@MeasurementId int,
@Amount decimal
as 
begin 
declare @return int = 0 

select @RecipeId = nullif(@RecipeId, 0), @IngredientId = nullif(@IngredientId, 0), @MeasurementId = nullif(@MeasurementId, 0), @RecipeIngredientId = isnull(@RecipeIngredientId, 0) 

if @RecipeIngredientId = 0
    begin 
        insert into RecipeIngredient( RecipeId, IngredientId, IngredientSequence, MeasurementId, Amount)
        values(@RecipeId, @IngredientId, @IngredientSequence, @MeasurementId, @Amount)

        select @RecipeIngredientId = scope_identity()
    end 
else 
   begin
       update RecipeIngredient
       set
           RecipeId = @RecipeId,
           IngredientId = @IngredientId,
           IngredientSequence = @IngredientSequence,
           MeasurementId = @MeasurementId,
           Amount = @Amount
       where RecipeIngredientId = @RecipeIngredientId;
   end 
return @return 
end 
go 



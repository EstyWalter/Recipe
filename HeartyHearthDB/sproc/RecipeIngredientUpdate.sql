create or alter proc dbo.RecipeIngredientUpdate
@RecipeIngredientId int output,
@RecipeId int,
@IngredientId int,
@IngredientSequence int,
@MeasurmentId int,
@Amount decimal
as 
begin 
declare @return int = 0 

select @RecipeId = nullif(@RecipeId, 0), @IngredientId = nullif(@IngredientId, 0), @MeasurmentId = nullif(@MeasurmentId, 0), @RecipeIngredientId = isnull(@RecipeIngredientId, 0) 

if @RecipeIngredientId = 0
    begin 
        insert into RecipeIngredient( RecipeId, IngredientId, IngredientSequence, MeasurmentId, Amount)
        values(@RecipeId, @IngredientId, @IngredientSequence, @MeasurmentId, @Amount)

        select @RecipeIngredientId = scope_identity()
    end 
else 
   begin
       update RecipeIngredient
       set
           RecipeId = @RecipeId,
           IngredientId = @IngredientId,
           IngredientSequence = @IngredientSequence,
           MeasurmentId = @MeasurmentId,
           Amount = @Amount
       where RecipeIngredientId = @RecipeIngredientId;
   end 
return @return 
end 
go 



create or alter proc dbo.CloneRecipe(
    @RecipeId int, 
    @Message varchar(500) = ''
)
as 
begin 
    declare @RecipeNameClone varchar(107) = ''
    declare @return int = 0 
    select @RecipeId = isnull(@RecipeId, 0)

    begin try
        begin tran 
            
            select @RecipeNameClone =  r.RecipeName + ' - clone' from recipe r where @RecipeId = r.RecipeId 

            insert Recipe (CuisineId, UsersId, DateDrafted, DatePublished, DateArchived, RecipeName, Calories)
            select r.CuisineId, r.UsersId, r.DateDrafted, r.DatePublished, r.DateArchived, @RecipeNameClone, r.Calories
            from Recipe r 
            where @RecipeId = r.RecipeId  

            insert Directions (RecipeId, DirectionsSequence, Steps)
            select (select r.RecipeId from Recipe r where r.RecipeName = @RecipeNameClone), d.DirectionsSequence, d.Steps
            from Recipe r
            join Directions d 
            on r.RecipeId = d.RecipeId
            where @RecipeId = r.RecipeId

            insert RecipeIngredient(RecipeId, IngredientId, IngredientSequence, MeasurementId, Amount)
            select (select r.RecipeId from Recipe r where r.recipename = @RecipeNameClone),  
            ri.IngredientId, ri.IngredientSequence, m.MeasurementId, ri.Amount
            from Recipe r
            join recipeIngredient ri 
            on r.RecipeId = ri.RecipeId 
            join Measurement m 
            on m.MeasurementId = ri.MeasurementId 
            where @RecipeId = r.RecipeId

        commit tran;
    end try 
begin catch
  select  @return = 1, @message = 'An error occured, could not clone recipe.'
    rollback;
throw;
end catch 
end 

/*
declare @recipeids int 
select top 1 @recipeids = r.RecipeId  from recipe r 
select @RecipeIds
--exec CloneRecipe @RecipeId = @RecipeIds

select *  
from recipe r 
--join Directions d
--on r.recipeid = d.recipeid 
join 
recipeIngredient ri 
on ri.recipeid = r.recipeid 
where r.recipeid = @recipeids
*/
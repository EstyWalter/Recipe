create or alter proc dbo.IngredientGet
@IngredientId int = 0,
@All bit = 0,
@IncludeBlank bit = 0
as
    begin
    select @IngredientId = isnull(@IngredientId, 0)
        if @IncludeBlank = 1 
            begin 
                select i.ingredientid, i.ingredientname
                from Ingredient i 
                where i.ingredientid = @IngredientId 
                or @All = 1 
                union select 0, ' '
                order by IngredientId desc 
            end 
        else 
            begin 
                select i.ingredientid, i.ingredientname
                from Ingredient i 
                where i.ingredientid = @IngredientId 
                or @All = 1 
            end 
    end
go 
--exec IngredientGet @All = 1
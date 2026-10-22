create or alter proc dbo.DirectionsGet(
@All bit = 0,
@RecipeId int = 0)
as 
    begin
        select @RecipeId = isnull(@RecipeId, 0)
        select d.DirectionsId, d.RecipeId, d.Steps, d.DirectionsSequence
        from Directions d 
        where d.recipeid = @RecipeId 
        or @All = 1
        order by d.DirectionsSequence
    end 
go
/*
declare @recipeid int
select @recipeid = recipeid from directions d 
exec dbo.DirectionsGet @RecipeId = @recipeid
*/



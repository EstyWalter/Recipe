create or alter proc dbo.DirectionsUpdate
@DirectionsId	int,
@RecipeId	int,
@DirectionsSequence	int,
@Steps	varchar(500)
as 
begin 
declare @return int = 0 

select @RecipeId = nullif(@RecipeId, 0), @DirectionsId = isnull(@DirectionsId, 0) 

if (@DirectionsId = 0)
    begin 
        insert Directions(RecipeId, Steps, DirectionsSequence)
        values(@RecipeId, @Steps, @DirectionsSequence)
    
        select @DirectionsId = scope_identity() 
    end 
else  
   begin
        update Directions 
        set
        RecipeId = @RecipeId,
        Steps = @Steps,
        DirectionsSequence = @DirectionsSequence
        WHERE DirectionsId = @DirectionsId;
   end 
return @return 
end 
go
/*
DECLARE @DirectionsId INT = 0;

DECLARE @RecipeId INT = (
    SELECT TOP 1 RecipeId
    FROM dbo.Recipe
);

EXEC dbo.DirectionsUpdate
    @DirectionsId = @DirectionsId,
    @RecipeId = @RecipeId,
    @DirectionsSequence = 10,
    @Steps = 'Test step: Mix the ingredients together.';

SELECT TOP 10 *
FROM dbo.Directions
WHERE RecipeId = @RecipeId
ORDER BY DirectionsId DESC;
*/
create or alter proc dbo.UsersDelete
@UsersId int,
@Message varchar(500) = '' output  
as 
begin
declare @return int = 0
select @usersId = isnull(@usersId, 0)
    begin try 
        begin tran 

    DELETE d
    FROM Directions d
    JOIN Recipe r ON r.RecipeId = d.RecipeId
    WHERE r.UsersId = @UsersId;

    DELETE ri
    FROM RecipeIngredient ri
    JOIN Recipe r ON r.RecipeId = ri.RecipeId
    WHERE r.UsersId = @UsersId;

    DELETE cr
    FROM CookbookRecipe cr
    JOIN Recipe r ON r.RecipeId = cr.RecipeId
    WHERE r.UsersId = @UsersId;

    DELETE mcr
    FROM MealCourseRecipe mcr
    JOIN Recipe r ON r.RecipeId = mcr.RecipeId
    WHERE r.UsersId = @UsersId;

    DELETE mcr
    FROM MealCourseRecipe mcr
    JOIN MealCourse mc ON mc.MealCourseId = mcr.MealCourseId
    JOIN Meal m ON m.MealId = mc.MealId
    WHERE m.UsersId = @UsersId;

    DELETE cr
    FROM CookbookRecipe cr
    JOIN Cookbook c ON c.CookbookId = cr.CookbookId
    WHERE c.UsersId = @UsersId;

    DELETE c
    FROM Cookbook c
    WHERE c.UsersId = @UsersId;

    DELETE mc
    FROM MealCourse mc
    JOIN Meal m ON m.MealId = mc.MealId
    WHERE m.UsersId = @UsersId;

    DELETE m
    FROM Meal m
    WHERE m.UsersId = @UsersId;

    DELETE r
    FROM Recipe r
    WHERE r.UsersId = @UsersId;

    DELETE FROM Users 
    WHERE UsersId = @UsersId;

        commit;
    end try 
    	begin catch
        select @return = 1, @Message = 'Could not delete user'

		    rollback;
		    throw
         
	    end catch 
    return @return
end
go 
/*
select * from Users u 
declare @usersid int 
select top 1 @usersid = usersid from Users 
exec UsersDelete @UsersId = @usersid
select * from Users u 
*/












create or alter proc dbo.CuisineDelete(
@CuisineId int,
@Message varchar(500) = '' output) 
as 
begin
declare @return int = 0
select @CuisineId = isnull(@CuisineId, 0)
    begin try 
        begin tran 
               
            delete cr
            from CookbookRecipe cr
            join Recipe r 
            on r.RecipeId = cr.RecipeId
            where Cuisineid = @CuisineId    
            
            delete mcr 
            from MealCourseRecipe mcr 
            join recipe r 
            on mcr.Recipeid = r.RecipeId
            where r.Cuisineid = @CuisineId

            delete d
            from Directions d
            join Recipe r 
            on r.RecipeId = d.RecipeId
            where Cuisineid = @CuisineId    
            
            delete ri 
            from  RecipeIngredient ri 
            join recipe r 
            on ri.recipeid = r.recipeid 
            where Cuisineid = @CuisineId    
     
            delete Recipe  
            where Cuisineid = @CuisineId    
            
            delete Cuisine 
            where Cuisineid = @CuisineId
        commit;
    end try 
    	begin catch
        select @return = 1, @Message = 'Could not delete Cuisine'
		    rollback;
		    throw
	    end catch 
    return @return
end
go 

/*
select * from Cuisine 
declare @cuisineid int 
select top 1 @cuisineid = Cuisineid from Cuisine
exec CuisineDelete @CuisineID = @cuisineid
select * from Cuisine 
*/




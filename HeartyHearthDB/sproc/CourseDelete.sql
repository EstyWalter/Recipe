create or alter proc dbo.CourseDelete
@CourseId int,
@Message varchar(500) = '' output  
as 
    begin
    declare @return int = 0
    select @CourseId = isnull(@CourseId, 0)
        begin try 
            begin tran 
   
                delete mcr 
                from MealCourseRecipe mcr  
                join mealcourse mc 
                on mcr.MealCourseId = mc.MealCourseId
                where mc.CourseId = @CourseId

                delete MealCourse
                where CourseId = @CourseId

                delete Course 
                where CourseId = @CourseId

            commit;
        end try 
    	begin catch
            select @return = 1, @Message = 'Could not delete Course'
		    rollback;
		    throw 
	    end catch 
    return @return
end
go 
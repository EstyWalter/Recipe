create or alter proc dbo.CourseGet(
@CoursesId int = 0, 
@All bit = 0)
as 
    begin 
    select @CoursesId = isnull(@CoursesId, 0)
        select c.courseId, c.CourseName, c.CourseSequence 
        from Course c
        where c.courseId = @CoursesId
        or @All = 1 
    end 
go 
--exec CoursesGet @All = 1 


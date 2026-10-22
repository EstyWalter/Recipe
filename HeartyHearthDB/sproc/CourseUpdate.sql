create or alter proc dbo.CourseUpdate
@courseId int output,
@CourseName	varchar(50),
@CourseSequence	int
as 
begin 
declare @return int = 0 
select @CourseId = isnull(@courseId, 0)

if (@courseId = 0)
    begin 
        insert course (CourseName, CourseSequence)
        values(@CourseName, @CourseSequence)

        select CourseId = scope_identity()
    end 
else 
   begin
       update course 
       set
        coursename = @coursename,
        CourseSequence = @CourseSequence
       where courseId = @courseId 
   end 
return @return 
end 
go 

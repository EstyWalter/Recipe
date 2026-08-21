create or alter procedure UsersGet(@UsersId int = 0, @All bit = 0, @UserName varchar(50) = '')
as 
begin 
select @UserName = nullif(@UserName, '')
select u.UsersId, u.FirstName, u.LastName, u.UserName
from Users u 
where u.UsersId = @UsersId
or @All = 1
or u.UserName like '%' + @UserName + '%'
end
go


exec UsersGet

exec UsersGet  @all = 1

exec UsersGet @UserName = 'h'

exec UsersGet @UserName = ''

declare @id int
select top 1 @id = u.usersid from Users u
exec UsersGet @UsersId = @id 


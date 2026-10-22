create or alter procedure UsersGet(
    @UsersId int = 0, 
    @All bit = 0,
    @IncludeBlank bit = 0)
as 
    begin 
    select @UsersId = isnull(@UsersId, 0)
    if @IncludeBlank = 1
        begin 
            select u.UsersId, u.FirstName, u.LastName, u.UserName
            from Users u 
            where u.UsersId = @UsersId
            or @All = 1
            union select 0, '', '', ''
            where @IncludeBlank = 1
            order by usersid 
        end 
    else 
        begin 
            select u.UsersId, u.FirstName, u.LastName, u.UserName
            from Users u 
            where u.UsersId = @UsersId
            or @All = 1
        end 
    end
go

/*
exec UsersGet

exec UsersGet  @all = 1, @IncludeBlank = 1 

exec UsersGet @UserName = 'h'

exec UsersGet @UserName = ''

declare @id int
select top 1 @id = u.usersid from Users u
exec UsersGet @UsersId = @id 
*/

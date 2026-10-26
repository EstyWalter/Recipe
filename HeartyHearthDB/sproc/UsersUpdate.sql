create or alter proc dbo.UsersUpdate
@UsersId int output,
@FirstName varchar (50),
@LastName varchar (50),
@UserName varchar (50)
as 
begin 
declare @return int = 0 

select @UsersId = isnull(@UsersId, 0)

if (@UsersId = 0)
    begin 
        insert Users (FirstName, LastName, UserName)
        values (@FirstName, @LastName, @UserName)

        select @UsersId = scope_identity()
    end 
else 
   begin
        update Users 
        set 
        FirstName = @FirstName,
        LastName = @LastName,
        username = @UserName
        where UsersId = @Usersid 
   end 
return @return 
end 
go 

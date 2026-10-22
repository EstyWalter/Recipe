create or alter proc dbo.CookbookUpdate(
@CookbookId int output,
@UsersId int, 
@BookName varchar(100),
@Price decimal(5,2),
@BookActive bit,
@DateCreated date output 
)
as 
begin 
declare @return int = 0

select @CookbookId = isnull(@Cookbookid, 0), @UsersId = nullif(@UsersId, 0), @BookActive = isnull(@BookActive, 1)

if @CookbookId = 0
begin
    select @DateCreated = SYSDATETIMEOFFSET() AT TIME ZONE 'Eastern Standard Time'
    insert Cookbook(UsersId, BookName, Price, BookActive, DateCreated)
    values (@UsersId, @BookName, @Price, @BookActive, @Datecreated )

    select @CookbookId = scope_identity()
end 
else 
begin 

    update Cookbook
    set 
        UsersId = @UsersId,
        Bookname = @Bookname,
        price = @Price,
        BookActive = @BookActive,
        DateCreated = @DateCreated
        where Cookbookid = @CookbookId
    end 
return @return 
end 

GO




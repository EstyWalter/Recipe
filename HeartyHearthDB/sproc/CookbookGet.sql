
create or alter procedure dbo.CookbookGet(
    @CookbookId int = 0, 
    @All bit = 0)
as 
    begin 
        select @CookbookId = isnull(@CookbookId, 0)

        select c.cookbookid, c.UsersId, c.BookName, c.Price, c.BookActive, c.DateCreated
        from cookbook c 
        where c.cookbookId = @CookbookId
        or @All = 1
        order by CookbookId  desc 
    end
go

--exec cookbookGet @All = 1





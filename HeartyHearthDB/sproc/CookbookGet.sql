create or alter procedure dbo.CookbookGet(
    @CookbookId int = 0, 
    @All bit = 0,
    @List bit = 0
)
as 
begin 

    select @CookbookId = isnull(@CookbookId, 0);
    if @List = 0
    begin
        select c.CookbookId, c.bookname, c.Price, c.UsersId, c.BookActive, c.DateCreated
        from dbo.Cookbook c 
        where c.CookbookId = @CookbookId
        or @All = 1
        order by c.CookbookId desc;
    end
    else if @List = 1
    begin
        select c.CookbookId, c.BookName, u.UserName, NumOfRecipes = count(cr.RecipeId), c.Price
        from dbo.Cookbook c 
        join dbo.Users u 
        on c.UsersId = u.UsersId 
        left join dbo.CookbookRecipe cr 
        on c.CookbookId = cr.CookbookId
        group by c.CookbookId, c.BookName, c.Price, u.UserName
        order by c.CookbookId desc;
    end
end
go


--exec cookbookGet @All = 1, @List = 1





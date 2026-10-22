create or alter proc dbo.CookbookList
    as 
    begin 
        select c.cookbookid, c.BookName, Author = u.UserName, NumOfRecipes = count(cr.recipeid), c.Price 
        from cookbook c 
        left join CookbookRecipe cr 
        on c.Cookbookid =  cr.Cookbookid
        join Users u 
        on c.UsersId = u.UsersId 
        group by c.cookbookid, c.BookActive, c.BookName, u.UserName, c.Price 
        order by c.BookName
    end 
go 

exec CookbookList
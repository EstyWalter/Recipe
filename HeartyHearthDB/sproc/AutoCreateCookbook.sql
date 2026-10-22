create or alter proc dbo.AutoCreateCookbook(
    @UsersId int output,
    @Message varchar(500) = ''
)
as 
begin 
    declare @return int = 0 

  select @UsersId = isnull(@UsersId, 0)

    begin try
        begin tran 
            insert Cookbook (UsersId, BookName, Price, BookActive)
            select @UsersId,
            concat('Recipes by ', u.FirstName, ' ', u.LastName),
            count(r.RecipeId) * 1.33, 1
            from Users u
            join Recipe r
            on u.UsersId = r.UsersId
            where u.UsersId = @usersid 
            group by u.UsersId, u.FirstName, u.LastName;

            with CookbookInfo as
            (
            select c.CookbookId
            from Cookbook c
            join Users u
                on c.UsersId = u.UsersId
            where c.BookName = concat('Recipes by ', u.FirstName, ' ', u.LastName)
              and u.Usersid = @UsersId 
            )

            insert CookbookRecipe ( CookbookId, RecipeId, RecipeSequence )
            select ci.CookbookId, r.RecipeId, ROW_NUMBER() over (order by r.RecipeName)
            from CookbookInfo ci
            cross join Recipe r
            join Users u
            on r.UsersId = u.UsersId
            where u.Usersid = @UsersId

        commit tran;
    end try 
begin catch
  select  @return = 1, @message = 'An error occured, could not Auto-Create Cookbook'
    rollback;
throw;
end catch 
end 
go 

/*
 declare @usersid  int 
 select top 1 @usersid = u.usersid from users u 
 select @usersid
 --exec AutoCreateCookbook @UsersId = @usersid 
 select * 
from cookbook c 
join cookbookrecipe cr
on cr.cookbookid = c.cookbookid 
  where usersid = @usersid 
 */
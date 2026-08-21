create or alter procedure dbo.RecipeGet(
@RecipeId int = 0, 
@All bit = 0, 
@RecipeName varchar(100) = '')
as
begin 
select @RecipeName = nullif(@RecipeName, '')
select r.recipeid, r.cuisineid, r.usersid, r.datedrafted, r.datepublished, r.datearchived, r.recipename, r.calories, r.statuses, r.picturerecipe
from Recipe r 
where r.recipeid = @RecipeId
or @All = 1
or r.recipename like '%' + @recipename + '%' 
end 
go 

/*
exec RecipeGet

exec RecipeGet  @all = 1

exec RecipeGet @recipename = 'h'

exec RecipeGet @recipename = ''

declare @id int
select top 1 @id = r.recipeid from recipe r 
exec RecipeGet @Recipeid = @id 
*/

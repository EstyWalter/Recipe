create or alter procedure dbo.RecipeGet(
@RecipeId int = 0, 
@All bit = 0
--@IncludeBlank bit = 0
)
as
    begin 
    select @RecipeId = isnull(@RecipeId, 0)
        select r.recipeid, r.cuisineid, r.usersid, r.datedrafted, r.datepublished, r.datearchived, r.recipename, r.calories, r.statuses, r.picturerecipe
        from Recipe r 
        where r.recipeid = @RecipeId
        or @All = 1  
     --     union select 0, 0, 0, '', '', '', '', 0, '', ''
       -- where @IncludeBlank = 1 
        order by RecipeId desc 
    end 
go 

/*
exec RecipeGet

exec RecipeGet  @all = 1, @IncludeBlank = 0

exec RecipeGet @recipename = 'h'

exec RecipeGet @recipename = ''

declare @id int
select top 1 @id = r.recipeid from recipe r 
exec RecipeGet @Recipeid = @id 
*/

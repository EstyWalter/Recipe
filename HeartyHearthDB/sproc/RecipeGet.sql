create or alter procedure dbo.RecipeGet(
@RecipeId int = 0, 
@All bit = 0,
@List bit = 0,
@IncludeBlank bit = 0
)
as
    begin 
    select @RecipeId = isnull(@RecipeId, 0)
        if @list = 1
        begin 
            select r.recipeid, RecipeName,
            r.statuses, u.UserName, r.Calories, NumIngredients = count(RecipeIngredientId)
            from recipe r 
            left join RecipeIngredient ri 
            on r.RecipeId = ri.RecipeId
            join Users u 
            on u.UsersId = r.UsersId 
            group by r.recipeid, r.statuses, r.RecipeName, u.Username, r.Calories
            order by r.statuses desc 
        end 
        if @List = 0
        begin 
            if @IncludeBlank = 1 
            begin 
                select r.recipeid, r.cuisineid, r.usersid, r.datedrafted, r.datepublished, r.datearchived, r.recipename, r.calories, r.statuses, r.picturerecipe
                from Recipe r 
                where r.recipeid = @RecipeId
                or @All = 1  
                union select 0, 0, 0, '', '', '', '', 0, '', ''
                order by RecipeId 
            end 
            else 
            begin 
                select r.recipeid, r.cuisineid, r.usersid, r.datedrafted, r.datepublished, r.datearchived, r.recipename, r.calories, r.statuses, r.picturerecipe
                from Recipe r 
                where r.recipeid = @RecipeId
                or @All = 1  
                order by RecipeId desc 
            end 
        end 
    end 
go 

/*
exec RecipeGet


exec RecipeGet  @all = 1, @IncludeBlank = 0, @List = 1

exec RecipeGet @recipename = 'h'

exec RecipeGet @recipename = ''

declare @id int
select top 1 @id = r.recipeid from recipe r 
exec RecipeGet @Recipeid = @id 
*/

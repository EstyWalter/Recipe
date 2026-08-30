create or alter procedure dbo.RecipeDelete (
@RecipeId int,
@Message varchar(500) = ' ' output
)
as 
begin 

	declare @return int = 0
	

	if exists (select recipeid from recipe r where recipeid = @recipeid and (statuses = 'Published' or (statuses = 'Archived' and datediff(day, isnull(DatePublished, DateDrafted),  DateArchived) <= 30)))
		begin
			select @return = 1, @message = 'Cannot delete recipe that is published or archived for less than 30 days.'
			goto finished
		end

	begin try 
		begin tran 
			delete Directions where recipeid = @recipeid
			delete RecipeIngredient where RecipeId = @RecipeId 
			delete Recipe where recipeid = @RecipeId 
		commit;
	end try 
	begin catch
		rollback;
		throw
	end catch 
	finished:
	return @return 
end 



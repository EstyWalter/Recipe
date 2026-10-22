create or alter proc dbo.CookbookDelete
@CookbookId int,
@Message varchar(500) = '' output  
as 
begin
    declare @return int = 0
    select @CookbookId = isnull(@CookbookId, 0)

    begin try 
        begin tran 
          delete CookbookRecipe where CookbookId = @CookbookId
          delete Cookbook where CookbookId = @CookbookId
        commit;
    end try 
    	begin catch
        select @return = 1, @Message = 'Could not delete Cookbook'
		    rollback;
		    throw
	    end catch 
    return @return
end
go 
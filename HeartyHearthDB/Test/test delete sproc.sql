declare @recipeid int

select top 1 @recipeid = recipeid 
from recipe r 
where 
    statuses = 'Archived' 
    and 
    datediff(day, isnull(DatePublished, DateDrafted),  DateArchived) <= 30

select * from recipe where recipeid = @recipeid 

exec RecipeDelete @recipeid = @recipeid 

select * from recipe where recipeid = @recipeid 
------------------------------------------------------------
select top 1 @recipeid = recipeid 
from recipe r 
where 
    statuses = 'Archived' 
    and 
    datediff(day, isnull(DatePublished, DateDrafted),  DateArchived) >= 30

select * from recipe where recipeid = @recipeid 

exec RecipeDelete @recipeid = @recipeid 

select * from recipe where recipeid = @recipeid 
-------------------------------------------------------------------

select top 1 @recipeid = recipeid 
from recipe r 
where 
  statuses = 'Drafted' 


    select * from recipe where recipeid = @recipeid 


exec RecipeDelete @recipeid = @recipeid 

select * 
from recipe r 
where 
  recipeid = @recipeid 
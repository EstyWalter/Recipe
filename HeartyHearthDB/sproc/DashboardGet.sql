create or alter proc dbo.DashboardGet
as 
    begin 
        select Itemname = 'recipes', count = count(r.recipeid) from recipe r
        union select Itemname = 'Meals', count = count(m.mealid) from meal m 
        union select Itemname = 'cookbooks', count = count(c.cookbookid) from Cookbook c  
    end 
go 
--exec DashboardGet
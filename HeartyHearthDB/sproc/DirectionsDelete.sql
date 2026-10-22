create or alter proc dbo.DirectionsDelete
@DirectionsId int 
as 
begin 
     declare @return int = 0
     select @DirectionsId = isnull(@DirectionsId, 0)
          delete Directions where Directionsid = @DirectionsId
     return @return 
end 
go 
	
    
    
    
    
    
    
    
    
    
    
    

	



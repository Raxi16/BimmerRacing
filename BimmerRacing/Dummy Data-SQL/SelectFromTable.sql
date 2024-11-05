SELECT 
    ProductId,
    ProductName,
    Quantity
FROM 
    [dbo].[Product]
WHERE 
    Quantity < 5;
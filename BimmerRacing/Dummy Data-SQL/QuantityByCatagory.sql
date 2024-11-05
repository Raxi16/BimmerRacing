SELECT 
    CategoryId, 
    SUM(Quantity) AS TotalQuantity, 
    AVG(ListPrice) AS AveragePrice
FROM 
    [dbo].[Product]
GROUP BY 
    CategoryId;
SELECT 
    c.CustomerID, 
    c.FirstName + ' ' + c.LastName AS CustomerName,
    MAX(o.RequiredDate) AS LastOrderDate
FROM 
    [dbo].[Customer] c
LEFT JOIN 
    [dbo].[Order] o ON c.CustomerID = o.CustomerId
GROUP BY 
    c.CustomerID, 
    c.FirstName, 
    c.LastName
HAVING 
    MAX(o.RequiredDate) < DATEADD(MONTH, -6, GETDATE()) OR MAX(o.RequiredDate) IS NULL;

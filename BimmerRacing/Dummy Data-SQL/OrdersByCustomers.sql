SELECT 
    o.OrderId,
    c.FirstName + ' ' + c.LastName AS CustomerName,
    p.PayAmount,
    p.PayMethod,
    p.PayDate,
    o.OrderStatus,
    o.RequiredDate,
    o.ShippedDate
FROM 
    [dbo].[Order] o
JOIN 
    [dbo].[Customer] c ON o.CustomerId = c.CustomerID
LEFT JOIN 
    [dbo].[Payment] p ON o.CustomerId = p.CustomerId
ORDER BY 
    o.OrderId;
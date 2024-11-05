SELECT 
    o.OrderId,
    c.FirstName + ' ' + c.LastName AS CustomerName,
    SUM(p.PayAmount) AS TotalAmountPaid,
    o.OrderStatus,
    CASE 
        WHEN SUM(p.PayAmount) IS NULL THEN 'No Payment'
        WHEN SUM(p.PayAmount) >= 1000 THEN 'Fully Paid'
        ELSE 'Partially Paid'
    END AS PaymentStatus
FROM 
    [dbo].[Order] o
JOIN 
    [dbo].[Customer] c ON o.CustomerId = c.CustomerID
LEFT JOIN 
    [dbo].[Payment] p ON o.CustomerId = p.CustomerId
GROUP BY 
    o.OrderId, 
    c.FirstName, 
    c.LastName, 
    o.OrderStatus;

SELECT 
    c.CustomerID,
    c.FirstName + ' ' + c.LastName AS CustomerName,
    COUNT(p.PaymentId) AS TotalPayments,
    SUM(p.PayAmount) AS TotalAmountPaid,
    AVG(p.PayAmount) AS AverageOrderValue
FROM 
    [dbo].[Customer] c
JOIN 
    [dbo].[Payment] p ON c.CustomerID = p.CustomerId
GROUP BY 
    c.CustomerID, 
    c.FirstName, 
    c.LastName;

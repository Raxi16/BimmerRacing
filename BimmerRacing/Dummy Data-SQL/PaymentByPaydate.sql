SELECT 
    FORMAT(PayDate, 'yyyy-MM') AS Month,
    SUM(PayAmount) AS MonthlyRevenue
FROM 
    [dbo].[Payment]
GROUP BY 
    FORMAT(PayDate, 'yyyy-MM')
ORDER BY 
    Month;
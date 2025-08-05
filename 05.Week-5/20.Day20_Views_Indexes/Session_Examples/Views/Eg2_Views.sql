
/*
SELECT * FROM Customers 
SELECT * FROM Orders

INSERT INTO Orders VALUES(3, '2025-08-01')
INSERT INTO Orders VALUES(2, '2025-07-31')
*/

-- Example 2: View for Customer Order Summary

ALTER VIEW vw_CustomerOrderSummary
AS
SELECT 
    c.Customer_ID,
    c.Customer_Name,
    c.Email,
    COUNT(o.Order_ID) AS TotalOrders  
FROM Customers c
LEFT JOIN Orders o ON c.Customer_ID = o.Customer_ID
GROUP BY c.Customer_ID, c.Customer_Name, c.Email;


 
-- Usage: Retrieve customers who placed multiple orders
SELECT * FROM vw_CustomerOrderSummary WHERE TotalOrders > 1;




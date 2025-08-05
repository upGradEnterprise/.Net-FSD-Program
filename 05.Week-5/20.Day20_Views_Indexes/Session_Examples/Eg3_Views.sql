-- Example 3: View for Order Details with Book Titles


ALTER VIEW vw_OrderDetailsWithBooks
AS
SELECT 
    o.order_id,
    o.Order_Date,
    c.Customer_Name,
    b.Title,
	a.author_name,
	b.Price,
    od.quantity,    
    (od.quantity * b.Price) AS TotalPrice
FROM Orders o
JOIN Customers c ON o.Customer_ID = c.Customer_ID
JOIN Order_Details od ON o.Order_ID = od.Order_ID
JOIN Books b ON od.Book_ID = b.Book_ID
JOIN Authors a ON b.author_id = a.author_id;


-- Usage: Check details of orders placed in 2025.
SELECT * FROM vw_OrderDetailsWithBooks
SELECT * FROM vw_OrderDetailsWithBooks WHERE YEAR(order_date) = 2023;
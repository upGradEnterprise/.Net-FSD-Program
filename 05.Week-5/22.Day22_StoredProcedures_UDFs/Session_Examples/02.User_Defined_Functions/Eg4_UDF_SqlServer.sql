
----------------------------------------------------------
-- Eg4:  Get the total price of an order (given an OrderID)
-------------------------------------------------------------


use OnlineBookStore

CREATE FUNCTION dbo.fn_GetOrderTotal( @OrderID INT ) RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Total DECIMAL(10,2)

    SELECT @Total = SUM(b.Price * od.Quantity)
    FROM Order_Details od
    JOIN Books b ON od.Book_ID = b.Book_ID
    WHERE od.Order_ID = @OrderID

    RETURN ISNULL(@Total, 0)
END


-- Invoke the udf
SELECT dbo.fn_GetOrderTotal(3) AS OrderTotal





SELECT * FROM Orders
SELECT * FROM Order_Details

DECLARE @OrderID INT = 1
SELECT SUM(b.Price * od.Quantity)
    FROM Order_Details od
    JOIN Books b ON od.Book_ID = b.Book_ID
    WHERE od.Order_ID = @OrderID





-- Example: CTE for Aggregating Sales Data

-- Sample table: Sales
CREATE TABLE Sales (
    SaleID INT,
    Product VARCHAR(50),
    Amount DECIMAL(10, 2)
);

INSERT INTO Sales VALUES
(1, 'Laptop', 1000),
(2, 'Phone', 500),
(3, 'Laptop', 1200),
(4, 'Tablet', 300);


SELECT * FROM Sales; 

-- CTE to calculate total sales by product
WITH ProductSales AS (
    SELECT Product, SUM(Amount) AS TotalSales
    FROM Sales
    GROUP BY Product
)
SELECT Product, TotalSales
FROM ProductSales
WHERE TotalSales > 1000;


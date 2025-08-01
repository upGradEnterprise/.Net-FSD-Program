--- Example 4: CTE to Find Duplicate Records


-- Sample table: Customers
CREATE TABLE Customers (
    CustomerID INT,
    Email VARCHAR(50)
);

INSERT INTO Customers VALUES
(1, 'john@example.com'),
(2, 'jane@example.com'),
(3, 'john@example.com'),
(4, 'bob@example.com'),
(5, 'bob@example.com');

-- CTE to find duplicate emails
WITH DuplicateEmails AS (
    SELECT Email, COUNT(*) AS EmailCount
    FROM Customers
    GROUP BY Email
    HAVING COUNT(*) > 1
)
SELECT c.CustomerID, c.Email
FROM Customers c
INNER JOIN DuplicateEmails de ON c.Email = de.Email;






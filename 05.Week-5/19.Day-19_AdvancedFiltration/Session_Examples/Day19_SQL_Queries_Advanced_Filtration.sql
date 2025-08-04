

use EmployeeDb


SELECT * FROM Emps 

-- Display employees whose salary between 2000 to 5000
SELECT * FROM Emps 
WHERE Salary BETWEEN 2000 AND 5000


--  Display employees who are working in deptno :  10, 20
SELECT * FROM Emps 
WHERE Deptno IN (10,30)
ORDER by Deptno


--  Display employees who are not working in deptno :  30,40
SELECT * FROM Emps 
WHERE Deptno NOT IN (20,30)


--  Display employees who are as Clerk, Salesman
SELECT * FROM Emps 
WHERE JOB IN ('CLERK','SALESMAN')



-- Usage of LIKE Operator

SELECT * FROM Emps  WHERE Ename LIKE 'A%'	-- Starts with 'A'
SELECT * FROM Emps  WHERE Ename LIKE '_A%'  -- Second letter 'A'
SELECT * FROM Emps  WHERE Ename LIKE '%N'	-- End with 'N'
	

-- Handling Null / Not Null

SELECT * FROM Emps 

SELECT * FROM Emps  WHERE Deptno IS NULL
SELECT * FROM Emps  WHERE Deptno IS NOT NULL


SELECT * FROM Emps  WHERE Deptno <> 10
SELECT * FROM Emps  WHERE Deptno <> 10 OR Deptno IS NULL


-- Combine Join and Sub-Query 

SELECT e.Ename, e.Salary
FROM Emps e
JOIN (
    SELECT Deptno, AVG(Salary) AS AvgSalary
    FROM Emps
    GROUP BY Deptno
) avgDept ON e.Deptno = avgDept.Deptno
WHERE e.Salary > avgDept.AvgSalary;




-----------------------------------------------------


--  Online BookStore Case Study

--  UseCase:   Find Customers who placed orders in 2025 and have a specific email domain  "gmail"


use OnlineBookStore 

SELECT * FROM Orders
SELECT * FROM Customers

INSERT INTO Customers (customer_name, email, join_date) VALUES
('Scott', 'scott@gmail.com', '1995-01-15');


INSERT INTO Orders (customer_id, order_date) VALUES
(3, '2023-01-10');



SELECT 
	c.customer_id, 
	c.customer_name, 
	c.email, 
	o.order_date
FROM 
	Customers c
	INNER JOIN Orders o ON c.customer_id = o.customer_id
WHERE 
	YEAR(o.order_date) = 2023
	AND c.email LIKE '%@gmail.com';


--------------------------------------------------------------------------


-- Find Books published between 2015 and 2020 with a price range


SELECT book_id, Title, publication_year, price FROM Books
WHERE 
	publication_year BETWEEN 1991 AND 1999
	AND price BETWEEN 10 AND 30;









EXEC sp_help  Authors

 


select * from Customers 
select * from Orders

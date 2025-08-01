-- Example:   	Basic CTE to Filter Employees


-- CTE to get employees with salary > 2000
WITH HighSalaryEmployees AS (
    SELECT Empno, Ename, Salary
    FROM Emps
    WHERE Salary > 2000
)
SELECT * 
FROM HighSalaryEmployees;


use EmployeeDb


CREATE VIEW vw_GetEmpsByDeptno AS
SELECT Ename, Job, Deptno 
FROM Emps
WHERE Deptno=10;


ALTER VIEW vw_GetEmpsByDeptno AS
SELECT Ename, Job, Deptno, Salary
FROM Emps
WHERE Deptno=30;



SELECT * FROM vw_GetEmpsByDeptno

DROP VIEW vw_GetEmpsByDeptno; 

-- Rename the view
EXEC sp_rename 'vw_GetEmpsByDeptno','vw_GetNewEmpsByDeptno'

SELECT * FROM vw_GetNewEmpsByDeptno
DROP VIEW vw_GetNewEmpsByDeptno; 




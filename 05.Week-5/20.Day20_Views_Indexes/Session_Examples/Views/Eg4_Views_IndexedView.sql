

use EmployeeDb


CREATE VIEW vw_GetEmpsByDeptno 
WITH SCHEMABINDING
AS
SELECT Empno, Ename, Job, Deptno 
FROM dbo.Emps
WHERE Deptno=10;

CREATE UNIQUE CLUSTERED INDEX idx_vwDepartment ON vw_GetEmpsByDeptno(Empno);


ALTER VIEW vw_GetEmpsByDeptno AS
SELECT Ename, Job, Deptno, Salary
FROM Emps
WHERE Deptno=30;

SELECT * FROM Emps WHERE Deptno=10	

SELECT * FROM vw_GetEmpsByDeptno

INSERT INTO Emps VALUES(7114, 'Lokehs4','LEAD',1500,10)

DROP VIEW vw_GetEmpsByDeptno; 

-- Rename the view
EXEC sp_rename 'vw_GetEmpsByDeptno','vw_GetNewEmpsByDeptno'

SELECT * FROM vw_GetNewEmpsByDeptno
DROP VIEW vw_GetNewEmpsByDeptno; 




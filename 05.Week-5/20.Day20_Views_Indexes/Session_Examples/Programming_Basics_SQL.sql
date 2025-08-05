
use EmployeeDb



DECLARE @EmpCount INT
SET @EmpCount = 10
SELECT @EmpCount 



DECLARE @EmpCount INT
SELECT @EmpCount = Count(*) FROM Emps 
-- SELECT @EmpCount

IF @EmpCount > 50 
	PRINT 'High Employee Count';
ELSE
	PRINT 'Low Employee Count';





	SELECT * FROM Emps





-- Eg3: Get the no. of employees working in the given deptno

	ALTER  PROCEDURE  usp_getEmpsCountByDeptno
		@param_deptno INT,
		@param_empCount  INT  OUTPUT
	AS
	BEGIN
			DECLARE @dname VARCHAR(100);
			SELECT @dname = Dname from Dept WHERE Deptno=@param_deptno; 

			SELECT  @param_empCount = Count(*) FROM Emps WHERE Deptno=@param_deptno;

		    Print ('No. of Employees working in ' + @dname + ' : '+  CAST(@param_empCount AS VARCHAR));
	END;


	-- Execution

	DECLARE  @dno INT =30;
	DECLARE  @empCount INT;
	EXEC usp_getEmpsCountByDeptno @dno, @empCount OUTPUT
	SELECT @empCount


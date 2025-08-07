

	-- Eg2:  Display Employee details by Deptno
	CREATE  PROCEDURE  usp_getEmpsByDeptno
	   @param_deptno INT  	
	AS
	BEGIN
		SELECT * FROM Emps WHERE Deptno=@param_deptno;
	END;


	-- Passing value as input parameter
	EXEC usp_getEmpsByDeptno 30

	DECLARE  @dno INT = 10
	EXEC usp_getEmpsByDeptno @dno

----------------------------------------------------

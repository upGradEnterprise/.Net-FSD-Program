---------------------------------
--	Day22:  SQL Server- Working with Stored Procedure
----------------------------------


	use EmployeeDb;
	
	-- Eg1  Requirement:  Generate Employee count
	CREATE PROCEDURE  usp_GetEmpCount
	AS
	BEGIN
		SELECT COUNT(*) FROM Emps;

		Print('Get Emp Count procedure invoked');
	END;


	-- Executing the SP
	EXECUTE usp_GetEmpCount 
	EXEC usp_GetEmpCount 

	-------------------------------------


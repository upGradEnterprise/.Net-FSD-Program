

----------------------------------------------------------
-- Eg2:  Create a UDF to return employee count based on deptno
-------------------------------------------------------------


--- Creating udf
CREATE FUNCTION dbo.udf_getEmpCount(@deptno INT)  RETURNS INT
AS
BEGIN
	DECLARE @count INT	
	SELECT @count = Count(*) FROM Emps WHERE Deptno=@deptno;
	RETURN( @count );
END;


-- Invoke the udf
SELECT dbo.udf_getEmpCount(30);







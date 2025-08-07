

----------------------------------------------------------
-- Eg3:  Create a UDF to return all employee details based on deptno
-------------------------------------------------------------


--- Creating udf
CREATE FUNCTION dbo.udf_getEmpsByDeptno( @deptno INT )  RETURNS TABLE
AS
RETURN( SELECT * FROM Emps WHERE Deptno=@deptno );



-- Invoke the udf
SELECT * from  dbo.udf_getEmpsByDeptno(20);







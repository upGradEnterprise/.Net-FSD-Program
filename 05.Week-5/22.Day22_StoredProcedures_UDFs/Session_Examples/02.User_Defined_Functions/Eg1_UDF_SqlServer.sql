

----------------------------------------
-- Eg1:  Create a UDF to get sum of numbers
----------------------------------------


--- Creating udf
CREATE FUNCTION dbo.udf_getSum(@x INT,  @y INT)  RETURNS INT
AS
BEGIN
	RETURN(@x + @y);
END;


-- Invoke the udf
SELECT dbo.udf_getSum(10,20)







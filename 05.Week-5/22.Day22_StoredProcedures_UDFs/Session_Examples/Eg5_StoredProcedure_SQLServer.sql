--------------------------------------------------
---   Eg5:   Passing TVP(Table Valued Parameter) in Stored Procedure
-----------------------------------------------
		

---  User Defined Type As TABLE 	
CREATE TYPE MyUD_Emp_Table AS TABLE  
(  
    Empno INT PRIMARY KEY,  
    Ename VARCHAR(50),  
    Job  VARCHAR(50),
	Salary DECIMAL(10,2),
	Deptno  INT	
) 



DROP TYPE MyUD_Emp_Table
	



CREATE PROCEDURE usp_insertTableTypeData 
     @myData MyUD_Emp_Table READONLY 
As
BEGIN
	INSERT INTO Emps
	SELECT * FROM  @myData
END;

DROP PROCEDURE usp_insertTableTypeData;


-- Declare variables of type MyUD_Emp_Table
DECLARE @MyEmpTable MyUD_Emp_Table;

-- INSERT data into Table Valued Parameter
INSERT INTO @MyEmpTable VALUES (2222, 'Scott', 'Lead',5000,10)		

Exec usp_insertTableTypeData @MyEmpTable


SELECT * FROM Emps












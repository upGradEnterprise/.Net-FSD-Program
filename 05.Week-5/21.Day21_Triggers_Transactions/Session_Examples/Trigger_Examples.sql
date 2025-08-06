 ------------------------------------------
--   *************  Day21    ********************
------------------------------------------------


use EmployeeDb 

SELECT * FROM Emps 

DELETE FROM Emps  WHERE Empno = 7113


CREATE TRIGGER trg_InseadOfDelete
ON Emps
INSTEAD OF DELETE
AS
BEGIN
	PRINT 'DELETE operation not allowed on Emps table';	
END;



ALTER TRIGGER trg_InseadOfDelete
ON Emps
INSTEAD OF DELETE
AS
BEGIN
	RAISERROR('DELETE operation not allowed on Emps table', 16, 1);
END;



--  ----------------------------------------------


CREATE TABLE EmpLogTable(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Operation  NVARCHAR(100),
	Empno INT,  
	PerformedOn Date,  
	Description NVARCHAR(200)
)



CREATE TRIGGER  trg_after_insert_emps
ON Emps  
AFTER INSERT
AS  
BEGIN  
		DECLARE @eno INT
		SELECT  @eno = empno from INSERTED; 

	  -- Trigger Statements  
      -- Insert, Update, Or Delete Statements  
		INSERT INTO EmpLogTable VALUES('INSERT Opeation', @eno, GETDATE(), 'This message generated at the time insert a record in emp table')

		Print 'AFTER INSERT TRIGGER IS EXECUTED';
END;



select * from EmpLogTable

SELECT * FROM Emps 

INSERT INTO Emps VALUES(1122,'Smith','LEAD',1600,10);









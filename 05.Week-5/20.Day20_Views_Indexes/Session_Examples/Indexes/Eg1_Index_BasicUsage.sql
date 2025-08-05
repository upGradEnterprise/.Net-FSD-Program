

USE EmployeeDb


CREATE NONCLUSTERED INDEX
idx_ename
ON Emps (ename); 


CREATE UNIQUE INDEX
idx_email
ON Emps (email); 


-- To view all indexes on the given table 
EXEC sp_helpindex  'Emps'


-- Rebuild and Reorganize an Index

ALTER INDEX ALL ON Emps  REORGANIZE;
ALTER INDEX idx_ename ON Emps  REORGANIZE;



ALTER INDEX ALL ON Emps  REBUILD;
ALTER INDEX idx_ename ON Emps  REBUILD;


ALTER INDEX idx_ename ON Emps  DISABLE;



-- Drop Index
DROP INDEX idx_ename ON Emps; 


















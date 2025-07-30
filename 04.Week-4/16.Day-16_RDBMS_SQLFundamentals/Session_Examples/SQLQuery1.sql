
--------------------------------------------------------------------
--  SQL Server Case Study -   Library Management System
---------------------------------------------------------------------

-- Creating Database 
CREATE DATABASE  LibraryDB;

-- Select Database
USE LibraryDb;


-- Books Table
CREATE TABLE Books (
	BookID INT PRIMARY KEY,
	Title VARCHAR(100) NOT NULL,
	Author VARCHAR(50) NOT NULL,
	PublicationYear INT CHECK (PublicationYear >= 1800),
	ISBN VARCHAR(13) UNIQUE,
	AvailableCopies INT DEFAULT 1
);


-- Members Table
CREATE TABLE Members (
		MemberID INT PRIMARY KEY,
		FirstName VARCHAR(50) NOT NULL,
		LastName VARCHAR(50) NOT NULL,
		Email VARCHAR(100) UNIQUE,
		JoinDate DATE DEFAULT GETDATE()
);


-- Loans Table (to track borrowed books)
CREATE TABLE Loans (
		LoanID INT PRIMARY KEY,
		BookID INT,
		MemberID INT,
		LoanDate DATE NOT NULL,
		ReturnDate DATE,
		FOREIGN KEY (BookID) REFERENCES Books(BookID),
		FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);


 


-- Insert into Books
INSERT INTO Books (BookID, Title, Author, PublicationYear, ISBN, AvailableCopies)
VALUES
(1, 'The Great Gatsby', 'F. Scott Fitzgerald', 1925, '9780743273565', 3),
(2, '1984', 'George Orwell', 1949, '9780451524935', 2);




-- Insert into Books
INSERT INTO Books VALUES (3, 'Greatest Of All Times', 'Smith', 2025, '845446586454', 5)
 


SELECT * FROM Books 



-- Insert into Members
INSERT INTO Members (MemberID, FirstName, LastName, Email, JoinDate)
VALUES
(1, 'John', 'Doe', 'john.doe@email.com', '2025-01-01'),
(2, 'Jane', 'Smith', 'jane.smith@email.com', '2025-02-01');



-- Insert into Loans
INSERT INTO Loans (LoanID, BookID, MemberID, LoanDate, ReturnDate)
VALUES
(1, 1, 1, '2025-07-01', NULL),
(2, 2, 2, '2025-07-15', '2025-07-20');




SELECT * FROM Books 

SELECT * FROM Members 

SELECT * FROM Loans WHERE ReturnDate IS NULL


DELETE FROM  Books WHERE BookID=1


DELETE FROM Loans 



UPDATE Books  
SET Author='Smith George', AvailableCopies=5 
WHERE BookID=2



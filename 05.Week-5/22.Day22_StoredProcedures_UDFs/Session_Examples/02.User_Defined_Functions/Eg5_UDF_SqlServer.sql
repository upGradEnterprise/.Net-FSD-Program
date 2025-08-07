
----------------------------------------------------------
-- Eg5:  Get all books by a specific author
-------------------------------------------------------------


use OnlineBookStore

 
CREATE FUNCTION dbo.fn_GetBooksByAuthor(@AuthorName NVARCHAR(100))
RETURNS TABLE
AS
RETURN
(
    SELECT b.Book_ID, b.Title, b.Price
    FROM Books b
	JOIN Authors a ON  a.author_id = b.author_id
    WHERE a.author_name = @AuthorName
)
 

-- Invoke the udf
SELECT * FROM dbo.fn_GetBooksByAuthor('J.K. Rowling')





SELECT * FROM Authors
SELECT * FROM Books

 

 


 





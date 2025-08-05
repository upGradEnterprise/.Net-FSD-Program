-- Example 1: View for Book Details with Author Information

use OnlineBookStore

CREATE VIEW vw_BookAuthorDetails
AS
SELECT 
    b.book_id,
    b.title,    
    b.Price,
    b.publication_year,
    a.author_name,
    a.country
FROM Books b
JOIN Authors a ON b.Author_ID = a.Author_ID;



SELECT * FROM Authors
SELECT * FROM vw_BookAuthorDetails
SELECT * FROM vw_BookAuthorDetails WHERE country='USA'
SELECT * FROM vw_BookAuthorDetails WHERE publication_year=1997

--  To recursively find all books related (directly or indirectly) to a given book — like a "book recommendation tree".


-- ======================
-- 1. DROP TABLES IF EXIST
-- ======================
DROP TABLE IF EXISTS RelatedBooks;
DROP TABLE IF EXISTS Books;
DROP TABLE IF EXISTS Authors;

-- ======================
-- 2. CREATE Authors TABLE
-- ======================
CREATE TABLE Authors (
    AuthorID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);

-- ======================
-- 3. CREATE Books TABLE
-- ======================
CREATE TABLE Books (
    BookID INT PRIMARY KEY,
    Title VARCHAR(150) NOT NULL,
    AuthorID INT NOT NULL,
    Price DECIMAL(6,2) NOT NULL,
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

-- ======================
-- 4. CREATE RelatedBooks TABLE
-- ======================
CREATE TABLE RelatedBooks (
    BookID INT,
    RelatedBookID INT,
    PRIMARY KEY (BookID, RelatedBookID),
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (RelatedBookID) REFERENCES Books(BookID)
);

-- ======================
-- 5. INSERT INTO Authors
-- ======================
INSERT INTO Authors (AuthorID, Name) VALUES
(1, 'John Smith'),
(2, 'Alice Johnson'),
(3, 'Robert Brown'),
(4, 'Emily Davis');

-- ======================
-- 6. INSERT INTO Books
-- ======================
INSERT INTO Books (BookID, Title, AuthorID, Price) VALUES
(101, 'Intro to SQL', 1, 29.99),
(102, 'Advanced SQL', 1, 39.99),
(103, 'SQL for Data Science', 2, 34.99),
(104, 'Database Design', 3, 44.99),
(105, 'Data Warehousing', 4, 49.99);

-- ======================
-- 7. INSERT INTO RelatedBooks
-- ======================
INSERT INTO RelatedBooks (BookID, RelatedBookID) VALUES
(101, 102),  -- Intro to SQL → Advanced SQL
(101, 103),  -- Intro to SQL → SQL for Data Science
(102, 104),  -- Advanced SQL → Database Design
(104, 105);  -- Database Design → Data Warehousing




WITH RelatedTree AS (
    -- Anchor member: start with a specific book
    SELECT BookID, RelatedBookID, 1 AS Depth
    FROM RelatedBooks
    WHERE BookID = 101  -- starting from 'Intro to SQL'

    UNION ALL

    -- Recursive member: find related books of related books
    SELECT rt.RelatedBookID AS BookID, rb.RelatedBookID, rt.Depth + 1
    FROM RelatedTree rt
    JOIN RelatedBooks rb ON rt.RelatedBookID = rb.BookID
)
SELECT DISTINCT rt.RelatedBookID, b.Title, rt.Depth
FROM RelatedTree rt
JOIN Books b ON rt.RelatedBookID = b.BookID
ORDER BY rt.Depth;

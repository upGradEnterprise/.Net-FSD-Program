 create database OnlineBookStore
 
 use OnlineBookStore
 
 CREATE TABLE Authors (
	author_id INT PRIMARY KEY IDENTITY(1, 1),
	author_name VARCHAR(100) NOT NULL,
	country VARCHAR(50)
);

CREATE TABLE Books (
	book_id INT   PRIMARY KEY IDENTITY(1, 1),
	title VARCHAR(200) NOT NULL,
	author_id INT FOREIGN KEY REFERENCES Authors(author_id),
	price DECIMAL(10, 2) NOT NULL,
	publication_year INT	
);

CREATE TABLE Customers (
	customer_id INT PRIMARY KEY IDENTITY(1, 1),
	customer_name VARCHAR(100) NOT NULL,
	email VARCHAR(100),
	join_date DATE
);

CREATE TABLE Orders (
	order_id INT PRIMARY KEY IDENTITY(1, 1),
	customer_id INT FOREIGN KEY REFERENCES Customers(customer_id),
	order_date DATE
);

CREATE TABLE Order_Details (
	order_detail_id INT PRIMARY KEY IDENTITY(1, 1),
	order_id INT FOREIGN KEY REFERENCES Orders(order_id),
	book_id INT FOREIGN KEY REFERENCES Books(book_id),
	quantity INT NOT NULL,
	subtotal DECIMAL(10, 2) NOT NULL
);

INSERT INTO Authors (author_name, country) VALUES
('J.K. Rowling', 'UK'),
('George R.R. Martin', 'USA'),
('Haruki Murakami', 'Japan');

INSERT INTO Books (title, author_id, price, publication_year)
VALUES
('Harry Potter and the Philosophers Stone', 1, 20.99, 1997),
('A Game of Thrones', 2, 25.99, 1996),
('Norwegian Wood', 3, 15.99, 1987);

INSERT INTO Customers (customer_name, email, join_date) VALUES
('Alice Johnson', 'alice@example.com', '2020-01-15'),
('Bob Smith', 'bob@example.com', '2019-05-20');

INSERT INTO Orders (customer_id, order_date) VALUES
(1, '2023-01-10'),
(2, '2023-02-15');

INSERT INTO Order_Details (order_id, book_id, quantity,
subtotal) VALUES
(1, 1, 2, 41.98),
(1, 3, 1, 15.99),
(2, 2, 1, 25.99);
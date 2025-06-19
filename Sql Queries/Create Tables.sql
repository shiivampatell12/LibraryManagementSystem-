create table Users
(
	UserID int identity(1001,1) primary key,
	FirstName varchar(50),
	MiddleName varchar(50),
	LastName varchar(50),
	Address varchar(50),
	ContactNumber varchar(50),
	Email varchar(50),
	
	UserName varchar(50),
	Password varchar(50),
	IsAdmin varchar(50)
)

create table Books
(
	BookID int identity(1001,1) primary key,
	ISBN varchar(50),
	Category varchar(50),
	Title varchar(50),
	Author varchar(50),
	Abstract varchar(255),

)

create table BookSupplyTransaction
(
	SupplyTransID int identity(1001,1) primary key,
	BookID int,
	Supplies numeric

)

create table BorrowingTransaction
(
	BorrowTransID int identity(1001,1) primary key,
	BookID int,
	UserID int,
	Quantity numeric
	
)

create table BookReturnTransaction
(
	BookReturnTransID int identity(1001,1) primary key,
	BookID int,
	UserID int,
	Quantity numeric
)


USE LIBRARYMS;

INSERT INTO Users (FirstName, MiddleName, LastName, Address, ContactNumber, Email, UserName, Password, IsAdmin)
VALUES
('Juan', 'Rizal', 'Dela Cruz', '123 Sampaguita St, Manila', '09171234567', 'juan.delacruz@email.com', 'juan', 'pass123', '0'),
('Maria', 'Clara', 'Santos', '456 Narra Ave, Quezon City', '09187654321', 'maria.santos@email.com', 'maria', 'pass123', '0'),
('Peter', 'Jones', 'Admin', '789 Admin Ave, Makati City', '09191112222', 'peter.admin@email.com', 'admin', 'adminpass', '1'),
('Ana', 'Marie', 'Garcia', '101 Ilang-Ilang Rd, Pasig', '09203334444', 'ana.garcia@email.com', 'ana', 'pass123', '0'),
('Luis', 'Miguel', 'Reyes', '222 Dahlia St, Cebu City', '09215556666', 'luis.reyes@email.com', 'luis', 'pass123', '0');

INSERT INTO Books (ISBN, Category, Title, Author, Abstract)
VALUES
('978-3-16-148410-0', 'Fiction', 'The Great Adventure', 'John Doe', 'A thrilling journey into the unknown.'),
('978-0-12-345678-9', 'Science', 'The Science of Everything', 'Jane Smith', 'An exploration of the universe and beyond.'),
('978-1-23-456789-0', 'Biography', 'Life of an Explorer', 'Mark Johnson', 'A detailed biography of a famous explorer.'),
('978-2-12-345678-5', 'Technology', 'The Future of AI', 'Emily Clark', 'Insights into the advancements in Artificial Intelligence.'),
('978-0-56-789012-3', 'History', 'The World Wars', 'Thomas Brown', 'A comprehensive history of the world wars.'),
('978-1-32-654987-5', 'Technology', 'Coding for Beginners', 'Alice White', 'A beginners guide to coding and programming.'),
('978-0-15-662156-2', 'Fiction', 'The Lost Kingdom', 'David Green', 'A fantasy story about an ancient kingdom.'),
('978-1-54-123456-7', 'Literature', 'The Great Gatsby', 'F. Scott Fitzgerald', 'A classic American novel about love and betrayal.'),
('978-0-19-852663-6', 'Science', 'The Physics of Nature', 'Albert Einstein', 'A groundbreaking look into the laws of nature.'),
('978-1-40-289470-7', 'Health', 'The Art of Meditation', 'Sarah Black', 'A guide to the practice and benefits of meditation.');

INSERT INTO BookSupplyTransaction (BookID, Supplies)
VALUES
(1001, 100),
(1002, 150),
(1003, 80),
(1004, 200),
(1005, 120),
(1006, 50),
(1007, 75),
(1008, 90),
(1009, 110),
(1010, 130);

INSERT INTO BorrowingTransaction (BookID, UserID, Quantity)
VALUES
(1001, 1001, 2),
(1002, 1002, 1),
(1003, 1001, 3),
(1004, 1004, 1),
(1005, 1005, 2),
(1006, 1002, 1),
(1007, 1005, 1),
(1008, 1002, 1),
(1009, 1002, 2),
(1010, 1001, 1);

INSERT INTO BookReturnTransaction (BookID, UserID, Quantity)
VALUES
(1001, 1001, 1),
(1002, 1002, 1),
(1003, 1001, 1),
(1004, 1004, 1),
(1005, 1005, 1),
(1006, 1002, 1),
(1007, 1005, 1),
(1008, 1002, 1),
(1009, 1002, 1),
(1010, 1001, 1);
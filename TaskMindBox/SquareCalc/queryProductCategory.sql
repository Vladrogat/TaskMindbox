CREATE TABLE Product(
	Id INT PRIMARY KEY,
	Name TEXT
);

INSERT INTO Product (Id, Name)
VALUES
	(1, 'Milk'),
	(2, 'apple'),
	(3, 'tomato'),
	(4, 'hazelnuts'),
    (5, "pineapple"),
    (6, "watermelon");

CREATE TABLE Category (
	Id INT PRIMARY KEY,
	Name TEXT
);

INSERT INTO Category (Id, Name)
VALUES
	(1, 'fermented milk'),
	(2, 'vegetable'),
	(3, 'fruit'),
    (4, "berry")

CREATE TABLE ProductCategory (
    Id INT PRIMARY KEY,
	ProductId INT FOREIGN KEY REFERENCES Product(Id),
	CategoryId INT FOREIGN KEY REFERENCES Category(Id),
);

INSERT INTO ProductCategory (Id, ProductId, CategoryId)
VALUES
	(1, 3, 2),
    (2, 5, 3),
	(3, 2, 3),
	(4, 1, 1),
    (5, 6, 3),
    (6, 6, 4);

SELECT Product."Name", Category."Name"
FROM Product 
LEFT JOIN ProductCategory
	ON Product.Id = ProductCategory.ProductId
LEFT JOIN Category
	ON ProductCategory.CategoryId = Category.Id;

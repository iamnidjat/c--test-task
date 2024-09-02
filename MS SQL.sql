-- Создание таблицы продуктов
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(255) NOT NULL
);

-- Создание таблицы категорий
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(255) NOT NULL
);

-- Создание таблицы связи между продуктами и категориями
-- (Связь many-to-many)
CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Вставка данных

INSERT INTO Products (ProductName) VALUES ('Product 1');
INSERT INTO Products (ProductName) VALUES ('Product 2');
INSERT INTO Products (ProductName) VALUES ('Product 3');

INSERT INTO Categories (Categoryname) VALUES ('Category 1');
INSERT INTO Categories (CategoryName) VALUES ('Category 2');

INSERT INTO ProductCategories (ProductID, CategoryID) VALUES (1, 1);
INSERT INTO ProductCategories (ProductID, CategoryID) VALUES (1, 2);
INSERT INTO ProductCategories (ProductID, CategoryID) VALUES (2, 1);
INSERT INTO ProductCategories (ProductID, CategoryID) VALUES (2, 2);

SELECT ProductName, CategoryName
FROM Products 
LEFT JOIN ProductCategories ON Products.ProductID = ProductCategories.ProductID
LEFT JOIN Categories ON ProductCategories.CategoryID = Categories.CategoryID
ORDER BY Products.ProductName, Categories.CategoryName;
CREATE TABLE Users
(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Name VARCHAR(50),
    isEmployee BIT
);

INSERT INTO Users(Name, isEmployee) VALUES ('Matthew', 1);

SELECT * FROM Users;

CREATE TABLE Stores
(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Address VARCHAR(100)
);

INSERT INTO Stores(Address) VALUES('672 Red St, Las Vegas, NV');
INSERT INTO Stores(Address) VALUES('478 Blue Blvd, Las Vegas, NV');
INSERT INTO Stores(Address) VALUES('427 Green Ave, Las Vegas, NV');

SELECT * FROM Stores;

CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Name VARCHAR(100),
    Price DECIMAL(5,2),
);

INSERT INTO Products(Name, Price)
VALUES('10 Ohm Resistor',0.25);
INSERT INTO Products(Name, Price)
VALUES('100 Ohm Resistor',0.50);
INSERT INTO Products(Name, Price)
VALUES('50 uF Capacitor', 1.25);
INSERT INTO Products(Name, Price)
VALUES('500 uF Capacitor', 0.75);
INSERT INTO Products(Name, Price)
VALUES('Soldering Kit', 30.00);

SELECT * FROM Products;

CREATE TABLE InventoryItems
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    StoreId INT FOREIGN KEY REFERENCES Stores(Id),
    ProductId INT FOREIGN KEY REFERENCES Products(Id),
    Quantity INT
);

INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (1, 1, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (1, 2, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (1, 3, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (1, 4, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (1, 5, 10);

INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (2, 1, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (2, 2, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (2, 3, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (2, 4, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (2, 5, 10);
SELECT * FROM InventoryItems;

INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (3, 1, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (3, 2, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (3, 3, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (3, 4, 100);
INSERT INTO InventoryItems(StoreID, ProductId, Quantity)
VALUES (3, 5, 10);
SELECT * FROM InventoryItems;

CREATE TABLE Orders
(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    UserId INT FOREIGN KEY REFERENCES Users(Id),
    StoreId INT FOREIGN KEY REFERENCES Stores(Id),
    DatePlaced DATETIME DEFAULT CURRENT_TIMESTAMP
);

SELECT * FROM Orders;

CREATE TABLE OrderItems
(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    OrderId INT FOREIGN KEY REFERENCES Orders(Id),
    ProductId INT FOREIGN KEY REFERENCES Products(Id),
    Quantity INT
);

SELECT * FROM OrderItems;


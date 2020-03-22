-- CREATE TABLE Customer
CREATE TABLE Customer (
	ID INT IDENTITY NOT NULL,
	CName NVARCHAR(255) NOT NULL,
	Phone NVARCHAR(10)
	CONSTRAINT PK_Customer PRIMARY KEY (ID)
	CONSTRAINT CHK_Phone_CorrectDigits CHECK (LEN(Phone) = 10),
);

-- CREATE TABLE Product
CREATE TABLE Product (
	ID INT IDENTITY NOT NULL,
	PName NVARCHAR(255) NOT NULL,
	Price MONEY NOT NULL,
	CONSTRAINT PK_Product PRIMARY KEY (ID),
	CONSTRAINT CHK_Price_Nonnegative CHECK (Price > 0)
);

-- CREATE TABLE Location
CREATE TABLE Location (
	ID INT IDENTITY NOT NULL,
	Zipcode NVARCHAR(5) NOT NULL,
	CONSTRAINT PK_Location PRIMARY KEY (ID),
	CONSTRAINT CHK_Zipcode_CorrectDigits CHECK (LEN(Zipcode) = 5),
);


-- CREATE TABLE Orders
CREATE TABLE Orders (
	ID INT IDENTITY NOT NULL,
	LocationID INT NOT NULL,
	CustomerID INT NOT NULL,
	OrderTime DATETIME NOT NULL,
	CONSTRAINT PK_Orders PRIMARY KEY (ID),
	CONSTRAINT FK_Orders_Location_ID FOREIGN KEY (LocationID) REFERENCES Location(ID),
	CONSTRAINT FK_Orders_Customer_ID FOREIGN KEY (CustomerID) REFERENCES Customer(ID)
);

-- CREATE TABLE OrderProduct
CREATE TABLE OrderProduct (
	OrdersID INT NOT NULL,
	ProductID INT NOT NULL,
	Quantity INT NOT NULL,
	CONSTRAINT PK_OrderProduct PRIMARY KEY (OrdersID, ProductID),
	CONSTRAINT FK_OrderProduct_Orders_ID FOREIGN KEY (OrdersID) REFERENCES Orders(ID),
	CONSTRAINT FK_OrderProduct_Product_ID FOREIGN KEY (ProductID) REFERENCES Product(ID),
	CONSTRAINT CHK_Quantity_Nonnegative CHECK (Quantity > 0)
);

-- CREATE TABLE Store
CREATE TABLE Store (
	LocationID INT NOT NULL,
	ProductID INT NOT NULL,
	ItemInStore INT NOT NULL,
	CONSTRAINT PK_Inventory PRIMARY KEY (LocationID, ProductID),
	CONSTRAINT FK_Inventory_Location_ID FOREIGN KEY (LocationID) REFERENCES Location(ID),
	CONSTRAINT FK_Inventory_Product_ID FOREIGN KEY (ProductID) REFERENCES Product(ID),
	CONSTRAINT CHK_Stock_Nonnegative CHECK (ItemInStore >= 0)
);
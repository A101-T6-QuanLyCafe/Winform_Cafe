	-- Tạo cơ sở dữ liệu
	CREATE DATABASE CoffeeShopDB;
	go
	USE CoffeeShopDB;
	go
	-- Bảng chứa thông tin sản phẩm
	create table typeProduct(
		typeProductID int primary key identity(1,1),
		typeProductName nvarchar(100) not null,
	)
	go

	CREATE TABLE Products (
		ProductID INT PRIMARY KEY identity(1,1),
		ProductName NVARCHAR(255) not null,
		Price real not null default 0,
		typeProductID int not null,
		ISDELETE INT NOT NULL DEFAULT 0,
		------------------ image, craft craftable 
		photo image,
		Craftable int not null default 0, -- 0 if hadnt recipe 1 if have
		constraint FK_Product_TypeProduct foreign key (typeProductID) references typeProduct(typeProductID)
	);
	-- Bảng chứa thông tin nhân viên
	CREATE TABLE Employees (
		EmployeeID INT IDENTITY PRIMARY KEY,
		FirstName NVARCHAR(50),
		LastName NVARCHAR(50),
		EMAIL VARCHAR(50) NOT NULL UNIQUE,
		PHONE VARCHAR(15) NOT NULL UNIQUE,
		DOB DATETIME NOT NULL,
		SEX NVARCHAR(7) NOT NULL DEFAULT 'NAM',
		USERNAME VARCHAR(20) NOT NULL UNIQUE,
		PASSWORD VARCHAR(20) NOT NULL,
		ISDELETE INT NOT NULL DEFAULT 0 -- O LA CON 1 LA DA XOA
	)
	go



	 


	-- bảng đặt bàn
	create table tablesT(
		TableID int primary key identity(1,1),
		Name nvarchar(20) unique,
		Note nvarchar(100) not null default '',
		ISDELETE INT NOT NULL DEFAULT 0,
		status int not null default 0, -- 1 la có khach 0 là trống
	)
	-- bảng orders tính tiền 
	CREATE TABLE Orders (
		OrderID INT PRIMARY KEY identity(1,1),
		OrderDate DATETIME not null default getdate(),
		TotalAmount real not null default 0,
		EmployeeID INT not null,
		TablesID int not null,
		status int not null default 0, -- thanh toan hay chua
		constraint FK_od_TB foreign key (TablesID) references tablesT(TableID),	
		FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID),
	);

	-- Bảng chứa chi tiết đơn hàng
	CREATE TABLE OrderDetails (
		OrderDetailID INT PRIMARY KEY identity(1,1),
		OrderID INT not null,
		ProductID INT not null,
		Quantity INT not null default 1,
		Price real not null default 0,
		FOREIGN KEY (OrderID) REFERENCES Orders (OrderID),
		FOREIGN KEY (ProductID) REFERENCES Products (ProductID)
	);


	-- Bảng quản lý quyền truy cập(nhoms quyen)
	CREATE TABLE Permissions (
		PermissionID INT PRIMARY KEY identity(1,1),
		PermissionName NVARCHAR(50)
	);

	-- Bảng quản lý quyền của từng nhân viên
	CREATE TABLE EmployeePermissions (
		EmployeePermissionID INT PRIMARY KEY identity(1,1),
		EmployeeID INT,
		PermissionID INT,
		FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID),
		FOREIGN KEY (PermissionID) REFERENCES Permissions (PermissionID)
	);

	-- Bảng quản lý các màn hình
	CREATE TABLE Screens (
		ScreenID INT PRIMARY KEY identity(1,1),
		ScreenName NVARCHAR(50)
	);

	-- Bảng quản lý quyền truy cập của từng nhóm quyền đối với các màn hình
	CREATE TABLE PermissionScreens (
		PermissionScreenID INT PRIMARY KEY identity(1,1),
		PermissionID INT,
		ScreenID INT,
		FOREIGN KEY (PermissionID) REFERENCES Permissions (PermissionID),
		FOREIGN KEY (ScreenID) REFERENCES Screens (ScreenID)
	);

	-- Bảng chứa thông tin nhập hàng
	CREATE TABLE Incomings (
		IncomingID INT PRIMARY KEY identity(1,1),
		IncomingDate DATETIME,
		total_Price float ,
		amount_paid float,
		EmployeeID INT not null ,
		constraint fk_incom_employee foreign key (EmployeeID) references Employees(EmployeeID)


	);
	-- nhà cung cấp 
	create table supplier(
		supplierID int primary key identity(1,1),
		suplierName nvarchar(100),
		email varchar(100),
		address nvarchar(100),
		phone text,
		ISDELETE INT NOT NULL DEFAULT 0
	)
	-- kiểu nguyên liệu 
	create table TypeMaterials(
		TypeID int primary key identity(1,1),
		TypeName nvarchar(100),
		ISDELETE INT NOT NULL DEFAULT 0
	)
	-- nguyên liệu đầu vào 
	create table materials (
		Materials_ID int primary key identity(1,1),
		Materials_Name nvarchar(100),
		Price float,
		supplieriD int,
		quantity int,
		-- ----------------them unit ------------------ 
		Unit varchar(10),
		-- ----------------them image neu co the ko thi thoi ------------------ 
		Photo image,
		TypeID int ,
		ISDELETE INT NOT NULL DEFAULT 0,
		constraint FK_MT_Type foreign key (TypeID) references TypeMaterials(TypeID),
		constraint FK_SP_MT foreign key (supplieriD) references supplier(supplierID)
	)
	-- chi tiết phiếu nhập 
	create table Incomings_Detail(
		Incomings_Detail_ID int primary key identity(1,1),
		IncomingID int ,
		Materials_ID int, 
		quantity int,
		price float ,-- thành tiền của món này ( dùng trigger viết sau)	
		constraint FK_IC_ICDetail foreign key (IncomingID) references Incomings(IncomingID),
		constraint FK_ICDEtail_Material foreign key (Materials_ID) references materials(Materials_ID)

	)
	go

		-- ----------------them Recipe ------------------ 
	Create Table Recipe
	(
		RecipeID int primary key identity,
		ProductID int,
		Constraint FK_Recipe_Product Foreign key (ProductID) references Products(ProductID)
	)
	go

	Create Table RecipeInfo
	(
		RecipeInfoID int primary key identity,
		RecipeID int not null,
		MaterialID int not null,
		Quantity int not null,
		Constraint FK_RecipeInfo_Recipe Foreign key (RecipeID) References Recipe(RecipeID),
		Constraint FK_RecipeInfo_Materials Foreign key (MaterialID) References materials(Materials_ID)
	)
	go
	--=================================insert data==================================
	-- Insert data into typeProduct table
INSERT INTO typeProduct (typeProductName) VALUES 
  (N'Coffee'), 
  (N'Tea'), 
  (N'Snacks'), 
  (N'Desserts'), 
  (N'Soft Drinks');

-- Insert data into Products table
INSERT INTO Products (ProductName, Price, typeProductID) VALUES
  (N'Espresso', 2.5, 1),
  (N'Latte', 3.0, 1),
  (N'Green Tea', 2.0, 2),
  (N'French Fries', 4.0, 3),
  (N'Cheesecake', 5.5, 4);

-- Insert data into Employees table
INSERT INTO Employees (FirstName, LastName, Email, Phone, DOB, SEX, USERNAME, PASSWORD) VALUES
  (N'Dũng', N'Nguyễn', 'john.doe@example.com', '123456789', '1990-01-01', N'Male', 'admin', '123'),
  (N'Hoàng', N'Trần', 'jane.smith@example.com', '987654321', '1988-05-15', N'Male', 'hoang', '123');

-- Insert data into tablesT table
INSERT INTO tablesT (Name, status) VALUES
  ('Bàn 1', 0),
  ('Bàn 2',0),
  ('Bàn 3',0),
  ('Bàn 4',0),
  ('Bàn 5',0);



-- Insert data into OrderDetails table


-- Insert data into Permissions table
INSERT INTO Permissions (PermissionName) VALUES
  (N'Admin'),
  (N'Cashier'),
  (N'Waiter');

-- Insert data into EmployeePermissions table
INSERT INTO EmployeePermissions (EmployeeID, PermissionID) VALUES
  (1, 1),
  (2, 2),
  (1, 3),
  (2, 3);

-- Insert data into Screens table
INSERT INTO Screens (ScreenName) VALUES
  (N'Dashboard'),
  (N'Orders'),
  (N'Reports');

-- Insert data into PermissionScreens table
INSERT INTO PermissionScreens (PermissionID, ScreenID) VALUES
  (1, 1),
  (2, 2),
  (3, 3);

-- Insert data into Incomings table


-- Insert data into supplier table
INSERT INTO supplier (suplierName, email, address, phone) VALUES
  (N'SupplierA', 'supplierA@example.com', N'Street A, City A', '123-456-789'),
  (N'SupplierB', 'supplierB@example.com', N'Street B, City B', '987-654-321');

-- Insert data into TypeMaterials table
INSERT INTO TypeMaterials (TypeName) VALUES
  (N'Coffee Beans'),
  (N'Tea Leaves'),
  (N'Potatoes'),
  (N'Cheese'),
  (N'Flour');

-- Insert data into materials table
INSERT INTO materials (Materials_Name, Price, supplieriD, quantity, TypeID) VALUES
  (N'Arabica Coffee Beans', 15.0, 1, 50, 1),
  (N'Green Tea Leaves', 10.0, 2, 30, 2),
  (N'Potatoes', 2.5, 1, 100, 3),
  (N'Cheddar Cheese', 8.0, 2, 20, 4),
  (N'All-Purpose Flour', 3.0, 1, 40, 5);

SELECT * FROM typeProduct;

SELECT * FROM Products;

SELECT * FROM Employees;

SELECT * FROM tablesT;

SELECT * FROM Orders;

SELECT * FROM OrderDetails;

SELECT * FROM Permissions;

SELECT * FROM EmployeePermissions;

SELECT * FROM Screens;

SELECT * FROM PermissionScreens;

SELECT * FROM Incomings;

SELECT * FROM supplier;

SELECT * FROM TypeMaterials;

SELECT * FROM materials;

SELECT Price FROM Incomings_Detail;

--=======================================trigger===============================
go
CREATE TRIGGER trgCalculatePrice
ON Incomings_Detail
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IncomingID INT;
    DECLARE @MaterialsID INT;
    DECLARE @Quantity INT;

    -- Lấy thông tin từ bảng Inserted
    SELECT @IncomingID = i.IncomingID,
           @MaterialsID = i.Materials_ID,
           @Quantity = i.Quantity
    FROM Inserted i;

    -- Tính giá trị mới và cập nhật vào cột Price
    UPDATE Incomings_Detail
    SET Price = m.Price * @Quantity
    FROM Incomings_Detail id
    INNER JOIN Materials m ON id.Materials_ID = m.Materials_ID
    WHERE id.IncomingID = @IncomingID
      AND id.Materials_ID = @MaterialsID;
END;
-- cập nhật tổng tiền 
CREATE TRIGGER trgUpdateTotalAmount
ON Incomings_Detail
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IncomingID INT;

    -- Lấy IncomingID từ bảng Inserted
    SELECT @IncomingID = i.IncomingID
    FROM Inserted i;

    -- Cập nhật tổng tiền của Incomings
    UPDATE Incomings
    SET total_Price = (
        SELECT SUM(price)
        FROM Incomings_Detail
        WHERE IncomingID = @IncomingID
    )
    WHERE Incomings.IncomingID = @IncomingID;
END;

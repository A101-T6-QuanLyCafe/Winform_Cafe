	-- Tạo cơ sở dữ liệu
	CREATE DATABASE CoffeeShopDB;
	go
	USE CoffeeShopDB;
	go
	-- Bảng chứa thông tin sản phẩm
	create table typeProduct(
		typeProductID int primary key identity(1,1),
		typeProductName nvarchar(100),
	)
	CREATE TABLE Products (
		ProductID INT PRIMARY KEY identity(1,1),
		ProductName NVARCHAR(255),
		Price float,
		typeProductID int,
		constraint FK_Product_TypeProduct foreign key (typeProductID) references typeProduct(typeProductID)
	);
	-- Bảng chứa thông tin nhân viên
	CREATE TABLE Employees (
		EmployeeID INT PRIMARY KEY identity(1,1),
		FirstName NVARCHAR(50),
		LastName NVARCHAR(50),
		Email NVARCHAR(100),
		Password NVARCHAR(50)
	);
	 


	-- bảng đặt bàn
	create table tablesT(
		TableID int primary key identity(1,1),
		status int default 0, -- 1 la có khach 0 là trống 
	)
	-- bảng orders tính tiền 
	CREATE TABLE Orders (
		OrderID INT PRIMARY KEY identity(1,1),
		OrderDate DATETIME,
		TotalAmount DECIMAL(10, 2),
		EmployeeID INT,
		TablesID int,
		status int default 0 , -- thanh toan hay chua
		constraint FK_od_TB foreign key (TablesID) references tablesT(TableID),	
		FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID),
	);

	-- Bảng chứa chi tiết đơn hàng
	CREATE TABLE OrderDetails (
		OrderDetailID INT PRIMARY KEY identity(1,1),
		OrderID INT,
		ProductID INT,
		Quantity INT,
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

	);
	-- nhà cung cấp 
	create table supplier(
		supplierID int primary key identity(1,1),
		suplierName nvarchar(100),
		email varchar(100),
		address nvarchar(100),
		phone text
	)
	-- kiểu nguyên liệu 
	create table TypeMaterials(
		TypeID int primary key identity(1,1),
		TypeName nvarchar(100),
	
	)
	-- nguyên liệu đầu vào 
	create table materials (
		Materials_ID int primary key identity(1,1),
		Materials_Name nvarchar(100),
		Price float,
		supplieriD int,
		quantity int,
		TypeID int ,
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
	--=================================insert data==================================


	--=================================trigger======================================
	go
	 create trigger Incomings_Detail_price
	 on Incomings_Detail 
	 after insert 
	 as
	 begin 
		declare @GiaSp float 
		declare @maSp int 
		declare @In_ID int 
		set @In_ID=(select Incomings_Detail_ID from inserted)
		set @maSp = (select Materials_ID from inserted)
		set @GiaSp= (select Price from materials where Materials_ID=@maSp)\
		update Incomings_Detail set price= @GiaSp*(select quantity from inserted) where Incomings_Detail_ID=@In_ID
	 end 
	 -- tinhs tổng tiền nhập hàng
	 --go 
		--create trigger totalPrice_Incomings
		--on Incomings_Deltail 
		--after insert
		--as
		--begin
		--	update Incomings set total_Price= total_Price+(select price from Incomings_Detail where IncomingID=(select IncomingID from inserted)) 
		--	where IncomingID=(select IncomingID from inserted)
		--end 
	--=================================function=====================================

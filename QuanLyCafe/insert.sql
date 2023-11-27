-- insert 
-- Nhập liệu vào bảng loại sản phẩm
INSERT INTO typeProduct (typeProductName) VALUES 
    ('Coffee'),
    ('Tea'),
    ('Dessert'),
    ('Snack');

-- Nhập liệu vào bảng sản phẩm
INSERT INTO Products (ProductName, Price, typeProductID) VALUES 
    ('Espresso', 3.5, 1),
    ('Green Tea', 2.0, 2),
    ('Chocolate Cake', 5.0, 3),
    ('French Fries', 4.0, 4);

-- Nhập liệu vào bảng nhân viên
INSERT INTO Employees (FirstName, LastName, Email, Password) VALUES 
    (N'Dũng', N'Nguyễn', 'admin@gmail.com', '1'),
    (N'Khang', N'Quách', 'khang@example.com', '2');

-- Nhập liệu vào bảng đặt bàn
INSERT INTO tablesT (status) VALUES 
    (0),
    (0),
    (0),
    (1);

-- Nhập liệu vào bảng đơn hàng

-- Nhập liệu vào bảng quyền truy cập
INSERT INTO Permissions (PermissionName) VALUES 
    ('Admin'),
    ('Waiter'),
    ('Cashier');

-- Nhập liệu vào bảng quyền nhân viên
INSERT INTO EmployeePermissions (EmployeeID, PermissionID) VALUES 
    (1, 1),
    (2, 2);

-- Nhập liệu vào bảng màn hình
INSERT INTO Screens (ScreenName) VALUES 
    ('Dashboard'),
    ('Order Management'),
    ('Inventory');

-- Nhập liệu vào bảng quyền màn hình
INSERT INTO PermissionScreens (PermissionID, ScreenID) VALUES 
    (1, 1),
    (2, 2),
    (3, 3);



-- Nhập liệu vào bảng nhà cung cấp
INSERT INTO supplier (suplierName, email, address, phone) VALUES 
    ('ABC Supplier', 'abc@example.com', '123 Main St', '123-456-7890'),
    ('XYZ Supplier', 'xyz@example.com', '456 Oak St', '987-654-3210');

-- Nhập liệu vào bảng loại nguyên liệu
INSERT INTO TypeMaterials (TypeName) VALUES 
    ('Grains'),
    ('Liquids'),
    ('Vegetables');

-- Nhập liệu vào bảng nguyên liệu
INSERT INTO materials (Materials_Name, Price, supplieriD, quantity, TypeID) VALUES 
    ('Coffee Beans', 20.0, 1, 100, 1),
    ('Milk', 10.0, 2, 50, 2),
    ('Potatoes', 5.0, 1, 200, 3);




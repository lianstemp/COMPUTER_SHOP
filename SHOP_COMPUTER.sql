DROP DATABASE LKS_COMPUTER_SHOP;

CREATE DATABASE LKS_COMPUTER_SHOP;

USE LKS_COMPUTER_SHOP;

-- Membuat tabel Customer
CREATE TABLE Customer (
    IdCustomer INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255),
    Phone VARCHAR(20),
    Email VARCHAR(255),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);
-- Membuat tabel Product
CREATE TABLE Product (
    IdProduct INT IDENTITY(1,1) PRIMARY KEY,
    Category VARCHAR(255),
    Name VARCHAR(255),
    Price DECIMAL(10, 2),
    Stock INT,
    Image VARCHAR(255),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

-- Membuat tabel Payment
CREATE TABLE Payment (
    IdPayment INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

-- Membuat tabel Employee
CREATE TABLE Employee (
    IdEmployee INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255),
    PhoneNumber VARCHAR(20),
    Email VARCHAR(255),
    Pass VARCHAR(255),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

-- Membuat tabel Transactions
CREATE TABLE Transactions (
    IdTransaction INT IDENTITY(1,1) PRIMARY KEY,
    IdCustomer INT,
    IdPayment INT,
    IdEmployee INT,
    Date DATE,
    SubTotal DECIMAL(10, 2),
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (IdCustomer) REFERENCES Customer (IdCustomer),
    FOREIGN KEY (IdPayment) REFERENCES Payment (IdPayment),
    FOREIGN KEY (IdEmployee) REFERENCES Employee (IdEmployee)
);

-- Membuat tabel DetailTransaction
CREATE TABLE DetailTransaction (
    IdDetailTransaction INT IDENTITY(1,1) PRIMARY KEY,
    IdTransaction INT,
    IdProduct INT,
    DetailPrice DECIMAL(10, 2),
    Quantity INT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (IdTransaction) REFERENCES Transactions (IdTransaction),
    FOREIGN KEY (IdProduct) REFERENCES Product (IdProduct)
);

-- Dummy data for Customer table
INSERT INTO Customer (Name, Phone, Email, CreatedAt, UpdatedAt)
VALUES
    ('John Doe', '123456789', 'john@example.com', GETDATE(), GETDATE()),
    ('Jane Smith', '987654321', 'jane@example.com', GETDATE(), GETDATE()),
    ('Michael Johnson', '555555555', 'michael@example.com', GETDATE(), GETDATE()),
    ('Emily Brown', '111111111', 'emily@example.com', GETDATE(), GETDATE()),
    ('David Wilson', '999999999', 'david@example.com', GETDATE(), GETDATE()),
    ('Olivia Davis', '444444444', 'olivia@example.com', GETDATE(), GETDATE()),
    ('Sophia Martinez', '222222222', 'sophia@example.com', GETDATE(), GETDATE()),
    ('Emma Anderson', '777777777', 'emma@example.com', GETDATE(), GETDATE()),
    ('Daniel Taylor', '666666666', 'daniel@example.com', GETDATE(), GETDATE()),
    ('Noah Hernandez', '888888888', 'noah@example.com', GETDATE(), GETDATE());

-- Dummy data for Product table
INSERT INTO Product (Category, Name, Price, Stock, Image, CreatedAt, UpdatedAt)
VALUES
    ('Laptop', 'Dell XPS 15', 1500.00, 10, 'dell_xps_15.jpg', GETDATE(), GETDATE()),
    ('Laptop', 'HP Spectre x360', 1200.00, 8, 'hp_spectre_x360.jpg', GETDATE(), GETDATE()),
    ('Desktop', 'Apple iMac', 2000.00, 5, 'apple_imac.jpg', GETDATE(), GETDATE()),
    ('Desktop', 'Lenovo ThinkCentre', 800.00, 12, 'lenovo_thinkcentre.jpg', GETDATE(), GETDATE()),
    ('Monitor', 'Dell Ultrasharp U2419H', 300.00, 15, 'dell_ultrasharp_u2419h.jpg', GETDATE(), GETDATE()),
    ('Monitor', 'LG 27UK850-W', 400.00, 7, 'lg_27uk850w.jpg', GETDATE(), GETDATE()),
    ('Keyboard', 'Logitech G Pro Mechanical Keyboard', 100.00, 20, 'logitech_g_pro_keyboard.jpg', GETDATE(), GETDATE()),
    ('Keyboard', 'Razer BlackWidow Elite', 120.00, 18, 'razer_blackwidow_elite.jpg', GETDATE(), GETDATE()),
    ('Mouse', 'SteelSeries Rival 600', 80.00, 25, 'steelseries_rival_600.jpg', GETDATE(), GETDATE()),
    ('Mouse', 'Logitech MX Master 3', 90.00, 22, 'logitech_mx_master_3.jpg', GETDATE(), GETDATE());

-- Dummy data for Payment table
INSERT INTO Payment (Name, CreatedAt, UpdatedAt)
VALUES
    ('Credit Card', GETDATE(), GETDATE()),
    ('Cash', GETDATE(), GETDATE()),
    ('PayPal', GETDATE(), GETDATE()),
    ('Bank Transfer', GETDATE(), GETDATE()),
    ('Google Pay', GETDATE(), GETDATE()),
    ('Apple Pay', GETDATE(), GETDATE()),
    ('Venmo', GETDATE(), GETDATE()),
    ('Bitcoin', GETDATE(), GETDATE()),
    ('Samsung Pay', GETDATE(), GETDATE()),
    ('Alipay', GETDATE(), GETDATE());

-- Dummy data for Employee table
INSERT INTO Employee (Name, PhoneNumber, Email, Pass, CreatedAt, UpdatedAt)
VALUES
    ('Alex Johnson', '555444333', 'alex@example.com', 'password123', GETDATE(), GETDATE()),
    ('Sarah Thompson', '111222333', 'sarah@example.com', 'pass456', GETDATE(), GETDATE()),
    ('Christopher Lee', '999888777', 'chris@example.com', 'hellopass', GETDATE(), GETDATE()),
    ('Jessica Wilson', '444555666', 'jessica@example.com', 'mypassword', GETDATE(), GETDATE()),
    ('Matthew Davis', '888777666', 'matthew@example.com', 'securepass', GETDATE(), GETDATE()),
    ('Sophie Martinez', '777888999', 'sophie@example.com', 'abc123', GETDATE(), GETDATE()),
    ('Andrew Anderson', '222333444', 'andrew@example.com', 'qwerty123', GETDATE(), GETDATE()),
    ('Emily Taylor', '666777888', 'emily@example.com', 'pass321', GETDATE(), GETDATE()),
    ('Noah Johnson', '999000111', 'noah@example.com', 'mypassword123', GETDATE(), GETDATE()),
    ('Olivia Hernandez', '888999000', 'olivia@example.com', 'testpass', GETDATE(), GETDATE());

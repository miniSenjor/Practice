DROP DATABASE IF EXISTS Farm;
CREATE DATABASE Farm;
USE Farm;

-- Таблица "Продукты"
DROP TABLE IF EXISTS Products;
CREATE TABLE Products (
    product_id INT NOT NULL PRIMARY KEY IDENTITY,
	category VARCHAR(30) NOT NULL,
    name VARCHAR(30) UNIQUE NOT NULL,
	quantity INT NOT NULL,
	price INT NOT NULL
);

-- Таблица "Пользователи"
DROP TABLE IF EXISTS Users;
CREATE TABLE Users (
    user_id INT NOT NULL PRIMARY KEY IDENTITY,
    login VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(50) NOT NULL,
    role VARCHAR(255) NOT NULL
);

-- Таблица "Покупки"
DROP TABLE IF EXISTS Purchases;
CREATE TABLE Purchases (
    purchase_id INT NOT NULL PRIMARY KEY IDENTITY,
    user_id INT NOT NULL,
    product_id INT NOT NULL,
	quantity INT NOT NULL,
	price INT NOT NULL,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
	ON UPDATE CASCADE
	ON DELETE NO ACTION
);

INSERT INTO Products (category, name, quantity,price) VALUES
('молочная продукция', 'молоко', 100, 50),
('молочная продукция', 'сыр', 200, 60),
('яйца', 'яйцо куриное', 300, 30);

INSERT INTO Users (login, password, role) VALUES
('admin', 'admin', 'admin'),
('manager', 'manager', 'manager'),
('user', 'user', 'user');
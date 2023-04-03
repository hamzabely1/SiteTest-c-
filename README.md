uml
![uml free side](https://user-images.githubusercontent.com/96245936/229379748-e57c13ec-7d42-4a24-b14b-36172d374c8c.PNG)
use case
![use case  free side](https://user-images.githubusercontent.com/96245936/229379752-c4a2d873-5f7e-4146-b45f-7caf97c63df3.PNG)
sql


-- Active: 1679929419112@@127.0.0.1@3306@freeside

DROP TABLE users;

DROP TABLE items;

DROP TABLE addrees;

DROP TABLE orders;

CREATE DATABASE freeside
CREATE TABLE
    users(
        id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
        create_time DATETIME,
        firstName VARCHAR(255),
        lastName VARCHAR(200),
        dateBirth DATETIME,
        address INT,
        numero VARCHAR(200),
        email VARCHAR(200),
        password VARCHAR(2000)
    );

CREATE TABLE
    items(
        id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
        create_time DATETIME,
        name VARCHAR(255),
        price FLOAT,
        description VARCHAR(5000),
        image VARCHAR(5000),
        stock INT
    );

DROP TABLE address;

CREATE TABLE
    address(
        id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
        create_time DATETIME,
        street int,
        city VARCHAR(200),
        country VARCHAR(200),
        postalCode int
    );

CREATE TABLE
    order_item(
        id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
        idOrder int,
        idItem int
    );

CREATE TABLE
    orders(
        id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
        create_time DATETIME,
        idClient int,
        totalPrice int
    );

ALTER TABLE users
ADD
    CONSTRAINT FK_address FOREIGN KEY (address) REFERENCES Address(id);

ALTER TABLE orders
ADD
    CONSTRAINT FK_item FOREIGN KEY (idClient) REFERENCES users(id);

ALTER TABLE order_item
ADD
    CONSTRAINT FK_item FOREIGN KEY (idItem) REFERENCES item(id);

ALTER TABLE order_item
ADD
    CONSTRAINT FK_order FOREIGN KEY (idOrder) REFERENCES orders(id);

INSERT INTO
    address (
        `street`,
        `city`,
        `country`,
        `postalCode`
    )
VALUES (
        '2 rue claude farrere',
        'Staint-Priest',
        'Francais',
        69800
    ), (
        '2 rue claude fpaper',
        'Staint-Giorgio',
        'Francais',
        69500
    ), (
        '2 rue bali',
        'Staint-Bali',
        'Francais',
        69666
    );

INSERT INTO
    `users` (
        `firstName`,
        `lastName`,
        `dateBirth`,
        `address`,
        `numero`,
        `email`,
        `password`
    )
VALUES (
        'hamza',
        'bely',
        '16-04-1950',
        1,
        '0773967483',
        'hamzaciao80@gmail.com',
        'hamza123'
    );

INSERT INTO
    `items` (
        `name`,
        `price`,
        `description`,
        `image`,
        `stock`
    )
VALUES (
        'frigo',
        10,
        'description frigo',
        'image',
        1
    ), (
        'iphone',
        300,
        'description iphone',
        'image',
        1
    ), (
        'table',
        200,
        'description table,',
        'image',
        1
    ), (
        'maison',
        100,
        'description maison',
        'image',
        1
    ), (
        'pc',
        30,
        'description pc',
        'image',
        1
    )

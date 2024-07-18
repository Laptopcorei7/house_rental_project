CREATE TABLE users
(
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(MAX) NOT NULL,
    role VARCHAR(MAX) NOT NULL,
    status VARCHAR(50) NOT NULL,
    date_registered DATE NOT NULL
);



SELECT * FROM users
DROP TABLE users


CREATE TABLE addHouse
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    house_id VARCHAR(255) NOT NULL,
    house_name VARCHAR(255) NOT NULL,
    description TEXT,
    address VARCHAR(255) NOT NULL,
    number_of_bedrooms INT NOT NULL,
    number_of_bathrooms INT NOT NULL,
    rent_amount DECIMAL(10, 2) NOT NULL,
    deposit_amount DECIMAL(10, 2) NOT NULL,
    image_path VARCHAR(255) NOT NULL,
    date_available DATE NOT NULL,
    date_update DATE NULL,
    date_delete DATE NULL,
    status VARCHAR(255) NOT NULL,

)

SELECT * FROM addHouse
DROP TABLE addHouse

CREATE TABLE customers
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    book_id VARCHAR(255) NOT NULL,
    full_name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    contact VARCHAR(255) NOT NULL,
    gender VARCHAR(255) NOT NULL,
    house_id VARCHAR(255) NOT NULL,
    rent_amount DECIMAL NOT NULL,
    status_payment VARCHAR(255) NOT NULL,
    status VARCHAR(255) NOT NULL,
    date_start DATE NULL,
    date_end DATE NULL,
    date_book DATE NULL,
)

SELECT * FROM customers
DROP TABLE customers

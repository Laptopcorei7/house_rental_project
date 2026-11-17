-- Creates the database tables for a fresh install. Run once on an empty database.

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

-- The app hashes this plain-text password the first time anyone logs in (Passwords.HashPlainTextPasswords).
INSERT INTO users(name, email, password, role, status, date_registered) VALUES('admin', 'admin@example.com', 'admin12345', 'Admin', 'Active', '2024-07-23');

CREATE TABLE addHouse
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    house_id VARCHAR(255) NOT NULL CONSTRAINT UQ_addHouse_house_id UNIQUE,
    house_name VARCHAR(255) NOT NULL,
    description VARCHAR(MAX) NULL,
    address VARCHAR(255) NOT NULL,
    number_of_bedrooms INT NOT NULL,
    number_of_bathrooms INT NOT NULL,
    rent_amount DECIMAL(10, 2) NOT NULL,
    daily_rent DECIMAL(10, 2) NOT NULL DEFAULT 0,
    deposit_amount DECIMAL(10, 2) NOT NULL,
    -- File name only; the app looks for it in the house_directory folder next to the program.
    image_path VARCHAR(255) NOT NULL,
    date_available DATE NOT NULL,
    date_update DATE NULL,
    date_delete DATE NULL,
    status VARCHAR(255) NOT NULL
);

CREATE TABLE customers
(
    id INT PRIMARY KEY IDENTITY(1, 1),
    book_id VARCHAR(255) NOT NULL,
    full_name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    contact VARCHAR(255) NOT NULL,
    gender VARCHAR(255) NOT NULL,
    -- Changing a house's ID renames it in its bookings too.
    house_id VARCHAR(255) NOT NULL CONSTRAINT FK_customers_addHouse
        REFERENCES addHouse (house_id) ON UPDATE CASCADE,
    rent_amount DECIMAL(10, 2) NOT NULL,
    rent_plan VARCHAR(20) NOT NULL DEFAULT 'Monthly',
    status_payment VARCHAR(255) NOT NULL,
    status VARCHAR(255) NOT NULL,
    date_start DATE NULL,
    date_end DATE NULL,
    date_book DATE NULL
);

CREATE TABLE users
(
    id INT PRIMARY KEY IDENTITY(1,1),
    email VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(MAX) NOT NULL,
    role VARCHAR(MAX) NOT NULL,
    status VARCHAR(50) NOT NULL,
    date_registered DATE NOT NULL
);



SELECT * FROM users
DROP TABLE users

INSERT INTO users(email, password, role, status, date_registered) VALUES('test@example.com', 'pass123', 'Admin', 'Active', '2024-06-09')  

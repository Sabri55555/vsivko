CREATE DATABASE minion;
USE minion;

CREATE TABLE if not exists people
(
id INT (50),
name_ VARCHAR (100),
picture BLOB,
height NUMERIC (10, 5),
weight NUMERIC (10 ,5),
gender VARCHAR (200),
birthdate DATE NOT NULL,
biography LONGTEXT
);

CREATE TABLE if not exists User
(
id INT (50),
username_ VARCHAR (100),
password_ INT (50),
profile_picture BLOB,
last_login_time INT,
is_deleted INT
);

INSERT INTO people (id, name_, gender)
VALUES ('10', 'Anton', 'men');

CREATE database if not exists movies;
USE movies;

CREATE TABLE if not exists directors
(
id INT,
director_name VARCHAR (100),
notes longtext
);

CREATE TABLE if not exists genres
(
id INT,
director_name VARCHAR (100),
notes longtext
);

CREATE TABLE if not exists catagories
(
id INT,
director_name VARCHAR (100),
notes longtext
);

CREATE TABLE if not exists movies
(
id INT,
director_id INT,
copyright_year INT,
lenght INT,
genre_id INT,
category_id INT,
rating INT,
notes longtext
);

CREATE DATABASE if not exists soft_uni;
USE soft_uni;

CREATE TABLE if not exists towns
(
id INT (10),
name_ CHAR (30),
);
CREATE TABLE if not exists addresses
(
town_id INT (10),
id INT (10),
address_text longtext
);
CREATE TABLE if not exists departments
(
id INT (10),
name_ CHAR (10)
);
CREATE TABLE if not exists employees
(
id INT (10),
first_name CHAR (30),
middle_name CHAR (30),
last_name CHAR (30),
job_tittle CHAR (30),
department_id INT (10),
hire_dade INT,
salary INT,
address_id INT (10),
);
id INT (10),
first_name CHAR (30),
);

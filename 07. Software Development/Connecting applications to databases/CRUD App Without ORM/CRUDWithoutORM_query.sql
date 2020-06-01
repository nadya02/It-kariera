create database shop;
GO
use shop;
GO
create table product
(
	id int identity primary key,
	Name varchar(100) not null,
	Price decimal(10, 2),
	Stock int
)

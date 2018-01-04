create database QLCOFFEE
go

use QLCOFFEE
go


-- Table
create table TableFood
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null default N'Trống'
)
go

-- Account 
create table Account
(
	UserName nvarchar(100)  primary key,
	DisplayName nvarchar(100) not null,
	PassWord nvarchar(100)  not null default 123456,
	Type int  not null default 0 -- 1: Admin ; 0: Staff
)
go

-- FoodCategory
create table FoodCategory
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên'
)
go

-- Food
create table Food
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',
	IdCategory int not null,
	Price float not null default 0
	foreign key (IdCategory) references FoodCategory(ID)
)
go

-- Bill
create table Bill
(
	ID int identity primary key,
	DateCheckIn date not null default getdate(),
	DateCheckOut date not null,
	IdTable int not null,
	status int not null default 0 -- 0: Chua thanh toan; 1: Da thanh toan
	foreign key (IdTable) references TableFood(ID)
)
go
-- BillInfo
create table BillInfo
(
	ID int identity primary key,
	IdBill int not null,
	IdFood int not null,
	NumberFood int not null default 0
	foreign key (IdBill) references Bill(ID),
	foreign key (IdFood) references Food(ID)
)
go

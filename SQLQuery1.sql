create database libraryy
use libraryy
create table signupp
 (
 staff_id int primary key identity(1,1),
 staffName varchar(50) not null,
 staffPhone bigint not null,
 staffEmail nvarchar(50) not null,
 staffPass nvarchar(50) not null
 )

 select * from signupp

 create table addbook
 (
 book_id int primary key identity(1,1),
 bookName varchar(50) not null,
 bookAuthor varchar(50) not null,
 bookPurh varchar(50) not null,
 bookPrice int not null,
  bookQan int not null
 )
  select * from addbook
  
  create table stdsignup
  (
  std_id int primary key identity(200,1),
 stdName varchar(50) not null,
 stdPhone bigint not null,
 depart varchar(50) not null,
 stdEmail nvarchar(50) not null,
 stdPass nvarchar(50) not null
 )
 select * from stdsignup

 create table IRbook
 (
 idd int not null identity(1,1) primary key,
 std_id int not null,
 stddName varchar(50)not null,
 stddPhone bigint not null,
 ddepart varchar(50) not null,
 stddEmail nvarchar(50) not null,
 Bookkname varchar(50) not null,
 bookIssueDate varchar(50) not null,
 bookReturnDate varchar(50)
 )

 select * from IRbook


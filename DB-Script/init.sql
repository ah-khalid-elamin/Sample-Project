use master
GO

ALTER DATABASE "sample-db" 
SET SINGLE_USER 
WITH ROLLBACK IMMEDIATE;
GO

DROP DATABASE  IF Exists "sample-db"
GO

create database "sample-db"
GO

use "sample-db"
GO

create table persons (
id int identity(1,1),
name nvarchar(100),
age int)

insert into persons values (N'Ahmed', 23);
insert into persons values (N'Ali', 34);
insert into persons values (N'Ala', 32);
insert into persons values (N'Aladeen', 55);
GO
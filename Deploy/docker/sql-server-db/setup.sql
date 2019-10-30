
CREATE DATABASE database_resume
go
USE database_resume
go
CREATE TABLE AboutMe(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Name nvarchar(50) NOT NULL, Job nvarchar(50) NOT NULL, Nationality nvarchar(50) NOT NULL, Introduce nvarchar(max) NOT NULL)
CREATE TABLE Career(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Company nvarchar(50) NOT NULL, Experience nvarchar(50) NOT NULL, Period nvarchar(50) NOT NULL, Position nvarchar(50) NOT NULL)
CREATE TABLE Education(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Insititute nvarchar(50) NOT NULL, Type nvarchar(50) NOT NULL, Period nvarchar(50) NOT NULL, Description nvarchar(max) NOT NULL)
CREATE TABLE Project(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Title nvarchar(50) NOT NULL, Description nvarchar(max) NOT NULL, DemoUrl nvarchar(500) NOT NULL, Github nvarchar(500) NOT NULL)
CREATE TABLE Skill(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Name nvarchar(50) NOT NULL, ImageUrl nvarchar(500) NOT NULL, Proficiency int NOT NULL, SerializedHashTag nvarchar(max) NOT NULL)
go

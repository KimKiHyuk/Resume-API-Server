
CREATE DATABASE database_resume
go
USE database_resume
go
CREATE TABLE AboutMe(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Json nvarchar(max) NOT NULL, HashCode int NOT NULL)
CREATE TABLE Career(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Json nvarchar(max) NOT NULL, HashCode int NOT NULL)
CREATE TABLE Education(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Json nvarchar(max) NOT NULL, HashCode int NOT NULL)
CREATE TABLE Project(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Json nvarchar(max) NOT NULL, HashCode int NOT NULL)
CREATE TABLE Skill(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Json nvarchar(max) NOT NULL, HashCode int NOT NULL)
go


CREATE DATABASE database_resume
go
USE database_resume
go
CREATE TABLE AboutMe(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, Name nvarchar(20) NOT NULL, Job nvarchar(20) NOT NULL, Nationality nvarchar(20) NOT NULL, Introduce nvarchar(max) NOT NULL, HashCode Int NOT NULL)
go
INSERT INTO AboutMe VALUES("Name1", "Job1", "Nation1", "Intro1", 50);
go

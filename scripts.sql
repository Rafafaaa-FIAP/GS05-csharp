CREATE DATABASE FutureWorkDB;
GO

USE FutureWorkDB;
GO

CREATE TABLE Careers (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX),
    SkillLevel INT,
    Category NVARCHAR(100)
);

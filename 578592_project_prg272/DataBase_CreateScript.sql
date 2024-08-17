USE [master]
GO

CREATE DATABASE [student_manager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'student_manager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\student_manager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'student_manager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\student_manager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

USE [student_manager]
GO

CREATE TABLE [dbo].[module](
	[code] [int] NULL,
	[name] [varchar](50) NULL,
	[description] [varchar](max) NULL,
	[links] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[moduleLinks](
	[linkId] [int] NULL,
	[moduleId] [int] NULL,
	[studentNumber] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[student](
	[number] [int] NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[gender] [varchar](50) NULL,
	[address] [varchar](max) NULL,
	[image] [varbinary](max) NULL,
	[DOB] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO





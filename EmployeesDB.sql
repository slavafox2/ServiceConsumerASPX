USE [EmployeesDB]
GO

/****** Object: Table [dbo].[Employees] Script Date: 02.08.2017 10:10:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees] (
    [Emp_id]     INT           IDENTITY (1, 1) NOT NULL,
    [Job_id]     INT           NULL,
    [First_name] NVARCHAR (50) NULL,
    [Last_name]  NVARCHAR (50) NULL,
    [Salary]     FLOAT (53)    NULL
);

SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (1, 100, N'Ivan', N'Ivanov', 1000)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (2, 100, N'Lindsay', N' Malachi ', 900)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (3, 100, N'Amee', N'Gochenour ', 800)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (4, 100, N'Kellie', N'Keister', 700)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (5, 100, N'Annabel', N'Dimeo', 600)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (6, 100, N'Orlando', N'Claywell ', 500)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (7, 101, N'Devorah', N'Heidecker ', 400)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (1002, 100, N'Aurore', N'Stanberry ', 300)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (1003, 100, N'Angele ', N'Wiren', 200)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (1004, 100, N'Julietta', N'Sigler', 500)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (2002, 102, N'Juliy', N'Tonna', 450)
INSERT INTO [dbo].[Employees] ([Emp_id], [Job_id], [First_name], [Last_name], [Salary]) VALUES (2003, 101, N'Grag', N'Maccone', 750)
SET IDENTITY_INSERT [dbo].[Employees] OFF



USE [EmployeesDB]
GO

/****** Object: Table [dbo].[Jobs] Script Date: 02.08.2017 10:11:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Jobs] (
    [Job_id] INT           IDENTITY (100, 1) NOT NULL,
    [Job_nm] NVARCHAR (50) NULL
);

SET IDENTITY_INSERT [dbo].[Jobs] ON
INSERT INTO [dbo].[Jobs] ([Job_id], [Job_nm]) VALUES (100, N'Actor')
INSERT INTO [dbo].[Jobs] ([Job_id], [Job_nm]) VALUES (101, N'Lawyer')
INSERT INTO [dbo].[Jobs] ([Job_id], [Job_nm]) VALUES (102, N'Consultant')
SET IDENTITY_INSERT [dbo].[Jobs] OFF

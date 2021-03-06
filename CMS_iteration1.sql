USE [master]
GO
/****** Object:  Database [CMS]    Script Date: 04/10/2018 22:44:55 ******/
CREATE DATABASE [CMS] ON  PRIMARY 
( NAME = N'CMS', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\CMS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CMS_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\CMS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CMS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CMS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CMS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CMS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CMS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CMS] SET ARITHABORT OFF
GO
ALTER DATABASE [CMS] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [CMS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CMS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CMS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CMS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CMS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CMS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CMS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CMS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CMS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CMS] SET  DISABLE_BROKER
GO
ALTER DATABASE [CMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CMS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CMS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CMS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CMS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CMS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [CMS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CMS] SET  READ_WRITE
GO
ALTER DATABASE [CMS] SET RECOVERY SIMPLE
GO
ALTER DATABASE [CMS] SET  MULTI_USER
GO
ALTER DATABASE [CMS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CMS] SET DB_CHAINING OFF
GO
USE [CMS]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 04/10/2018 22:44:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[PatientName] [varchar](60) NOT NULL,
	[PatientPhone] [char](12) NOT NULL,
	[PatientAddress] [varchar](60) NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job]    Script Date: 04/10/2018 22:44:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job](
	[JobID] [int] NOT NULL,
	[JobName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Session]    Script Date: 04/10/2018 22:44:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Session](
	[SessionID] [int] IDENTITY(1,1) NOT NULL,
	[SessionName] [varchar](50) NOT NULL,
	[SessionPrice] [int] NOT NULL,
	[DoctorSalary] [int] NOT NULL,
	[NurseSalary] [int] NOT NULL,
 CONSTRAINT [PK_Session] PRIMARY KEY CLUSTERED 
(
	[SessionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Session] UNIQUE NONCLUSTERED 
(
	[SessionName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 04/10/2018 22:44:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stock](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC,
	[ItemName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddUser] 
	-- Add the parameters for the stored procedure here
	@UserName varchar(60),
@Password char(1),
@Privilege int

AS 
BEGIN
insert into UserPassword (UserName,Password,privilege) values(@UserName, @Password, @Privilege)
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSession]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[UpdateSession] @SessionID int,
                              @SessionName varchar(50),
							  @SessionPrice int,
							  @DoctorSalary int,
							  @NurseSalary int
AS
BEGIN
UPDATE Session  SET SessionName = @SessionName,
					  
 @SessionPrice= @SessionPrice ,
DoctorSalary = @DoctorSalary ,
NurseSalary = @NurseSalary
WHERE SessionID = @SessionID
END
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[StaffName] [varchar](50) NOT NULL,
	[StaffJob] [int] NOT NULL,
	[StaffPhone] [char](12) NOT NULL,
	[StaffSalary] [int] NOT NULL,
	[StaffUserName] [varchar](50) NOT NULL,
	[StaffPassword] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Staff] UNIQUE NONCLUSTERED 
(
	[StaffUserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[GetAllSessions]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllSessions]
as
begin
select * from Session
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllJobs]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllJobs]

AS
BEGIN
select JobID,JobName 
FROM Job
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteStock]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteStock]
	@ItemName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Stock where ItemName=@ItemName
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllStock]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[GetAllStock]
	-- Add the parameters for the stored procedure here
	

AS
BEGIN
select *
FROM Stock
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStock]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[UpdateStock]
	 
@ItemName varchar(50),
@ItemID int,
@ItemPrice  int,
@ItemQuantity int

AS
BEGIN
UPDATE Stock
SET ItemName=@ItemName,Price=@ItemPrice,Quantity=@ItemQuantity
WHERE @ItemID=ItemID
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteSessions]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteSessions] @SessionName varchar(50)
	-- Add the parameters for the stored procedure here
	

AS
BEGIN
	DELETE FROM Session WHERE SessionName = @SessionName
END
GO
/****** Object:  StoredProcedure [dbo].[AddSession]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddSession] @SessionName varchar(50),
							@SessionPrice int,
							@DoctorSalary int,
							@NurseSalary int
AS
BEGIN
INSERT INTO Session
(                           SessionName ,
							SessionPrice ,
							DoctorSalary ,
							NurseSalary 
)
VALUES
(                           @SessionName ,
							@SessionPrice ,
							@DoctorSalary ,
							@NurseSalary 
)
END
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Appointment](
	[AppID] [int] IDENTITY(1,1) NOT NULL,
	[AppDate] [date] NOT NULL,
	[AppTime] [time](7) NOT NULL,
	[AppRoom] [int] NOT NULL,
	[Patient_ID] [int] NOT NULL,
	[SessionID] [int] NOT NULL,
	[Status] [char](1) NOT NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[AppDate] ASC,
	[AppTime] ASC,
	[AppRoom] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Appointment] UNIQUE NONCLUSTERED 
(
	[AppID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[AddStockItem]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddStockItem]
@ItemName varchar(50),
@ItemPrice  int,
@ItemQuantity int
AS
BEGIN
insert into Stock (ItemName,Price,Quantity) values (@ItemName,@ItemPrice,@ItemQuantity);
END
GO
/****** Object:  StoredProcedure [dbo].[GetStockName]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetStockName] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ItemName From Stock 
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetSessionName]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetSessionName]
as
begin
Select SessionName from Session
end
GO
/****** Object:  StoredProcedure [dbo].[SelectID]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create procedure [dbo].[SelectID]
as
begin
select StaffID
from Staff
end
GO
/****** Object:  Table [dbo].[PatientStatus]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientStatus](
	[PatientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[Case] [varchar](1000) NOT NULL,
	[Date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[getUsername]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getUsername]
@ID int
as
begin
select StaffUsername
from Staff
where StaffID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[GetUser]
@StaffName varchar(60),
@StaffPassword varchar(50)
AS 
BEGIN
SELECT StaffJob
FROM Staff
WHERE StaffName = @StaffName and StaffPassword = @StaffPassword
END
GO
/****** Object:  StoredProcedure [dbo].[getSalary]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create procedure [dbo].[getSalary]
@ID int
as
begin
select StaffSalary
from Staff
where StaffID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[getPhone]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create procedure [dbo].[getPhone]
@ID int
as
begin
select StaffPhone
from Staff
where StaffID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[getPass]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getPass]

@StaffID int

AS
begin
select StaffPassword
FROM Staff

where StaffID= @StaffID
END
GO
/****** Object:  StoredProcedure [dbo].[getName]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create procedure [dbo].[getName]
@ID int
as 
begin
select StaffName
from Staff
where StaffID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[GetJobFromStaffID]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJobFromStaffID] 
	-- Add the parameters for the stored procedure here
	@StaffID int
	
	as 
	begin
	select JobName from Job, Staff
	where @StaffID=StaffID and JobID=StaffJob
	end
GO
/****** Object:  StoredProcedure [dbo].[getJob]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create procedure [dbo].[getJob]
@ID int
as
begin
select StaffJob
from Staff
where StaffID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[GetID]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE procedure [dbo].[GetID]
@StaffUserName varchar (50)
As 
Begin
select StaffID From Staff where StaffUserName=@StaffUserName
End
GO
/****** Object:  StoredProcedure [dbo].[AddStaff]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddStaff] 
	-- Add the parameters for the stored procedure here

@StaffName varchar(50),
@StaffJob int ,
@StaffPhone varchar(50),
@StaffSalary int,
@StaffUserName varchar(50),
@StaffPassword varchar(50)



AS 
BEGIN
insert into Staff (StaffName,StaffJob,StaffPhone,StaffSalary,StaffUserName, StaffPassword) values(@StaffName,@StaffJob,@StaffPhone,@StaffSalary,@StaffUserName,@StaffPassword)
END
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[ChangePassword]


@StaffID int,
@StaffPassword varchar(50)
AS 
BEGIN
Update  Staff
Set StaffPassword = @StaffPassword
WHERE StaffID=@StaffID 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStaff]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateStaff]

@StaffID int,
@StaffName varchar(50),
@StaffJob int ,
@StaffPhone varchar(50),
@StaffSalary int,
@StaffUserName varchar(50)


AS
BEGIN
UPDATE Staff
SET StaffName=@StaffName,StaffJob=@StaffJob,StaffPhone=@StaffPhone, StaffUserName=@StaffUserName, StaffSalary=@StaffSalary
WHERE StaffID=@StaffID
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllStaff]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllStaff]
	--
AS
BEGIN
	Select * from Staff
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteStaff]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create Procedure [dbo].[DeleteStaff]
@StaffID int
AS
BEGIN
Delete From Staff
Where StaffID=@StaffID
END
GO
/****** Object:  Table [dbo].[StaffAppointment]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StaffAppointment](
	[StaffID] [int] NOT NULL,
	[AppID] [int] NOT NULL,
	[Attendance] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC,
	[AppID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[ShowSchedule]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ShowSchedule]
as 
begin
select Appdate,Apptime,StaffName
from Appointment,Staff ,StaffAppointment
where staff.StaffID=StaffAppointment.StaffID
end
GO
/****** Object:  StoredProcedure [dbo].[CountAbsence]    Script Date: 04/10/2018 22:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CountAbsence] 
AS
BEGIN
SELECT  COUNT(*) 
FROM StaffAppointment
where Attendance='f'
END
GO
/****** Object:  ForeignKey [FK_Staff_Job]    Script Date: 04/10/2018 22:45:03 ******/
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Job] FOREIGN KEY([StaffJob])
REFERENCES [dbo].[Job] ([JobID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Job]
GO
/****** Object:  ForeignKey [FK_Appointment_Patient]    Script Date: 04/10/2018 22:45:03 ******/
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([Patient_ID])
REFERENCES [dbo].[Patient] ([PatientID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
/****** Object:  ForeignKey [FK_Appointment_Session]    Script Date: 04/10/2018 22:45:03 ******/
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Session] FOREIGN KEY([SessionID])
REFERENCES [dbo].[Session] ([SessionID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Session]
GO
/****** Object:  ForeignKey [FK_PatientStatus_Patient]    Script Date: 04/10/2018 22:45:03 ******/
ALTER TABLE [dbo].[PatientStatus]  WITH CHECK ADD  CONSTRAINT [FK_PatientStatus_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([PatientID])
GO
ALTER TABLE [dbo].[PatientStatus] CHECK CONSTRAINT [FK_PatientStatus_Patient]
GO
/****** Object:  ForeignKey [FK_PatientStatus_Staff]    Script Date: 04/10/2018 22:45:03 ******/
ALTER TABLE [dbo].[PatientStatus]  WITH CHECK ADD  CONSTRAINT [FK_PatientStatus_Staff] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[PatientStatus] CHECK CONSTRAINT [FK_PatientStatus_Staff]
GO
/****** Object:  ForeignKey [FK_StaffAppointment_Appointment]    Script Date: 04/10/2018 22:45:03 ******/
ALTER TABLE [dbo].[StaffAppointment]  WITH CHECK ADD  CONSTRAINT [FK_StaffAppointment_Appointment] FOREIGN KEY([AppID])
REFERENCES [dbo].[Appointment] ([AppID])
GO
ALTER TABLE [dbo].[StaffAppointment] CHECK CONSTRAINT [FK_StaffAppointment_Appointment]
GO
/****** Object:  ForeignKey [FK_StaffAppointment_Staff]    Script Date: 04/10/2018 22:45:03 ******/
ALTER TABLE [dbo].[StaffAppointment]  WITH CHECK ADD  CONSTRAINT [FK_StaffAppointment_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[StaffAppointment] CHECK CONSTRAINT [FK_StaffAppointment_Staff]
GO

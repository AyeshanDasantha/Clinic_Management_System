USE [master]
GO
/****** Object:  Database [CMS]    Script Date: 11/17/2017 16:20:43 ******/
CREATE DATABASE [CMS] ON  PRIMARY 
( NAME = N'CMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CMS.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CMS_1.LDF' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [CMS] SET RECOVERY FULL
GO
ALTER DATABASE [CMS] SET  MULTI_USER
GO
ALTER DATABASE [CMS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CMS] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'CMS', N'ON'
GO
USE [CMS]
GO
/****** Object:  Table [dbo].[Patient_Reg]    Script Date: 11/17/2017 16:20:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient_Reg](
	[PatientID] [varchar](50) NOT NULL,
	[Saluation] [varchar](50) NULL,
	[FirstName] [varchar](100) NULL,
	[MiddleName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[NIC] [varchar](15) NULL,
	[DOB] [varchar](50) NULL,
	[Age] [varchar](50) NULL,
	[Gender] [varchar](20) NULL,
	[MarriedStatus] [varchar](20) NULL,
	[Address] [varchar](max) NULL,
	[CHome] [int] NULL,
	[CMobile] [int] NULL,
	[Regdatetime] [varchar](50) NULL,
	[Weight] [float] NULL,
	[Height] [float] NULL,
	[BMI] [varchar](10) NULL,
	[Blood_Group] [varchar](20) NULL,
	[Disease] [varchar](100) NULL,
	[Discription] [varchar](max) NULL,
 CONSTRAINT [pk_Patient_Reg] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login]    Script Date: 11/17/2017 16:20:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[id] [int] NOT NULL,
	[Username] [varchar](max) NULL,
	[password] [varchar](max) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Report_MarriedStatus]    Script Date: 11/17/2017 16:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Report_MarriedStatus]
as
	begin
		SELECT COUNT (PatientID) As 'Total'
			,MarriedStatus As 'MarriedStatus'
		FROM [dbo].[Patient_Reg]
		Group by MarriedStatus
	end
GO
/****** Object:  StoredProcedure [dbo].[Report_ColumChart_SpaceAge]    Script Date: 11/17/2017 16:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Report_ColumChart_SpaceAge]
as
	begin
		select 
		cast( 1 + DateDiff(YY,DATEADD(YY,-1,DOB),getdate())/10 *10 as varchar)+ '-'+ cast(10+ DateDiff(YY,DATEADD(YY,-1,DOB),getdate())/10 *10 as varchar) as AgeRange
		,
		count(1) as count
		from Patient_Reg
		group by 
		DateDiff(YY,DATEADD(YY,-1,DOB),getdate())/10
    end
GO
/****** Object:  StoredProcedure [dbo].[Report_Chart_Age2]    Script Date: 11/17/2017 16:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Report_Chart_Age2]
as
	begin
SELECT CAST(DATEDIFF(dy, DOB, GETDATE()+1)/366 AS int)As 'Age' , COUNT (PatientID) As 'Total' FROM [dbo].[Patient_Reg]
Group by DOB
	end
GO
/****** Object:  StoredProcedure [dbo].[Report_Chart_Age]    Script Date: 11/17/2017 16:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Report_Chart_Age]
as
	begin
	
SELECT COUNT (PatientID) As 'Total'
			,Age As 'Age'
		FROM [dbo].[Patient_Reg]
		Group by Age
	end
GO
/****** Object:  StoredProcedure [dbo].[Report_Chart]    Script Date: 11/17/2017 16:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Report_Chart]
as
	begin
		SELECT COUNT (PatientID) As 'Total'
			,Gender As 'Gender'
		FROM [dbo].[Patient_Reg]
		Group by Gender
	end
GO
/****** Object:  StoredProcedure [dbo].[GetReport]    Script Date: 11/17/2017 16:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetReport]
(
	@FromDate datetime,
	@ToDate datetime
)
as
	select PatientID,FirstName,MiddleName,LastName,NIC,DOB,Age,Gender,MarriedStatus,Address,CHome,CMobile from Patient_Reg
	where Regdatetime between @FromDate and @ToDate
	order by Regdatetime asc
GO
/****** Object:  StoredProcedure [dbo].[Disease_ChartReport]    Script Date: 11/17/2017 16:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Disease_ChartReport]
as
	begin
		SELECT COUNT (PatientID) As 'Total'
			,Disease As 'Disease'
		FROM [dbo].[Patient_Reg]
		Group by Disease
	end
GO
/****** Object:  StoredProcedure [dbo].[Blood_Group_ChartReport]    Script Date: 11/17/2017 16:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Blood_Group_ChartReport]
as
	begin
		SELECT COUNT (PatientID) As 'Total'
			,Blood_Group As 'Disease'
		FROM [dbo].[Patient_Reg]
		Group by Blood_Group
	end
GO
/****** Object:  StoredProcedure [dbo].[New_Blood_Group_ChartReport]    Script Date: 11/17/2017 16:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[New_Blood_Group_ChartReport]
as
	begin
		SELECT COUNT (PatientID) As 'Total'
			,Blood_Group As 'Blood_Group'
		FROM [dbo].[Patient_Reg]
		Group by Blood_Group
	end
GO

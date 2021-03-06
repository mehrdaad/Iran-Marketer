USE [IranMarketer]
GO
/****** Object:  Table [dbo].[AcademicField]    Script Date: 9/25/2017 12:11:34 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcademicField](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleEn] [nvarchar](1000) NULL,
	[TitleFa] [nvarchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Industry]    Script Date: 9/25/2017 12:11:34 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Industry](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleFa] [nvarchar](max) NULL,
	[TitleEn] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobCategory]    Script Date: 9/25/2017 12:11:34 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitlefFa] [nvarchar](1000) NULL,
	[TitlefEn] [nvarchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobPrefer]    Script Date: 9/25/2017 12:11:34 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobPrefer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobCategory] [nvarchar](max) NULL,
	[Industry] [nvarchar](max) NULL,
	[ExpectedSalary] [int] NULL,
	[BusinessTrips] [int] NULL,
	[Relocate] [int] NULL,
	[PartyId] [int] NOT NULL,
	[LastModificationDate] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartyUniversity]    Script Date: 9/25/2017 12:11:34 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartyUniversity](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DegreeLevel] [int] NULL,
	[AcademicField] [int] NOT NULL,
	[University] [nvarchar](300) NULL,
	[CountryId] [int] NULL,
	[CityId] [int] NULL,
	[FromDate] [int] NULL,
	[ToDate] [int] NULL,
	[Average] [decimal](2, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Region]    Script Date: 9/25/2017 12:11:34 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Region](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[EnTitle] [nvarchar](250) NULL,
	[CodeId] [nvarchar](20) NULL,
	[RegionType] [int] NULL,
	[ZipCode] [nvarchar](20) NULL,
	[ValidFrom] [date] NULL,
	[ValidUntil] [date] NULL,
	[Created] [datetime] NULL,
	[Modified] [datetime] NULL,
 CONSTRAINT [PK_Region] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RetailParty]    Script Date: 9/25/2017 12:11:34 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RetailParty](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[EnName] [nvarchar](100) NULL,
	[FirstName] [nvarchar](100) NULL,
	[EnFirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[EnLastName] [nvarchar](100) NULL,
	[FatherName] [nvarchar](100) NULL,
	[EnFatherName] [nvarchar](100) NULL,
	[NationalId] [nvarchar](50) NULL,
	[NationalityPlaceId] [int] NULL,
	[CityId] [int] NULL,
	[FullName] [nvarchar](220) NULL,
	[Address] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[MobileNumber] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
	[BirthPlace] [nvarchar](100) NULL,
	[Gender] [int] NULL,
	[MilitaryServiceStatus] [int] NULL,
	[MaritalStatus] [int] NULL,
	[UserId] [nvarchar](128) NULL,
	[UserName] [nvarchar](100) NULL,
	[ValidFrom] [date] NULL,
	[ValidUntil] [date] NULL,
	[Modified] [datetime] NULL,
	[Created] [datetime] NULL,
	[ModifiedBy] [nvarchar](128) NULL,
	[CreatedBy] [nvarchar](128) NULL,
 CONSTRAINT [PK_Party] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkExperience]    Script Date: 9/25/2017 12:11:34 ق.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkExperience](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PartyId] [int] NOT NULL,
	[JobTitle] [nvarchar](500) NULL,
	[JobCategory] [int] NULL,
	[CompanyName] [nvarchar](500) NULL,
	[IndustryId] [int] NULL,
	[CountryId] [int] NULL,
	[CityId] [int] NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[Achievements] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

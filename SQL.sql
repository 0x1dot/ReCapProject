USE [ReCapProject]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[BrandId] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarImages]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarImages](
	[CarImageId] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[ImagePath] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_CarImages] PRIMARY KEY CLUSTERED 
(
	[CarImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BrandId] [int] NOT NULL,
	[ColorId] [int] NOT NULL,
	[FuelId] [int] NOT NULL,
	[GearId] [int] NOT NULL,
	[CarName] [nvarchar](200) NOT NULL,
	[ModelYear] [nvarchar](50) NOT NULL,
	[DailyPrice] [int] NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[ColorId] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCard]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCard](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CardTypeId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[CardNumber] [nvarchar](17) NOT NULL,
	[ExpirationMonth] [int] NOT NULL,
	[ExpirationYear] [int] NOT NULL,
	[Cvv] [int] NOT NULL,
 CONSTRAINT [PK_CreditCard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCardType]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCardType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CreditCardType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[CompanyName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fuels]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fuels](
	[FuelId] [int] IDENTITY(1,1) NOT NULL,
	[FuelName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Fuels] PRIMARY KEY CLUSTERED 
(
	[FuelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gears]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gears](
	[GearId] [int] IDENTITY(1,1) NOT NULL,
	[GearName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Gears] PRIMARY KEY CLUSTERED 
(
	[GearId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationClaims]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NULL,
 CONSTRAINT [PK_OperationClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CarId] [int] NOT NULL,
	[TotalPrice] [money] NOT NULL,
	[CardTypeId] [int] NOT NULL,
	[CardId] [int] NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rentals]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentals](
	[RentalId] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[RentDate] [date] NOT NULL,
	[ReturnDate] [date] NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[RentalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOperationClaims]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOperationClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[OperationClaimId] [int] NOT NULL,
 CONSTRAINT [PK_UserOperationClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2021-04-23 11:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PasswordHash] [varbinary](500) NOT NULL,
	[PasswordSalt] [varbinary](500) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CarImages]  WITH CHECK ADD  CONSTRAINT [FK_CarImages_Cars] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
GO
ALTER TABLE [dbo].[CarImages] CHECK CONSTRAINT [FK_CarImages_Cars]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Users]
GO

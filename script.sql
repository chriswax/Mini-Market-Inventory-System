USE [master]
GO
/****** Object:  Database [MiniMartInventory]    Script Date: 21/08/2023 10:24:30 AM ******/
CREATE DATABASE [MiniMartInventory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MiniMartInventory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MiniMartInventory.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MiniMartInventory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MiniMartInventory_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MiniMartInventory] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiniMartInventory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MiniMartInventory] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MiniMartInventory] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MiniMartInventory] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MiniMartInventory] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MiniMartInventory] SET ARITHABORT OFF 
GO
ALTER DATABASE [MiniMartInventory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MiniMartInventory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MiniMartInventory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MiniMartInventory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MiniMartInventory] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MiniMartInventory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MiniMartInventory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MiniMartInventory] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MiniMartInventory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MiniMartInventory] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MiniMartInventory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MiniMartInventory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MiniMartInventory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MiniMartInventory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MiniMartInventory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MiniMartInventory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MiniMartInventory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MiniMartInventory] SET RECOVERY FULL 
GO
ALTER DATABASE [MiniMartInventory] SET  MULTI_USER 
GO
ALTER DATABASE [MiniMartInventory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MiniMartInventory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MiniMartInventory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MiniMartInventory] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MiniMartInventory] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MiniMartInventory', N'ON'
GO
USE [MiniMartInventory]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bill]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillID] [int] NOT NULL,
	[SellerID] [nvarchar](50) NULL,
	[SellerDate] [nvarchar](50) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CatID] [int] IDENTITY(1,1) NOT NULL,
	[CatName] [nvarchar](50) NULL,
	[CatDesc] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProID] [int] IDENTITY(1,1) NOT NULL,
	[ProName] [nvarchar](50) NULL,
	[ProCatID] [int] NULL,
	[ProPrice] [decimal](10, 2) NULL,
	[ProQty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sales]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SellerID] [int] IDENTITY(1,1) NOT NULL,
	[SellerName] [nvarchar](50) NULL,
	[SellerAge] [nvarchar](20) NULL,
	[SellerPhone] [nvarchar](50) NULL,
	[SellerPassword] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[SellerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Admin] ([Username], [Password], [FullName]) VALUES (N'chriswax', N'police', N'Uzoigwe Chris')
INSERT [dbo].[Admin] ([Username], [Password], [FullName]) VALUES (N'kamsi', N'Uzoigwe Kamsi', N'kamsi')
INSERT [dbo].[Admin] ([Username], [Password], [FullName]) VALUES (N'temple', N'thanks', N'temple Chiononso')
INSERT [dbo].[Bill] ([BillID], [SellerID], [SellerDate], [TotalAmount]) VALUES (12, N'chriswax', N'18/08/2023', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[Bill] ([BillID], [SellerID], [SellerDate], [TotalAmount]) VALUES (90899, N'chriswax', N'18/08/2023', CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[Bill] ([BillID], [SellerID], [SellerDate], [TotalAmount]) VALUES (202466887, N'chriswax', N'19/08/2023', CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[Bill] ([BillID], [SellerID], [SellerDate], [TotalAmount]) VALUES (1385189256, N'chriswax', N'19/08/2023', CAST(2.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CatID], [CatName], [CatDesc]) VALUES (1, N'Coffee', N'Best Coffe in Nigeria')
INSERT [dbo].[Category] ([CatID], [CatName], [CatDesc]) VALUES (2, N'Juice', N'Good Juice')
INSERT [dbo].[Category] ([CatID], [CatName], [CatDesc]) VALUES (3, N'Bread e', N'Bread tread')
INSERT [dbo].[Category] ([CatID], [CatName], [CatDesc]) VALUES (7, N'Diary', N'Diary Food')
INSERT [dbo].[Category] ([CatID], [CatName], [CatDesc]) VALUES (8, N'Flour', N'Flour for bread')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProID], [ProName], [ProCatID], [ProPrice], [ProQty]) VALUES (1, N'Tea Milksi2', 7, CAST(500.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([ProID], [ProName], [ProCatID], [ProPrice], [ProQty]) VALUES (2, N'Dangote Flour', 8, CAST(3000.00 AS Decimal(10, 2)), 8)
INSERT [dbo].[Product] ([ProID], [ProName], [ProCatID], [ProPrice], [ProQty]) VALUES (5, N'Bons Lee', 8, CAST(300.00 AS Decimal(10, 2)), 20)
INSERT [dbo].[Product] ([ProID], [ProName], [ProCatID], [ProPrice], [ProQty]) VALUES (6, N'Citechs Bread', 8, CAST(450.00 AS Decimal(10, 2)), 12)
INSERT [dbo].[Product] ([ProID], [ProName], [ProCatID], [ProPrice], [ProQty]) VALUES (7, N'Nunu', 7, CAST(230.00 AS Decimal(10, 2)), 9)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([SellerID], [SellerName], [SellerAge], [SellerPhone], [SellerPassword]) VALUES (1, N'amaka', N'30', N'08039365012', N'amaka')
INSERT [dbo].[Sales] ([SellerID], [SellerName], [SellerAge], [SellerPhone], [SellerPassword]) VALUES (2, N'kamsi', N'20', N'08033837887', N'kamsi')
SET IDENTITY_INSERT [dbo].[Sales] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Category__9C61AB260818ADAF]    Script Date: 21/08/2023 10:24:30 AM ******/
ALTER TABLE [dbo].[Category] ADD UNIQUE NONCLUSTERED 
(
	[CatName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Sales__030470FAB6FCC299]    Script Date: 21/08/2023 10:24:30 AM ******/
ALTER TABLE [dbo].[Sales] ADD UNIQUE NONCLUSTERED 
(
	[SellerName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spAdminDelete]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAdminDelete](
	@Username NVARCHAR(50)
)
AS
BEGIN
	DELETE FROM Admin WHERE Username = @Username
END
GO
/****** Object:  StoredProcedure [dbo].[spAdminInsert]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAdminInsert](
	@Username NVARCHAR(50),
	@Password NVARCHAR (50),
	@FullName NVARCHAR (50)
)
AS
BEGIN
	INSERT INTO Admin (Username, Password, FullName) VALUES (@Username, @Password, @FullName)
END
GO
/****** Object:  StoredProcedure [dbo].[spAdminUpdate]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAdminUpdate](
	@AdminID NVARCHAR(50),
	@Username NVARCHAR(50),
	@Password NVARCHAR (50),
	@FullName NVARCHAR (50)
)
AS
BEGIN
	UPDATE Admin SET Username=@Username, [Password]=@Password, FullName=@FullName WHERE Username = @AdminID
END

GO
/****** Object:  StoredProcedure [dbo].[spCatDelete]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCatDelete](
	@CatID INT
)
AS
BEGIN
	DELETE FROM Category WHERE CatID = @CatID
END
GO
/****** Object:  StoredProcedure [dbo].[spCatInsert]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCatInsert](
	@CatName NVARCHAR (50),
	@CatDesc NVARCHAR (50)
)
AS
BEGIN
	INSERT INTO Category (CatName, CatDesc) VALUES (@CatName, @CatDesc)
END
GO
/****** Object:  StoredProcedure [dbo].[spCatUpdate]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCatUpdate](
	@CatID INT,
	@CatName NVARCHAR (50),
	@CatDesc NVARCHAR (50)
)
AS
BEGIN
	UPDATE Category SET CatName=@CatName, CatDesc = @CatDesc WHERE CatID = @CatID
END
GO
/****** Object:  StoredProcedure [dbo].[spCheckDuplicateProduct]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCheckDuplicateProduct]
(
	@ProName NVARCHAR(50),
	@ProCatID INT
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT ProName FROM Product WHERE ProName = @ProName AND ProCatID=@ProCatID
END

GO
/****** Object:  StoredProcedure [dbo].[spDeleteProduct]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteProduct]
(
	@ProID INT
)
AS
BEGIN
	DELETE FROM Product WHERE ProID=@ProID;
END

GO
/****** Object:  StoredProcedure [dbo].[spGetAllProduct]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllProduct]
AS
BEGIN
	SELECT p.ProID AS ID, p.ProName AS [Name], c.CatName as [Category Name], p.ProCatID AS [Category ID], p.ProPrice AS Price, p.ProQty AS Quantity FROM Product as p
	INNER JOIN Category as c ON p.ProCatID = c.CatID
	ORDER BY p.ProName, c.CatName ASC
END

GO
/****** Object:  StoredProcedure [dbo].[spGetBillList]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetBillList]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT BillID, SellerID, SellerDate, TotalAmount FROM  Bill ORDER BY BillID DESC;
END

GO
/****** Object:  StoredProcedure [dbo].[spGetCategory]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetCategory]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT CatID, CatName FROM Category ORDER BY CatName ASC
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertBill]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertBill]
(
	@BillID INT,
	@SellerID NVARCHAR (50),
	@SellerDate NVARCHAR (50),
	@TotalAmount DECIMAL (18, 2)
)
AS
BEGIN
	INSERT INTO Bill (BillID, SellerID, SellerDate, TotalAmount) VALUES(@BillID, @SellerID, @SellerDate, @TotalAmount);
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertProduct]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertProduct]
(
	@ProName NVARCHAR(50),
	@ProCatID INT,
	@ProPrice decimal(10,2),
	@ProQty INT
)
AS
BEGIN
	INSERT INTO Product (ProName, ProCatID, ProPrice, ProQty) VALUES(@ProName, @ProCatID, @ProPrice, @ProQty);
END

GO
/****** Object:  StoredProcedure [dbo].[spSalesDelete]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSalesDelete](
	@SellerID INT
)
AS
BEGIN
	DELETE FROM Sales WHERE SellerID = @SellerID
END
GO
/****** Object:  StoredProcedure [dbo].[spSalesInsert]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSalesInsert](
	--@SellerID INT,
	@SellerName NVARCHAR(50),
	@SellerAge NVARCHAR(20),
	@SellerPhone NVARCHAR(50),
	@SellerPassword NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO Sales (SellerName, SellerAge, SellerPhone, SellerPassword) VALUES (@SellerName, @SellerAge, @SellerPhone, @SellerPassword)
END

GO
/****** Object:  StoredProcedure [dbo].[spSalesUpdate]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSalesUpdate](
	@SellerID INT,
	@SellerName NVARCHAR(50),
	@SellerAge NVARCHAR(20),
	@SellerPhone NVARCHAR(50),
	@SellerPassword NVARCHAR(50)
)
AS
BEGIN
	UPDATE Sales SET SellerName=@SellerName, SellerAge=@SellerAge, SellerPassword=@SellerPassword, SellerPhone= @SellerPhone WHERE SellerID = @SellerID
END
GO
/****** Object:  StoredProcedure [dbo].[spSearchProductByCategory]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSearchProductByCategory](
	@ProCatID INT
)
AS
BEGIN
SET NOCOUNT ON;
	SELECT p.ProID AS ID, p.ProName AS [Name], c.CatName as [Category Name], p.ProCatID AS [Category ID], p.ProPrice AS Price, p.ProQty AS Quantity FROM Product as p
	INNER JOIN Category as c ON p.ProCatID = c.CatID
	WHERE ProCatID=@ProCatID
	ORDER BY p.ProName, c.CatName ASC
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateProduct]    Script Date: 21/08/2023 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateProduct]
(
	@ProID INT,
	@ProName NVARCHAR(50),
	@ProCatID INT,
	@ProPrice decimal(10,2),
	@ProQty INT
	)
AS
BEGIN
	UPDATE Product SET ProName=@ProName, ProCatID=@ProCatID, ProPrice=@ProPrice, ProQty=@ProQty WHERE ProID=@ProID;
END

GO
USE [master]
GO
ALTER DATABASE [MiniMartInventory] SET  READ_WRITE 
GO

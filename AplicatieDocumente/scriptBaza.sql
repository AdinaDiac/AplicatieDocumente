USE [master]
GO

CREATE DATABASE [AplicatieDocumente]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AplicatieDocumente', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AplicatieDocumente.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AplicatieDocumente_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AplicatieDocumente_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AplicatieDocumente] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AplicatieDocumente].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AplicatieDocumente] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET ARITHABORT OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AplicatieDocumente] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AplicatieDocumente] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AplicatieDocumente] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AplicatieDocumente] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET RECOVERY FULL 
GO
ALTER DATABASE [AplicatieDocumente] SET  MULTI_USER 
GO
ALTER DATABASE [AplicatieDocumente] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AplicatieDocumente] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AplicatieDocumente] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AplicatieDocumente] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AplicatieDocumente] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AplicatieDocumente] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AplicatieDocumente', N'ON'
GO
ALTER DATABASE [AplicatieDocumente] SET QUERY_STORE = OFF
GO
USE [AplicatieDocumente]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inregistrari](
	[IdDocument] [int] IDENTITY(1,1) NOT NULL,
	[DataInregistrarii] [datetime] NULL,
	[DenumireDocument] [varchar](500) NULL,
	[ProvenientaDocument] [varchar](500) NULL,
	[DestinatieDocument] [varchar](500) NULL,
	[InregistratDe] [varchar](500) NULL,
	[NumeFisier] [varchar](500) NULL,
	[TipFisier] [varchar](500) NULL,
	[DataFisier] [varbinary](max) NULL,
	[TipDocument] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDocument] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Useri](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[NumeUtilizator] [varchar](500) NULL,
	[Parola] [varchar](500) NULL,
	[Acces] [varchar](500) NULL,
	[PasswordCheck] [varchar](500) NULL,
	[Grup] [varchar](500) NULL,
	[StatusUser] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Inregistrari] ON 

INSERT [dbo].[Inregistrari] ([IdDocument], [DataInregistrarii], [DenumireDocument], [ProvenientaDocument], [DestinatieDocument], [InregistratDe], [NumeFisier], [TipFisier], [DataFisier], [TipDocument]) VALUES (4, CAST(N'2022-11-18T08:51:49.203' AS DateTime), N'Nota cumparare echipament', N'HR', N'HSE', N'Adina', NULL, NULL, NULL, N'Iesire')
SET IDENTITY_INSERT [dbo].[Inregistrari] OFF
GO
SET IDENTITY_INSERT [dbo].[Useri] ON 

INSERT [dbo].[Useri] ([IdUser], [NumeUtilizator], [Parola], [Acces], [PasswordCheck], [Grup], [StatusUser]) VALUES (7, N'Admin', N'admin', N'Admin', N'0', N'IT', N'Activ')
INSERT [dbo].[Useri] ([IdUser], [NumeUtilizator], [Parola], [Acces], [PasswordCheck], [Grup], [StatusUser]) VALUES (8, N'User', N'user', N'User', N'0', N'HR', N'Activ')
INSERT [dbo].[Useri] ([IdUser], [NumeUtilizator], [Parola], [Acces], [PasswordCheck], [Grup], [StatusUser]) VALUES (9, N'Adina', N'Abc123', N'User', N'0', N'IT', N'Activ')
INSERT [dbo].[Useri] ([IdUser], [NumeUtilizator], [Parola], [Acces], [PasswordCheck], [Grup], [StatusUser]) VALUES (10, N'Bla modif', N'12345', N'User', N'0', N'PURCHASING', N'Activ')
SET IDENTITY_INSERT [dbo].[Useri] OFF
GO
ALTER TABLE [dbo].[Useri] ADD  DEFAULT ('0') FOR [PasswordCheck]
GO
ALTER TABLE [dbo].[Useri] ADD  DEFAULT ('Activ') FOR [StatusUser]
GO
USE [master]
GO
ALTER DATABASE [AplicatieDocumente] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [BDSISTR]    Script Date: 21/09/2023 09:13:57 ******/
CREATE DATABASE [BDSISTR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDSISTR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BDSISTR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDSISTR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BDSISTR_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BDSISTR] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDSISTR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDSISTR] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDSISTR] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDSISTR] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDSISTR] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDSISTR] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDSISTR] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDSISTR] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDSISTR] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDSISTR] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDSISTR] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDSISTR] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDSISTR] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDSISTR] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDSISTR] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDSISTR] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDSISTR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDSISTR] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDSISTR] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDSISTR] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDSISTR] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDSISTR] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDSISTR] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDSISTR] SET RECOVERY FULL 
GO
ALTER DATABASE [BDSISTR] SET  MULTI_USER 
GO
ALTER DATABASE [BDSISTR] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDSISTR] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDSISTR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDSISTR] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDSISTR] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDSISTR] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDSISTR', N'ON'
GO
ALTER DATABASE [BDSISTR] SET QUERY_STORE = ON
GO
ALTER DATABASE [BDSISTR] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BDSISTR]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 21/09/2023 09:13:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[primernombre] [varchar](50) NOT NULL,
	[segundonombre] [varchar](50) NOT NULL,
	[primerapellido] [varchar](50) NOT NULL,
	[segundoapellido] [varchar](50) NOT NULL,
	[nivel] [varchar](20) NOT NULL,
	[GRADO] [varchar](2) NOT NULL,
	[SECCION] [varchar](3) NOT NULL,
	[SEXO] [varchar](15) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[telefono] [varchar](9) NOT NULL,
	[dirección] [varchar](60) NOT NULL,
	[fechaDnac] [date] NOT NULL,
	[observaciones] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21/09/2023 09:13:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[password] [varchar](8) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[cargo] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Mostrar]    Script Date: 21/09/2023 09:13:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Mostrar]
AS 
SELECT * FROM Estudiante
GO
USE [master]
GO
ALTER DATABASE [BDSISTR] SET  READ_WRITE 
GO

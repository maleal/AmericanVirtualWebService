/*
	Desarrollador: Mario Leal Fuentes mariolealfuentes@gmail.com
	Ejercicio 'Web Service' para búsqueda laboral de America Virtual 
	2019
*/
USE [master]
GO

/****** Object:  Database [db_america_virtual_exercise]    Script Date: 23/10/2019 08:40:44 ******/
CREATE DATABASE [db_america_virtual_exercise]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_america_virtual_exercise', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_america_virtual_exercise.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_america_virtual_exercise_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_america_virtual_exercise_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [db_america_virtual_exercise] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_america_virtual_exercise].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [db_america_virtual_exercise] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET ARITHABORT OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [db_america_virtual_exercise] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [db_america_virtual_exercise] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET  DISABLE_BROKER 
GO

ALTER DATABASE [db_america_virtual_exercise] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [db_america_virtual_exercise] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [db_america_virtual_exercise] SET  MULTI_USER 
GO

ALTER DATABASE [db_america_virtual_exercise] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [db_america_virtual_exercise] SET DB_CHAINING OFF 
GO

ALTER DATABASE [db_america_virtual_exercise] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [db_america_virtual_exercise] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [db_america_virtual_exercise] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [db_america_virtual_exercise] SET  READ_WRITE 
GO



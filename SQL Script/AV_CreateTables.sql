/*
	Desarrollador: Mario Leal Fuentes mariolealfuentes@gmail.com
	Ejercicio 'Web Service' para búsqueda laboral de America Virtual 
	2019
*/
USE db_america_virtual_exercise
GO

IF OBJECT_ID('dbo.AvUsers', 'U') IS NOT NULL
DROP TABLE AvUsers;

CREATE TABLE AvUsers(
   Id int IDENTITY(1,1) NOT NULL,
   UserName  varchar(250) NOT NULL,
   UserPasswordHash  varchar(250) NOT NULL,
   UserEmail  varchar(250) NOT NULL,
   UserStatus varchar(1) NOT NULL,
   UserCreationDate DateTime Not NULL
);

USE db_america_virtual_exercise
GO

INSERT INTO [dbo].[AvUsers]
           ([UserName]
           ,[UserPasswordHash]
           ,[UserEmail]
		   ,[UserStatus]
		   ,[UserCreationDate])
		   VALUES('userUno', 'asdfgasdfg', 'userUno@gmail.com', 'E', GETDATE());

INSERT INTO [dbo].[AvUsers]
           ([UserName]
           ,[UserPasswordHash]
           ,[UserEmail]
		   ,[UserStatus]
		   ,[UserCreationDate])
		   VALUES('userDos', 'asdfgasdfg', 'userDos@gmail.com', 'E', GETDATE());

INSERT INTO [dbo].[AvUsers]
           ([UserName]
           ,[UserPasswordHash]
           ,[UserEmail]
		   ,[UserStatus]
		   ,[UserCreationDate])
		   VALUES('userTres', 'asdfgasdfg', 'userTres@gmail.com', 'E', GETDATE());

USE db_america_virtual_exercise
GO

IF OBJECT_ID('dbo.Categories', 'U') IS NOT NULL
DROP TABLE Categories;
GO
CREATE TABLE Categories (
 Id INT IDENTITY (1, 1) PRIMARY KEY,
 catry_name VARCHAR (255) NOT NULL,
 catry_description VARCHAR (255) NOT NULL,
 catry_status varchar(1) NOT NULL
);

INSERT INTO [dbo].[Categories]
           ([catry_name]
           ,[catry_description]
		   ,[catry_status])
		   VALUES('ecommerce', 'Tiendas Virtuales con Carrito, Medios de Pagpos, Fidelizacion y Pagina de Administracion', 'E');

INSERT INTO [dbo].[Categories]
           ([catry_name]
           ,[catry_description]
		   ,[catry_status])
		   VALUES('blogs', 'Personales o Temáticos', 'E');

INSERT INTO [dbo].[Categories]
           ([catry_name]
           ,[catry_description]
		   ,[catry_status])
		   VALUES('institucionales', 'Creación de sitios webs a medida', 'E');

INSERT INTO [dbo].[Categories]
           ([catry_name]
           ,[catry_description]
		   ,[catry_status])
		   VALUES('juegos_mobile', 'Creación de juegos para mobiles', 'E');

INSERT INTO [dbo].[Categories]
           ([catry_name]
           ,[catry_description]
		   ,[catry_status])
		   VALUES('juegos_desktop', 'Creación de juegos para pc', 'E');


IF OBJECT_ID('dbo.Product', 'U') IS NOT NULL
DROP TABLE Product;
USE db_america_virtual_exercise
GO
CREATE TABLE Product(
   Id int IDENTITY(1,1) NOT NULL,
   CategoryId int NOT NULL,
   ProductName varchar(250) NOT NULL,
   PrecioUnitario money NOT NULL,
   Imagen image NULL
   CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC),
   CONSTRAINT FK_Product_Categories FOREIGN KEY (CategoryId) REFERENCES dbo.Categories (Id)
);

USE db_america_virtual_exercise
GO

INSERT INTO [dbo].[Product]([CategoryId], [ProductName], [PrecioUnitario], [Imagen])
SELECT 1, 'Ecommerce Basico', 3000, * FROM OPENROWSET(BULK N'C:\images\Magentodownload.jpg', SINGLE_BLOB) Image;

INSERT INTO [dbo].[Product]([CategoryId], [ProductName], [PrecioUnitario], [Imagen])
SELECT 1, 'Ecommerce Full', 9000.00, * FROM OPENROWSET(BULK N'C:\images\opencart-logo.png', SINGLE_BLOB) Image;

INSERT INTO [dbo].[Product]([CategoryId], [ProductName], [PrecioUnitario], [Imagen])
SELECT 3, '3D Super Mario Bros', 5000.00, * FROM OPENROWSET(BULK N'C:\images\smariodownload.jpg', SINGLE_BLOB) Image;


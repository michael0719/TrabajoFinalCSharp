USE [master]
GO
/****** Object:  Database [BDBar]    Script Date: 11/11/2019 02:20:37 a.m. ******/
CREATE DATABASE [BDBar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDBar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BDBar.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDBar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BDBar_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BDBar] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDBar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDBar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDBar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDBar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDBar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDBar] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDBar] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BDBar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDBar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDBar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDBar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDBar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDBar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDBar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDBar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDBar] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDBar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDBar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDBar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDBar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDBar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDBar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDBar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDBar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDBar] SET  MULTI_USER 
GO
ALTER DATABASE [BDBar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDBar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDBar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDBar] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BDBar] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BDBar]
GO
/****** Object:  Table [dbo].[TblCategoria]    Script Date: 11/11/2019 02:20:37 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCategoria](
	[Id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblDetalle_fact]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDetalle_fact](
	[Id_factura] [int] NULL,
	[Id_Producto] [int] NULL,
	[Cantidad] [int] NULL,
	[Subtotal] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblFactura]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblFactura](
	[Id_factura] [int] IDENTITY(1,1) NOT NULL,
	[Mesa] [varchar](20) NULL,
	[Total] [int] NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblProductos]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblProductos](
	[Id_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Id_categoria] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[precio] [int] NULL,
	[cantidad] [int] NULL,
	[Estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblUsuarios]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblUsuarios](
	[Id_usuario] [varchar](20) NOT NULL,
	[Contra] [varchar](20) NULL,
	[Pregunta] [varchar](30) NULL,
	[Respuesta] [varchar](50) NULL,
	[Tipo] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TblCategoria] ON 

INSERT [dbo].[TblCategoria] ([Id_categoria], [Nombre], [Descripcion]) VALUES (1, N'Cervezas', N'Aqui estan registradas todos los tipos de cerveza que se venden')
INSERT [dbo].[TblCategoria] ([Id_categoria], [Nombre], [Descripcion]) VALUES (2, N'Gaseosas', N'Todos las gaseosas o refrescos que se venden en el negocio')
SET IDENTITY_INSERT [dbo].[TblCategoria] OFF
INSERT [dbo].[TblDetalle_fact] ([Id_factura], [Id_Producto], [Cantidad], [Subtotal]) VALUES (1, 1, 2, 5000)
INSERT [dbo].[TblDetalle_fact] ([Id_factura], [Id_Producto], [Cantidad], [Subtotal]) VALUES (1, 2, 3, 4600)
INSERT [dbo].[TblDetalle_fact] ([Id_factura], [Id_Producto], [Cantidad], [Subtotal]) VALUES (1, 3, 1, 4500)
INSERT [dbo].[TblDetalle_fact] ([Id_factura], [Id_Producto], [Cantidad], [Subtotal]) VALUES (2, 2, 3, 10000)
SET IDENTITY_INSERT [dbo].[TblFactura] ON 

INSERT [dbo].[TblFactura] ([Id_factura], [Mesa], [Total], [fecha]) VALUES (1, N'1', 14100, NULL)
INSERT [dbo].[TblFactura] ([Id_factura], [Mesa], [Total], [fecha]) VALUES (2, N'Mesa 1', 15000, CAST(N'1994-07-07 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TblFactura] OFF
SET IDENTITY_INSERT [dbo].[TblProductos] ON 

INSERT [dbo].[TblProductos] ([Id_Producto], [Id_categoria], [Nombre], [precio], [cantidad], [Estado]) VALUES (1, 1, N'Pilse', 2300, 10, 1)
INSERT [dbo].[TblProductos] ([Id_Producto], [Id_categoria], [Nombre], [precio], [cantidad], [Estado]) VALUES (2, 1, N'Aguila', 2300, 10, 1)
INSERT [dbo].[TblProductos] ([Id_Producto], [Id_categoria], [Nombre], [precio], [cantidad], [Estado]) VALUES (3, 1, N'Pilsenon', 4500, 10, 1)
INSERT [dbo].[TblProductos] ([Id_Producto], [Id_categoria], [Nombre], [precio], [cantidad], [Estado]) VALUES (4, 1, N'Aguilon', 4500, 10, 1)
INSERT [dbo].[TblProductos] ([Id_Producto], [Id_categoria], [Nombre], [precio], [cantidad], [Estado]) VALUES (5, 1, N'Heineken', 2500, 5, 1)
INSERT [dbo].[TblProductos] ([Id_Producto], [Id_categoria], [Nombre], [precio], [cantidad], [Estado]) VALUES (6, 2, N'Postobon', 1500, 8, 1)
INSERT [dbo].[TblProductos] ([Id_Producto], [Id_categoria], [Nombre], [precio], [cantidad], [Estado]) VALUES (7, 2, N'Colombiana', 1500, 10, 1)
INSERT [dbo].[TblProductos] ([Id_Producto], [Id_categoria], [Nombre], [precio], [cantidad], [Estado]) VALUES (8, 1, N'pilsen', 2500, 10, 0)
INSERT [dbo].[TblProductos] ([Id_Producto], [Id_categoria], [Nombre], [precio], [cantidad], [Estado]) VALUES (9, 1, N'asdf', 1234, 123, 0)
SET IDENTITY_INSERT [dbo].[TblProductos] OFF
INSERT [dbo].[TblUsuarios] ([Id_usuario], [Contra], [Pregunta], [Respuesta], [Tipo]) VALUES (N'Michael', N'123546', N'Nombre de la madre', N'Nombre de la madre', 1)
ALTER TABLE [dbo].[TblDetalle_fact]  WITH CHECK ADD FOREIGN KEY([Id_factura])
REFERENCES [dbo].[TblFactura] ([Id_factura])
GO
ALTER TABLE [dbo].[TblDetalle_fact]  WITH CHECK ADD FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[TblProductos] ([Id_Producto])
GO
ALTER TABLE [dbo].[TblProductos]  WITH CHECK ADD FOREIGN KEY([Id_categoria])
REFERENCES [dbo].[TblCategoria] ([Id_categoria])
GO
/****** Object:  StoredProcedure [dbo].[SPEliminarCategoria]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPEliminarCategoria] 
	@codigo int
AS
BEGIN
	DELETE FROM TblCategoria WHERE Id_categoria=@codigo
END

GO
/****** Object:  StoredProcedure [dbo].[SPEliminarProducto]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPEliminarProducto]
	-- Add the parameters for the stored procedure here
	@codigo int
AS
BEGIN
	Update TblProductos SET Estado=0 WHERE Id_Producto=@codigo
END

GO
/****** Object:  StoredProcedure [dbo].[SPGuardarCategoria]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPGuardarCategoria]
@nombre varchar(50),
@descripcion varchar(200)
AS
	INSERT INTO TblCategoria (Nombre,Descripcion) VALUES (@nombre,@descripcion)

GO
/****** Object:  StoredProcedure [dbo].[SPGuardarProducto]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPGuardarProducto]
	@nombre varchar(50),
	@precio int,
	@cantidad int,
	@idcategoria int,
	@estado int
AS
    INSERT INTO TblProductos(Nombre,precio,cantidad,Estado,Id_categoria) VALUES
	(@nombre,@precio,@cantidad,@idcategoria,@estado)

GO
/****** Object:  StoredProcedure [dbo].[SPGuardarProductoCC]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPGuardarProductoCC]
	-- Add the parameters for the stored procedure here
	@codigo int,
	@nombre varchar(50),
	@precio int,
	@cantidad int,
	@idcategoria int
AS

	Update TblProductos SET Nombre=@nombre,precio=@precio,cantidad=@cantidad,
	Id_categoria=@idcategoria WHERE Id_Producto=@codigo;


GO
/****** Object:  StoredProcedure [dbo].[SPGuardarProductoSC]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPGuardarProductoSC]
	-- Add the parameters for the stored procedure here
	@codigo int,
	@nombre varchar(50),
	@precio int,
	@cantidad int
AS

	Update TblProductos SET Nombre=@nombre,precio=@precio,cantidad=@cantidad
 WHERE Id_Producto=@codigo;


GO
/****** Object:  StoredProcedure [dbo].[SPListarCategoria]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPListarCategoria]
AS
	SELECT Id_categoria,Nombre,Descripcion FROM TblCategoria

GO
/****** Object:  StoredProcedure [dbo].[SPListarProductos]    Script Date: 11/11/2019 02:20:38 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPListarProductos]
AS
    SELECT pro.Id_Producto as ID,pro.Nombre as Nombre,pro.precio as Precio,
	pro.cantidad as Cantidad,ca.Nombre as Categoria FROM TblProductos pro JOIN
	TblCategoria ca on pro.Id_categoria=ca.Id_categoria WHERE pro.Estado=1

GO
USE [master]
GO
ALTER DATABASE [BDBar] SET  READ_WRITE 
GO

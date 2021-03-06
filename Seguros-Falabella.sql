USE [master]
GO
/****** Object:  Database [Seguros]    Script Date: 08/01/2019 23:02:20 ******/
CREATE DATABASE [Seguros]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Seguros', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Seguros.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Seguros_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Seguros_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Seguros] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Seguros].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Seguros] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Seguros] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Seguros] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Seguros] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Seguros] SET ARITHABORT OFF 
GO
ALTER DATABASE [Seguros] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Seguros] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Seguros] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Seguros] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Seguros] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Seguros] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Seguros] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Seguros] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Seguros] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Seguros] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Seguros] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Seguros] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Seguros] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Seguros] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Seguros] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Seguros] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Seguros] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Seguros] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Seguros] SET RECOVERY FULL 
GO
ALTER DATABASE [Seguros] SET  MULTI_USER 
GO
ALTER DATABASE [Seguros] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Seguros] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Seguros] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Seguros] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Seguros]
GO
/****** Object:  Table [dbo].[Asesor]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asesor](
	[IdAsesor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Asesor] PRIMARY KEY CLUSTERED 
(
	[IdAsesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Documento] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compania]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compania](
	[IdCompania] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Compania] PRIMARY KEY CLUSTERED 
(
	[IdCompania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoVenta]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoVenta](
	[IdEstado] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](20) NULL,
 CONSTRAINT [PK_EstadoVenta] PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemProducto]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemProducto](
	[IdItemProducto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [text] NULL,
	[IdTipoItem] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
 CONSTRAINT [PK_ItemProducto] PRIMARY KEY CLUSTERED 
(
	[IdItemProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [text] NULL,
	[IdCompania] [int] NOT NULL,
	[IdAsesor] [int] NOT NULL,
 CONSTRAINT [PK_Prroducto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoItem]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoItem](
	[IdTipoItem] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NULL,
 CONSTRAINT [PK_TipoItem] PRIMARY KEY CLUSTERED 
(
	[IdTipoItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdEstado] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VentaProducto]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaProducto](
	[IdVentaProducto] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
 CONSTRAINT [PK_VentaProducto] PRIMARY KEY CLUSTERED 
(
	[IdVentaProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[V_ListaProductos]    Script Date: 08/01/2019 23:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_ListaProductos]
AS
	SELECT 
		A.IdProducto
		,A.Nombre
		,A.Descripcion
		,A.IdCompania
		,A.IdAsesor 
		,B.Nombre AS NombreCompania
		,C.Nombre as Asesor
		,D.Descripcion AS DescripcionItem
		,E.Descripcion AS TipoItem
	FROM PRODUCTO AS A
	INNER JOIN Compania AS B ON B.IdCompania = A.IdCompania
	INNER JOIN ASESOR AS C ON C.IdAsesor = A.IdAsesor
	LEFT JOIN ItemProducto AS D ON D.IdProducto = A.IdProducto
	LEFT JOIN TipoItem AS E ON E.IdTipoItem = D.IdTipoItem


GO
SET IDENTITY_INSERT [dbo].[Asesor] ON 

INSERT [dbo].[Asesor] ([IdAsesor], [Nombre]) VALUES (1, N'Asesor 1')
INSERT [dbo].[Asesor] ([IdAsesor], [Nombre]) VALUES (2, N'Asesor 2')
INSERT [dbo].[Asesor] ([IdAsesor], [Nombre]) VALUES (3, N'Asesor 3')
SET IDENTITY_INSERT [dbo].[Asesor] OFF
SET IDENTITY_INSERT [dbo].[Compania] ON 

INSERT [dbo].[Compania] ([IdCompania], [Nombre], [Estado]) VALUES (1, N'Compañia Uno', 1)
INSERT [dbo].[Compania] ([IdCompania], [Nombre], [Estado]) VALUES (2, N'Compañia 2 ', 1)
SET IDENTITY_INSERT [dbo].[Compania] OFF
SET IDENTITY_INSERT [dbo].[EstadoVenta] ON 

INSERT [dbo].[EstadoVenta] ([IdEstado], [Descripcion]) VALUES (1, N'Solicitado')
INSERT [dbo].[EstadoVenta] ([IdEstado], [Descripcion]) VALUES (2, N'Vendido')
INSERT [dbo].[EstadoVenta] ([IdEstado], [Descripcion]) VALUES (3, N'Rechazado')
SET IDENTITY_INSERT [dbo].[EstadoVenta] OFF
SET IDENTITY_INSERT [dbo].[ItemProducto] ON 

INSERT [dbo].[ItemProducto] ([IdItemProducto], [Descripcion], [IdTipoItem], [IdProducto]) VALUES (1, N'Item 1', 1, 17)
INSERT [dbo].[ItemProducto] ([IdItemProducto], [Descripcion], [IdTipoItem], [IdProducto]) VALUES (2, N'Item 2', 1, 17)
INSERT [dbo].[ItemProducto] ([IdItemProducto], [Descripcion], [IdTipoItem], [IdProducto]) VALUES (3, N'Item 111', 1, 19)
INSERT [dbo].[ItemProducto] ([IdItemProducto], [Descripcion], [IdTipoItem], [IdProducto]) VALUES (4, N'Item 11122', 1, 19)
INSERT [dbo].[ItemProducto] ([IdItemProducto], [Descripcion], [IdTipoItem], [IdProducto]) VALUES (5, N'Item 11122', 1, 19)
INSERT [dbo].[ItemProducto] ([IdItemProducto], [Descripcion], [IdTipoItem], [IdProducto]) VALUES (6, N'descripcion 1', 1, 19)
INSERT [dbo].[ItemProducto] ([IdItemProducto], [Descripcion], [IdTipoItem], [IdProducto]) VALUES (7, N'Pruebas', 1, 27)
SET IDENTITY_INSERT [dbo].[ItemProducto] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (4, N'Producto 1', N'Descripción producto 1', 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (5, N'Producto 2', N'Descripción producto 2', 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (6, N'Producto 2', N'Descripción producto 2', 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (7, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (8, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (9, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (10, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (11, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (12, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (13, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (14, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (15, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (16, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (17, NULL, NULL, 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (18, N'Prueba 1', N'Descripción producto 1', 2, 2)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (19, N'Producto 111', N'Descripción producto 111', 2, 3)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (20, N'Producto 111', N'Descripción producto 111', 2, 3)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (25, N'Prueba 45', N'Descripción producto 1', 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (26, N'Prueba 178', N'Descripción 1', 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [IdCompania], [IdAsesor]) VALUES (27, N'Producto 48755', N'Descripción producto 48755', 2, 3)
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[TipoItem] ON 

INSERT [dbo].[TipoItem] ([IdTipoItem], [Descripcion]) VALUES (1, N'Prima')
INSERT [dbo].[TipoItem] ([IdTipoItem], [Descripcion]) VALUES (2, N'Cobertura')
INSERT [dbo].[TipoItem] ([IdTipoItem], [Descripcion]) VALUES (3, N'Asistencia')
SET IDENTITY_INSERT [dbo].[TipoItem] OFF
ALTER TABLE [dbo].[ItemProducto]  WITH CHECK ADD  CONSTRAINT [FK_ItemProducto_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[ItemProducto] CHECK CONSTRAINT [FK_ItemProducto_Producto]
GO
ALTER TABLE [dbo].[ItemProducto]  WITH CHECK ADD  CONSTRAINT [FK_ItemProducto_TipoItem] FOREIGN KEY([IdTipoItem])
REFERENCES [dbo].[TipoItem] ([IdTipoItem])
GO
ALTER TABLE [dbo].[ItemProducto] CHECK CONSTRAINT [FK_ItemProducto_TipoItem]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Asesor] FOREIGN KEY([IdAsesor])
REFERENCES [dbo].[Asesor] ([IdAsesor])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Asesor]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Compania] FOREIGN KEY([IdCompania])
REFERENCES [dbo].[Compania] ([IdCompania])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Compania]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_EstadoVenta] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[EstadoVenta] ([IdEstado])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_EstadoVenta]
GO
ALTER TABLE [dbo].[VentaProducto]  WITH CHECK ADD  CONSTRAINT [FK_VentaProducto_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[VentaProducto] CHECK CONSTRAINT [FK_VentaProducto_Producto]
GO
ALTER TABLE [dbo].[VentaProducto]  WITH CHECK ADD  CONSTRAINT [FK_VentaProducto_Venta] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Venta] ([IdVenta])
GO
ALTER TABLE [dbo].[VentaProducto] CHECK CONSTRAINT [FK_VentaProducto_Venta]
GO
USE [master]
GO
ALTER DATABASE [Seguros] SET  READ_WRITE 
GO

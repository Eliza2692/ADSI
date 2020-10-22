USE [master]
GO
/****** Object:  Database [PasajesBD]    Script Date: 23/09/2016 11:26:01 ******/
CREATE DATABASE [PasajesBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PasajesBD', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PasajesBD.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PasajesBD_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PasajesBD_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PasajesBD] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PasajesBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PasajesBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PasajesBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PasajesBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PasajesBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PasajesBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [PasajesBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PasajesBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PasajesBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PasajesBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PasajesBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PasajesBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PasajesBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PasajesBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PasajesBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PasajesBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PasajesBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PasajesBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PasajesBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PasajesBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PasajesBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PasajesBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PasajesBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PasajesBD] SET RECOVERY FULL 
GO
ALTER DATABASE [PasajesBD] SET  MULTI_USER 
GO
ALTER DATABASE [PasajesBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PasajesBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PasajesBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PasajesBD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PasajesBD] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PasajesBD', N'ON'
GO
USE [PasajesBD]
GO
/****** Object:  Table [dbo].[BUSES]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BUSES](
	[IdBus] [varchar](5) NOT NULL,
	[PlacaBus] [varchar](6) NOT NULL,
 CONSTRAINT [PK_BUSES] PRIMARY KEY CLUSTERED 
(
	[IdBus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BUSES_RUTAS]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BUSES_RUTAS](
	[IdBusRuta] [int] IDENTITY(1,1) NOT NULL,
	[idBus] [varchar](5) NOT NULL,
	[FechaRuta] [datetime] NOT NULL,
	[IdHorario] [int] NOT NULL,
 CONSTRAINT [PK_BUSES_RUTAS] PRIMARY KEY CLUSTERED 
(
	[IdBusRuta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CIUDADES]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CIUDADES](
	[IdCiudad] [int] IDENTITY(1,1) NOT NULL,
	[NombreCiudad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CIUDADES] PRIMARY KEY CLUSTERED 
(
	[IdCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[IdCliente] [varchar](20) NOT NULL,
	[NombresCliente] [varchar](50) NOT NULL,
	[ApellidosCliente] [nchar](10) NOT NULL,
	[TelefonoCliente] [varchar](10) NOT NULL,
	[CorreoCliente] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLE_FACTURA]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_FACTURA](
	[IdDetalleFactura] [int] IDENTITY(1,1) NOT NULL,
	[Valor] [decimal](10, 2) NOT NULL,
	[IdBusesRuta] [int] NOT NULL,
	[IdFactura] [int] NOT NULL,
 CONSTRAINT [PK_DETALLE_FACTURA] PRIMARY KEY CLUSTERED 
(
	[IdDetalleFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FACTURAS]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FACTURAS](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[FechaFactura] [datetime] NOT NULL,
	[IdCliente] [varchar](20) NOT NULL,
 CONSTRAINT [PK_FACTURAS] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HORARIOS]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HORARIOS](
	[IdHorario] [int] IDENTITY(1,1) NOT NULL,
	[IdRuta] [int] NOT NULL,
	[Hora] [time](7) NOT NULL,
 CONSTRAINT [PK_HORARIOS] PRIMARY KEY CLUSTERED 
(
	[IdHorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PUESTOS]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PUESTOS](
	[IdPuesto] [int] IDENTITY(1,1) NOT NULL,
	[IdBusRuta] [int] NOT NULL,
	[NumeroPuesto] [int] NOT NULL,
 CONSTRAINT [PK_PUESTOS] PRIMARY KEY CLUSTERED 
(
	[IdPuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RUTAS]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RUTAS](
	[IdRuta] [int] IDENTITY(1,1) NOT NULL,
	[CiudadOrigen] [int] NOT NULL,
	[CiudadDestino] [int] NOT NULL,
	[Valor] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_RUTAS] PRIMARY KEY CLUSTERED 
(
	[IdRuta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 23/09/2016 11:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [nvarchar](128) NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
 CONSTRAINT [PK_sysdiagrams] PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_FK_BUSES_RUTAS_BUSES]    Script Date: 23/09/2016 11:26:01 ******/
CREATE NONCLUSTERED INDEX [IX_FK_BUSES_RUTAS_BUSES] ON [dbo].[BUSES_RUTAS]
(
	[idBus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_BUSES_RUTAS_HORARIOS]    Script Date: 23/09/2016 11:26:01 ******/
CREATE NONCLUSTERED INDEX [IX_FK_BUSES_RUTAS_HORARIOS] ON [dbo].[BUSES_RUTAS]
(
	[IdHorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_DETALLE_FACTURA_BUSES_RUTAS]    Script Date: 23/09/2016 11:26:01 ******/
CREATE NONCLUSTERED INDEX [IX_FK_DETALLE_FACTURA_BUSES_RUTAS] ON [dbo].[DETALLE_FACTURA]
(
	[IdBusesRuta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_FK_FACTURAS_CLIENTES]    Script Date: 23/09/2016 11:26:01 ******/
CREATE NONCLUSTERED INDEX [IX_FK_FACTURAS_CLIENTES] ON [dbo].[FACTURAS]
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_HORARIOS_RUTAS]    Script Date: 23/09/2016 11:26:01 ******/
CREATE NONCLUSTERED INDEX [IX_FK_HORARIOS_RUTAS] ON [dbo].[HORARIOS]
(
	[IdRuta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PUESTOS_BUSES_RUTAS]    Script Date: 23/09/2016 11:26:01 ******/
CREATE NONCLUSTERED INDEX [IX_FK_PUESTOS_BUSES_RUTAS] ON [dbo].[PUESTOS]
(
	[IdBusRuta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_RUTAS_CIUDADES]    Script Date: 23/09/2016 11:26:01 ******/
CREATE NONCLUSTERED INDEX [IX_FK_RUTAS_CIUDADES] ON [dbo].[RUTAS]
(
	[CiudadOrigen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_RUTAS_CIUDADES1]    Script Date: 23/09/2016 11:26:01 ******/
CREATE NONCLUSTERED INDEX [IX_FK_RUTAS_CIUDADES1] ON [dbo].[RUTAS]
(
	[CiudadDestino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BUSES_RUTAS]  WITH CHECK ADD  CONSTRAINT [FK_BUSES_RUTAS_BUSES] FOREIGN KEY([idBus])
REFERENCES [dbo].[BUSES] ([IdBus])
GO
ALTER TABLE [dbo].[BUSES_RUTAS] CHECK CONSTRAINT [FK_BUSES_RUTAS_BUSES]
GO
ALTER TABLE [dbo].[BUSES_RUTAS]  WITH CHECK ADD  CONSTRAINT [FK_BUSES_RUTAS_HORARIOS] FOREIGN KEY([IdHorario])
REFERENCES [dbo].[HORARIOS] ([IdHorario])
GO
ALTER TABLE [dbo].[BUSES_RUTAS] CHECK CONSTRAINT [FK_BUSES_RUTAS_HORARIOS]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_FACTURA_BUSES_RUTAS] FOREIGN KEY([IdBusesRuta])
REFERENCES [dbo].[BUSES_RUTAS] ([IdBusRuta])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [FK_DETALLE_FACTURA_BUSES_RUTAS]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_FACTURA_FACTURAS] FOREIGN KEY([IdDetalleFactura])
REFERENCES [dbo].[FACTURAS] ([IdFactura])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [FK_DETALLE_FACTURA_FACTURAS]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_CLIENTES] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[CLIENTES] ([IdCliente])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_FACTURAS_CLIENTES]
GO
ALTER TABLE [dbo].[HORARIOS]  WITH CHECK ADD  CONSTRAINT [FK_HORARIOS_RUTAS] FOREIGN KEY([IdRuta])
REFERENCES [dbo].[RUTAS] ([IdRuta])
GO
ALTER TABLE [dbo].[HORARIOS] CHECK CONSTRAINT [FK_HORARIOS_RUTAS]
GO
ALTER TABLE [dbo].[PUESTOS]  WITH CHECK ADD  CONSTRAINT [FK_PUESTOS_BUSES_RUTAS] FOREIGN KEY([IdBusRuta])
REFERENCES [dbo].[BUSES_RUTAS] ([IdBusRuta])
GO
ALTER TABLE [dbo].[PUESTOS] CHECK CONSTRAINT [FK_PUESTOS_BUSES_RUTAS]
GO
ALTER TABLE [dbo].[RUTAS]  WITH CHECK ADD  CONSTRAINT [FK_RUTAS_CIUDADES] FOREIGN KEY([CiudadOrigen])
REFERENCES [dbo].[CIUDADES] ([IdCiudad])
GO
ALTER TABLE [dbo].[RUTAS] CHECK CONSTRAINT [FK_RUTAS_CIUDADES]
GO
ALTER TABLE [dbo].[RUTAS]  WITH CHECK ADD  CONSTRAINT [FK_RUTAS_CIUDADES1] FOREIGN KEY([CiudadDestino])
REFERENCES [dbo].[CIUDADES] ([IdCiudad])
GO
ALTER TABLE [dbo].[RUTAS] CHECK CONSTRAINT [FK_RUTAS_CIUDADES1]
GO
USE [master]
GO
ALTER DATABASE [PasajesBD] SET  READ_WRITE 
GO

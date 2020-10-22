
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/23/2016 08:41:04
-- Generated from EDMX file: C:\Users\PC-RAMIREZ\Desktop\PasajesGH-master\DAL\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PasajesBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BUSES_RUTAS_BUSES]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BUSES_RUTAS] DROP CONSTRAINT [FK_BUSES_RUTAS_BUSES];
GO
IF OBJECT_ID(N'[dbo].[FK_BUSES_RUTAS_HORARIOS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BUSES_RUTAS] DROP CONSTRAINT [FK_BUSES_RUTAS_HORARIOS];
GO
IF OBJECT_ID(N'[dbo].[FK_DETALLE_FACTURA_BUSES_RUTAS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DETALLE_FACTURA] DROP CONSTRAINT [FK_DETALLE_FACTURA_BUSES_RUTAS];
GO
IF OBJECT_ID(N'[dbo].[FK_DETALLE_FACTURA_FACTURAS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DETALLE_FACTURA] DROP CONSTRAINT [FK_DETALLE_FACTURA_FACTURAS];
GO
IF OBJECT_ID(N'[dbo].[FK_FACTURAS_CLIENTES]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FACTURAS] DROP CONSTRAINT [FK_FACTURAS_CLIENTES];
GO
IF OBJECT_ID(N'[dbo].[FK_HORARIOS_RUTAS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HORARIOS] DROP CONSTRAINT [FK_HORARIOS_RUTAS];
GO
IF OBJECT_ID(N'[dbo].[FK_PUESTOS_BUSES_RUTAS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PUESTOS] DROP CONSTRAINT [FK_PUESTOS_BUSES_RUTAS];
GO
IF OBJECT_ID(N'[dbo].[FK_RUTAS_CIUDADES]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RUTAS] DROP CONSTRAINT [FK_RUTAS_CIUDADES];
GO
IF OBJECT_ID(N'[dbo].[FK_RUTAS_CIUDADES1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RUTAS] DROP CONSTRAINT [FK_RUTAS_CIUDADES1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BUSES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BUSES];
GO
IF OBJECT_ID(N'[dbo].[BUSES_RUTAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BUSES_RUTAS];
GO
IF OBJECT_ID(N'[dbo].[CIUDADES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CIUDADES];
GO
IF OBJECT_ID(N'[dbo].[CLIENTES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CLIENTES];
GO
IF OBJECT_ID(N'[dbo].[DETALLE_FACTURA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DETALLE_FACTURA];
GO
IF OBJECT_ID(N'[dbo].[FACTURAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FACTURAS];
GO
IF OBJECT_ID(N'[dbo].[HORARIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HORARIOS];
GO
IF OBJECT_ID(N'[dbo].[PUESTOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PUESTOS];
GO
IF OBJECT_ID(N'[dbo].[RUTAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RUTAS];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BUSES'
CREATE TABLE [dbo].[BUSES] (
    [IdBus] varchar(5)  NOT NULL,
    [PlacaBus] varchar(6)  NOT NULL
);
GO

-- Creating table 'BUSES_RUTAS'
CREATE TABLE [dbo].[BUSES_RUTAS] (
    [IdBusRuta] int IDENTITY(1,1) NOT NULL,
    [idBus] varchar(5)  NOT NULL,
    [FechaRuta] datetime  NOT NULL,
    [IdHorario] int  NOT NULL
);
GO

-- Creating table 'CIUDADES'
CREATE TABLE [dbo].[CIUDADES] (
    [IdCiudad] int IDENTITY(1,1) NOT NULL,
    [NombreCiudad] varchar(50)  NOT NULL
);
GO

-- Creating table 'CLIENTES'
CREATE TABLE [dbo].[CLIENTES] (
    [IdCliente] varchar(20)  NOT NULL,
    [NombresCliente] varchar(50)  NOT NULL,
    [ApellidosCliente] nchar(10)  NOT NULL,
    [TelefonoCliente] varchar(10)  NOT NULL,
    [CorreoCliente] varchar(100)  NOT NULL
);
GO

-- Creating table 'DETALLE_FACTURA'
CREATE TABLE [dbo].[DETALLE_FACTURA] (
    [IdDetalleFactura] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(10,2)  NOT NULL,
    [IdBusesRuta] int  NOT NULL,
    [IdFactura] int  NOT NULL
);
GO

-- Creating table 'FACTURAS'
CREATE TABLE [dbo].[FACTURAS] (
    [IdFactura] int IDENTITY(1,1) NOT NULL,
    [FechaFactura] datetime  NOT NULL,
    [IdCliente] varchar(20)  NOT NULL
);
GO

-- Creating table 'HORARIOS'
CREATE TABLE [dbo].[HORARIOS] (
    [IdHorario] int IDENTITY(1,1) NOT NULL,
    [IdRuta] int  NOT NULL,
    [Hora] time  NOT NULL
);
GO

-- Creating table 'PUESTOS'
CREATE TABLE [dbo].[PUESTOS] (
    [IdPuesto] int IDENTITY(1,1) NOT NULL,
    [IdBusRuta] int  NOT NULL,
    [NumeroPuesto] int  NOT NULL
);
GO

-- Creating table 'RUTAS'
CREATE TABLE [dbo].[RUTAS] (
    [IdRuta] int IDENTITY(1,1) NOT NULL,
    [CiudadOrigen] int  NOT NULL,
    [CiudadDestino] int  NOT NULL,
    [Valor] decimal(10,2)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdBus] in table 'BUSES'
ALTER TABLE [dbo].[BUSES]
ADD CONSTRAINT [PK_BUSES]
    PRIMARY KEY CLUSTERED ([IdBus] ASC);
GO

-- Creating primary key on [IdBusRuta] in table 'BUSES_RUTAS'
ALTER TABLE [dbo].[BUSES_RUTAS]
ADD CONSTRAINT [PK_BUSES_RUTAS]
    PRIMARY KEY CLUSTERED ([IdBusRuta] ASC);
GO

-- Creating primary key on [IdCiudad] in table 'CIUDADES'
ALTER TABLE [dbo].[CIUDADES]
ADD CONSTRAINT [PK_CIUDADES]
    PRIMARY KEY CLUSTERED ([IdCiudad] ASC);
GO

-- Creating primary key on [IdCliente] in table 'CLIENTES'
ALTER TABLE [dbo].[CLIENTES]
ADD CONSTRAINT [PK_CLIENTES]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdDetalleFactura] in table 'DETALLE_FACTURA'
ALTER TABLE [dbo].[DETALLE_FACTURA]
ADD CONSTRAINT [PK_DETALLE_FACTURA]
    PRIMARY KEY CLUSTERED ([IdDetalleFactura] ASC);
GO

-- Creating primary key on [IdFactura] in table 'FACTURAS'
ALTER TABLE [dbo].[FACTURAS]
ADD CONSTRAINT [PK_FACTURAS]
    PRIMARY KEY CLUSTERED ([IdFactura] ASC);
GO

-- Creating primary key on [IdHorario] in table 'HORARIOS'
ALTER TABLE [dbo].[HORARIOS]
ADD CONSTRAINT [PK_HORARIOS]
    PRIMARY KEY CLUSTERED ([IdHorario] ASC);
GO

-- Creating primary key on [IdPuesto] in table 'PUESTOS'
ALTER TABLE [dbo].[PUESTOS]
ADD CONSTRAINT [PK_PUESTOS]
    PRIMARY KEY CLUSTERED ([IdPuesto] ASC);
GO

-- Creating primary key on [IdRuta] in table 'RUTAS'
ALTER TABLE [dbo].[RUTAS]
ADD CONSTRAINT [PK_RUTAS]
    PRIMARY KEY CLUSTERED ([IdRuta] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idBus] in table 'BUSES_RUTAS'
ALTER TABLE [dbo].[BUSES_RUTAS]
ADD CONSTRAINT [FK_BUSES_RUTAS_BUSES]
    FOREIGN KEY ([idBus])
    REFERENCES [dbo].[BUSES]
        ([IdBus])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BUSES_RUTAS_BUSES'
CREATE INDEX [IX_FK_BUSES_RUTAS_BUSES]
ON [dbo].[BUSES_RUTAS]
    ([idBus]);
GO

-- Creating foreign key on [IdBusesRuta] in table 'DETALLE_FACTURA'
ALTER TABLE [dbo].[DETALLE_FACTURA]
ADD CONSTRAINT [FK_DETALLE_FACTURA_BUSES_RUTAS]
    FOREIGN KEY ([IdBusesRuta])
    REFERENCES [dbo].[BUSES_RUTAS]
        ([IdBusRuta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DETALLE_FACTURA_BUSES_RUTAS'
CREATE INDEX [IX_FK_DETALLE_FACTURA_BUSES_RUTAS]
ON [dbo].[DETALLE_FACTURA]
    ([IdBusesRuta]);
GO

-- Creating foreign key on [IdBusRuta] in table 'PUESTOS'
ALTER TABLE [dbo].[PUESTOS]
ADD CONSTRAINT [FK_PUESTOS_BUSES_RUTAS]
    FOREIGN KEY ([IdBusRuta])
    REFERENCES [dbo].[BUSES_RUTAS]
        ([IdBusRuta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PUESTOS_BUSES_RUTAS'
CREATE INDEX [IX_FK_PUESTOS_BUSES_RUTAS]
ON [dbo].[PUESTOS]
    ([IdBusRuta]);
GO

-- Creating foreign key on [CiudadOrigen] in table 'RUTAS'
ALTER TABLE [dbo].[RUTAS]
ADD CONSTRAINT [FK_RUTAS_CIUDADES]
    FOREIGN KEY ([CiudadOrigen])
    REFERENCES [dbo].[CIUDADES]
        ([IdCiudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RUTAS_CIUDADES'
CREATE INDEX [IX_FK_RUTAS_CIUDADES]
ON [dbo].[RUTAS]
    ([CiudadOrigen]);
GO

-- Creating foreign key on [CiudadDestino] in table 'RUTAS'
ALTER TABLE [dbo].[RUTAS]
ADD CONSTRAINT [FK_RUTAS_CIUDADES1]
    FOREIGN KEY ([CiudadDestino])
    REFERENCES [dbo].[CIUDADES]
        ([IdCiudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RUTAS_CIUDADES1'
CREATE INDEX [IX_FK_RUTAS_CIUDADES1]
ON [dbo].[RUTAS]
    ([CiudadDestino]);
GO

-- Creating foreign key on [IdCliente] in table 'FACTURAS'
ALTER TABLE [dbo].[FACTURAS]
ADD CONSTRAINT [FK_FACTURAS_CLIENTES]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[CLIENTES]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FACTURAS_CLIENTES'
CREATE INDEX [IX_FK_FACTURAS_CLIENTES]
ON [dbo].[FACTURAS]
    ([IdCliente]);
GO

-- Creating foreign key on [IdDetalleFactura] in table 'DETALLE_FACTURA'
ALTER TABLE [dbo].[DETALLE_FACTURA]
ADD CONSTRAINT [FK_DETALLE_FACTURA_FACTURAS]
    FOREIGN KEY ([IdDetalleFactura])
    REFERENCES [dbo].[FACTURAS]
        ([IdFactura])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdRuta] in table 'HORARIOS'
ALTER TABLE [dbo].[HORARIOS]
ADD CONSTRAINT [FK_HORARIOS_RUTAS]
    FOREIGN KEY ([IdRuta])
    REFERENCES [dbo].[RUTAS]
        ([IdRuta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HORARIOS_RUTAS'
CREATE INDEX [IX_FK_HORARIOS_RUTAS]
ON [dbo].[HORARIOS]
    ([IdRuta]);
GO

-- Creating foreign key on [IdHorario] in table 'BUSES_RUTAS'
ALTER TABLE [dbo].[BUSES_RUTAS]
ADD CONSTRAINT [FK_BUSES_RUTAS_HORARIOS]
    FOREIGN KEY ([IdHorario])
    REFERENCES [dbo].[HORARIOS]
        ([IdHorario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BUSES_RUTAS_HORARIOS'
CREATE INDEX [IX_FK_BUSES_RUTAS_HORARIOS]
ON [dbo].[BUSES_RUTAS]
    ([IdHorario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
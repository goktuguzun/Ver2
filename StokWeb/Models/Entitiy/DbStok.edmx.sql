
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/15/2022 03:08:44
-- Generated from EDMX file: C:\Users\goktu\source\repos\Ver2\StokWeb\Models\Entitiy\DbStok.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [StokTakip];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_StokTabloSatici_KategoriTablo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StokTabloSatici] DROP CONSTRAINT [FK_StokTabloSatici_KategoriTablo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ArizaliUrun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArizaliUrun];
GO
IF OBJECT_ID(N'[dbo].[KategoriTablo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KategoriTablo];
GO
IF OBJECT_ID(N'[dbo].[Kullanicilar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kullanicilar];
GO
IF OBJECT_ID(N'[dbo].[Servis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servis];
GO
IF OBJECT_ID(N'[dbo].[StokGirisCikis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StokGirisCikis];
GO
IF OBJECT_ID(N'[dbo].[StokTabloSatici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StokTabloSatici];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[WebUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WebUser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ArizaliUrun'
CREATE TABLE [dbo].[ArizaliUrun] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StokNo] int  NULL,
    [StokAd] nvarchar(50)  NULL,
    [Adet] int  NULL,
    [Aciklama] nvarchar(250)  NULL,
    [OnayDurum] nvarchar(50)  NULL,
    [Sicil] nvarchar(50)  NULL,
    [Tarih] nvarchar(50)  NULL
);
GO

-- Creating table 'KategoriTablo'
CREATE TABLE [dbo].[KategoriTablo] (
    [KategoriNo] nvarchar(50)  NOT NULL,
    [Kategori] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Kullanicilar'
CREATE TABLE [dbo].[Kullanicilar] (
    [SicilNo] int  NOT NULL,
    [Ad] nvarchar(20)  NULL,
    [Soyad] nvarchar(20)  NULL,
    [KullaniciTuru] nvarchar(20)  NULL
);
GO

-- Creating table 'Servis'
CREATE TABLE [dbo].[Servis] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Urun] nvarchar(50)  NULL,
    [Gittigitarih] nvarchar(50)  NULL,
    [GittigiServis] nvarchar(50)  NULL,
    [GeldigiTarih] nvarchar(50)  NULL,
    [TedenBolum] nvarchar(50)  NULL,
    [Arıza] nvarchar(50)  NULL,
    [Durum] nvarchar(50)  NULL,
    [SicilNo] nvarchar(50)  NULL,
    [YapılanIslem] nvarchar(50)  NULL
);
GO

-- Creating table 'StokGirisCikis'
CREATE TABLE [dbo].[StokGirisCikis] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StokKod] nvarchar(50)  NULL,
    [StokAd] nvarchar(50)  NULL,
    [Aciklama] nvarchar(50)  NULL,
    [Tarih] nvarchar(50)  NULL,
    [Adet] int  NULL,
    [Sicil] nvarchar(50)  NULL
);
GO

-- Creating table 'StokTabloSatici'
CREATE TABLE [dbo].[StokTabloSatici] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StokKodu] nvarchar(50)  NOT NULL,
    [StokAdi] nvarchar(50)  NOT NULL,
    [KritikStok] int  NULL,
    [KalanMiktar] int  NOT NULL,
    [KategoriNo] nvarchar(50)  NULL
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

-- Creating table 'WebUser'
CREATE TABLE [dbo].[WebUser] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(50)  NULL,
    [Pass] nvarchar(50)  NULL,
    [Name] nvarchar(50)  NULL,
    [Surname] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ArizaliUrun'
ALTER TABLE [dbo].[ArizaliUrun]
ADD CONSTRAINT [PK_ArizaliUrun]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [KategoriNo] in table 'KategoriTablo'
ALTER TABLE [dbo].[KategoriTablo]
ADD CONSTRAINT [PK_KategoriTablo]
    PRIMARY KEY CLUSTERED ([KategoriNo] ASC);
GO

-- Creating primary key on [SicilNo] in table 'Kullanicilar'
ALTER TABLE [dbo].[Kullanicilar]
ADD CONSTRAINT [PK_Kullanicilar]
    PRIMARY KEY CLUSTERED ([SicilNo] ASC);
GO

-- Creating primary key on [id] in table 'Servis'
ALTER TABLE [dbo].[Servis]
ADD CONSTRAINT [PK_Servis]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'StokGirisCikis'
ALTER TABLE [dbo].[StokGirisCikis]
ADD CONSTRAINT [PK_StokGirisCikis]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StokTabloSatici'
ALTER TABLE [dbo].[StokTabloSatici]
ADD CONSTRAINT [PK_StokTabloSatici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'WebUser'
ALTER TABLE [dbo].[WebUser]
ADD CONSTRAINT [PK_WebUser]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KategoriNo] in table 'StokTabloSatici'
ALTER TABLE [dbo].[StokTabloSatici]
ADD CONSTRAINT [FK_StokTabloSatici_KategoriTablo]
    FOREIGN KEY ([KategoriNo])
    REFERENCES [dbo].[KategoriTablo]
        ([KategoriNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StokTabloSatici_KategoriTablo'
CREATE INDEX [IX_FK_StokTabloSatici_KategoriTablo]
ON [dbo].[StokTabloSatici]
    ([KategoriNo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
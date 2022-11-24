
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/07/2022 13:06:56
-- Generated from EDMX file: C:\Users\328-6\Documents\Таскаев\LABA10\lab\Model\LanguageModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [user3];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CourseLanguage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseSet] DROP CONSTRAINT [FK_CourseLanguage];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseTeacher_Course]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseTeacher] DROP CONSTRAINT [FK_CourseTeacher_Course];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseTeacher_Teacher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseTeacher] DROP CONSTRAINT [FK_CourseTeacher_Teacher];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CourseSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseSet];
GO
IF OBJECT_ID(N'[dbo].[LanguageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LanguageSet];
GO
IF OBJECT_ID(N'[dbo].[TeacherSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeacherSet];
GO
IF OBJECT_ID(N'[dbo].[CourseTeacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseTeacher];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CourseSet'
CREATE TABLE [dbo].[CourseSet] (
    [CourseId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [Language_LanguageId] int  NOT NULL
);
GO

-- Creating table 'LanguageSet'
CREATE TABLE [dbo].[LanguageSet] (
    [LanguageId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'TeacherSet'
CREATE TABLE [dbo].[TeacherSet] (
    [TeacherId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Surname] nvarchar(200)  NOT NULL,
    [Phone] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'CourseTeacher'
CREATE TABLE [dbo].[CourseTeacher] (
    [Courses_CourseId] int  NOT NULL,
    [Teacher_TeacherId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CourseId] in table 'CourseSet'
ALTER TABLE [dbo].[CourseSet]
ADD CONSTRAINT [PK_CourseSet]
    PRIMARY KEY CLUSTERED ([CourseId] ASC);
GO

-- Creating primary key on [LanguageId] in table 'LanguageSet'
ALTER TABLE [dbo].[LanguageSet]
ADD CONSTRAINT [PK_LanguageSet]
    PRIMARY KEY CLUSTERED ([LanguageId] ASC);
GO

-- Creating primary key on [TeacherId] in table 'TeacherSet'
ALTER TABLE [dbo].[TeacherSet]
ADD CONSTRAINT [PK_TeacherSet]
    PRIMARY KEY CLUSTERED ([TeacherId] ASC);
GO

-- Creating primary key on [Courses_CourseId], [Teacher_TeacherId] in table 'CourseTeacher'
ALTER TABLE [dbo].[CourseTeacher]
ADD CONSTRAINT [PK_CourseTeacher]
    PRIMARY KEY CLUSTERED ([Courses_CourseId], [Teacher_TeacherId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Language_LanguageId] in table 'CourseSet'
ALTER TABLE [dbo].[CourseSet]
ADD CONSTRAINT [FK_CourseLanguage]
    FOREIGN KEY ([Language_LanguageId])
    REFERENCES [dbo].[LanguageSet]
        ([LanguageId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseLanguage'
CREATE INDEX [IX_FK_CourseLanguage]
ON [dbo].[CourseSet]
    ([Language_LanguageId]);
GO

-- Creating foreign key on [Courses_CourseId] in table 'CourseTeacher'
ALTER TABLE [dbo].[CourseTeacher]
ADD CONSTRAINT [FK_CourseTeacher_Course]
    FOREIGN KEY ([Courses_CourseId])
    REFERENCES [dbo].[CourseSet]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Teacher_TeacherId] in table 'CourseTeacher'
ALTER TABLE [dbo].[CourseTeacher]
ADD CONSTRAINT [FK_CourseTeacher_Teacher]
    FOREIGN KEY ([Teacher_TeacherId])
    REFERENCES [dbo].[TeacherSet]
        ([TeacherId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseTeacher_Teacher'
CREATE INDEX [IX_FK_CourseTeacher_Teacher]
ON [dbo].[CourseTeacher]
    ([Teacher_TeacherId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
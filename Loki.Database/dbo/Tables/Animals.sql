CREATE TABLE [dbo].[Animals] (
    [Id]           INT                IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX)     NOT NULL,
    [Continents]   NVARCHAR (MAX)     NOT NULL,
    [Habitat]      NVARCHAR (MAX)     NOT NULL,
    [Food]         NVARCHAR (MAX)     NOT NULL,
    [Health]       INT                DEFAULT (50) NOT NULL,
    [Attack]       INT                DEFAULT (50) NOT NULL,
    [Defence]      INT                DEFAULT (50) NOT NULL,
    [Speed]        INT                DEFAULT (50) NOT NULL,
    [Stamina]      INT                DEFAULT (50) NOT NULL,
    [Intelligence] INT                DEFAULT (50) NOT NULL,
    [DateCreated]  DATETIMEOFFSET (7) DEFAULT (getutcdate()) NOT NULL,
    [DateModified] DATETIMEOFFSET (7) NULL,
    [DateDeleted]  DATETIMEOFFSET (7) NULL,
    [IsDeleted]    BIT                DEFAULT (CONVERT([bit],(0))) NOT NULL,
    CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [health_range] CHECK ([Health] >= 1 AND [Health] <= 100),
    CONSTRAINT [attack_range] CHECK ([Attack] >= 1 AND [Attack] <= 100),
    CONSTRAINT [defence_range] CHECK ([Defence] >= 1 AND [Defence] <= 100),
    CONSTRAINT [speed_range] CHECK ([Speed] >= 1 AND [Speed] <= 100),
    CONSTRAINT [stamina_range] CHECK ([Stamina] >= 1 AND [Stamina] <= 100),
    CONSTRAINT [intelligence_range] CHECK ([Intelligence] >= 1 AND [Intelligence] <= 100),
);

GO
CREATE NONCLUSTERED INDEX [IX_Animals_IsDeleted]
    ON [dbo].[Animals]([IsDeleted] ASC);


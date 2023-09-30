CREATE TABLE [dbo].[Animals] (
    [Id]           INT                IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX)     NOT NULL,
    [Continents]   NVARCHAR (MAX)     NOT NULL,
    [Habitat]      NVARCHAR (MAX)     NOT NULL,
    [Food]         NVARCHAR (MAX)     NOT NULL,
    [DateCreated]  DATETIMEOFFSET (7) DEFAULT (getutcdate()) NOT NULL,
    [DateModified] DATETIMEOFFSET (7) NULL,
    [DateDeleted]  DATETIMEOFFSET (7) NULL,
    [IsDeleted]    BIT                DEFAULT (CONVERT([bit],(0))) NOT NULL,
    CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Animals_IsDeleted]
    ON [dbo].[Animals]([IsDeleted] ASC);


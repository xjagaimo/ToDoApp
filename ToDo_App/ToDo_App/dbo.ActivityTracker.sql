CREATE TABLE [dbo].[ActivityTracker] (
    [Id]        INT           NULL ,
    [Aktivitas] VARCHAR (100) NOT NULL,
    [Selesai]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


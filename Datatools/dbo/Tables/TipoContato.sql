CREATE TABLE [dbo].[TipoContato] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [tipo]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


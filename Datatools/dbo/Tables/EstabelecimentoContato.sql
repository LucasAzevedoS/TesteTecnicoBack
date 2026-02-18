CREATE TABLE [dbo].[EstabelecimentoContato] (
    [id]                INT            IDENTITY (1, 1) NOT NULL,
    [idEstabelecimento] INT            NULL,
    [contato]           NVARCHAR (255) NULL,
    [idTipoContato]     INT            NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([idEstabelecimento]) REFERENCES [dbo].[Estabelecimento] ([id]),
    FOREIGN KEY ([idEstabelecimento]) REFERENCES [dbo].[Estabelecimento] ([id]),
    FOREIGN KEY ([idEstabelecimento]) REFERENCES [dbo].[Estabelecimento] ([id]),
    FOREIGN KEY ([idTipoContato]) REFERENCES [dbo].[TipoContato] ([id]),
    FOREIGN KEY ([idTipoContato]) REFERENCES [dbo].[TipoContato] ([id]),
    FOREIGN KEY ([idTipoContato]) REFERENCES [dbo].[TipoContato] ([id])
);


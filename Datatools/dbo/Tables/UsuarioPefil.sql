CREATE TABLE [dbo].[UsuarioPefil] (
    [idUsuario]         INT NULL,
    [idPerfil]          INT NULL,
    [idEstabelecimento] INT NULL,
    FOREIGN KEY ([idEstabelecimento]) REFERENCES [dbo].[Estabelecimento] ([id]),
    FOREIGN KEY ([idEstabelecimento]) REFERENCES [dbo].[Estabelecimento] ([id]),
    FOREIGN KEY ([idPerfil]) REFERENCES [dbo].[Perfil] ([id]),
    FOREIGN KEY ([idPerfil]) REFERENCES [dbo].[Perfil] ([id]),
    FOREIGN KEY ([idUsuario]) REFERENCES [dbo].[Usuario] ([id]),
    FOREIGN KEY ([idUsuario]) REFERENCES [dbo].[Usuario] ([id])
);


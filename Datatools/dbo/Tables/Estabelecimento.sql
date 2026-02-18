CREATE TABLE [dbo].[Estabelecimento] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [nome]      NVARCHAR (255) NULL,
    [descricao] NVARCHAR (MAX) NULL,
    [endereco]  NVARCHAR (255) NULL,
    [cep]       NVARCHAR (10)  NULL,
    [cidade]    NVARCHAR (50)  NULL,
    [estado]        NCHAR (2)      NULL,
    [banner] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
);



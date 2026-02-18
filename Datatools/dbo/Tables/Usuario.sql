CREATE TABLE [dbo].[Usuario] (
    [id]       INT            IDENTITY (1, 1) NOT NULL,
    [dtCriacao] DATETIME       DEFAULT (getdate()) NULL,
    [nome]     NVARCHAR (150) NULL,
    [email]    NVARCHAR (150) NULL,
    [celular]  NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


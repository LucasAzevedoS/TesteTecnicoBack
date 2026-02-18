CREATE TABLE [dbo].[Reuniao]
(
	
    id INT IDENTITY(1,1) PRIMARY KEY,
    nomeReuniao NVARCHAR(255) NOT NULL,
    dsReuniao NVARCHAR(255) NOT NULL,
    cep NVARCHAR(9),
    endereco NVARCHAR(255),
    numeroEndereco NVARCHAR(15),
    complemento NVARCHAR(255),
    bairro NVARCHAR(100),
    cidade NVARCHAR(100),
    uf CHAR(2),
    idGrupo INT NOT NULL,
    CONSTRAINT FK_Reuniao_Grupo FOREIGN KEY (idGrupo) REFERENCES Grupo(id)
);



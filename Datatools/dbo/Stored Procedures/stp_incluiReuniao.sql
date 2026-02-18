CREATE PROCEDURE [dbo].[stp_incluiReuniao]
    @id INT,
    @nomeReuniao NVARCHAR(255),
    @dsReuniao NVARCHAR(255),
    @cep NVARCHAR(9) = NULL,
    @endereco NVARCHAR(255) = NULL,
    @numeroEndereco NVARCHAR(15) = NULL,
    @complemento NVARCHAR(255) = NULL,
    @bairro NVARCHAR(100) = NULL,
    @cidade NVARCHAR(100) = NULL,
    @uf CHAR(2) = NULL,
    @idGrupo INT
AS
BEGIN
    DECLARE @iId INT;
    DECLARE @exists INT;

    SELECT @exists = COUNT(*) FROM Reuniao WHERE id = @id;

    IF @id IS NULL OR @exists = 0
    BEGIN
        INSERT INTO Reuniao (
            nomeReuniao,
            dsReuniao,
            cep,
            endereco,
            numeroEndereco,
            complemento,
            bairro,
            cidade,
            uf,
            idGrupo
        )
        VALUES (
            @nomeReuniao,
            @dsReuniao,
            @cep,
            @endereco,
            @numeroEndereco,
            @complemento,
            @bairro,
            @cidade,
            @uf,
            @idGrupo
        );

        SET @iId = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        UPDATE Reuniao
        SET
            nomeReuniao = @nomeReuniao,
            dsReuniao = @dsReuniao,
            cep = @cep,
            endereco = @endereco,
            numeroEndereco = @numeroEndereco,
            complemento = @complemento,
            bairro = @bairro,
            cidade = @cidade,
            uf = @uf,
            idGrupo = @idGrupo
        WHERE id = @id;

        SET @iId = @id;
    END

    SELECT * FROM Reuniao WHERE id = @iId;
END

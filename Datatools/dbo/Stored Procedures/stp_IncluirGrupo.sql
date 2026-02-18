CREATE PROCEDURE [dbo].[stp_incluirGrupo]
    @id INT,
    @dsGrupo VARCHAR(255),
    @flAtivo BIT
AS
BEGIN
    DECLARE @iId INT;

    IF @id IS NULL OR NOT EXISTS (SELECT 1 FROM Grupo WHERE id = @id)
    BEGIN
        INSERT INTO Grupo (dsGrupo, flAtivo)
        VALUES (@dsGrupo, @flAtivo);

        SET @iId = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        UPDATE Grupo
        SET dsGrupo = @dsGrupo,
            flAtivo = @flAtivo
        WHERE id = @id;

        SET @iId = @id;
    END

    SELECT * FROM Grupo WHERE id = @iId;
END
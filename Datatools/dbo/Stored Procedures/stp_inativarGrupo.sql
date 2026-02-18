CREATE PROCEDURE [dbo].[stp_inativarGrupo]
    @id INT
AS
BEGIN
    -- Verifica se o grupo existe
    IF EXISTS (SELECT 1 FROM Grupo WHERE id = @id)
    BEGIN
        UPDATE Grupo
        SET flAtivo = 0
        WHERE id = @id;

        SELECT * FROM Grupo WHERE id = @id;
    END
    ELSE
    BEGIN
        -- Retorna um erro customizado se o grupo não for encontrado
        RAISERROR('Grupo não encontrado com o ID fornecido.', 16, 1);
    END
END

SELECT * FROM Grupo


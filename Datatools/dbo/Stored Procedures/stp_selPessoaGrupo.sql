CREATE PROCEDURE [dbo].[stp_selPessoaGrupo]
    @id INT
AS
BEGIN
    SELECT * 
    FROM Pessoa 
    WHERE Grupo = @id
END



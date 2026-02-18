
Create procedure [dbo].[stp_incluiEstabelecimento]
@id int = null
,@Nome nvarchar(255)
,@Descricao nvarchar(255)
,@Endereco nvarchar(255)
,@Cep nvarchar(20)
,@Cidade nvarchar(255)
,@Estado nvarchar(255)
,@Banner nvarchar(MAX)

as begin

declare @iId int = 0

    IF @id is NULL
    Begin
        Insert into Estabelecimento (nome,descricao,endereco,cep,cidade,estado,banner)
        Values(@Nome,@Descricao,@Endereco,@Cep,@Cidade,@Estado,@Banner)

        set @iId = SCOPE_IDENTITY()
    End
    ELSE
    Begin
        Update Estabelecimento 
        set Nome = @Nome,
            Descricao = @Descricao,
            Endereco = @Endereco,
            Cep = @Cep,
            Cidade = @Cidade,
            Estado = @Estado,
            Banner = @Banner
        where id = @id
    set @iId = @id
    end

    select * from Estabelecimento where id = @iId
   
end
GO

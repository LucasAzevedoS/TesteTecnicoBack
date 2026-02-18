CREATE PROCEDURE [dbo].[stp_incluiPessoa]
	@Nome nvarchar(255) = null,
    @Idade int = null

AS Begin

declare @Id int = 0


    if exists (select 1 from Pessoa where CPF = @cpf)
        Begin
            update Pessoa set
            Nome = @Nome 
            ,Email = @Email 
            ,celular = @celular 
            ,dtNascimento = @dtnascimento 
            ,Grupo = @grupo 
            ,CPF = @cpf 
            ,telefone = @telefone
            ,cadUnico = @cadUnico 
            ,tituloEleitor = @tituloEleitor 
            ,reservista = @reservista 
            ,cohab = @cohab 
            ,EstadoCivil = @estadoCivil 
            ,Conjuge = @Conjuge 
            ,filhos = @filhos 
            ,filhosMenores = @filhosMenores 
            ,cep = @cep 
            ,endereco = @endereco 
            ,numeroEndereco = @numeroEndereco 
            ,complemento = @complemento 
            ,bairro = @bairro 
            ,cidade = @cidade 
            ,uf = @uf 
            where CPF = @cpf

            select @iId = id from Pessoa where CPF = @cpf
        End
    else
        Begin
	        insert into Pessoa(Nome
)
            values(
            @Nome 
            ,@Idade
)

        set @Id = SCOPE_IDENTITY()
    End
End

create procedure stp_selPessoa
@id int = null,
@Nome nvarchar(255) = null, 
@email nvarchar(255) = null, 
@grupo int = null        
,@cpf nvarchar(100) = NUll
,@page nvarchar(100) = NUll
,@limit int = 0
,@sortBy nvarchar(100) = NUll
,@sortOrder nvarchar(100) = NUll
as
BEGIN
	
set @cpf = replace(replace(@cpf,'/',''),'-','')
if @grupo = 0
	set @grupo = null
	
	if @id > 0

		select * from Pessoa where id = @id

	else 
	
	select 
    a.id        
    ,dtCriacao  
    ,Nome 
    ,Email 
    ,celular 
    ,dtNascimento 
    ,b.dsGrupo as Grupo 
    ,e.dsEstadoCivil as EstadoCivil 
    ,CPF 
    ,telefone 
    ,cadUnico  
    ,tituloEleitor  
    ,reservista 
    ,cohab  
    ,Conjuge  
    ,filhos 
    ,filhosMenores 
    ,cep  
    ,endereco  
    ,numeroEndereco  
    ,complemento  
    ,bairro  
    ,cidade  
    ,uf 
    from pessoa a
    inner join EstadoCivil e on a.EstadoCivil = e.id
	inner join grupo b on a.Grupo = b.Id
	where (@Nome is null or Nome like '%'+@Nome+'%') And 
			(@email is null or Email = @email ) and 
			(@grupo  is null or Grupo = @Grupo ) and
			(@cpf is null or CPF = @cpf  ) 


End

CREATE procedure stp_selEstabelecimento
@id int = null
as
BEGIN
if @id = 0
set @id = null
select * from Estabelecimento 
where (@id is null or id = @id)
End
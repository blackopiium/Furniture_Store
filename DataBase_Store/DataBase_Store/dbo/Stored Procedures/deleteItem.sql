create procedure deleteItem
@Id_Item nchar(5)
as
delete Items 
where Items.Id_Item=@Id_Item
create procedure updateItem
@Id_Update nchar(5),
@Id_Item nchar(5),
@Id_Name nchar(100),
@Id_Category nchar(5),
@Price money,
@Id_Factory nchar(5)
as
update Items 
set 
Id_Item=@Id_Item,
Id_Name=@Id_Name, 
Id_Category=@Id_Category, 
Price=@Price, 
Id_Factory=@Id_Factory
where Items.Id_Item=@Id_Update
create procedure createItem
@Id_Item nchar(5),
@Id_Name nchar(100),
@Id_Category nchar(5),
@Price money,
@Id_Factory nchar(5)
as
insert into Items (Id_Item, Id_Name, Id_Category, Price, Id_Factory)
values (@Id_Item, @Id_Name, @Id_Category, @Price, @Id_Factory)
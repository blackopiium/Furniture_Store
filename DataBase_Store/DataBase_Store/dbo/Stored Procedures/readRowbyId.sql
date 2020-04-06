create procedure readRowbyId
@Id_Item int
as 
select it.Id_Item, it.Id_Name, it.Price, it.Id_Category, it.Id_Factory, ch.Width_it, ch.Colour_it, ch.Height_it, ch.Length_it, ord.Id_Order
from [items] it inner join [Charasteritics_Item] ch on it.Id_Item=ch.Id_Item
inner join [Order_Items] ord on ch.Id_Item=ord.Id_Item
where it.Id_Item=@Id_Item
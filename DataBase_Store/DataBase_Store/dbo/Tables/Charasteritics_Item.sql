create table Charasteritics_Item
(
Id_Item INT not null unique,
Width_it int null,
Height_it int null,
Length_it int null,
Colour_it nchar(25) null,
Foreign key(Id_Item) references Items
)
create table Order_Items
(
Id_Order INT not null,
Id_Item INT not null,
Count_of_item int not null,
Foreign key(Id_Order) references Orders,
Foreign key(Id_Item) references Items
)
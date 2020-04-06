create table Items
(
Id_Item INT not null,
Id_Name nchar(100) not null,
Id_Category INT not null,
Price money not null,
Id_Factory INT not null,
Primary key(Id_Item),
Foreign key(Id_Category) references Category,
Foreign key(Id_Factory) references Factory
)
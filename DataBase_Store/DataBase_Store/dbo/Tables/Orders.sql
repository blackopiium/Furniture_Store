create table Orders
(
Id_Order INT not null unique,
Id_Client INT not null unique,
Price money not null,
Country nchar(15) not null,
City nchar(20) not null,
Street nchar(20) not null,
Apartment int not null,
Primary key(Id_Order),
Foreign key (Id_Client) references Client
)
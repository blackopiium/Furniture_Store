create table Client
(
Id_Client INT not null,
LastName nchar(20) not null,
FirstName nchar(20) not null,
MiddleName nchar(25) null,
Phone_number nchar(12) null,
E_mail nchar(30) not null,
Id_Order int not null,
Primary key(Id_client)
)
create table Factory
(
Id_Factory INT not null,
Country nchar(100) not null,
City nchar(100) not null,
Description_Fact nvarchar(max) null,
Primary key(Id_Factory)
)
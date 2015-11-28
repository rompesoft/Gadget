Create Table [User]
(
	[Id] Int Not Null Identity(1,1),
	[Name] Varchar(100) Not Null,
	[Last_Name] Varchar(100) Not Null,
	[Maternal_Surname] Varchar(100) Null,
	[Username] Varchar(50) Collate Latin1_General_CS_AS Not Null,
	[Password] Varchar (Max) Not Null,
	[Condition] Varchar(20) Not Null,
	Primary Key([Id])
)
Go
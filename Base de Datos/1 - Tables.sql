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

Create Table [Option]
(
	[Id] Int Not Null Identity(1,1),
	[Name] Varchar(100) Not Null,
	[Condition] Varchar(20) Not Null,
	Primary Key([Id])
)
Go

Create Table [Privilege]
(
	[Id] Int Not Null Identity(1,1),
	[User_Id] Int Not Null,
	[Option_Id] Int Not Null,
	[Condition] Varchar(20) Not Null,
	Primary Key([Id]),
	Foreign Key([User_Id]) References [User]([Id]),
	Foreign Key([Option_Id]) References [Option]([Id])
)
Go

Create Table [Company]
(
	[Id] Int Not Null Identity(1,1),
	[Owner] Varchar(300) Not Null,
	[Business_Name] Varchar(200) Not Null,
	[Nit] Varchar(20) Not Null,
	[Economic_Activity] Varchar(MAX) Not Null,
	[Condition] Varchar(20) Not Null,
	Primary Key(Id)
)
Go

Create Table Branch_Office
(
	[Id] Int Not Null Identity(1,1),
	[Company_Id] Int Not Null,
	[Number] Varchar(3) Not Null,
	[Address] Varchar(MAX) Not Null,
	[Phone] Varchar(20) Not Null,
	[Municipality] Varchar(100) Not Null,
	[Condition] Varchar(20) Not Null,
	Primary Key([Id]),
	Foreign Key([Company_Id]) References Company([Id])
)
Go

Create Table [Dosage]
(
	[Id] Int Not Null Identity(1,1),
	[Branch_Office_Id] Int Not Null,
	[Authorization_Number] Varchar(15) Not Null,
	[Key] Varchar(256) Not Null,
	[Emission_Deadline] Date Not Null,
	[Legend] Varchar(MAX) Not Null,
	[Condition] Varchar(20) Not Null,
	Primary Key([Id]),
	Foreign Key([Branch_Office_Id]) References [Branch_Office]([Id])
)
Go

Create Table [Provider]
(
	[Id] Int Not Null Identity(1,1),
	[Nit] Varchar(12) Not Null,
	[Name] Varchar(300) Not Null,
	[Location] Varchar(150) Null,
	[Condition] Varchar(20) Not Null,
	Primary Key([Id])
)
Go

Create Table [Client]
(
	[Id] Int Not Null Identity(1,1),
	[Ci_Or_Nit] Varchar(12) Not Null,
	[Name] Varchar(300) Not Null,
	[Condition] Varchar(20) Not Null,
	Primary Key([Id])
)
Go

Create Table [Group]
(
	[Id] Int Not Null Identity(1,1),
	[Name] Varchar(100) Not Null,
	[Condition] Varchar(20) Not Null,
	Primary Key([Id])
)
Go

Create Table [Product]
(
	[Id] Int Not Null Identity(1,1),
	[Group_Id] Int Not Null,
	[Barcode_Type] Varchar(15) Not Null,
	[Barcode] Varchar(100) Not Null,
	[Name] Varchar(100) Not Null,
	[Brand] Varchar(100) Null,
	[Model] Varchar(100) Null,
	[Color] Varchar(100) Null,
	[Purchase_Price] Decimal(18,2) Not Null,
	[Sale_Price] Decimal (18,2) Not Null,
	[Warraty_Time] Int Not Null,
	[Condition] Varchar(20) Not Null,
	Primary Key([Id])
)
Go
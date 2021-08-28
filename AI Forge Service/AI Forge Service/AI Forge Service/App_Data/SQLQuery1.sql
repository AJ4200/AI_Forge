CREATE TABLE [dbo].[User]
(
	[User_Id] INT NOT NULL PRIMARY KEY,
	[User_Name] varchar(50) not null,
	[User_Surname] varchar(50) not null,
	[User_Email] varchar(50) not null,
	[User_Contact] numeric not null,
	[User_Gender] varchar(2) not null,
	[User_DOB] date null,
	[User_Address] varchar(50) not null,
	[User_UserName] varchar(50) not null,
	[User_Password] varchar(50) not null,
	[ProductT_ID] int not null,
	[Product_Active] int not null,
	[User_Type] varchar(50) not null,
	foreign key(ProductT_ID) references Product_Type
)

CREATE TABLE [dbo].[Product_Type]
(
	[ProductT_Id] INT NOT NULL PRIMARY KEY,
	[ProductT_Name] varchar(50) not null,
)

CREATE TABLE [dbo].[Product]
(
	[Product_Id] INT NOT NULL PRIMARY KEY,
	[ProductT_ID] int not null,
	[Product_Name] varchar(50) not null,
	[Product_Price] money not null,
	[Product_Description] varchar(150) not null,
	[Product_Dimensions] varchar(150) not null,
	[Product_Category] varchar(150) not null,
	[Product_Quantity] int not null,
	[Product_Sale] int,
	[Product_SalePrice] money,
	[Product_SaleDescription] varchar(150),
	[Product_Deleted] int,
	foreign key(ProductT_ID) references Product_Type
)

CREATE TABLE [dbo].[Invoice_Line]
(
	[InvoiceL_Id] INT NOT NULL PRIMARY KEY,
	[InvoiceL_Quantity] INT NOT NULL,
	[InvoiceL_Price] money NOT NULL,
	[InvoiceL_Tax] money NOT NULL,
	[Product_Id] INT NOT NULL,

	foreign key(Product_Id) references Product
)

CREATE TABLE [dbo].[Invoice]
(
	[Invoice_Id] INT NOT NULL PRIMARY KEY,
	[InvoiceL_Id] INT NOT NULL,
	[User_Id] INT NOT NULL,
	[Invoice_Date] date not null,
	foreign key(User_Id) references [dbo].[User],
	foreign key(InvoiceL_Id) references Invoice_Line
)
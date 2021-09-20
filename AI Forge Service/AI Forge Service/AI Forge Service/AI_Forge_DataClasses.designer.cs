﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AI_Forge_Service
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AI_Forge_Database")]
	public partial class AI_Forge_DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSale(Sale instance);
    partial void UpdateSale(Sale instance);
    partial void DeleteSale(Sale instance);
    partial void InsertInvoice_Line(Invoice_Line instance);
    partial void UpdateInvoice_Line(Invoice_Line instance);
    partial void DeleteInvoice_Line(Invoice_Line instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertInvoice(Invoice instance);
    partial void UpdateInvoice(Invoice instance);
    partial void DeleteInvoice(Invoice instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    #endregion
		
		public AI_Forge_DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AI_Forge_DatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AI_Forge_DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AI_Forge_DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AI_Forge_DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AI_Forge_DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Sale> Sales
		{
			get
			{
				return this.GetTable<Sale>();
			}
		}
		
		public System.Data.Linq.Table<Invoice_Line> Invoice_Lines
		{
			get
			{
				return this.GetTable<Invoice_Line>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Invoice> Invoices
		{
			get
			{
				return this.GetTable<Invoice>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sale")]
	public partial class Sale : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SLE_ID;
		
		private string _SLE_Name;
		
		private byte _SLE_Value;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSLE_IDChanging(int value);
    partial void OnSLE_IDChanged();
    partial void OnSLE_NameChanging(string value);
    partial void OnSLE_NameChanged();
    partial void OnSLE_ValueChanging(byte value);
    partial void OnSLE_ValueChanged();
    #endregion
		
		public Sale()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLE_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SLE_ID
		{
			get
			{
				return this._SLE_ID;
			}
			set
			{
				if ((this._SLE_ID != value))
				{
					this.OnSLE_IDChanging(value);
					this.SendPropertyChanging();
					this._SLE_ID = value;
					this.SendPropertyChanged("SLE_ID");
					this.OnSLE_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLE_Name", DbType="VarChar(100)")]
		public string SLE_Name
		{
			get
			{
				return this._SLE_Name;
			}
			set
			{
				if ((this._SLE_Name != value))
				{
					this.OnSLE_NameChanging(value);
					this.SendPropertyChanging();
					this._SLE_Name = value;
					this.SendPropertyChanged("SLE_Name");
					this.OnSLE_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLE_Value", DbType="TinyInt NOT NULL")]
		public byte SLE_Value
		{
			get
			{
				return this._SLE_Value;
			}
			set
			{
				if ((this._SLE_Value != value))
				{
					this.OnSLE_ValueChanging(value);
					this.SendPropertyChanging();
					this._SLE_Value = value;
					this.SendPropertyChanged("SLE_Value");
					this.OnSLE_ValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sale_Product", Storage="_Products", ThisKey="SLE_ID", OtherKey="SLE_ID")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Sale = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Sale = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Invoice_Line")]
	public partial class Invoice_Line : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _InvoiceL_Id;
		
		private int _InvoiceL_Quantity;
		
		private decimal _InvoiceL_Price;
		
		private int _PROD_ID;
		
		private int _Invoice_Id;
		
		private EntityRef<Invoice> _Invoice;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInvoiceL_IdChanging(int value);
    partial void OnInvoiceL_IdChanged();
    partial void OnInvoiceL_QuantityChanging(int value);
    partial void OnInvoiceL_QuantityChanged();
    partial void OnInvoiceL_PriceChanging(decimal value);
    partial void OnInvoiceL_PriceChanged();
    partial void OnPROD_IDChanging(int value);
    partial void OnPROD_IDChanged();
    partial void OnInvoice_IdChanging(int value);
    partial void OnInvoice_IdChanged();
    #endregion
		
		public Invoice_Line()
		{
			this._Invoice = default(EntityRef<Invoice>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvoiceL_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int InvoiceL_Id
		{
			get
			{
				return this._InvoiceL_Id;
			}
			set
			{
				if ((this._InvoiceL_Id != value))
				{
					this.OnInvoiceL_IdChanging(value);
					this.SendPropertyChanging();
					this._InvoiceL_Id = value;
					this.SendPropertyChanged("InvoiceL_Id");
					this.OnInvoiceL_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvoiceL_Quantity", DbType="Int NOT NULL")]
		public int InvoiceL_Quantity
		{
			get
			{
				return this._InvoiceL_Quantity;
			}
			set
			{
				if ((this._InvoiceL_Quantity != value))
				{
					this.OnInvoiceL_QuantityChanging(value);
					this.SendPropertyChanging();
					this._InvoiceL_Quantity = value;
					this.SendPropertyChanged("InvoiceL_Quantity");
					this.OnInvoiceL_QuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvoiceL_Price", DbType="Money NOT NULL")]
		public decimal InvoiceL_Price
		{
			get
			{
				return this._InvoiceL_Price;
			}
			set
			{
				if ((this._InvoiceL_Price != value))
				{
					this.OnInvoiceL_PriceChanging(value);
					this.SendPropertyChanging();
					this._InvoiceL_Price = value;
					this.SendPropertyChanged("InvoiceL_Price");
					this.OnInvoiceL_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_ID", DbType="Int NOT NULL")]
		public int PROD_ID
		{
			get
			{
				return this._PROD_ID;
			}
			set
			{
				if ((this._PROD_ID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPROD_IDChanging(value);
					this.SendPropertyChanging();
					this._PROD_ID = value;
					this.SendPropertyChanged("PROD_ID");
					this.OnPROD_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_Id", DbType="Int NOT NULL")]
		public int Invoice_Id
		{
			get
			{
				return this._Invoice_Id;
			}
			set
			{
				if ((this._Invoice_Id != value))
				{
					if (this._Invoice.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnInvoice_IdChanging(value);
					this.SendPropertyChanging();
					this._Invoice_Id = value;
					this.SendPropertyChanged("Invoice_Id");
					this.OnInvoice_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Invoice_Invoice_Line", Storage="_Invoice", ThisKey="Invoice_Id", OtherKey="Invoice_Id", IsForeignKey=true)]
		public Invoice Invoice
		{
			get
			{
				return this._Invoice.Entity;
			}
			set
			{
				Invoice previousValue = this._Invoice.Entity;
				if (((previousValue != value) 
							|| (this._Invoice.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Invoice.Entity = null;
						previousValue.Invoice_Lines.Remove(this);
					}
					this._Invoice.Entity = value;
					if ((value != null))
					{
						value.Invoice_Lines.Add(this);
						this._Invoice_Id = value.Invoice_Id;
					}
					else
					{
						this._Invoice_Id = default(int);
					}
					this.SendPropertyChanged("Invoice");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Invoice_Line", Storage="_Product", ThisKey="PROD_ID", OtherKey="PROD_ID", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Invoice_Lines.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Invoice_Lines.Add(this);
						this._PROD_ID = value.PROD_ID;
					}
					else
					{
						this._PROD_ID = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User_Id;
		
		private string _User_Name;
		
		private string _User_Surname;
		
		private string _User_Email;
		
		private string _User_Contact;
		
		private char _User_Gender;
		
		private System.Nullable<System.DateTime> _User_DOB;
		
		private string _User_Address;
		
		private string _User_Password;
		
		private bool _User_Active;
		
		private string _User_Type;
		
		private EntitySet<Invoice> _Invoices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IdChanging(int value);
    partial void OnUser_IdChanged();
    partial void OnUser_NameChanging(string value);
    partial void OnUser_NameChanged();
    partial void OnUser_SurnameChanging(string value);
    partial void OnUser_SurnameChanged();
    partial void OnUser_EmailChanging(string value);
    partial void OnUser_EmailChanged();
    partial void OnUser_ContactChanging(string value);
    partial void OnUser_ContactChanged();
    partial void OnUser_GenderChanging(char value);
    partial void OnUser_GenderChanged();
    partial void OnUser_DOBChanging(System.Nullable<System.DateTime> value);
    partial void OnUser_DOBChanged();
    partial void OnUser_AddressChanging(string value);
    partial void OnUser_AddressChanged();
    partial void OnUser_PasswordChanging(string value);
    partial void OnUser_PasswordChanged();
    partial void OnUser_ActiveChanging(bool value);
    partial void OnUser_ActiveChanged();
    partial void OnUser_TypeChanging(string value);
    partial void OnUser_TypeChanged();
    #endregion
		
		public User()
		{
			this._Invoices = new EntitySet<Invoice>(new Action<Invoice>(this.attach_Invoices), new Action<Invoice>(this.detach_Invoices));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					this.OnUser_IdChanging(value);
					this.SendPropertyChanging();
					this._User_Id = value;
					this.SendPropertyChanged("User_Id");
					this.OnUser_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string User_Name
		{
			get
			{
				return this._User_Name;
			}
			set
			{
				if ((this._User_Name != value))
				{
					this.OnUser_NameChanging(value);
					this.SendPropertyChanging();
					this._User_Name = value;
					this.SendPropertyChanged("User_Name");
					this.OnUser_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Surname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string User_Surname
		{
			get
			{
				return this._User_Surname;
			}
			set
			{
				if ((this._User_Surname != value))
				{
					this.OnUser_SurnameChanging(value);
					this.SendPropertyChanging();
					this._User_Surname = value;
					this.SendPropertyChanged("User_Surname");
					this.OnUser_SurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string User_Email
		{
			get
			{
				return this._User_Email;
			}
			set
			{
				if ((this._User_Email != value))
				{
					this.OnUser_EmailChanging(value);
					this.SendPropertyChanging();
					this._User_Email = value;
					this.SendPropertyChanged("User_Email");
					this.OnUser_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Contact", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string User_Contact
		{
			get
			{
				return this._User_Contact;
			}
			set
			{
				if ((this._User_Contact != value))
				{
					this.OnUser_ContactChanging(value);
					this.SendPropertyChanging();
					this._User_Contact = value;
					this.SendPropertyChanged("User_Contact");
					this.OnUser_ContactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Gender", DbType="Char(1) NOT NULL")]
		public char User_Gender
		{
			get
			{
				return this._User_Gender;
			}
			set
			{
				if ((this._User_Gender != value))
				{
					this.OnUser_GenderChanging(value);
					this.SendPropertyChanging();
					this._User_Gender = value;
					this.SendPropertyChanged("User_Gender");
					this.OnUser_GenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_DOB", DbType="Date")]
		public System.Nullable<System.DateTime> User_DOB
		{
			get
			{
				return this._User_DOB;
			}
			set
			{
				if ((this._User_DOB != value))
				{
					this.OnUser_DOBChanging(value);
					this.SendPropertyChanging();
					this._User_DOB = value;
					this.SendPropertyChanged("User_DOB");
					this.OnUser_DOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Address", DbType="VarChar(150)")]
		public string User_Address
		{
			get
			{
				return this._User_Address;
			}
			set
			{
				if ((this._User_Address != value))
				{
					this.OnUser_AddressChanging(value);
					this.SendPropertyChanging();
					this._User_Address = value;
					this.SendPropertyChanged("User_Address");
					this.OnUser_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Password", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string User_Password
		{
			get
			{
				return this._User_Password;
			}
			set
			{
				if ((this._User_Password != value))
				{
					this.OnUser_PasswordChanging(value);
					this.SendPropertyChanging();
					this._User_Password = value;
					this.SendPropertyChanged("User_Password");
					this.OnUser_PasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Active", DbType="Bit NOT NULL")]
		public bool User_Active
		{
			get
			{
				return this._User_Active;
			}
			set
			{
				if ((this._User_Active != value))
				{
					this.OnUser_ActiveChanging(value);
					this.SendPropertyChanging();
					this._User_Active = value;
					this.SendPropertyChanged("User_Active");
					this.OnUser_ActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Type", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string User_Type
		{
			get
			{
				return this._User_Type;
			}
			set
			{
				if ((this._User_Type != value))
				{
					this.OnUser_TypeChanging(value);
					this.SendPropertyChanging();
					this._User_Type = value;
					this.SendPropertyChanged("User_Type");
					this.OnUser_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Invoice", Storage="_Invoices", ThisKey="User_Id", OtherKey="User_Id")]
		public EntitySet<Invoice> Invoices
		{
			get
			{
				return this._Invoices;
			}
			set
			{
				this._Invoices.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Invoices(Invoice entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Invoices(Invoice entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Invoice")]
	public partial class Invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Invoice_Id;
		
		private int _User_Id;
		
		private System.DateTime _Invoice_Date;
		
		private EntitySet<Invoice_Line> _Invoice_Lines;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInvoice_IdChanging(int value);
    partial void OnInvoice_IdChanged();
    partial void OnUser_IdChanging(int value);
    partial void OnUser_IdChanged();
    partial void OnInvoice_DateChanging(System.DateTime value);
    partial void OnInvoice_DateChanged();
    #endregion
		
		public Invoice()
		{
			this._Invoice_Lines = new EntitySet<Invoice_Line>(new Action<Invoice_Line>(this.attach_Invoice_Lines), new Action<Invoice_Line>(this.detach_Invoice_Lines));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Invoice_Id
		{
			get
			{
				return this._Invoice_Id;
			}
			set
			{
				if ((this._Invoice_Id != value))
				{
					this.OnInvoice_IdChanging(value);
					this.SendPropertyChanging();
					this._Invoice_Id = value;
					this.SendPropertyChanged("Invoice_Id");
					this.OnInvoice_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", DbType="Int NOT NULL")]
		public int User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_IdChanging(value);
					this.SendPropertyChanging();
					this._User_Id = value;
					this.SendPropertyChanged("User_Id");
					this.OnUser_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_Date", DbType="Date NOT NULL")]
		public System.DateTime Invoice_Date
		{
			get
			{
				return this._Invoice_Date;
			}
			set
			{
				if ((this._Invoice_Date != value))
				{
					this.OnInvoice_DateChanging(value);
					this.SendPropertyChanging();
					this._Invoice_Date = value;
					this.SendPropertyChanged("Invoice_Date");
					this.OnInvoice_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Invoice_Invoice_Line", Storage="_Invoice_Lines", ThisKey="Invoice_Id", OtherKey="Invoice_Id")]
		public EntitySet<Invoice_Line> Invoice_Lines
		{
			get
			{
				return this._Invoice_Lines;
			}
			set
			{
				this._Invoice_Lines.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Invoice", Storage="_User", ThisKey="User_Id", OtherKey="User_Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Invoices.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Invoices.Add(this);
						this._User_Id = value.User_Id;
					}
					else
					{
						this._User_Id = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Invoice_Lines(Invoice_Line entity)
		{
			this.SendPropertyChanging();
			entity.Invoice = this;
		}
		
		private void detach_Invoice_Lines(Invoice_Line entity)
		{
			this.SendPropertyChanging();
			entity.Invoice = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PROD_ID;
		
		private string _PROD_Name;
		
		private decimal _PROD_Price;
		
		private string _PROD_Category;
		
		private byte _PROD_Height;
		
		private byte _PROD_Width;
		
		private byte _PROD_Depth;
		
		private string _PROD_Description;
		
		private string _PROD_Image_Path;
		
		private byte _PROD_Inventory;
		
		private bool _PROD_Active;
		
		private System.Nullable<int> _SLE_ID;
		
		private EntitySet<Invoice_Line> _Invoice_Lines;
		
		private EntityRef<Sale> _Sale;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPROD_IDChanging(int value);
    partial void OnPROD_IDChanged();
    partial void OnPROD_NameChanging(string value);
    partial void OnPROD_NameChanged();
    partial void OnPROD_PriceChanging(decimal value);
    partial void OnPROD_PriceChanged();
    partial void OnPROD_CategoryChanging(string value);
    partial void OnPROD_CategoryChanged();
    partial void OnPROD_HeightChanging(byte value);
    partial void OnPROD_HeightChanged();
    partial void OnPROD_WidthChanging(byte value);
    partial void OnPROD_WidthChanged();
    partial void OnPROD_DepthChanging(byte value);
    partial void OnPROD_DepthChanged();
    partial void OnPROD_DescriptionChanging(string value);
    partial void OnPROD_DescriptionChanged();
    partial void OnPROD_Image_PathChanging(string value);
    partial void OnPROD_Image_PathChanged();
    partial void OnPROD_InventoryChanging(byte value);
    partial void OnPROD_InventoryChanged();
    partial void OnPROD_ActiveChanging(bool value);
    partial void OnPROD_ActiveChanged();
    partial void OnSLE_IDChanging(System.Nullable<int> value);
    partial void OnSLE_IDChanged();
    #endregion
		
		public Product()
		{
			this._Invoice_Lines = new EntitySet<Invoice_Line>(new Action<Invoice_Line>(this.attach_Invoice_Lines), new Action<Invoice_Line>(this.detach_Invoice_Lines));
			this._Sale = default(EntityRef<Sale>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PROD_ID
		{
			get
			{
				return this._PROD_ID;
			}
			set
			{
				if ((this._PROD_ID != value))
				{
					this.OnPROD_IDChanging(value);
					this.SendPropertyChanging();
					this._PROD_ID = value;
					this.SendPropertyChanged("PROD_ID");
					this.OnPROD_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Name", DbType="VarChar(75) NOT NULL", CanBeNull=false)]
		public string PROD_Name
		{
			get
			{
				return this._PROD_Name;
			}
			set
			{
				if ((this._PROD_Name != value))
				{
					this.OnPROD_NameChanging(value);
					this.SendPropertyChanging();
					this._PROD_Name = value;
					this.SendPropertyChanged("PROD_Name");
					this.OnPROD_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Price", DbType="Money NOT NULL")]
		public decimal PROD_Price
		{
			get
			{
				return this._PROD_Price;
			}
			set
			{
				if ((this._PROD_Price != value))
				{
					this.OnPROD_PriceChanging(value);
					this.SendPropertyChanging();
					this._PROD_Price = value;
					this.SendPropertyChanged("PROD_Price");
					this.OnPROD_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Category", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PROD_Category
		{
			get
			{
				return this._PROD_Category;
			}
			set
			{
				if ((this._PROD_Category != value))
				{
					this.OnPROD_CategoryChanging(value);
					this.SendPropertyChanging();
					this._PROD_Category = value;
					this.SendPropertyChanged("PROD_Category");
					this.OnPROD_CategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Height", DbType="TinyInt NOT NULL")]
		public byte PROD_Height
		{
			get
			{
				return this._PROD_Height;
			}
			set
			{
				if ((this._PROD_Height != value))
				{
					this.OnPROD_HeightChanging(value);
					this.SendPropertyChanging();
					this._PROD_Height = value;
					this.SendPropertyChanged("PROD_Height");
					this.OnPROD_HeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Width", DbType="TinyInt NOT NULL")]
		public byte PROD_Width
		{
			get
			{
				return this._PROD_Width;
			}
			set
			{
				if ((this._PROD_Width != value))
				{
					this.OnPROD_WidthChanging(value);
					this.SendPropertyChanging();
					this._PROD_Width = value;
					this.SendPropertyChanged("PROD_Width");
					this.OnPROD_WidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Depth", DbType="TinyInt NOT NULL")]
		public byte PROD_Depth
		{
			get
			{
				return this._PROD_Depth;
			}
			set
			{
				if ((this._PROD_Depth != value))
				{
					this.OnPROD_DepthChanging(value);
					this.SendPropertyChanging();
					this._PROD_Depth = value;
					this.SendPropertyChanged("PROD_Depth");
					this.OnPROD_DepthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Description", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string PROD_Description
		{
			get
			{
				return this._PROD_Description;
			}
			set
			{
				if ((this._PROD_Description != value))
				{
					this.OnPROD_DescriptionChanging(value);
					this.SendPropertyChanging();
					this._PROD_Description = value;
					this.SendPropertyChanged("PROD_Description");
					this.OnPROD_DescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Image_Path", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string PROD_Image_Path
		{
			get
			{
				return this._PROD_Image_Path;
			}
			set
			{
				if ((this._PROD_Image_Path != value))
				{
					this.OnPROD_Image_PathChanging(value);
					this.SendPropertyChanging();
					this._PROD_Image_Path = value;
					this.SendPropertyChanged("PROD_Image_Path");
					this.OnPROD_Image_PathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Inventory", DbType="TinyInt NOT NULL")]
		public byte PROD_Inventory
		{
			get
			{
				return this._PROD_Inventory;
			}
			set
			{
				if ((this._PROD_Inventory != value))
				{
					this.OnPROD_InventoryChanging(value);
					this.SendPropertyChanging();
					this._PROD_Inventory = value;
					this.SendPropertyChanged("PROD_Inventory");
					this.OnPROD_InventoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROD_Active", DbType="Bit NOT NULL")]
		public bool PROD_Active
		{
			get
			{
				return this._PROD_Active;
			}
			set
			{
				if ((this._PROD_Active != value))
				{
					this.OnPROD_ActiveChanging(value);
					this.SendPropertyChanging();
					this._PROD_Active = value;
					this.SendPropertyChanged("PROD_Active");
					this.OnPROD_ActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLE_ID", DbType="Int")]
		public System.Nullable<int> SLE_ID
		{
			get
			{
				return this._SLE_ID;
			}
			set
			{
				if ((this._SLE_ID != value))
				{
					if (this._Sale.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSLE_IDChanging(value);
					this.SendPropertyChanging();
					this._SLE_ID = value;
					this.SendPropertyChanged("SLE_ID");
					this.OnSLE_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Invoice_Line", Storage="_Invoice_Lines", ThisKey="PROD_ID", OtherKey="PROD_ID")]
		public EntitySet<Invoice_Line> Invoice_Lines
		{
			get
			{
				return this._Invoice_Lines;
			}
			set
			{
				this._Invoice_Lines.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sale_Product", Storage="_Sale", ThisKey="SLE_ID", OtherKey="SLE_ID", IsForeignKey=true)]
		public Sale Sale
		{
			get
			{
				return this._Sale.Entity;
			}
			set
			{
				Sale previousValue = this._Sale.Entity;
				if (((previousValue != value) 
							|| (this._Sale.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sale.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Sale.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._SLE_ID = value.SLE_ID;
					}
					else
					{
						this._SLE_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Sale");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Invoice_Lines(Invoice_Line entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Invoice_Lines(Invoice_Line entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
}
#pragma warning restore 1591

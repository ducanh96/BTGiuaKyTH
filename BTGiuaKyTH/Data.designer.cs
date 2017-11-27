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

namespace BTGiuaKyTH
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BTLTTH")]
	public partial class DataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    partial void InsertNSX(NSX instance);
    partial void UpdateNSX(NSX instance);
    partial void DeleteNSX(NSX instance);
    #endregion
		
		public DataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BTLTTHConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
		
		public System.Data.Linq.Table<NSX> NSXes
		{
			get
			{
				return this.GetTable<NSX>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSp;
		
		private string _TenSp;
		
		private System.Nullable<int> _IDLoaiSp;
		
		private EntityRef<NSX> _NSX;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSpChanging(int value);
    partial void OnMaSpChanged();
    partial void OnTenSpChanging(string value);
    partial void OnTenSpChanged();
    partial void OnIDLoaiSpChanging(System.Nullable<int> value);
    partial void OnIDLoaiSpChanged();
    #endregion
		
		public SanPham()
		{
			this._NSX = default(EntityRef<NSX>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSp", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSp
		{
			get
			{
				return this._MaSp;
			}
			set
			{
				if ((this._MaSp != value))
				{
					this.OnMaSpChanging(value);
					this.SendPropertyChanging();
					this._MaSp = value;
					this.SendPropertyChanged("MaSp");
					this.OnMaSpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSp", DbType="NVarChar(50)")]
		public string TenSp
		{
			get
			{
				return this._TenSp;
			}
			set
			{
				if ((this._TenSp != value))
				{
					this.OnTenSpChanging(value);
					this.SendPropertyChanging();
					this._TenSp = value;
					this.SendPropertyChanged("TenSp");
					this.OnTenSpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLoaiSp", DbType="Int")]
		public System.Nullable<int> IDLoaiSp
		{
			get
			{
				return this._IDLoaiSp;
			}
			set
			{
				if ((this._IDLoaiSp != value))
				{
					if (this._NSX.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDLoaiSpChanging(value);
					this.SendPropertyChanging();
					this._IDLoaiSp = value;
					this.SendPropertyChanged("IDLoaiSp");
					this.OnIDLoaiSpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NSX_SanPham", Storage="_NSX", ThisKey="IDLoaiSp", OtherKey="Id", IsForeignKey=true)]
		public NSX NSX
		{
			get
			{
				return this._NSX.Entity;
			}
			set
			{
				NSX previousValue = this._NSX.Entity;
				if (((previousValue != value) 
							|| (this._NSX.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NSX.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._NSX.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._IDLoaiSp = value.Id;
					}
					else
					{
						this._IDLoaiSp = default(Nullable<int>);
					}
					this.SendPropertyChanged("NSX");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NSX")]
	public partial class NSX : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _TenNSX;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTenNSXChanging(string value);
    partial void OnTenNSXChanged();
    #endregion
		
		public NSX()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNSX", DbType="NVarChar(50)")]
		public string TenNSX
		{
			get
			{
				return this._TenNSX;
			}
			set
			{
				if ((this._TenNSX != value))
				{
					this.OnTenNSXChanging(value);
					this.SendPropertyChanging();
					this._TenNSX = value;
					this.SendPropertyChanged("TenNSX");
					this.OnTenNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NSX_SanPham", Storage="_SanPhams", ThisKey="Id", OtherKey="IDLoaiSp")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.NSX = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.NSX = null;
		}
	}
}
#pragma warning restore 1591

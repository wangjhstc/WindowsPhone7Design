﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.AppsSampleDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class AppsSampleDataSource { }
#else

	public class AppsSampleDataSource : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public AppsSampleDataSource()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/Marketplace;component/SampleData/AppsSampleDataSource/AppsSampleDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private Categories _Categories = new Categories();

		public Categories Categories
		{
			get
			{
				return this._Categories;
			}
		}

		private New _New = new New();

		public New New
		{
			get
			{
				return this._New;
			}
		}

		private Top _Top = new Top();

		public Top Top
		{
			get
			{
				return this._Top;
			}
		}

		private Featured _Featured = new Featured();

		public Featured Featured
		{
			get
			{
				return this._Featured;
			}
		}
	}

	public class CategoriesItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
	}

	public class Categories : System.Collections.ObjectModel.ObservableCollection<CategoriesItem>
	{ 
	}

	public class NewItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		private string _Publisher = string.Empty;

		public string Publisher
		{
			get
			{
				return this._Publisher;
			}

			set
			{
				if (this._Publisher != value)
				{
					this._Publisher = value;
					this.OnPropertyChanged("Publisher");
				}
			}
		}
	}

	public class New : System.Collections.ObjectModel.ObservableCollection<NewItem>
	{ 
	}

	public class TopItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		private string _Publisher = string.Empty;

		public string Publisher
		{
			get
			{
				return this._Publisher;
			}

			set
			{
				if (this._Publisher != value)
				{
					this._Publisher = value;
					this.OnPropertyChanged("Publisher");
				}
			}
		}
	}

	public class Top : System.Collections.ObjectModel.ObservableCollection<TopItem>
	{ 
	}

	public class FeaturedItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		private string _Comment = string.Empty;

		public string Comment
		{
			get
			{
				return this._Comment;
			}

			set
			{
				if (this._Comment != value)
				{
					this._Comment = value;
					this.OnPropertyChanged("Comment");
				}
			}
		}
	}

	public class Featured : System.Collections.ObjectModel.ObservableCollection<FeaturedItem>
	{ 
	}
#endif
}

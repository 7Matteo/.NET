using examjanvier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examjanvier.ViewModels
{
    internal class ProductModel : INotifyPropertyChanged
    {
        private readonly Product _product;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ProductModel(Product product)
        {
            _product = product;
        }

        public int ProductId
        {
            get { return _product.ProductId; }
        }

        public String ProductName
        {
            get { return _product.ProductName; }
            set
            {
                if (_product.ProductName != value)
                {
                    _product.ProductName = value;
                    OnPropertyChanged(nameof(ProductName));
                }
            }
        }


        public bool Discontinued
        {
            get { return _product.Discontinued;}
            set { _product.Discontinued = value; OnPropertyChanged(nameof(Discontinued)); } 
        }

    }
}

using examjanvier.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examjanvier.ViewModels
{
    internal class ProductVM
    {
        private ObservableCollection<ProductModel> _products;
        private ProductModel _selectedProduct;
        private NorthwindContext context = new NorthwindContext();
        private DelegateCommand _delProduct;

        public ObservableCollection<ProductModel> ProductsList
        {
            get
            {
                return _products = _products ?? loadProducts2();
            }
        }

        private ObservableCollection<ProductModel> loadProducts2()
        {
            ObservableCollection<ProductModel> localCollection = new ObservableCollection<ProductModel>();
            foreach (var item in context.Products)
            {
                localCollection.Add(new ProductModel(item));

            }

            return localCollection;

        }


        public ProductModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; }
        }

        public DelegateCommand deleteButton
        {
            get { return _delProduct = _delProduct ?? new DelegateCommand(DelProduct); }
        }


        private void DelProduct()
        {


            //MessageBox.Show("fskfjs");

            SelectedProduct.Discontinued = true;
            ProductsList.Remove(SelectedProduct);
            // OnPropertyChanged("SelectedLegume");
            // OnPropertyChanged("LegumesList");

        }
    }
}

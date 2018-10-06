using System;
using System.Collections.Generic;
using System.Text;

namespace Oprava.ViewModels
{
  public  class MainViewModel
    {

        public ProductsViewModel products { get; set; }

        public MainViewModel()
        {
            this.products = new ProductsViewModel();
        }
    }
}

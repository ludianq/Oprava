using System;
using System.Collections.Generic;
using System.Text;

namespace Oprava.Infractructure
{
    using ViewModels;

  public  class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }

   

}

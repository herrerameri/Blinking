using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.ViewModels.Base
{
    public class VMLocator
    {
        private Lazy<VMMain> mainViewMain;

        public VMLocator()
        {
            mainViewMain = new Lazy<VMMain>(() => new VMMain());
        }

        public VMMain MainViewModel
        {
            get
            {
                return mainViewMain.Value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Practica1.ViewModels.Base;

namespace Practica1.ViewModels
{
    public class VMMain : VMBase
    {
        private Lazy<DelegateCommand<object>> btnOpenClose;
        private bool eyeOpen;

        public bool EyeOpen
        {
            get { return eyeOpen; }
            set
            {
                eyeOpen = value;
                RaisePropertyChanged("EyeOpen");
            }
        }        

        public ICommand BtnOpenClose
        {
            get
            {
                return btnOpenClose.Value;
            }
        }

        public VMMain()
        {
            EyeOpen = true;
            btnOpenClose = new Lazy<DelegateCommand<object>>(
                () =>
                    new DelegateCommand<object>(ChangeState));
        }

        public async void ChangeState(object param)
        {
            EyeOpen = !eyeOpen;
        }       
    }
}

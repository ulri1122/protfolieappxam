using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App3.classes;
using System.Windows.Input;
using Xamarin.Essentials;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class company_temp : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));


        public company_temp(Comp comp)
        {
            InitializeComponent();
            Compview.BindingContext = comp;
            link.Command = TapCommand;
        }
    }
}
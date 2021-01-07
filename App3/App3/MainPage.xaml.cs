using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App3.classes;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            job0.BindingContext = new Comp() {
                CompName = "1lorem",
                CompDesc = "orem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a gall",
                CompLink = "https://google.com",
                Start = "2020-10-10",
                Stop = "2010-10-10",
                Img = "https://images.freeimages.com/images/large-previews/c25/glossy-ball-8-1156425.jpg"
            };

            job1.BindingContext = new Comp()
            {
                CompName = "2lorem",
                CompDesc = "orem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a gall",
                CompLink = "https://google.com",
                Start = "2020/10/10",
                Stop = "2010/10/10",
                Img = "https://images.freeimages.com/images/large-previews/c25/glossy-ball-8-1156425.jpg"
            };
            job2.BindingContext = new Comp()
            {
                CompName = "3lorem",
                CompDesc = "orem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a gall",
                CompLink = "https://google.com",
                Start = "2020/10/10",
                Stop = "2010/10/10",
                Img = "https://images.freeimages.com/images/large-previews/c25/glossy-ball-8-1156425.jpg"
            };
            job3.BindingContext = new Comp()
            {
                CompName = "4lorem",
                CompDesc = "orem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a gall",
                CompLink = "https://google.com",
                Start = "2020/10/10",
                Stop = "2010/10/10",
                Img = "https://images.freeimages.com/images/large-previews/c25/glossy-ball-8-1156425.jpg"
            };


        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            Comp data = ((Button)sender).BindingContext as Comp;
            await Navigation.PushAsync(new company_temp(data));
        }
        private async void About_me(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new about_me());
        }


    }
}

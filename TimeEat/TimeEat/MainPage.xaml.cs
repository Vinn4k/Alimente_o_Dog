using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeEat
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // bool clic = false;
        int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            count++;
            bt.Text = "Humm gostoso !!! ";
            photos.Source = "like_this";
            
            
            
            if (count ==2)
            {
                bt.Text = "Gostoso, mais quero mais";
                photos.Source = "giveme";
                count = 0;
                lbl1.Text = "Quero mais";

            }
            if (count == 1)
            {
                lbl1.Text = "Humm gostoso ";

            }

        }
    }
}

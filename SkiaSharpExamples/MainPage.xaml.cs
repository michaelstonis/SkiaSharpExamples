using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SkiaSharpExamples
{
    public partial class MainPage : ContentPage
    {
        public MainPage ()
        {
            InitializeComponent();
        }

        void RadialProgress_Clicked (object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new RadialProgressPage());
        }

        void RadialProgressOpenGl_Clicked (object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new RadialProgressOpenGLPage());
        }

        void LinearProgress_Clicked (object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new LinearProgressPage());
        }
    }
}

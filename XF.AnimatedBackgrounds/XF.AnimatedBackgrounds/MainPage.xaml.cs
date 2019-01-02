using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.AnimatedBackgrounds
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AnimateBackground();
        }

        private void AnimateBackground()
        {
            AnimateBackgroundLayer1();
            AnimateBackgroundLayer2();
            AnimateBackgroundLayer3();
            AnimateBackgroundLayer4();
        }

        private async void AnimateBackgroundLayer1()
        {
            while (true)
            {
                await BackgroundLayer1.ScaleTo(0.9, 2500, Easing.SinOut);
                await BackgroundLayer1.ScaleTo(1.2, 1750, Easing.SinInOut);
            }
        }

        private async void AnimateBackgroundLayer2()
        {
            while (true)
            {
                await BackgroundLayer2.ScaleTo(0.8, 2750, Easing.SinOut);
                await BackgroundLayer2.ScaleTo(1, 2250, Easing.SinInOut);
            }
        }

        private async void AnimateBackgroundLayer3()
        {
            while (true)
            {
                await BackgroundLayer3.ScaleTo(0.7, 3000, Easing.SinInOut);
                await BackgroundLayer3.ScaleTo(0.9, 2500, Easing.SinOut);
            }
        }

        private async void AnimateBackgroundLayer4()
        {
            while (true)
            {
                await BackgroundLayer4.ScaleTo(0.6, 1750, Easing.SinOut);
                await BackgroundLayer4.ScaleTo(0.8, 2000, Easing.SinInOut);
            }
        }
    }
}

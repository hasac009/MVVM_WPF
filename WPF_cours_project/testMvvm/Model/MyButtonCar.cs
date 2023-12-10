using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace testMvvm.Model
{
    internal class MyButtonCar
    {
        private string NameCar;
        private string NumberCar;
        private string ImageCarPath;
        private Button ButtonCarButton;

        MyButtonCar(string NameCar, string NuberCar, string ImageCar) 
        { 
            this.NameCar = NameCar;
            this.NumberCar = NuberCar;
            this.ImageCarPath = ImageCar;
            ButtonCarButton = new Button();
            ButtonCarButton.Style = Application.Current.Resources["MyButtonStyle4"] as Style;

        }

        private void SetupButton()
        {
            ButtonCarButton.Height = 171;
            ButtonCarButton.Width = 275;
            ButtonCarButton.Content = NameCar + " №" + NumberCar;
            ButtonCarButton.FontSize = 12;
            ButtonCarButton.VerticalAlignment = VerticalAlignment.Bottom;

            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri(ImageCarPath));
            ButtonCarButton.Background = imageBrush;
        }


    }
}

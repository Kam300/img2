using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace ImageViewer
{
    public partial class ImageRotator : UserControl
    {
        private double angle = 0; // угл поворота 

        public ImageRotator()
        {
            InitializeComponent();
        }

        public void SetImageSource(string imageUrl)
        {
            image.Source = new BitmapImage(new Uri(imageUrl, UriKind.Absolute)); //источн изобр
        }

        private void RotateLeft_Click(object sender, RoutedEventArgs e)
        {
            RotateImage(-90);
        }

        private void RotateRight_Click(object sender, RoutedEventArgs e)
        {
            RotateImage(90);
        }

        private void RotateImage(double rotationAngle)
        {
            var rotateTransform = image.RenderTransform as RotateTransform; // Получ тек Rotat
            if (rotateTransform == null)
            {
                rotateTransform = new RotateTransform(0);
                image.RenderTransform = rotateTransform;
                image.RenderTransformOrigin = new Point(0.5, 0.5); //центр вра
            }

            angle += rotationAngle;
            var animation = new DoubleAnimation
            {
                From = rotateTransform.Angle,
                To = angle,
                Duration = TimeSpan.FromMilliseconds(300),
                EasingFunction = new QuarticEase() 
            };

            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, animation);
        }

    }
}

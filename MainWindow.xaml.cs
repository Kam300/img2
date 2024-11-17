using System;
using System.Windows;

namespace ImageViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            imageRotator1.SetImageSource("https://avatars.mds.yandex.net/i?id=1445c569fce2f3115d5628f50911f075_l-12522553-images-thumbs&n=13");
            imageRotator2.SetImageSource("https://avatars.mds.yandex.net/i?id=6a22114b43f8b891f90e2fdbf2ebc760_l-5236641-images-thumbs&n=13");
            imageRotator3.SetImageSource("https://avatars.mds.yandex.net/i?id=44bf462830e2bb273caa2ef21252e8f2_l-4268172-images-thumbs&n=13");
            imageRotator4.SetImageSource("https://u-stena.ru/upload/iblock/806/806cbf9648de83c02c38388d8a19800b.jpg");
            imageRotator5.SetImageSource("https://cdnstatic.rg.ru/uploads/images/197/50/00/matterhorn-918442_1920.jpg");
            imageRotator6.SetImageSource("https://komionline.ru/uploads/2018/09/CF000816.jpg");

        }
    }
}

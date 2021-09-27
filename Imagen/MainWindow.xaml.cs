using System.Windows;
using System.Windows.Media;

namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpacidadAlta(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 1;
        }
        private void OpacidadMedia(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.6;
        }
        private void OpacidadBaja(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.3;
        }
        private void AjusteRelleno(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Fill;
        }
        private void AjusteUniforme(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Uniform;
        }
        private void AjusteRellenoUniforme(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.UniformToFill;
        }
        private void AjusteNone(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.None;
        }
    }
}

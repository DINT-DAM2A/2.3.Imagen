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

        private void OpacidadAlta_Cheched(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 1;
        }
        private void OpacidadMedia_Cheched(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.6;
        }
        private void OpacidadBaja_Cheched(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.3;
        }
        private void AjusteRelleno_Cheched(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Fill;
        }
        private void AjusteUniforme_Cheched(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Uniform;
        }
        private void AjusteRellenoUniforme_Cheched(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.UniformToFill;
        }
        private void AjusteNone_Cheched(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.None;
        }
    }
}

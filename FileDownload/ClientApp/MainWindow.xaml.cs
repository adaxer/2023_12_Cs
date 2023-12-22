using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientApp;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void Button_Click(object sender, RoutedEventArgs e)
    {
        await LoadImage("car.png");
        SetImage();
    }

    private void SetImage()
    {
        string filePath = "car.png";

        // Create a BitmapImage from the file
        BitmapImage bitmapImage = new BitmapImage();
        bitmapImage.BeginInit();
        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
        bitmapImage.UriSource = new Uri(filePath, UriKind.RelativeOrAbsolute);
        bitmapImage.EndInit();

        // Set the BitmapImage as the source of the Image control
        img.Source = bitmapImage;
    }

    private async Task LoadImage(string name)
    {
        using var client = new HttpClient();
        byte[] bytes = await client.GetByteArrayAsync("https://localhost:7258/image");
        using FileStream fileStream = new FileStream(name, FileMode.Create, FileAccess.Write);
        await fileStream.WriteAsync(bytes, 0, bytes.Length);
    }
}
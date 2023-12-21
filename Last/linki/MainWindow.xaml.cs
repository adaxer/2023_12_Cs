using System.Diagnostics;
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

namespace linki;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void LoadData(object sender, RoutedEventArgs e)
    {
        if(await LoadImage())
        {
SetImage();
        }
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
                    img.Source = bitmapImage;    }

    private async Task<bool> LoadImage()
    {
        string imageUrl = "http://localhost:5069/image";
        string filePath = "car.png"; 

        try
        {
            using (HttpClient httpClient = new HttpClient())
            {
                byte[] imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    await fileStream.WriteAsync(imageBytes, 0, imageBytes.Length);
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            Trace.TraceError($"{ex}");
            return false;
        }
    }
}
namespace PruebaGit;

public partial class pagina1 : ContentPage
{
	public pagina1()
	{
		InitializeComponent();

        List<string> imageSources = new List<string>
            {
                "dotnet_bot.png", // Asegúrate de agregar estas imágenes a la carpeta de recursos del proyecto
                "dotnet_bot.png",
                "dotnet_bot.png"
            };

        // Asignar la lista de imágenes al control del carrusel
        ImageCarousel.ItemsSource = imageSources;
    }
}
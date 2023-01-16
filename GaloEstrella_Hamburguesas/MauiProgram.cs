using GaloEstrella_Hamburguesas.Data;

namespace GaloEstrella_Hamburguesas;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});



 string dbPath = FileAccesHelper.GetLocalFilePath("burger.db3");
        builder.Services.AddSingleton<GEBurgerrDatabase>(s => ActivatorUtilities.CreateInstance<GEBurgerrDatabase>(s, dbPath));


        return builder.Build();


	}
}

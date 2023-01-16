using GaloEstrella_Hamburguesas.Data;

namespace GaloEstrella_Hamburguesas;

public partial class App : Application
{
    public static GEBurgerrDatabase PersonRepo { get; private set; }

    public App(GEBurgerrDatabase repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        PersonRepo = repo;
    }
}

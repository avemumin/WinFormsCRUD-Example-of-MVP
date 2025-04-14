using System.Configuration;
using WinFormsCRUD.Models;
using WinFormsCRUD.Presenters;
using WinFormsCRUD.Repositories;
using WinFormsCRUD.Views;

namespace WinFormsCRUD
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      var connection = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
      IPetView view = new PetView();
      IPetRepository repository = new PetRepository(connection);
      new PetPresenter(view, repository);
      Application.Run((Form)view);
    }
  }
}
//"Server=.;Database=MVPTry;User Id=sa;Password=5432!qaz;TrustServerCertificate=True;"
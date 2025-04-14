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
      IPetView view = new PetView();
      IPetRepository repository = new PetRepository("Server=.;Database=MVPTry;User Id=sa;Password=5432!qaz;TrustServerCertificate=True;");
      new PetPresenter(view, repository);
      Application.Run((Form)view);
    }
  }
}
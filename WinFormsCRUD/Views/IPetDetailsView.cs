using WinFormsCRUD.Models;

namespace WinFormsCRUD.Views
{
  public interface IPetDetailsView
  {
    string PetId { get; set; }
    string PetName { get; set; }
    string PetType { get; set; }
    string PetColor { get; set; }

    event EventHandler SaveEvent;
    event EventHandler CancelEvent;
    void Show();
   
  }
}

namespace WinFormsCRUD.Views
{
  /// <summary>
  /// The IPetView interface definition
  /// </summary>
  public interface IPetView
  {
    string PetId { get; set; }
    string PetName { get; set; }
    string PetType { get; set; }
    string PetColor { get; set; }

    string SearchValue { get; set; }
    bool IsEdit { get; set; }
    bool IsSuccessfully { get; set; }
    string Message { get; set; }


    event EventHandler SearchEvent;
    event EventHandler AddNewEvent;

    event EventHandler EditEvent;
    event EventHandler DeleteEvent;

    // event EventHandler SaveEvent;
    // event EventHandler CancelEvent;
    void SetPetListBindingSource(BindingSource petList);
  }
}

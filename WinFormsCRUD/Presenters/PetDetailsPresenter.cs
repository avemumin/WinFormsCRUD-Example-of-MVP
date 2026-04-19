using WinFormsCRUD.Models;
using WinFormsCRUD.Views;

namespace WinFormsCRUD.Presenters
{
  public class PetDetailsPresenter
  {
    private readonly IPetDetailsView _petDetailsView;
    private PetModel _pet;
 
    public PetDetailsPresenter(IPetDetailsView petDetailsView, PetModel pet)
    {
      _petDetailsView = petDetailsView;
      _pet = pet;
      DetailEventSubscribtion();
      BindDataFields();

    }

    private void BindDataFields()
    {
      this._petDetailsView.PetId = _pet.Id.ToString();
      this._petDetailsView.PetName = _pet.Name.ToString();
      this._petDetailsView.PetType = _pet.Type.ToString();
      this._petDetailsView.PetColor = _pet.Color.ToString();


    }

    private void DetailEventSubscribtion()
    {
      this._petDetailsView.SaveEvent += SaveChanges;
      this._petDetailsView.CancelEvent += Cancellation;
    }

    private void Cancellation(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void SaveChanges(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}

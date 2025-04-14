using WinFormsCRUD.Models;
using WinFormsCRUD.Views;
namespace WinFormsCRUD.Presenters
{
  public class PetPresenter
  {
    private IPetView view;
    private IPetRepository repository;
    private BindingSource petsBindingSource;

    private IEnumerable<PetModel> petList;
    /// <summary>
    /// Constructor with dependencies
    /// </summary>
    /// <param name="view">The view</param>
    /// <param name="repository">The repository</param>
    public PetPresenter(IPetView view, IPetRepository repository)
    {
      this.petsBindingSource = new BindingSource();
      this.view = view;
      this.repository = repository;
      //Event's
      this.view.SearchEvent += SearchPet;
      this.view.AddNewEvent += AddNewPet;
      this.view.EditEvent += EditPet;
      this.view.DeleteEvent += DeletePet;
      this.view.SaveEvent += SavePet;
      this.view.CancelEvent += CancelAction;
      //Set pets binding source
      this.view.SetPetListBindingSource(petsBindingSource);

      LoadAllPetList();
      //show view
      //this.view.Show();
    }

    private void LoadAllPetList()
    {
      petList = repository.GetAll();
      petsBindingSource.DataSource = petList;
    }

    private void CancelAction(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void SavePet(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void DeletePet(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void EditPet(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void AddNewPet(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void SearchPet(object? sender, EventArgs e)
    {
      string filter = this.view.SearchValue;
      if (!string.IsNullOrWhiteSpace(filter))
        petList = repository.GetBySPecVal(filter);
      else
        petList = repository.GetAll();
      petsBindingSource.DataSource = petList;
    }
  }
}

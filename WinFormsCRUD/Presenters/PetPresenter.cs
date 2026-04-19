using WinFormsCRUD.Models;
using WinFormsCRUD.Views;
namespace WinFormsCRUD.Presenters
{
  /// <summary>
  /// The pet presenter class.
  /// </summary>
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
      this.view = view;
      this.repository = repository;
      //Event's
      EventsSubscribtion();
      this.petsBindingSource = new BindingSource();
      this.view.SetPetListBindingSource(petsBindingSource);
      LoadAllPetList();
    }

    /// <summary>
    /// The event's subscribtion
    /// </summary>
    private void EventsSubscribtion()
    {
      this.view.SearchEvent += SearchPet;
      this.view.AddNewEvent += AddNewPet;
      this.view.EditEvent += EditPet;
      this.view.DeleteEvent += DeletePet;
      //this.view.SaveEvent += SavePet;
     // this.view.CancelEvent += CancelAction;
    }
    private void LoadAllPetList()
    {
      petList = repository.GetAll();
      petsBindingSource.DataSource = petList;
    }

    //private void CancelAction(object? sender, EventArgs e)
    //{
    //  throw new NotImplementedException();
    //}

    //private void SavePet(object? sender, EventArgs e)
    //{
    //  throw new NotImplementedException();
    //}

    private void DeletePet(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void EditPet(object? sender, EventArgs e)
    {
      //var marked  =  dgPetListView.CurrentRow.Cells["Id"].Value
      var pet = petList.FirstOrDefault();
      IPetDetailsView dView = new PetDetailsView();
      new PetDetailsPresenter(dView, pet);
      dView.Show();

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

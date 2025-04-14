namespace WinFormsCRUD.Views
{
  public partial class PetView : Form, IPetView
  {
    public string message;
    public bool isSuccessfull;
    private bool isEdit;

    public PetView()
    {
      InitializeComponent();
      RaiseViewEvents();
      tabControl1.TabPages.Remove(this.tabPage2);
    }

    private void RaiseViewEvents()
    {
      btnSearch.Click += (sender, e) =>
      {
        SearchEvent?.Invoke(sender, e);
      };
      txtSearch.KeyDown += (sender, e) =>
      {
        if (e.KeyCode == Keys.Enter)
        {
          SearchEvent?.Invoke(sender, e);
        }
      };
    }
    public string PetId { get => txtPetId.Text; set => txtPetId.Text = value; }
    public string PetName { get => txtPetName.Text; set => txtPetName.Text = value; }
    public string PetType { get => txtPetType.Text; set => txtPetType.Text = value; }
    public string PetColor { get => txtPetColor.Text; set => txtPetColor.Text = value; }
    public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
    public bool IsEdit { get => isEdit; set => isEdit = value; }
    public bool IsSuccessfully { get => isSuccessfull; set => isSuccessfull = value; }
    public string Message { get => message; set => message = value; }

    public event EventHandler SearchEvent;
    public event EventHandler AddNewEvent;
    public event EventHandler EditEvent;
    public event EventHandler DeleteEvent;
    public event EventHandler SaveEvent;
    public event EventHandler CancelEvent;

    public void SetPetListBindingSource(BindingSource petList)
    {
      dgPetListView.DataSource = petList;
    }
  }
}

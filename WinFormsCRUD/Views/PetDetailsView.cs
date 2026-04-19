namespace WinFormsCRUD.Views
{
  public partial class PetDetailsView : Form, IPetDetailsView
  {
    public PetDetailsView()
    {
      InitializeComponent();
      RiseEvents();
    }

    private void RiseEvents()
    {
      btnCancel.Click += (s, e) =>
      {
        this.Dispose();
        this.Close();
      };
    }

 

    public string PetId { get => txtPetId.Text; set => txtPetId.Text = value; }
    public string PetName { get => txtPetName.Text; set => txtPetName.Text = value; }
    public string PetType { get => txtPetType.Text; set => txtPetType.Text = value; }
    public string PetColor { get => txtPetColor.Text; set => txtPetColor.Text = value; }

    public event EventHandler SaveEvent;
    public event EventHandler CancelEvent;

    
  }
}

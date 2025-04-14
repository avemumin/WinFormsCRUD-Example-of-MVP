using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WinFormsCRUD.Models
{
  public class PetModel
  {
    private int id;
    private string name;
    private string type;
    private string color;

    [DisplayName("Pet  ID")]
    public int Id { get => id; set => id = value; }

    [DisplayName("Pet Name")]
    [Required(ErrorMessage ="Pet name is required")]
    [StringLength(50,MinimumLength =2,ErrorMessage ="Pet name must be min 2. chars length")]
    public string Name { get => name; set => name = value; }

    [DisplayName("Pet Type")]
    [Required(ErrorMessage = "Pet type is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet type must be min 3. chars length")]
    public string Type { get => type; set => type = value; }

    [DisplayName("Pet Color")]
    [Required(ErrorMessage = "Pet color is required")]
    [StringLength(50, MinimumLength = 4, ErrorMessage = "Pet color must be min 4. chars length")]
    public string Color { get => color; set => color = value; }
  }
}

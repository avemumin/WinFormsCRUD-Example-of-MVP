namespace WinFormsCRUD.Models
{
  /// <summary>
  /// The repository interface
  /// </summary>
  public interface IPetRepository
  {
    void Add(PetModel model);
    void Edit(PetModel model);
    void Delete(int id);
    IEnumerable<PetModel> GetAll();
    IEnumerable<PetModel> GetBySPecVal(string val);

  }
}

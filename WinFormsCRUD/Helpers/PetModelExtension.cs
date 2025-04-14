using WinFormsCRUD.Models;

namespace WinFormsCRUD.Helpers
{
  /// <summary>
  /// The extension's methods
  /// </summary>
  public static class PetModelExtension
  {
    public static IEnumerable<PetModel>? FilterByFields(this IEnumerable<PetModel> collection, string filter)
    {
      var result = collection.Where(x => x.Name.Contains(filter, StringComparison.CurrentCultureIgnoreCase)
      || x.Color.Contains(filter, StringComparison.CurrentCultureIgnoreCase)
      || x.Type.Contains(filter, StringComparison.CurrentCultureIgnoreCase));

      return result.Any() ? result : null;
    }
  }
}

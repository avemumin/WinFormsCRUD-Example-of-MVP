namespace WinFormsCRUD.Helpers
{
  public static class DapperSelectionHelper
  {
    public static string Basic()=>
     "Select Pet_Id as Id,Pet_Name as Name,Pet_Type as Type,Pet_Colour as Color from dbo.Pet";
  }
}

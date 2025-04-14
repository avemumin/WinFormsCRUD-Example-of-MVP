using Dapper;
using Microsoft.Data.SqlClient;
using WinFormsCRUD.Models;

namespace WinFormsCRUD.Repositories
{
  public class PetRepository : IPetRepository
  {
    private readonly string _connString = string.Empty;
    public PetRepository(string connStr)
    {
      this._connString = connStr;
    }


    public void Add(PetModel model)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public void Edit(PetModel model)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<PetModel> GetAll()
    {
      List<PetModel> list = new();
      string sql = "Select Pet_Id as Id,Pet_Name as Name,Pet_Type as Type,Pet_Colour as Color from dbo.Pet";
      using var conn = new SqlConnection(_connString);
      list = conn.Query<PetModel>(sql).ToList();
      if (list is null)
        throw new Exception("Pets not found");
      return list;
    }

    public IEnumerable<PetModel> GetBySPecVal(string val)
    {
      return GetAll().FilterByFields(val);
    }
  }
}

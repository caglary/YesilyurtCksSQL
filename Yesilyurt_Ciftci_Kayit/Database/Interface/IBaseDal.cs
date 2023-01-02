using System.Collections.Generic;
using System.Data.SqlClient;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public interface IBaseDal<T>
    {
        int Add(T Entity);
        int Update(T Entity);
        int Delete(T Entity);
        SqlDataReader GetAll();
    }
}

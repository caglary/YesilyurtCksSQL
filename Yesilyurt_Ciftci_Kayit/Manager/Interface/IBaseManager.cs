using System.Collections.Generic;
namespace Yesilyurt_Ciftci_Kayit.Manager
{
    public interface IBaseManager<T>
    {
        int Result { get; set; }
        int Add(T Entity);
        int Update(T Entity);
        int Delete(T Entity);
        List<T> GetAll();
    }
}

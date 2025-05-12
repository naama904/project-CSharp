

using BO;

namespace BlApi;

public interface ISale
{
    int Create(BO.Sale item);
    BO.Sale? Read(int id);
    //T? Read(Func<T, bool> filter);
    List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null);
    void Update(BO.Sale item);
    void Delete(int id);
    //Sale Read(Func<object, bool> value);
}

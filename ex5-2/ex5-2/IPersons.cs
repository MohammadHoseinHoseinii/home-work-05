// CRUD Repository 
public interface Ipersons<T>
{
    T GetItem(int id);
    List<T> GetAll();
    bool HasItem(int id);
    bool Add(T item);
    bool Remove(T item);
    T Update(T item);
}
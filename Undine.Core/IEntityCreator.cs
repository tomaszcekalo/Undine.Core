namespace Undine.Core
{
    public interface IEntityCreator<T>
    {
        T CreateNewEntity();
    }
}
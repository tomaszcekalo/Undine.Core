namespace Undine.Core.Struct
{
    public interface IUnifiedEntity
    {
        void AddComponent<A>(in A component)
            where A : struct;

        ref A GetComponent<A>()
            where A : struct;
    }
}
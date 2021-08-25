namespace Undine.Core
{
    public interface IUnifiedSystem
    {
        void PreProcess();
        void PostProcess();
    }

    public interface IUnifiedSystem<T> : IUnifiedSystem
        where T : struct
    {
        void ProcessSingleEntity(int entityId, ref T t);
    }

    public interface IUnifiedSystem<A, B> : IUnifiedSystem
        where A : struct
        where B : struct
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b);
    }

    public interface IUnifiedSystem<A, B, C> : IUnifiedSystem
        where A : struct
        where B : struct
        where C : struct
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c);
    }

    public interface IUnifiedSystem<A, B, C, D> : IUnifiedSystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c, ref D d);
    }
}
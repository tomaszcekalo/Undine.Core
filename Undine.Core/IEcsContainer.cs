namespace Undine.Core
{
    public interface IEcsContainer
    {
        void AddSystem<A>(UnifiedSystem<A> system)
        where A : struct;

        void AddSystem<A, B>(UnifiedSystem<A, B> system)
        where A : struct
        where B : struct;

        void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : struct
        where B : struct
        where C : struct;

        void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : struct
        where B : struct
        where C : struct
        where D : struct;

        IUnifiedEntity CreateNewEntity();
        void DeleteEntity(IUnifiedEntity entity);
        ISystem GetSystem<A>(UnifiedSystem<A> system)
        where A : struct;

        ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        where A : struct
        where B : struct;

        ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : struct
        where B : struct
        where C : struct;

        ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : struct
        where B : struct
        where C : struct
        where D : struct;

        void Init();

        void Run();
    }
}
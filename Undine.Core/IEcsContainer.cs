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
        IProcessAll GetSystem<A>(UnifiedSystem<A> system)
        where A : struct;

        IProcessAll GetSystem<A, B>(UnifiedSystem<A, B> system)
        where A : struct
        where B : struct;

        IProcessAll GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : struct
        where B : struct
        where C : struct;

        IProcessAll GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : struct
        where B : struct
        where C : struct
        where D : struct;

        void Init();

        void Run();
    }
}
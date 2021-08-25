namespace Undine.Core
{
    public abstract class EcsContainer : IEcsContainer
    {
        public abstract void AddSystem<A>(UnifiedSystem<A> system)
        where A : struct;

        public abstract void AddSystem<A, B>(UnifiedSystem<A, B> system)
        where A : struct
        where B : struct;

        public abstract void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : struct
        where B : struct
        where C : struct;

        public abstract void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : struct
        where B : struct
        where C : struct
        where D : struct;

        public abstract IProcessAll GetSystem<A>(UnifiedSystem<A> system)
        where A : struct;

        public abstract IProcessAll GetSystem<A, B>(UnifiedSystem<A, B> system)
        where A : struct
        where B : struct;

        public abstract IProcessAll GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : struct
        where B : struct
        where C : struct;

        public abstract IProcessAll GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : struct
        where B : struct
        where C : struct
        where D : struct;

        public virtual void Init()
        {
        }

        public abstract void Run();
        public abstract IUnifiedEntity CreateNewEntity();
    }
}
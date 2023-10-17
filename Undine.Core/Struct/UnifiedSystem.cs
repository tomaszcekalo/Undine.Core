namespace Undine.Core.Struct
{
    public abstract class UnifiedSystem : IUnifiedSystem
    {
        public virtual void PreProcess()
        {
        }

        public virtual void PostProcess()
        {
        }
    }

    public abstract class UnifiedSystem<T> : UnifiedSystem, IUnifiedSystem<T>
        where T : struct

    {
        public abstract void ProcessSingleEntity(int entityId, ref T t);
    }

    public abstract class UnifiedSystem<A, B> : UnifiedSystem, IUnifiedSystem<A, B>
        where A : struct
        where B : struct
    {
        public abstract void ProcessSingleEntity(int entityId, ref A a, ref B b);
    }

    public abstract class UnifiedSystem<A, B, C> : UnifiedSystem, IUnifiedSystem<A, B, C>
        where A : struct
        where B : struct
        where C : struct
    {
        public abstract void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c);
    }

    public abstract class UnifiedSystem<A, B, C, D> : UnifiedSystem, IUnifiedSystem<A, B, C, D>
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public abstract void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c, ref D d);
    }
}
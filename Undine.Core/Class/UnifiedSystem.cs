using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core.Class
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
        where T : class

    {
        public abstract void ProcessSingleEntity(int entityId, ref T t);
    }

    public abstract class UnifiedSystem<A, B> : UnifiedSystem, IUnifiedSystem<A, B>
        where A : class
        where B : class
    {
        public abstract void ProcessSingleEntity(int entityId, ref A a, ref B b);
    }

    public abstract class UnifiedSystem<A, B, C> : UnifiedSystem, IUnifiedSystem<A, B, C>
        where A : class
        where B : class
        where C : class
    {
        public abstract void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c);
    }

    public abstract class UnifiedSystem<A, B, C, D> : UnifiedSystem, IUnifiedSystem<A, B, C, D>
        where A : class
        where B : class
        where C : class
        where D : class
    {
        public abstract void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c, ref D d);
    }
}
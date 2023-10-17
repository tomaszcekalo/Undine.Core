using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core.Class
{
    public interface IEcsContainer
    {
        void AddSystem<A>(UnifiedSystem<A> system)
        where A : class;

        void AddSystem<A, B>(UnifiedSystem<A, B> system)
        where A : class
        where B : class;

        void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : class
        where B : class
        where C : class;

        void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : class
        where B : class
        where C : class
        where D : class;

        IUnifiedEntity CreateNewEntity();

        ISystem GetSystem<A>(UnifiedSystem<A> system)
        where A : class;

        ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        where A : class
        where B : class;

        ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : class
        where B : class
        where C : class;

        ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : class
        where B : class
        where C : class
        where D : class;

        void Init();

        void Run();
    }
}
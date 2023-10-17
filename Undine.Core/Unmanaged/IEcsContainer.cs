using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core.Unmanaged
{
    public interface IEcsContainer
    {
        void AddSystem<A>(UnifiedSystem<A> system)
        where A : unmanaged;

        void AddSystem<A, B>(UnifiedSystem<A, B> system)
        where A : unmanaged
        where B : unmanaged;

        void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged;

        void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
        where D : unmanaged;

        IUnifiedEntity CreateNewEntity();

        ISystem GetSystem<A>(UnifiedSystem<A> system)
        where A : unmanaged;

        ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        where A : unmanaged
        where B : unmanaged;

        ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged;

        ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
        where D : unmanaged;

        void Init();

        void Run();
    }
}
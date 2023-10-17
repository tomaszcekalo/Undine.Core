using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core.Unmanaged
{
    public interface IUnifiedSystem
    {
        void PreProcess();

        void PostProcess();
    }

    public interface IUnifiedSystem<T> : IUnifiedSystem
        where T : unmanaged
    {
        void ProcessSingleEntity(int entityId, ref T t);
    }

    public interface IUnifiedSystem<A, B> : IUnifiedSystem
        where A : unmanaged
        where B : unmanaged
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b);
    }

    public interface IUnifiedSystem<A, B, C> : IUnifiedSystem
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c);
    }

    public interface IUnifiedSystem<A, B, C, D> : IUnifiedSystem
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
        where D : unmanaged
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c, ref D d);
    }
}
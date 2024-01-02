using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core
{
    public interface IUnifiedSystem
    {
        void PreProcess();

        void PostProcess();
    }

    public interface IUnifiedSystem<T> : IUnifiedSystem
    {
        void ProcessSingleEntity(int entityId, ref T t);
    }

    public interface IUnifiedSystem<A, B> : IUnifiedSystem
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b);
    }

    public interface IUnifiedSystem<A, B, C> : IUnifiedSystem
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c);
    }

    public interface IUnifiedSystem<A, B, C, D> : IUnifiedSystem
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c, ref D d);
    }
}
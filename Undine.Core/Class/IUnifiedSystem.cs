using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core.Class
{
    public interface IUnifiedSystem
    {
        void PreProcess();

        void PostProcess();
    }

    public interface IUnifiedSystem<T> : IUnifiedSystem
        where T : class
    {
        void ProcessSingleEntity(int entityId, ref T t);
    }

    public interface IUnifiedSystem<A, B> : IUnifiedSystem
        where A : class
        where B : class
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b);
    }

    public interface IUnifiedSystem<A, B, C> : IUnifiedSystem
        where A : class
        where B : class
        where C : class
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c);
    }

    public interface IUnifiedSystem<A, B, C, D> : IUnifiedSystem
        where A : class
        where B : class
        where C : class
        where D : class
    {
        void ProcessSingleEntity(int entityId, ref A a, ref B b, ref C c, ref D d);
    }
}
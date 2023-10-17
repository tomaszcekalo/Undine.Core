using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core.Unmanaged
{
    public interface IUnifiedEntity
    {
        void AddComponent<A>(in A component)
            where A : unmanaged;

        ref A GetComponent<A>()
            where A : unmanaged;
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core.Class
{
    public interface IUnifiedEntity
    {
        void AddComponent<A>(in A component)
            where A : class;

        ref A GetComponent<A>()
            where A : class;
    }
}
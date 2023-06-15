using System;
using System.Collections.Generic;

namespace Undine.Core
{
    public class EditorEntity
    {
        public string Name { get; set; }
        public Dictionary<Type, object> Components { get; set; }
    }
}
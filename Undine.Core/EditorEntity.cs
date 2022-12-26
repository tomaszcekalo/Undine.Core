using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Concurrent;

namespace Undine.Core
{
    public class EditorEntity
    {
        public string Name { get; set; }
        public Dictionary<Type, object> Components { get; set; }
    }
}
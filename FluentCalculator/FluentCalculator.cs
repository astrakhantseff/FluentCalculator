using System;
using System.Collections.Generic;

namespace FluentCalculator
{
    public partial class FluentCalculator
    {
        // Статические свойства для доступа к начальным значениям
        public static Value zero => new Value(0);
        public static Value one => new Value(1);
        public static Value two => new Value(2);
        public static Value three => new Value(3);
        public static Value four => new Value(4);
        public static Value five => new Value(5);
        public static Value six => new Value(6);
        public static Value seven => new Value(7);
        public static Value eight => new Value(8);
        public static Value nine => new Value(9);
        public static Value ten => new Value(10);
    }
}

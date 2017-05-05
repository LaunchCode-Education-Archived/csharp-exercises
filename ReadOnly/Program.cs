using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadOnly
{
    public class ReadonlyFields
    {
        public readonly int IntValue = 42;
        public readonly FortyTwo ObjectValue = new FortyTwo();

        public static void Main(string[] args)
        {

            ReadonlyFields demo = new ReadonlyFields();

            // This would result in a compiler error
            demo.IntValue = 6;

            // Also a compiler error
            demo.DoubleValue = 6.0;

            // This would result in a compiler error, since we're trying to
            // give objectValue a different object value
            demo.objectValue = new FortyTwo();

            // However, this is allowed since we're changing a field
            // inside the readonly object, and not changing which object
            // objectValue refers to
            demo.ObjectValue.IntValue = 6;
        }
    }
}

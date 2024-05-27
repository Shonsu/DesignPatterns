using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype
{
    public class Border
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public Border Clone()
        {
            return new Border() { Color = Color, Size = Size };
        }
    }
}

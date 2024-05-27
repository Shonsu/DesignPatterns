using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype
{
    public class Triangle : Shape
    {
        public override Shape Clone()
        {
            Triangle cloneBase = (Triangle)this.MemberwiseClone();
            cloneBase.Border = Border.Clone();
            return cloneBase;
        }

        public override void Render()
        {
            System.Console.WriteLine("Render triangle");
        }
    }
}

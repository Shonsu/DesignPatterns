using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override Shape Clone()
        {
            Circle cloneBase = (Circle)this.MemberwiseClone();
            cloneBase.Border =  Border.Clone();
            return cloneBase;
        }

        public override void Render()
        {
            System.Console.WriteLine("Render circle");
        }
    }
}

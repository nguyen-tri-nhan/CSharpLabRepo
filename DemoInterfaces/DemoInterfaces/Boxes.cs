using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaces
{
    class Boxes : IDemension
    {
        private float length;
        private float width;

        public Boxes(float length, float width) => (this.length, this.width) = (length, width);

        public float GetLength() => length;
        public float GetWidth() => width;

        public override string ToString() => $"Length = {length}, width = {width}";
    }
}

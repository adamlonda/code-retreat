using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class AliveCell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            AliveCell c = obj as AliveCell;

            if (c == null)
                return base.Equals(obj);

            return c.X == X && c.Y == Y;
        }
    }
}

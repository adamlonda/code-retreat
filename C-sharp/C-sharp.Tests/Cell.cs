using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp.Tests
{
    public class Cell
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public State State { get; private set; }

        public Cell(int x, int y, int generation = 1)
        {
            X = x;
            Y = y;

            if (generation > 3)
                State = State.Zombie;
            else State = State.Alive;
        }

        public override bool Equals(object obj)
        {
            Cell c = obj as Cell;

            if (c == null)
                return base.Equals(obj);

            return c.X == X && c.Y == Y;
        }
    }
}

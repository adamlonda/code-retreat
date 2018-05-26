using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp.Tests
{
    public class World
    {
        public World()
        {
            Cells = new HashSet<Cell>();
        }

        public HashSet<Cell> Cells { get; private set; }

        public bool ApplyRule(State state, HashSet<Cell> aliveNeighbours)
        {
            if (state == State.Alive)
                return aliveNeighbours.Count == 2 || aliveNeighbours.Count == 3;

            return aliveNeighbours.Count == 3;
        }

        public HashSet<Cell> GetNeighbours(Cell c)
        {
            HashSet<Cell> neighbours = new HashSet<Cell>();

            Cells.Where(cell => IsEightNeighbour(cell, c));
        }

        private bool IsEightNeighbour(Cell c, Cell center)
        {
            return (c.X == cente)
        }
    }
}

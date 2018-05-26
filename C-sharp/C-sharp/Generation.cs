using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class Generation
    {
        public HashSet<AliveCell> Population { get; private set; }

        public Generation()
        {
            Random r = new Random();
            int count = r.Next();

            Population = new HashSet<AliveCell>();

            for (int i = 0; i < count; i++)
                Population.Add(new AliveCell { X = r.Next(), Y = r.Next() });
        }

        public Generation(Generation gen)
        {
            Population = new HashSet<AliveCell>();

            foreach (AliveCell c in gen.Population)
            {
                if (WillLive(c, gen.Population))
                    Population.Add(c);
            }
        }

        private bool WillLive(AliveCell c, HashSet<AliveCell> population)
        {
            HashSet<AliveCell> neighbors = GetNeighbors(c, population);

            if (neighbors.Count < 2)
                return false;

            if (neighbors.Count == 2 || neighbors.Count == 3)
                return true;

            if (neighbors.Count > 3)
                return false;

            throw new NotImplementedException();
        }

        private HashSet<AliveCell> GetNeighbors(AliveCell c, HashSet<AliveCell> population)
        {
            HashSet<AliveCell> neighbors = new HashSet<AliveCell>();

            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                    if (i != 0 || j != 0)
                    {
                        AliveCell neighbor = population
                            .FirstOrDefault(cell => cell.X == c.X + i && cell.Y == c.Y + j);

                        if (neighbor != null)
                            neighbors.Add(neighbor);
                    }

            return neighbors;
        }
    }
}

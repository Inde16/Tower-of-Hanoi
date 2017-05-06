using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class TowerOfHanoi
    {
        int m_numdiscs;

        public TowerOfHanoi()
        {
            m_numdiscs = 0;
        }

        public TowerOfHanoi(int newval)
        {
            m_numdiscs = newval;
        }

        public int numdiscs
        {
            get
            {
                return m_numdiscs;
            }

            set
            {
                if (value > 0)
                    m_numdiscs = value;
            }
        }
        public void movetower(int n, int from , int to , int other)
        {
            if (n > 0)
            {
                movetower(n - 1, from, other, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}",n,from,to);
                movetower(n - 1, other, to, from);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TowerOfHanoi Tower = new TowerOfHanoi();
            string cnumdiscs;
            Console.WriteLine("Enter the number of the disks");
            cnumdiscs = Console.ReadLine();
            Tower.numdiscs = Convert.ToInt32(cnumdiscs);
            Tower.movetower(Tower.numdiscs, 1, 3, 2);
            Console.ReadLine();
        }
    }
}

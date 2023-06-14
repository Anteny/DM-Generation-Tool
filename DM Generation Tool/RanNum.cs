using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Generation_Tool
{
    internal class RanNum
    {
        public int Generate(int Mod)
        {
            Random ran = new();
            return ran.Next(Mod);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // Derive dark chocolate from chocopack
    public class DarkChoco : ChocoPack
    {
        public DarkChoco(string type, int cash, int price, int bonusRatio)
            :base(type, cash, price, bonusRatio)
        {
        }

        // Override getDark function
        public override int getDark()
        {
            try
            {
                int packCount = cash / price;
                int bonusCount = packCount / bonusRatio;
                return 2 * bonusCount + packCount;
            } catch (Exception)
            {
                return -1;
            }            
        }
    }
}

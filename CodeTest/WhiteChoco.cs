using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // Derive white chocolate from chocopack
    public class WhiteChoco : ChocoPack
    {
        public WhiteChoco(string type, int cash, int price, int bonusRatio)
            :base(type, cash, price, bonusRatio)
        {
        }

        // Override getMilk function
        public override int getMilk()
        {
            try
            {
                int packCount = cash / price;
                int bonusCount = packCount / bonusRatio;
                return bonusCount;
            } catch (Exception)
            {
                return -1;
            }            
        }

        // Override getWhite function
        public override int getWhite()
        {
            try
            {
                int packCount = cash / price;
                int bonusCount = packCount / bonusRatio;
                return bonusCount + packCount;
            } catch (Exception)
            {
                return -1;
            }
        }
    }
}

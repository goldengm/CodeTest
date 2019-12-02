using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class ChocoPack
    {
        // string chocolate type
        public string type = "";

        // int order total cash
        public int cash = 0;

        // int prodcut price
        public int price = 0;

        // int bonus ratio
        public int bonusRatio = 0;

        public ChocoPack (string type, int cash, int price, int bonusRatio)
        {
            this.type = type;
            this.cash = cash;
            this.price = price;
            this.bonusRatio = bonusRatio;
        }


        // number of milk chocolates shopper will receive
        public virtual int getMilk()
        {
            return 0;
        }

        // number of dark chocolates shopper will receive
        public virtual int getDark()
        {
            return 0;
        }

        // number of white chocolates shopper will receive
        public virtual int getWhite()
        {
            return 0;
        }

        // print result to stdout
        public void printResult()
        {
            Console.WriteLine("milk " + getMilk() + ",dark " + getDark() + ",white " + getWhite());
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No filename inputed");
            }
            else
            {
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "/input/" + args[0];
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string currentLine;
                        int lineIndex = 0;
                        // currentLine will be null when the StreamReader reaches the end of file
                        while ((currentLine = sr.ReadLine()) != null)
                        {
                            if (lineIndex++ == 0) continue;

                            // Get chocolate type from line
                            string type = currentLine.Substring(0, currentLine.IndexOf(","));
                            currentLine = currentLine.Substring(currentLine.IndexOf(",") + 1);

                            // Get order cash from line
                            int cash = 0;
                            Int32.TryParse(currentLine.Substring(0, currentLine.IndexOf(",")), out cash);
                            currentLine = currentLine.Substring(currentLine.IndexOf(",") + 1);

                            // Get product price from line
                            int price = 0;
                            Int32.TryParse(currentLine.Substring(0, currentLine.IndexOf(",")), out price);
                            currentLine = currentLine.Substring(currentLine.IndexOf(",") + 1);

                            // Get order cash from line
                            int bonusRatio = 0;
                            Int32.TryParse(currentLine, out bonusRatio);

                            ChocoPack choco;
                            // Create chocolate instance by type
                            if (type == "\"milk\"")
                            {
                                choco = new MilkChoco(type, cash, price, bonusRatio);
                            }
                            else if (type == "\"dark\"")
                            {
                                choco = new DarkChoco(type, cash, price, bonusRatio);
                            }
                            else if (type == "\"white\"")
                            {
                                choco = new WhiteChoco(type, cash, price, bonusRatio);
                            }
                            else
                            {
                                choco = new ChocoPack(type, cash, price, bonusRatio);
                            }

                            // Print output
                            choco.printResult();                            
                        }
                    }
                }
                else
                {
                    Console.WriteLine("CSV file does not exist");
                }                
            }            
        }
    }
}

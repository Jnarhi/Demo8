using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan olio Noppa-luokasta
            Diceroll dice = new Diceroll();
            int number = dice.Heitto(); // 1-6
            // Console.WriteLine("Dice number is {0}", number);
            int one = 0; int two = 0; int three = 0; int four = 0; int five = 0; int six = 0;
            Console.WriteLine("How many times you want to throw dice? > ");
            int totalrolls = int.Parse(Console.ReadLine());
            Console.WriteLine("Dice is now thrown: {0}", totalrolls);
            for (int i = 1; i <= totalrolls; i++)
            {
                number = dice.Heitto(); // 1-6
                // Console.WriteLine("Dice number is {0}", number);
                switch (number)
                {
                    case 1:
                        one++;
                        break;
                    case 2:
                        two++;
                        break;
                    case 3:
                        three++;
                        break;
                    case 4:
                        four++;
                        break;
                    case 5:
                        five++;
                        break;
                    case 6:
                        six++;
                        break;

                }
            }
            int totalone = one * 1;
            int totaltwo = two * 2;
            int totalthree = three * 3;
            int totalfour = four * 4;
            int totalfive = five * 5;
            int totalsix = six * 6;
            double finaltotal = totalone + totaltwo + totalthree + totalfour + totalfive + totalsix;
            double average = finaltotal / totalrolls;

            Console.WriteLine("Average of all rolls: {0}", average);
            Console.WriteLine("1 count is: {0}", one);
            Console.WriteLine("2 count is: {0}", two);
            Console.WriteLine("3 count is: {0}", three);
            Console.WriteLine("4 count is: {0}", four);
            Console.WriteLine("5 count is: {0}", five);
            Console.WriteLine("6 count is: {0}", six);
        }
    }
}

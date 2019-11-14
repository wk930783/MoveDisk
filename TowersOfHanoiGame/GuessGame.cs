using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class GuessGame : IGame
    {

        string input;
        bool conversion = false;
        int I;

        int[] pax = new int[4];
        int[] fax = new int[4];

        int A = 0;
        int B = 0;


        public void Setup()
        {

            /*
            IList<int> temp = new List<int>();
            temp.Add(1);

            
            if (temp.Contains(5))
            {
                b++;
            }*/


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (pax[i] == pax[j])
                    {
                        if (i == j) { }
                        else
                        {
                            pax[i] = new Random().Next(10);
                        }
                    }
                    else
                    {
                        if (i != j)
                        {
                            pax[i] = new Random().Next(10);
                        }

                    }
                }
                Console.WriteLine($"{pax[i]}");


            }
            Console.ReadKey();
        }
        public void Play()
        {
            while (true)
            {
                while (true)
                {
                    A = 0;
                    B = 0;
                    Console.WriteLine("請輸入四個數字");
                    input = Console.ReadLine();
                    conversion = int.TryParse(input, out I);
                    if (conversion)
                    {
                        if (I < 10000 & I > -1)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("尼真ㄉ有看懂嗎");

                        }
                    }
                    else
                    {
                        Console.WriteLine("尼484想修怕");
                    }
                }

                int q;
                int w;
                int e;
                int r;
                q = I / 1000;
                w = (I - q * 1000) / 100;
                e = (I - q * 1000 - w * 100) / 10;
                r = (I - q * 1000 - w * 100 - e * 10) / 1;

                fax[0] = q;
                fax[1] = w;
                fax[2] = e;
                fax[3] = r;

                for (int X = 0; X < 4; X++)
                {
                    for (int O = 0; O < 4; O++)
                    {
                        if (fax[X] == pax[O])
                        {
                            if (X == O)
                            {
                                A++;
                            }
                            else
                            {
                                B++;
                            }
                        }
                    }
                }
                Console.WriteLine($"{A}A{B}B");

                Console.ReadKey();

                if (A == 4 && B == 0)
                {
                    Console.ReadKey();
                    break;

                }
            }

        }
    }
}

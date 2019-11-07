using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class HanoiGame
    {

        float result = -1;
        int disk = -1;
        int from = -1;
        int to = -1;
        int aux = -1;
        public void Setup()
        {

            bool conversion;
            string input;
            //輸入高度

            while (true)
            {
                Console.WriteLine("請輸入河內塔的高度：");
                input = Console.ReadLine();
                conversion = int.TryParse(input, out disk);
                if (conversion)
                {
                    if (disk > 0 && disk <= 10)
                    {
                        result = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("請輸入大於0且小於等於10的數值");
                    }
                }
                else
                {
                    Console.WriteLine("請輸入數字");
                }
            }
            /*
            try
            {
                
                disk = int.Parse(input);
                result = 1;
            }
            catch (Exception exp)
            {
                Console.WriteLine("請輸入數字");
                Console.WriteLine(exp.ToString());
                Console.ReadKey();
                throw;
            }*/

            while (true)
            {

                Console.WriteLine("起始地的柱子:(1,2,3)");

                input = Console.ReadLine();
                conversion = int.TryParse(input, out from);
                if (conversion)
                {
                    if (from > 0 && from <= 3)
                    {
                        result = 2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("請輸入大於0小於等於3的數值");
                    }
                }
                else
                {
                    Console.WriteLine("請輸入數字");
                }
            }
            /*
            try
            {
                from = int.Parse(input);
                result = 2;
            }
            catch (Exception exp)
            {
                Console.WriteLine("請輸入數字");
                Console.WriteLine(exp.ToString());
                Console.ReadKey();
                throw;
            }*/


            while (true)
            {
                Console.WriteLine("目的地的柱子：(1,2,3)");
                input = Console.ReadLine();
                conversion = int.TryParse(input, out to);
                if (conversion)
                {
                    if (to > 0 && to <= 3)
                    {
                        result = 3;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("請輸入大於0小於等於3的數值");
                    }
                }
                else
                {
                    Console.WriteLine("請輸入數字");
                }
            }
            /*
            try
            {
                to = int.Parse(input);
                result = 3;
            }
            catch (Exception exp)
            {
                Console.WriteLine("請輸入數字");
                Console.WriteLine(exp.ToString());
                Console.ReadKey();
                throw;
            }*/



            #region // 取得 第三柱子
            /* 例如 輸入 1 3  得到  2
             *      輸入 1 2  得到  3
             *      輸入 2 3  得到  1
             */
            aux = 0;
            int[] temp = { 1, 2, 3 };
            foreach (int item in temp)
            {
                if (item != from && item != to)
                {
                    aux = item;
                    break;
                }
            }
            #endregion


        }

        public void Play()
        {
            Hanoi(disk, from, to, aux);
            Console.ReadKey();
        }

        //參考演算法: http://notepad.yehyeh.net/Content/DS/CH02/4.php
        //參考演算法: http://program-lover.blogspot.com/2008/06/tower-of-hanoi.html
        public static void Hanoi(int Disk, int Src, int Dest, int Aux)
        {
            if (Disk == 1)
            {
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
            }
            else
            {
                Hanoi(Disk - 1, Src, Aux, Dest);
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                Hanoi(Disk - 1, Aux, Dest, Src);
            }
        }

    }
}

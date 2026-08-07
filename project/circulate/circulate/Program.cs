namespace circulate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("请输入一个数");
            int res = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while (i <= res)
            {
                sum = sum + i;
                i += 2;
            }
            Console.WriteLine($"{res}的累计奇数为{sum}");*/


            /* Console.WriteLine("请输入一个数");
             int res=int.Parse(Console.ReadLine());
             int i = 1;
             while (i <= res) 
             {
                 if (i % 3 == 0 && i % 5 == 0)
                  {
                      Console.WriteLine(i);

                  }
                  i++;
              }*/



            /*double money = 10;
            int i = 2;
            while (i <= 50) 
            { 
                money=money*1.05;
                i++;
            }
            Console.WriteLine(money);*/

            //********************************************************************************************

            //作业1
            /* int i ,sum=0;
             for ( i = 1; i <=100; i++)
             {
                 if (i % 2 == 0) 
                 {
                     sum += i;
                 }

             }
             Console.WriteLine($"偶数的和为{sum}");*/


            //作业2
            /*int i, j, count = 0;
            for (i = 1000; i <= 2000; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    Console.Write($"{i}\t");
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine();
                        count = 0;
                    }

                }
            }*/


            //作业3
            /* int i, j;
             for (i = 9; i > 0; i--)
             {

                 for (j = i; j > 0; j--)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();

             }*/



            //作业4
            /*double i=1, j=2;
            double sum =0;
            while (i<100)
            {
                sum += 1 / i - 1 / j;
                i = i + 2;
                j = j + 2;
            }
            Console.WriteLine(sum);*/



            //作业5
            /*int i, j;
            long n = 0;
            for (i = 1; i <= 10; i++)
            {
                long sum = 1;
                for (j = 1; j <= i; j++)
                {
                    sum = sum * j;
                }
                n = n + sum;
            }
            Console.WriteLine(n);*/


            //作业6
            /*double h = 5;
            int i = 0;
            do
            {
                h = h * 0.3;
                i++;
            } while (h > 0.1);
            Console.WriteLine($"第{i}次弹跳时高度为0.1");*/

            //作业7
            /* double n = 1;
             double num = 0;
             for (int i = 1; i <= 64; i++)
             {
                 num += n;
                 n = n * 2;

             }
             double res = num * 0.00001;
             Console.WriteLine(res);*/

            /*double res1 = 0;
            for (int i = 1; i <= 64; i++) 
            {
                res1 += Math.Pow(2,i-1);
            }
            Console.WriteLine(res1*0.00001);*/



            //作业8
            /*double money = 50000;
            int i = 0;
            while (money > 5000)
            {
                money = money - money * 0.05;
                i++;
                Console.WriteLine($"第{i}次扣费剩余{money}元");
            }*/



            //作业9
            /*int i;
            double num = 1;
            for (i = 6; i >= 1; i--)
            {
                num = (num + 1) * 2;
            }
            Console.WriteLine(num);*/



            //作业10
            /*double h = 10;
            double res = 10;
            for (int i = 1; i < 11; i++)
            {
                h = h * 0.5;
                res = res + h * 2;
                if (i == 10) res = res - h;

            }
            Console.WriteLine(res);*/























        }
    }
}

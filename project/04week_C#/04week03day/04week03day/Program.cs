namespace _04week03day
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //定义函数1
            /*var fn = (int n) =>
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j}*{i}={j * i}" + "\t");
                    }
                    Console.WriteLine();
                }

            };
            fn(8);*/

            //定义函数2
            /*void printline()
            {
                Console.WriteLine("====================================");
                Console.WriteLine("1.打印斐济杯");
                Console.WriteLine("1.打印周杰伦");
                Console.WriteLine("1.打印邹松钊");
                Console.WriteLine("1.打印王玉婷");
                Console.WriteLine("1.打印666");
            }

            printline();*/



            //定义函数2
            /*void printMeun(string st)
            {
                Console.WriteLine($"========{st}========");
                Console.WriteLine("1.打印斐济杯");
                Console.WriteLine("1.打印周杰伦");
                Console.WriteLine("1.打印邹松钊");
                Console.WriteLine("1.打印王玉婷");
                Console.WriteLine("1.打印666");
            }

            printMeun("图书管理系统");
            printMeun("学生管理系统");
            printMeun("商品管理系统");*/



            //作业1 
            /*var res = (double r, double need,double money =200) =>
            {
                double s = Math.PI * r * r;
                double total=s*money*need;
                return total;

            };
            double n=res(10,0.5);
            Console.WriteLine($"{n:F2}");*/

            //作业2
            /*int times(char x, string str = "qwerysssssqqqqwwweeeaaaaaaaaaaaaabbbbbb")
            {
                int count = 0;
                char[] arr = str.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i]==x)count++;
                }
                return count;
            }
             int num = times('b');
            Console.WriteLine(num);*/


            //作业3
            /*int[] arr = [10, 20, 5, 30, 50, 6, 7];
            int res(int[] x)
            {
                int min = 0;
                for(int i=1; i<x.Length; i++)
                {
                   if( x[i] < x[min])
                    {
                        min = i;
                    }
                }
                Console.WriteLine(min);
                return min;
            }
            res(arr);*/


            //作业4
            /*string str = "abcdcba";
            string stR = "abba";
            bool hui(string str1)
            {
                for (int i = 0; i < str1.Length/2; i++)
                {
                    if(str1[i] != str1[i]-1-i)
                    {
                        return false;
                    }     
                }
                return true;

            }
            Console.WriteLine(hui(str));*/
                

            
            






            //作业4
            /*void res()
            {
                Random aa = new Random();
                int num = aa.Next(0, 100);

                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"第{i}次");
                    Console.Write("请输入数字：");
                    int n = int.Parse(Console.ReadLine());

                    if (n<num)
                    {
                        Console.WriteLine("偏小");
                        Console.WriteLine();
                    }
                    else if (n > num)
                    {
                        Console.WriteLine("偏大");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("WIN");
                        Console.WriteLine();
                        break;
                    }
                    if(i==5&&n!=num) Console.WriteLine("GAME OVER");

                }
                
                Console.WriteLine($"随机数为{num}");
            }
            res();*/














        }
    }
}

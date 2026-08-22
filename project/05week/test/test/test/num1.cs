namespace test
{
    internal class num1
    {
        static void main(string[] args)
        {
            int[] Arr = new int[10];
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < 10; i++)
            {
                Random ran=new Random();
                int aa=ran.Next(1,50);
                Arr[i] = aa;
                sum += Arr[i];
            }
            avg=sum/Arr.Length;
           foreach (int i in Arr)
            {
                Console.Write($"{i}   ");   
            }
            Console.WriteLine();
            Console.WriteLine($"10个随机数总和：{sum}");
            Console.WriteLine($"10个随机数平均数：{avg}");





        }
    }
}

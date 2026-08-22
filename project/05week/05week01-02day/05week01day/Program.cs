using System.Text.Json;
using System.Text.RegularExpressions;

namespace _05week01day
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // 实例化图书对象
            BookManager BM = new BookManager("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true, // 美化格式内容
                AllowTrailingCommas = true,
            });


            string num = "";
            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("======欢迎来到图书管理系统======");
                Console.WriteLine("1: 新增图书");
                Console.WriteLine("2: 编辑图书");
                Console.WriteLine("3: 删除图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
                Console.WriteLine("6: 借阅图书");
                Console.WriteLine("7: 归还图书");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("----新增图书----");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        //double price = double.Parse(Console.ReadLine());
                        // 如果输入的不是 数字那么会报错===> 输入的数据格式不符合要求
                        // 使用正则处理
                        string priceStr = Console.ReadLine();
                        // @"^[1-9]+[0-9]*(\.[0-9]+)?$"
                        if (Regex.IsMatch(priceStr, @"^[1-9]+[0-9]*(\.[0-9]+)?$"))
                        {
                            // 组装 书籍 字典
                            Dictionary<string, dynamic> bookDic = new()
                            {
                                ["name"] = bookName,
                                ["author"] = author,
                                ["isBorrow"] = false,
                                ["id"] = new Random().NextDouble(),
                                ["mark"] = mark,
                                ["price"] = double.Parse(priceStr)
                            };
                            // 调用实例方法  实现 添加书籍
                            string res = BM.AddBook(bookDic);
                            Console.WriteLine(res);
                        }
                        else Console.WriteLine("输入的价格格式有误");
                        break;

                    case "2":
                        Console.WriteLine("----编辑图书----");
                        Console.WriteLine("请输入要进行编辑的书名");
                        string eitdbookName = Console.ReadLine();
                        Console.WriteLine("请输入书名");
                        string bookName1 = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author1 = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark1 = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        string priceStr1 = Console.ReadLine();
                        if (Regex.IsMatch(priceStr1,@"^[1-9]+[0-9]*(\.[0-9]+)?$"))
                        {
                            Dictionary<string, dynamic> bookDic1 = new()
                            {
                                ["name"] = bookName1,
                                ["author"] = author1,
                                ["mark"] = mark1,
                                ["price"] = priceStr1
                            };
                            string res1 = BM.EditBook(bookDic1, eitdbookName);
                            Console.WriteLine(res1);
                        }
                        else
                        {
                            Console.WriteLine("价格输入有误，请重新输入");
                        }
                            break;

                    case "3":
                        Console.WriteLine("----删除图书----");
                        Console.WriteLine("请输入要删除的书名");
                        string name1 = Console.ReadLine();
                        var reslist3 = BM.RemoveBook(name1);
                        Console.WriteLine(reslist3);
                        break;

   
                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        var reslist1= BM.SearchBook();
                        if(reslist1.Count==0) Console.WriteLine("没有图书，请先添加");
                        else 
                        foreach(dynamic item in reslist1)
                            {
                                Console.WriteLine($"书名：{item["name"]}--作者：{item["author"]}--标签：{item["mark"]}--价格：{item["price"]}--状态：{item["isBorrow"]}");
                            }
                            break;



                    case "5":
                        Console.WriteLine("----查询单个图书----");
                        Console.WriteLine("请输入要查询的书名");
                        string name= Console.ReadLine();
                        var reslist2 = BM.SearchBook(name);
                        if (reslist2.Count == 0) Console.WriteLine("没有图书，请先添加");
                        else
                         Console.WriteLine($"书名：{reslist2["name"]}--作者：{reslist2["author"]}--标签：{reslist2["mark"]}--价格：{reslist2["price"]}");
                             break;
                    case "6":
                        Console.WriteLine("借阅图书");
                        string name11 = Console.ReadLine();
                        var fds=BM.BorrowBook(name11);
                        Console.WriteLine(fds);


                        break;

                    case "7":
                        Console.WriteLine("归还图书");
                        break;

                    case "0":
                        Console.WriteLine("--**退出**--");
                        break;
                    default:
                        Console.WriteLine("****输入有误****");
                        break;
                }


                /*
后续同学自行完善 方向
    1. 对所有输入的数据进行校验
        - 可以先取出首尾两端的空白
        - 不为空，长度要求校验
        - 正则校验
    2. 完善一个借阅功能
        - 添加一个借阅功能的编号 比如： 5
            + 输入5 进入借阅功能
                - 将所有可借阅的书籍展示， 并要求用户输入借阅的书籍名称
                - 输入要借阅的书籍，实现借阅
    3. 完善一个还书功能  
*/


            }
        }
    }
}

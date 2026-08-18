using System.Text.Json;

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
                Console.WriteLine("2: 删除图书");
                Console.WriteLine("3: 编辑图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
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
                        double price = double.Parse(Console.ReadLine());
                        // 组装 书籍 字典
                        Dictionary<string, dynamic> bookDic = new()
                        {
                            ["name"] = bookName,
                            ["author"] = author,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["mark"] = mark,
                            ["price"] = price
                        };
                        // 调用实例方法  实现 添加书籍
                        string res = BM.AddBook(bookDic);
                        Console.WriteLine(res);




                        break;
                    case "2":
                        Console.WriteLine("----删除图书----");
                        Console.WriteLine("请输入要删除的书名");
                        string name1 = Console.ReadLine();
                        var reslist3 = BM.RemoveBook(name1);
                        if (reslist3.Count == 0) Console.WriteLine("未找到图书数据");
                        else
                        Console.WriteLine("删除成功！");
                        break;



                    case "3":
                        Console.WriteLine("----编辑图书----");
                        Console.WriteLine("请输入要编辑的书名");
                        
                        break;

                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        var reslist1= BM.SearchBook();
                        if(reslist1.Count==0) Console.WriteLine("没有图书，请先添加");
                        else 
                        foreach(dynamic item in reslist1)
                            {
                                Console.WriteLine($"书名：{item["name"]}--作者：{item["author"]}--标签：{item["mark"]}--价格：{item["price"]}");
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

                    case "0":
                        Console.WriteLine("--**退出**--");
                        break;
                    default:
                        Console.WriteLine("****输入有误****");
                        break;
                }


            }
        }
    }
}

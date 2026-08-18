using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _05week01day
{
    internal class BookManager
    {
        public string path { get; }  // 数据文件路径
        public JsonSerializerOptions JsonOpts { get; }// JSON序列化配置项
        // 新增数据：强制要求 ==> 将list写入文件中
        public string AddBook(Dictionary<string, dynamic> bookDic)
        {
            // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)
            // 新增的逻辑处理
            // 判断path路径是存在===> 不存在, 组装书籍list,序列化后 写入文件
            // 如果存在 =====> 先读取文件内容
            // 反序列化为list ====> 添加bookDic到list中
            // 序列化list ====> 写入文件
            List<Dictionary<string, dynamic>> bookList = new();
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);// 读取文件===>反序列化
                bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);// 反序列化
            }

            bookList.Add(bookDic);
            
            string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);//序列化
           
            File.WriteAllText(path, jsonStr); // 写入文件

            return "新增数据成功!!!";
        }


        // 编辑数据
        public string EditBook(string bookName)// 编辑的逻辑处理
        {
            

            
            return "ok";
        }






        // 删除数据
        public List<Dictionary<string, dynamic>> RemoveBook(string bookName)
        {
            List<Dictionary<string,dynamic>> aaa = new ();
            if (!File.Exists(path))return aaa;
            var json = File.ReadAllText(path);

            List<Dictionary<string, dynamic>> bbb = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            if (bbb == null) return bbb;
            List<Dictionary<string, dynamic>> ccc = bbb.Where(item => item["name"].ToString()!= bookName).ToList();

            string jsonStr = JsonSerializer.Serialize(ccc, JsonOpts);//序列化
            File.WriteAllText(path, jsonStr); // 写入文件
            return ccc;
        }





        // 查询所有数据
        public List<Dictionary<string, dynamic>> SearchBook() // 返回值根据情况修改
        {
            //先建立一个存放字典的列表，再读取文本内容添加到新列表里
            List<Dictionary<string, dynamic>> list1 = new();
            //先判断文件是否存在，不存在返回空list1
            if (!File.Exists(path)) return list1;
           //文件存在就读取文本内容后反序列化列表内容，再变成返回值
           var json = File.ReadAllText(path);
            list1 = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            return list1;

        }






        // 根据图书名称查询当前图书数据：强制要求
        public Dictionary<string, dynamic> SearchBook(string bookName) // 返回值根据情况修改
        {
            //先建立一个列表存放读取的数据
           Dictionary<string, dynamic> dic = new();
            //判断路径文件是否存在，不存在就返回空表
            if(!File.Exists(path)) return dic;
            //存在的话就读取文件再反序列化
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> list2 = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            Dictionary<string, dynamic> dic1 = list2.Find(item => item["name"].ToString() ==bookName);
            //与参数进行对比
            if(dic1 != null) return dic1;
            //返回查询图书的数据
            return dic;
        }






        // 自定义实例构造函数
        public BookManager(string bookPath, JsonSerializerOptions Opts)
        {
            // 实例化初始化属性
            path = bookPath;
            JsonOpts = Opts;
        }
    }
}

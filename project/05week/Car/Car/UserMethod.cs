using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Car
{
    internal class UserMethod
    {
        private string Path { get; } = "./User.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            //Json序列化时保持汉字不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };





        //新增用户
        public string Add(string name, string idCard,string Gender, string phoneNo, string Motto)
        {
            List<User> list=new List<User>();
            if (File.Exists(this.Path))
            {
                string str1 = File.ReadAllText(this.Path);
                 list = JsonSerializer.Deserialize<List<User>>(str1);
                if(list.Exists(item => item.IdCard==idCard))
                {
                    return "客户已存在，请勿重复添加";
                }
            }
            string RegTime = DateTime.Now.ToString();
            User UAdd = new User(list.Count + 1, name, idCard, RegTime, Gender, phoneNo, Motto);
            list.Add(UAdd);
            //序列化写入数据
            string res = JsonSerializer.Serialize(list, this.JsonOpt);
            File.WriteAllText(this.Path, res);
            return "新增客户成功";
        }



        public void SearchAll()
        {
            //判断文件是否存在,存在则读取数据
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("文件不存在");
                return;
            }
            string str = File.ReadAllText(this.Path);
            List<User> list = JsonSerializer.Deserialize<List<User>>(str);
            //遍历查询所有客户
            foreach (User item in list)
            {
                Console.WriteLine($"ID---{item.Id}   名字---{item.Name}   身份证号---{item.IdCard}   注册时间---{item.RegTime}   性别---{item.Gender}   电话号码---{item.phoneNo}   备注---{item.Motto}");
            }
            Console.WriteLine("查询成功"); 
        }


        public void SearchOne(string id)
        {
            //判断文件是否存在,存在则读取数据
            if (!File.Exists(this.Path))
            { 
                Console.WriteLine("文件不存在");
                return; 
            }
            string str = File.ReadAllText(this.Path);
            List<User> list = JsonSerializer.Deserialize<List<User>>(str);
            //查询客户
            User obj = list.Find(item => item.Id == int.Parse(id));
            if (obj == null) { Console.WriteLine("客户不存在"); return; }
            Console.WriteLine($"ID---{obj.Id}   名字---{obj.Name}   身份证号---{obj.IdCard}   注册时间---{obj.RegTime}   性别---{obj.Gender}   电话号码---{obj.phoneNo}   备注---{obj.Motto}");
            Console.WriteLine("查询成功");
        }




























    }
}

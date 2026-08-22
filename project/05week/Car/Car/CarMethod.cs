using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Car
{
    internal class CarMethod
    {
        private  string Path { get; } = "./Car.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            //Json序列化时保持汉字不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };


        //新增车辆
        public string Add(string carNum, string type, string price)
        {
            List<Car> carlist = new();
            //判断文件是否存在,存在则新增数据
            if (File.Exists(this.Path))
            {
                string str=File.ReadAllText(this.Path);
                carlist =JsonSerializer.Deserialize<List<Car>>(str);
                //判断是否有相同车辆
                if (carlist.Exists(item => item.CarNum == carNum)) return "新增失败，车辆已存在";
            }
            Car CAdd = new Car(carlist.Count+1, carNum, type,true, double.Parse(price));
            carlist.Add(CAdd);
            //序列化写入数据
            string res=JsonSerializer.Serialize(carlist,this.JsonOpt);
            File.WriteAllText(this.Path,res);
            return "新增车辆成功";
        }


        //查看单个车辆信息
        public string SearchOne(string id)
        {
            
            //判断文件是否存在,存在则读取数据
            if (!File.Exists(this.Path)) return "文件不存在";
            string str = File.ReadAllText(this.Path);
            List<Car> carlist = JsonSerializer.Deserialize<List<Car>>(str);
            //查询单个车辆
            Car aa=carlist.Find(item => item.Id == int.Parse(id));
            string freecar = aa.Static ? "空闲" : "已出租";
            Console.WriteLine($"ID---{aa.Id}   车牌号---{aa.CarNum}   车辆类型---{aa.Type}   状态---{freecar}   小时费用---{aa.Price}");
            return "查询成功";
        }

        //查看所有车辆信息
        public string SearchAll()
        {
            //判断文件是否存在,存在则读取数据
            if (!File.Exists(this.Path)) return "文件不存在";
            string str = File.ReadAllText(this.Path);
            List<Car> carlist = JsonSerializer.Deserialize<List<Car>>(str);
            //遍历查询所有车辆
            foreach(Car item in carlist)
            {
                string freecar = item.Static ? "空闲" : "已出租";
                Console.WriteLine($"ID---{item.Id}   车牌号---{item.CarNum}   车辆类型---{item.Type}   状态---{freecar}   小时费用---{item.Price}");
            }   
            return "查询成功";
        }

        //查看所有空闲车辆信息
        public string SearchFree()
        {
            //判断文件是否存在,存在则读取数据
            if (!File.Exists(this.Path)) return "文件不存在";
            string str = File.ReadAllText(this.Path);
            List<Car>  carlist = JsonSerializer.Deserialize<List<Car>>(str);
            List<Car> list=carlist.FindAll(item => item.Static);
            foreach(Car item in list)
            {
                string freecar = item.Static ? "空闲" : "已出租";
                Console.WriteLine($"ID---{item.Id}   车牌号---{item.CarNum}   车辆类型---{item.Type}   状态---{freecar}   小时费用---{item.Price}");
            }
            return "查询成功";
        }















































    }








}

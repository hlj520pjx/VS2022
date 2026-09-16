using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using test;

namespace test
{

    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }


        public Employee(int EmpId, string EmpName, string Department, double Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Department = Department;
            this.Salary = Salary;

        }

        public void ShowEmpInfo()
        {
            Console.WriteLine($"员工编号：{EmpId}，姓名：{EmpName}，部门：{Department}，薪资：{Salary:F2}");
        }

    }



    internal class Method
    {
        private string Path { get; } = "./employee.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            //Json序列化时保持汉字不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };

       



        internal string Add(string name, string dap, double money)
        {
            List< Employee> list= new ();
            if (File.Exists(this.Path))
            {
                string jsonstr = File.ReadAllText(this.Path);
                list = JsonSerializer.Deserialize<List<Employee>>(jsonstr);
                if(list.Exists(item => item.EmpName == name))
                {
                    return "员工已存在，请重新输入";
                }
            } 
            Employee adb=new Employee(list.Count+1, name, dap,money);
            list.Add(adb); 
            File.WriteAllText(this.Path,JsonSerializer.Serialize(list, this.JsonOpt));
            return "新增员工成功";
        }


        internal void SearchAll()
        {
            List<Employee> list = new();
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有员工信息，请添加"); 
            }
            string jsonstr = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<Employee>>(jsonstr);
            foreach(var item in list)
            {
                Console.WriteLine($"Id:{item.EmpId}   名字：{item.EmpName}   部门：{item.Department}   薪资：{item.Salary}");
                
            }
            Console.WriteLine("查看员工成功"); 
        }


        internal void adpmoney(string id,double money)
        {
            List<Employee> list = new();
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有员工信息，请添加");
            }
            string jsonstr = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<Employee>>(jsonstr);
            Employee em = list.Find(item => item.EmpId == int.Parse(id));
            em.Salary=money;
            File.WriteAllText(this.Path, JsonSerializer.Serialize(list, this.JsonOpt));

            Console.WriteLine("编辑薪资成功");
        }


        internal void del(string id)
        {
            List<Employee> list = new();
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有员工信息，请添加");
            }
            string jsonstr = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<Employee>>(jsonstr);
            Employee em = list.Find(item => item.EmpId == int.Parse(id));
            list.Remove(em);
            
            File.WriteAllText(this.Path, JsonSerializer.Serialize(list, this.JsonOpt));

            Console.WriteLine("删除成功");
        }



        internal void getmoney(double hope)
        {
            List<Employee> list = new();
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有员工信息，请添加");
            }
            string jsonstr = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<Employee>>(jsonstr);
            
            List<Employee> abc=list.FindAll(item => item.Salary > hope);
            foreach (var item in abc)
            {
                Console.WriteLine($"Id:{item.EmpId}   名字：{item.EmpName}   部门：{item.Department}   薪资：{item.Salary}");

            }
            Console.WriteLine("筛选成功");
        }




























    }








}

   
     


    


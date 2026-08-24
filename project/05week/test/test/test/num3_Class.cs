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
        //将私有字段和公开属性合并在一起
        //public int EmpId { get; set; }
        //public string EmpName { get; set; }
        //public string Department { get; set; }
        //public double Salary { get; set; }


        //定义私有字段，通过相应的公开属性来访问
        private int EmpId;
        private string EmpName ;
        private string Department ;
        private double Salary ;

        public int _EmpId
        {
            get { return this.EmpId; }
            set { this.EmpId = value; }
        }
        public  string _EmpName
        {
            get { return EmpName; }
            set { this.EmpName = value; }
        }
        public string _Department
        {
            get { return Department; }
            set { this.Department = value; }
        }
        public double _Salary
        {
            get { return Salary; }
            set { this.Salary = value; }
        }


        public Employee(int _EmpId, string _EmpName, string _Department, double _Salary)
        {
            this.EmpId = _EmpId;
            this.EmpName = _EmpName;
            this.Department = _Department;
            this.Salary = _Salary;

        }

        public void ShowEmpInfo()
        {
            Console.WriteLine($"员工编号：{EmpId}，姓名：{EmpName}，部门：{Department}，薪资：{Salary:F2}");
        }

        //public Employee() { }

        



        private string Path { get; } = "./employee.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            //Json序列化时保持汉字不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };

       



        public string Add(int EmpId, string EmpName, string Department, double Salary)
        {
            List< Employee> list= new ();
            if (File.Exists(this.Path))
            {
                string jsonstr = File.ReadAllText(this.Path);
                list = JsonSerializer.Deserialize<List<Employee>>(jsonstr);
                if(list.Exists(item => item.EmpName == EmpName))
                {
                    return "员工已存在，请重新输入";
                }
            } 
            Employee adb=new Employee(EmpId, EmpName, Department, Salary);
            list.Add(adb); 
            File.WriteAllText(this.Path,JsonSerializer.Serialize(list, this.JsonOpt));
            return "新增员工成功";
        }


        public void SearchAll()
        {
            List<Employee> list = new();
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有员工信息，请添加");
                return;
            }
            string jsonstr = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<Employee>>(jsonstr);
            if(list.Count==0)
            {
                Console.WriteLine("暂无员工数据");
                return;
            }
            foreach(Employee item in list)
            {
                item.ShowEmpInfo();
            }
            Console.WriteLine("查看员工成功"); 
        }


        public void adpmoney(string id, double money)
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


        public void del(string id)
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



        public void getmoney(double hope)
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

   
     


    


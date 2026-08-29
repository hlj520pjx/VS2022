namespace _05day
{
    public partial class Form1 : Form
    {
        List<Dictionary<string,dynamic>> data=new ();
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            data = new()
            {
                new Dictionary<string,dynamic>()
                {
                    ["id"]=1,
                    ["name"]="广西",
                    ["parent_id"]=0,
                },
                new Dictionary<string,dynamic>()
                {
                    ["id"]=2,
                    ["name"]="钦州",
                    ["parent_id"]=1,
                },
                new Dictionary<string,dynamic>()
                {
                    ["id"]=3,
                    ["name"]="南宁",
                    ["parent_id"]=1,
                },
                new Dictionary<string,dynamic>()
                {
                    ["id"]=4,
                    ["name"]="桂林",
                    ["parent_id"]=1,
                },
                new Dictionary<string,dynamic>()
                {
                    ["id"]=5,
                    ["name"]="广东",
                    ["parent_id"]=0,
                },
                new Dictionary<string,dynamic>()
                {
                    ["id"]=6,
                    ["name"]="深圳",
                    ["parent_id"]=5,
                },
                new Dictionary<string,dynamic>()
                {
                    ["id"]=7,
                    ["name"]="罗浮",
                    ["parent_id"]=5,
                },
                new Dictionary<string,dynamic>()
                {
                    ["id"]=8,
                    ["name"]="广州",
                    ["parent_id"]=5,
                }
            };

            List<Dictionary<string, dynamic>> prolist = data.FindAll(item => item["parent_id"] == 0);
            dynamic[] arr = prolist.Select(item => item["name"]).ToArray();
            comboBox1.Items.AddRange(arr);


        }
        //根据省份选择城市，二级联动
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string res = (sender as ComboBox).SelectedItem.ToString();
            int resid = data.Find(item => item["name"] == res)["id"];

            List<Dictionary<string, dynamic>> citylist = data.FindAll(item => item["parent_id"] == resid);
            dynamic[] cityarr = citylist.Select(item => item["name"]).ToArray();

            comboBox2.Text = "请输入城市";
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(cityarr.ToArray());
        }
    }
}

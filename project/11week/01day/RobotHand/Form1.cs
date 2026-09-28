using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RobotHand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 测试机械臂连接
            //开辟一块可以存 128 个字符的内存空间，DLL会把设备类型写进来
            StringBuilder fwType = new StringBuilder(128);
            //开辟一块可以存 128 个字符的内存空间，DLL会把设备版本写进来
            StringBuilder version = new StringBuilder(128);
            // 调用DLL中的函数，连接机械臂
            int ret = DobotDll.ConnectDobot("COM3", 115200, fwType, version);
            // 输出连接结果
            MessageBox.Show($"ConnectDobot 返回码:{ret}\n固件:{fwType}\n版本:{version}");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder fwType = new StringBuilder(128);
            StringBuilder version = new StringBuilder(128);
            int ret = DobotDll.ConnectDobot("COM3", 115200, fwType, version);
            if (ret == 0)
            {
                MessageBox.Show($"连接成功！\n固件:{fwType}\n版本:{version}");
            }
            else
            {
                MessageBox.Show($"连接失败，返回码:{ret}");
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            DobotDll.DisconnectDobot();
            MessageBox.Show("串口已断开");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 创建指令对象
            HOMECmd homeCmd = new HOMECmd();
            // 设置指令队列编号
            UInt64 cmdIndex = 0;
            // 调用回零函数
            int ret = DobotDll.SetHOMECmd(ref homeCmd, false, ref cmdIndex);
            if (ret == 0)
            {
                MessageBox.Show("回零指令下发成功，请观察机械臂运动");
            }
            else
            {
                MessageBox.Show($"回零调用失败，返回码:{ret}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PTPCmd ptpCmd = new PTPCmd();
            ptpCmd.ptpMode = 0; // 0：关节运动 MoveJ
            ptpCmd.x = 200;
            ptpCmd.y = 0;
            ptpCmd.z = 80;
            ptpCmd.rHead = 0;
            UInt64 cmdIndex = 0;
            int ret = DobotDll.SetPTPCmd(ref ptpCmd, false, ref cmdIndex);
            if (ret == 0)
            {
                MessageBox.Show("移动指令下发成功");
            }
            else
            {
                MessageBox.Show($"移动失败，返回码:{ret}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pose pose = new Pose();
            int ret = DobotDll.GetPose(ref pose);
            if (ret == 0)
            {
                string info = $"X:{pose.x:F2}\nY:{pose.y:F2}\nZ:{pose.z:F2}\nrHead:{pose.rHead:F2}";
                MessageBox.Show("当前机械臂坐标：\n" + info);
            }
            else
            {
                MessageBox.Show($"读取坐标失败，返回码:{ret}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UInt64 cmdIndex = 0;
            // 第二个参数true表示开启，false表示关闭
            int ret = DobotDll.SetEndEffectorSuctionCup(true, true, false, ref cmdIndex);
            if (ret == 0)
            {
                MessageBox.Show("吸盘吸气开启");
            }
            else
            {
                MessageBox.Show($"吸盘控制失败，返回码:{ret}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ret = DobotDll.SetQueuedCmdStopExec();
            MessageBox.Show($"停止队列引擎 返回值:{ret}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int ret = DobotDll.SetQueuedCmdClear();
            if (ret == 0)
            {
                MessageBox.Show("队列已清空");
            }
            else
            {
                MessageBox.Show($"清空队列失败，返回码:{ret}");
            }
        }
    }
}

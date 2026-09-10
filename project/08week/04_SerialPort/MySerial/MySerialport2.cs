using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySerial
{
    public partial class MySerialport2 : Form
    {
        public MySerialport2()
        {
            InitializeComponent();
            this.Shown += MySerialport1_init;

            button1.Click += OpenCOM1;
            button2.Click += SendData;
        }

        private int Ypoint = 0;
        SerialPort myPort;
        Stream ST;

        private void MySerialport1_init(object? sender, EventArgs e)
        {
            //创建串口1
            myPort = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);


        }

        private void OpenCOM1(object? sender, EventArgs e)
        {
            myPort.Open();

            ST = myPort.BaseStream;
            readData();
        }

        private async void SendData(object? sender, EventArgs e)
        {
            if (!myPort.IsOpen)
            {
                MessageBox.Show("串口未打开");
                return;
            }
            await ST.WriteAsync(Encoding.UTF8.GetBytes(textBox1.Text));

        }

        //打开串口1后一直读取信息
        private async void readData()
        {
            byte[] Buffer = new byte[1024];
            while (true)
            {
                int len = await ST.ReadAsync(Buffer, 0, Buffer.Length);
                if (len < 0)
                {
                    MessageBox.Show("连接失败");
                    return;
                }
                string res = Encoding.UTF8.GetString(Buffer, 0, len);

                Label lab = new Label();
                lab.Text = res;
                lab.Size = new Size(300, 30);
                lab.Location = new Point(0, Ypoint * 30);
                panel1.Controls.Add(lab);
                Ypoint++;
            }
        }
    }
}

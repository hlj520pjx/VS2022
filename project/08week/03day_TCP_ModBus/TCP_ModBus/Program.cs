using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCP_ModBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建Tcp监听器对象，这个对象有ip和端口号
            string ip="127.0.0.1";
            IPAddress IP=IPAddress.Parse(ip);
            int Port = 8868;
            TcpListener listener = new TcpListener(IP, Port);

            //启动Tcp服务器
            listener.Start();

            //创造客户端对象
            TcpClient Myclient = listener.AcceptTcpClient();

            //创造数据管道，让服务器可以通过数据管道.Write(字节数组的形式的数据)给客户端发送数据
            //或者通过数据管道.read(字节数组的形式的数据)接受数据
            NetworkStream stream = Myclient.GetStream();

            //创建字节数组方便接收数据
            byte[] Byte=new byte[1024];
            //死循环接收数据
            while (true)
            {
                //定义len来接收读取管道中的有效数据长度，比如字节数组只有5个字节那长度就是5
                int len=stream.Read(Byte, 0, Byte.Length);

                //获取客户端的ip信息
                //Myclient.Client代表客户端的网络属性(ip,端口号)，RemoteEndPoint可以获得Myclient.Client里面的ip和端口号
                string Client = Myclient.Client.RemoteEndPoint?.ToString();
                Console.WriteLine($"有客户端连接：{Client}");

                //将接收到的客户端数据解码成字符串
                string receiveData=System.Text.Encoding.UTF8.GetString(Byte,0,len);
                Console.WriteLine(receiveData);

                //将我们发送的内容进行编码(将字符串转换为字符数组)后发送给客户端
                string str = "你们好";
                byte[] sendData= Encoding.UTF8.GetBytes(str);
                stream.Write(sendData,0, sendData.Length);


            }




        }
    }
}

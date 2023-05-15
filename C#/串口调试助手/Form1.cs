using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;






namespace 串口调试助手
{
    public partial class MainForm : Form
    {
        //private Timer serialTimer;
        private System.Windows.Forms.Timer serialTimer;

        private SerialPort _serialPort;
        // 获取系统中可用的串口列表
        private string[] portNames; // = SerialPort.GetPortNames();

        private Queue<string> dataQueue_serial = new Queue<string>();  // 定义消息队列

        //serialTimer =new Timer();






        public MainForm()
        {
            InitializeComponent();

            comboBox_baudRate.SelectedIndex = 0;
            comboBox_dataBit.SelectedIndex = 3; // 将第4个项设置为默认选中项


            // 获取系统中可用的串口列表
            string[] portNames = SerialPort.GetPortNames();
            comboBox_serialPort.Items.Clear();


            // 遍历串口列表
            foreach (string portName in portNames)
            {
                // 获取串口描述信息
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%" + portName + "%'");
                foreach (ManagementObject portInfo in searcher.Get())
                {
                    // 输出串口描述信息
                    Console.WriteLine(portInfo["Description"].ToString());

                    comboBox_serialPort.Items.Add(portName + " " + portInfo["Description"].ToString());
                    comboBox_serialPort.SelectedIndex = 0;
                }
            }
            rtxDataReceive.AppendText(comboBox_serialPort.Items[0].ToString());

#if true
            //实例化一个定时器
            serialTimer = new System.Windows.Forms.Timer();

            serialTimer.Interval = 1000; // 1000ms = 1s
            serialTimer.Tick += new EventHandler(Timer_Tick);
            serialTimer.Stop();
#endif
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 在这里添加定时执行的代码
            //MessageBox.Show("定时器触发！");
            // 获取当前电脑上所有可用的串口
            //string[] portNames = SerialPort.GetPortNames();
            //if (portNames != null && portNames.Length > 0)
            //{
            //    // 字符串数组不为空
            //    comboBox_serialPort.Items.Clear();
            //    comboBox_serialPort.Items.AddRange(portNames);
            //}
            //else
            //{
            //    // 字符串数组为空
            //}
            if (chkAutowrap.Checked)
            {
                rtxDataReceive.AppendText(Environment.NewLine);
            }
            serialTimer.Stop();

        }

        private void comboBox_serialPort_DropDown(object sender, EventArgs e)
        {
            int maxWidth = 0;
            foreach (var item in comboBox_serialPort.Items)
            {
                int itemWidth = TextRenderer.MeasureText(item.ToString(), comboBox_serialPort.Font).Width;
                if (itemWidth > maxWidth)
                {
                    maxWidth = itemWidth;
                }
            }
            comboBox_serialPort.DropDownWidth = maxWidth;
        }


        private void button_SerialOpenClose_Click(object sender, EventArgs e)
        {
            if (button_SerialOpenClose.Text == "打开串口")
            {
                string[] port = comboBox_serialPort.Text.Split(' ');

                Console.WriteLine(port[0]);
                int baudRate;
                int dataBit;
                int.TryParse(comboBox_baudRate.Text, out baudRate);
                int.TryParse(comboBox_dataBit.Text, out dataBit);

                _serialPort = new SerialPort(port[0], baudRate, Parity.None, dataBit, StopBits.One);
                try
                {
                    _serialPort.Open();
                    _serialPort.ErrorReceived += SerialPort_ErrorReceived;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    button_SerialOpenClose.Text = "关闭串口";
                    Console.WriteLine("串口正常打开");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("串口不存在");
                }
            }
            else
            {
                try
                {
                    //关闭串口
                    _serialPort.Close();
                    button_SerialOpenClose.Text = "打开串口";
                    Console.WriteLine("串口正常关闭");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("串口关闭异常");
                }
            }
        }
        //使用SerialPort类打开了串口设备，然后订阅了ErrorReceived事件。
        //在该事件处理函数中，我们检测到串口设备被拔出时，可以进行一些处理，例如关闭串口等。
        //需要注意的是，ErrorReceived事件会在串口出现错误时触发，例如数据接收错误、硬件故障等，
        //因此在处理事件时需要对错误类型进行判断，以避免误判。在检测到设备被拔出后，我们可以调用SerialPort类的Close方法关闭串口。
        private void SerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (e.EventType == SerialError.RXOver || e.EventType == SerialError.Overrun || e.EventType == SerialError.Frame || e.EventType == SerialError.RXParity)
            {
                Console.WriteLine("串口设备已被拔出");
                this._serialPort.Close();
            }
        }

        private void btnSerialDataSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoAsciiSend.Checked)
                {
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(rtxSend.Text); // 将字符串转换为ASCII码
                    _serialPort.Write(asciiBytes, 0, asciiBytes.Length);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("串口异常：\n" +
                    "串口没打开");
            }

        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            string data = port.ReadExisting();

#if false



            try
            {
                // 在 UI 线程中更新 RichTextBox 控件
                BeginInvoke(new Action(() =>
                {
                    // 将数据添加到 RichTextBox 中             
                    rtxDataReceive.AppendText(data);
                }));
                //this.rtxDataReceive.AppendText(data);

                if (chkAutowrap.Checked)
                {
                    BeginInvoke(new Action(() =>
                    {
                        // 将数据添加到 RichTextBox 中
                        rtxDataReceive.AppendText(Environment.NewLine);

                    }));
                }

            }
            catch
            {
                MessageBox.Show("接收数据异常");
            }
#else
            // 将数据添加到消息队列中
            lock (dataQueue_serial)
            {
                dataQueue_serial.Enqueue(data);
            }

            // 向 UI 线程发送消息
            BeginInvoke(new Action(ProcessDataQueue));

            // 在 UI 线程上启动定时器
            Invoke(new Action(() =>
            {
                serialTimer.Interval = 100;
                serialTimer.Start();
            }));


#endif

        }

        private void ProcessDataQueue()
        {
            string data;
            lock (dataQueue_serial)
            {
                // 从队列中取出所有数据
                while (dataQueue_serial.Count > 0)
                {
                    data = dataQueue_serial.Dequeue();
      
                    // 将数据添加到 RichTextBox 中
                    rtxDataReceive.AppendText(data);           
                }

                // 将滚动条位置设置为最大值
                rtxDataReceive.SelectionStart = rtxDataReceive.TextLength;
                rtxDataReceive.ScrollToCaret();

            }
        }
        private void chkAutowrap_CheckedChanged(object sender, EventArgs e)
        {
            //if (!chkAutowrap.Checked)
            //{
            //    rtxDataReceive.WordWrap = false;
            //    Console.WriteLine("关闭自动换行");
            //}
            //else
            //{
            //    rtxDataReceive.WordWrap = true;
            //    Console.WriteLine("使能自动换行");
            //}
        }
    }
}

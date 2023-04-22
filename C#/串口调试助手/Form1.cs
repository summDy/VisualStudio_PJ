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


namespace 串口调试助手
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private SerialPort _serialPort;
        // 获取系统中可用的串口列表
        private string[] portNames;// = SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1000ms = 1s
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

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

                    comboBox_serialPort.Items.Add(portInfo["Description"].ToString() + "(" + portName + ")");
                    comboBox_serialPort.SelectedIndex = 0;
                }
            }
            richTextBox_dataReceive.AppendText(comboBox_serialPort.Items[0].ToString());
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {











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



        }

        private void comboBox_serialPort_SelectedIndexChanged(object sender, EventArgs e)
        {



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

        private void button2_Click(object sender, EventArgs e)
        {
            _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口不存在");
            }

            _serialPort.ErrorReceived += SerialPort_ErrorReceived;

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
    }
}

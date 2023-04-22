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

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1000ms = 1s
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // 获取系统中可用的串口列表
            string[] ports = SerialPort.GetPortNames();

            // 遍历串口列表，获取每个串口的描述信息
            foreach (string port in ports)
            {
                string description = string.Empty;

                //ManagementObjectSearcher searcher = new ManagementObjectSearcher(port);
                // 查询串口的描述信息
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_SerialPort WHERE DeviceID='" + port + "'");
                foreach (ManagementObject portInfo in searcher.Get())
                {
                    description = portInfo["Description"].ToString();
                }


                // 输出串口及其描述信息
                Console.WriteLine("串口名：{0}，描述信息：{1}", port, description);
            }


            // 获取串口列表
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
                }
            }





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
    }
}

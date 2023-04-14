using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace liuhe
{
    public partial class liuhe : Form
    {
        public liuhe()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("huiweiyong");
            float revenue;

            //调用方法
            //实现实例化之后，才能用
            MyClass myclass = new MyClass();
            string text = this.textBox1.Text;

            revenue = myclass.myMethod(myclass.aomenLiuHeData2021);
            richTextBox1.AppendText("年营收： " + text+ "\r\n");

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }




    public class MyClass
    {
        //类成员
        public  int[] aomenLiuHeData2021 = { 
            3, 3, 3, 1, 2, 1, 2, 1, 3, 1, 3, 3, 2, 3, 1, 1, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 1, 2, 2, 3, 3, // 1月
            3, 3, 2, 2, 3, 2, 2, 2, 2, 3, 3, 3, 3, 2, 3, 2, 1, 2, 2, 2, 3, 2, 2, 2, 1, 3, 3, 2,          // 2月
            2, 1, 1, 3, 1, 2, 2, 3, 3, 3, 2, 2, 3, 2, 1, 3, 3, 2, 1, 2, 1, 1, 2, 2, 2, 3, 3, 3, 1, 1, 2, // 3月
            1, 3, 1, 1, 1, 1, 3, 2, 1, 2, 3, 2, 2, 1, 2, 1, 3, 1, 3, 3, 3, 1, 3, 1, 3, 2, 3, 2, 3, 1,    // 4月
            3, 1, 3, 1, 3, 1, 3, 3, 1, 2, 1, 1, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 2, 1, 1, 1, 1, 2, 2, 3, // 5月
            3, 3, 2, 3, 2, 3, 1, 2, 1, 3, 3, 3, 1, 1, 2, 2, 3, 1, 1, 1, 3, 1, 3, 3, 2, 3, 1, 2, 3, 2,    // 6月
            3, 2, 3, 1, 3, 1, 1, 2, 1, 1, 3, 2, 3, 2, 3, 2, 1, 3, 2, 3, 2, 1, 1, 3, 2, 3, 2, 1, 3, 1, 2, // 7月
            2, 2, 3, 3, 2, 2, 3, 2, 2, 3, 1, 3, 1, 2, 3, 3, 3, 3, 3, 3, 3, 2, 1, 1, 3, 2, 1, 3, 2, 2, 1, // 8月
            2, 2, 1, 3, 1, 1, 3, 2, 3, 1, 2, 1, 1, 3, 2, 2, 2, 1, 2, 3, 1, 1, 2, 1, 2, 2, 1, 2, 1, 2,    // 9月
            2, 2, 1, 1, 1, 2, 3, 1, 1, 3, 3, 3, 3, 1, 3, 2, 2, 1, 3, 1, 3, 2, 3, 2, 1, 3, 3, 3, 3, 3, 1, // 10月
            1, 2, 1, 2, 1, 3, 3, 2, 1, 3, 2, 3, 1, 3, 1, 2, 2, 2, 1, 2, 3, 2, 2, 1, 1, 2, 2, 3, 2, 3,    // 11月
            3, 1, 1, 1, 2, 3, 2, 1, 2, 1, 2, 2, 3, 1, 2, 3, 1, 3, 1, 3, 2, 2, 1, 2, 2, 2, 3, 1, 3, 2, 2  // 12月
                                                                                                        
        };

        //public static readonly string arrayName = { value1, value2, ..., valueN };
      

        public float myMethod(int[] liuHeData )
        {
            float revenue;
            revenue = 30000;
            //方法实现
            Console.WriteLine("我为什么要这么做" + aomenLiuHeData2021[1]);
            if (liuHeData[3] == 3)
            {
                Console.WriteLine("中\n");
            }
            else
            {
                Console.WriteLine("不中\n");
            }
            return revenue;
        }
    }


}

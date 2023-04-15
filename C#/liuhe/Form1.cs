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
using MarkSix;


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
            float revenue=0;

            //调用方法
            //实现实例化之后，才能用

            string text = this.textBox1.Text;

            Macao liuHeMacao = new Macao();
            liuHeMacao.odds = 42;
            
            //准备资金，字符串转float
            float.TryParse(textBox1.Text, out liuHeMacao.cashPooling);

            richTextBoxOut.AppendText("准备资金:" + liuHeMacao.cashPooling + "\r\n");
            if (comboBoxYears.Text == "2022")
            {
                revenue = liuHeMacao.myMethod(liuHeMacao.aomenLiuHeData2022, liuHeMacao.odds, 5);
            }
            else
            {
                revenue = liuHeMacao.myMethod(liuHeMacao.aomenLiuHeData2021, liuHeMacao.odds, 5);
            }

            richTextBoxOut.AppendText("中奖次数：" + liuHeMacao.WinningNum + "\r\n");
            richTextBoxOut.AppendText("年营收： " + revenue + "\r\n");
            Console.WriteLine(comboBoxYears.Text);

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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


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
            float revenue = 0;

            //调用方法
            //实现实例化之后，才能用

            string text = this.textBox_reserve.Text;

            Macao liuHeMacao = new Macao();
            Hongkong liuHeHK = new Hongkong();


            //准备资金，字符串转float
            float.TryParse(textBox_reserve.Text, out liuHeMacao.cashPooling);
            if (liuHeMacao.cashPooling == 0)
            {

                MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
            }
            //赔率，字符串转int
            int.TryParse(textBox_odds.Text, out liuHeMacao.odds);
            if (liuHeMacao.odds == 0)
            {
                MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
            }


            richTextBoxOut.AppendText("准备资金:" + liuHeMacao.cashPooling + "\r\n");


            if (radioButton_HongKong.Checked)
            {
                // 当选中 radioButton_HongKong 控件时执行的代码
                // 当选中 radioButton_Macao 控件时执行的代码
                if (comboBoxYears.Text == "2021")
                {
                    //revenue = liuHeMacao.myMethod(liuHeMacao.aomenLiuHeData2021, liuHeMacao.odds, 5);
                    //richTextBoxOut.AppendText("2021年的数据" + "\r\n");
                }
                else if (comboBoxYears.Text == "2022")
                {
                    revenue = liuHeMacao.myMethod(liuHeHK.HongkongLiuHeData2022, liuHeMacao.odds, 5);
                    richTextBoxOut.AppendText("2022年的数据" + "\r\n");
                }
                else { }

                richTextBoxOut.AppendText("中奖次数：" + liuHeMacao.WinningNum + "\r\n");
                richTextBoxOut.AppendText("资金池最小金额：" + liuHeMacao.cashPoolingMix + "\r\n");
                richTextBoxOut.AppendText("年营收： " + revenue + "\r\n");
            }
            else if (radioButton_Macao.Checked)
            {
                // 当选中 radioButton_Macao 控件时执行的代码
                if (comboBoxYears.Text == "2021")
                {
                    if (comboBox_algorithm.Text == "反转双线")
                    {
                        revenue = liuHeMacao.twoLine_ColorInversion(liuHeMacao.aomenLiuHeData2021, liuHeMacao.odds, 5);
                    }
                    else
                    {
                        revenue = liuHeMacao.myMethod(liuHeMacao.aomenLiuHeData2021, liuHeMacao.odds, 5);
                    }
                    richTextBoxOut.AppendText("2021年的数据" + "\r\n");
                }
                else if (comboBoxYears.Text == "2022")
                {
                    if (comboBox_algorithm.Text == "反转双线")
                    {
                        revenue = liuHeMacao.twoLine_ColorInversion(liuHeMacao.aomenLiuHeData2022, liuHeMacao.odds, 5);
                    }
                    else
                    {
                        revenue = liuHeMacao.myMethod(liuHeMacao.aomenLiuHeData2022, liuHeMacao.odds, 5);
                    }
                    richTextBoxOut.AppendText("2022年的数据" + "\r\n");
                }
                else { }

                richTextBoxOut.AppendText("中奖次数：" + liuHeMacao.WinningNum + "\r\n");
                richTextBoxOut.AppendText("连续不中奖最大数：" + liuHeMacao.bettingFailedMax + "\r\n");
                richTextBoxOut.AppendText("资金池最小金额：" + liuHeMacao.cashPoolingMix + "\r\n");
                richTextBoxOut.AppendText("年营收： " + revenue + "\r\n");

            }
            else { }

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

        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBoxOut.Clear();
        }
    }

}

using System;
using System.Windows.Forms;


namespace tooloptions
{
    public partial class Options :Form
    {
        #region Windows 窗体设计器生成的代码

        private Button button_confirm;
        private Button button_cancel;
        private Button button_apply;

        #endregion
        public Options()
        {
            InitializeComponent();
        }


        #region Windows 窗体设计器生成的代码


        private void InitializeComponent()
        {
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(396, 482);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 0;
            this.button_confirm.Text = "确认";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(558, 482);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 2;
            this.button_apply.Text = "应用";
            this.button_apply.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(477, 482);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.ClientSize = new System.Drawing.Size(645, 517);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_confirm);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }
        #endregion

        private void button_confirm_Click(object sender, EventArgs e)
        {

        }
    }
}


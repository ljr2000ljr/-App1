namespace 会员App1
{
    partial class 会员
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.VIPPhone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.VIPSex = new System.Windows.Forms.Label();
            this.VIPAddress = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.VIPAdd = new System.Windows.Forms.Button();
            this.VIPSearch = new System.Windows.Forms.Button();
            this.VIPChange = new System.Windows.Forms.Button();
            this.VIPDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VIPPhone
            // 
            this.VIPPhone.AutoSize = true;
            this.VIPPhone.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VIPPhone.Location = new System.Drawing.Point(69, 168);
            this.VIPPhone.Name = "VIPPhone";
            this.VIPPhone.Size = new System.Drawing.Size(124, 28);
            this.VIPPhone.TabIndex = 0;
            this.VIPPhone.Text = "会员电话";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 28);
            this.textBox1.TabIndex = 1;
            // 
            // VIPSex
            // 
            this.VIPSex.AutoSize = true;
            this.VIPSex.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VIPSex.Location = new System.Drawing.Point(69, 245);
            this.VIPSex.Name = "VIPSex";
            this.VIPSex.Size = new System.Drawing.Size(124, 28);
            this.VIPSex.TabIndex = 2;
            this.VIPSex.Text = "会员性别";
            // 
            // VIPAddress
            // 
            this.VIPAddress.AutoSize = true;
            this.VIPAddress.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VIPAddress.Location = new System.Drawing.Point(69, 320);
            this.VIPAddress.Name = "VIPAddress";
            this.VIPAddress.Size = new System.Drawing.Size(124, 28);
            this.VIPAddress.TabIndex = 4;
            this.VIPAddress.Text = "会员地址";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 28);
            this.textBox2.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(228, 245);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 22);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(314, 245);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 22);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // VIPAdd
            // 
            this.VIPAdd.Location = new System.Drawing.Point(536, 68);
            this.VIPAdd.Name = "VIPAdd";
            this.VIPAdd.Size = new System.Drawing.Size(142, 38);
            this.VIPAdd.TabIndex = 8;
            this.VIPAdd.Text = "会员开通";
            this.VIPAdd.UseVisualStyleBackColor = true;
            // 
            // VIPSearch
            // 
            this.VIPSearch.Location = new System.Drawing.Point(536, 167);
            this.VIPSearch.Name = "VIPSearch";
            this.VIPSearch.Size = new System.Drawing.Size(142, 38);
            this.VIPSearch.TabIndex = 9;
            this.VIPSearch.Text = "会员查询";
            this.VIPSearch.UseVisualStyleBackColor = true;
            this.VIPSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // VIPChange
            // 
            this.VIPChange.Location = new System.Drawing.Point(536, 268);
            this.VIPChange.Name = "VIPChange";
            this.VIPChange.Size = new System.Drawing.Size(142, 38);
            this.VIPChange.TabIndex = 10;
            this.VIPChange.Text = "会员修改";
            this.VIPChange.UseVisualStyleBackColor = true;
            // 
            // VIPDelete
            // 
            this.VIPDelete.Location = new System.Drawing.Point(536, 364);
            this.VIPDelete.Name = "VIPDelete";
            this.VIPDelete.Size = new System.Drawing.Size(142, 38);
            this.VIPDelete.TabIndex = 11;
            this.VIPDelete.Text = "会员删除";
            this.VIPDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 84);
            this.label1.TabIndex = 12;
            this.label1.Text = "会员信息";
            // 
            // 会员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VIPDelete);
            this.Controls.Add(this.VIPChange);
            this.Controls.Add(this.VIPSearch);
            this.Controls.Add(this.VIPAdd);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.VIPAddress);
            this.Controls.Add(this.VIPSex);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VIPPhone);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "会员";
            this.Text = "会员";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VIPPhone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label VIPSex;
        private System.Windows.Forms.Label VIPAddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button VIPAdd;
        private System.Windows.Forms.Button VIPSearch;
        private System.Windows.Forms.Button VIPChange;
        private System.Windows.Forms.Button VIPDelete;
        private System.Windows.Forms.Label label1;
    }
}


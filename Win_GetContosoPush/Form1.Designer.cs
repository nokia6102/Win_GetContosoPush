﻿namespace Win_TestPicClassify
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TestConnect_Btn = new System.Windows.Forms.Button();
            this.Pass_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserName_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SQLValid_Radio = new System.Windows.Forms.RadioButton();
            this.WinValid_Radio = new System.Windows.Forms.RadioButton();
            this.DBName_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerName_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StoredProcedure_Text = new System.Windows.Forms.TextBox();
            this.RunClassify_Btn = new System.Windows.Forms.Button();
            this.Result_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbProductid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TestConnect_Btn
            // 
            this.TestConnect_Btn.Location = new System.Drawing.Point(563, 43);
            this.TestConnect_Btn.Name = "TestConnect_Btn";
            this.TestConnect_Btn.Size = new System.Drawing.Size(75, 23);
            this.TestConnect_Btn.TabIndex = 10;
            this.TestConnect_Btn.Text = "測試連接";
            this.TestConnect_Btn.UseVisualStyleBackColor = true;
            this.TestConnect_Btn.Click += new System.EventHandler(this.TestConnect_Btn_Click);
            // 
            // Pass_Text
            // 
            this.Pass_Text.Enabled = false;
            this.Pass_Text.Location = new System.Drawing.Point(395, 73);
            this.Pass_Text.Name = "Pass_Text";
            this.Pass_Text.Size = new System.Drawing.Size(132, 22);
            this.Pass_Text.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "密碼：";
            // 
            // UserName_Text
            // 
            this.UserName_Text.Enabled = false;
            this.UserName_Text.Location = new System.Drawing.Point(395, 45);
            this.UserName_Text.Name = "UserName_Text";
            this.UserName_Text.Size = new System.Drawing.Size(132, 22);
            this.UserName_Text.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "帳號：";
            // 
            // SQLValid_Radio
            // 
            this.SQLValid_Radio.AutoSize = true;
            this.SQLValid_Radio.Location = new System.Drawing.Point(266, 48);
            this.SQLValid_Radio.Name = "SQLValid_Radio";
            this.SQLValid_Radio.Size = new System.Drawing.Size(68, 16);
            this.SQLValid_Radio.TabIndex = 5;
            this.SQLValid_Radio.Text = "SQL驗證";
            this.SQLValid_Radio.UseVisualStyleBackColor = true;
            this.SQLValid_Radio.CheckedChanged += new System.EventHandler(this.SQLValid_Radio_CheckedChanged);
            // 
            // WinValid_Radio
            // 
            this.WinValid_Radio.AutoSize = true;
            this.WinValid_Radio.Checked = true;
            this.WinValid_Radio.Location = new System.Drawing.Point(266, 25);
            this.WinValid_Radio.Name = "WinValid_Radio";
            this.WinValid_Radio.Size = new System.Drawing.Size(91, 16);
            this.WinValid_Radio.TabIndex = 4;
            this.WinValid_Radio.TabStop = true;
            this.WinValid_Radio.Text = "Windows驗證";
            this.WinValid_Radio.UseVisualStyleBackColor = true;
            // 
            // DBName_Text
            // 
            this.DBName_Text.Location = new System.Drawing.Point(79, 53);
            this.DBName_Text.Name = "DBName_Text";
            this.DBName_Text.Size = new System.Drawing.Size(152, 22);
            this.DBName_Text.TabIndex = 3;
            this.DBName_Text.Text = "Concoso_8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "資料庫：";
            // 
            // ServerName_Text
            // 
            this.ServerName_Text.Location = new System.Drawing.Point(79, 25);
            this.ServerName_Text.Name = "ServerName_Text";
            this.ServerName_Text.Size = new System.Drawing.Size(152, 22);
            this.ServerName_Text.TabIndex = 1;
            this.ServerName_Text.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "伺服器：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TestConnect_Btn);
            this.groupBox1.Controls.Add(this.Pass_Text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.UserName_Text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SQLValid_Radio);
            this.groupBox1.Controls.Add(this.WinValid_Radio);
            this.groupBox1.Controls.Add(this.DBName_Text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ServerName_Text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "資料庫連接";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "預存程序：";
            // 
            // StoredProcedure_Text
            // 
            this.StoredProcedure_Text.Location = new System.Drawing.Point(509, 278);
            this.StoredProcedure_Text.Name = "StoredProcedure_Text";
            this.StoredProcedure_Text.Size = new System.Drawing.Size(169, 22);
            this.StoredProcedure_Text.TabIndex = 8;
            this.StoredProcedure_Text.Text = "usp_GetQueryFromSSAS";
            // 
            // RunClassify_Btn
            // 
            this.RunClassify_Btn.Location = new System.Drawing.Point(698, 273);
            this.RunClassify_Btn.Name = "RunClassify_Btn";
            this.RunClassify_Btn.Size = new System.Drawing.Size(87, 29);
            this.RunClassify_Btn.TabIndex = 9;
            this.RunClassify_Btn.Text = "推薦";
            this.RunClassify_Btn.UseVisualStyleBackColor = true;
            this.RunClassify_Btn.Click += new System.EventHandler(this.RunClassify_Btn_Click);
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Result_Label.Location = new System.Drawing.Point(535, 355);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(80, 27);
            this.Result_Label.TabIndex = 10;
            this.Result_Label.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "結果：";
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(119, 158);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 111);
            this.listView1.TabIndex = 14;
            this.listView1.TileSize = new System.Drawing.Size(280, 100);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(284, 172);
            this.dataGridView1.TabIndex = 15;
            // 
            // tbProductid
            // 
            this.tbProductid.Location = new System.Drawing.Point(509, 185);
            this.tbProductid.Name = "tbProductid";
            this.tbProductid.Size = new System.Drawing.Size(100, 22);
            this.tbProductid.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(440, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "產品id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 529);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbProductid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.RunClassify_Btn);
            this.Controls.Add(this.StoredProcedure_Text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Concoso購物推薦";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestConnect_Btn;
        private System.Windows.Forms.TextBox Pass_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserName_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton SQLValid_Radio;
        private System.Windows.Forms.RadioButton WinValid_Radio;
        private System.Windows.Forms.TextBox DBName_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServerName_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StoredProcedure_Text;
        private System.Windows.Forms.Button RunClassify_Btn;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbProductid;
        private System.Windows.Forms.Label label5;
    }
}


﻿namespace QTsys
{
    partial class 领料清单生成
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox订单 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.com供应商 = new System.Windows.Forms.ComboBox();
            this.text单价 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text原料名称 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text单位 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text余料 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text需要原料数量 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(718, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "产品：";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(224, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(394, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "数量：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "确认领料";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消领料";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox订单
            // 
            this.textBox订单.Enabled = false;
            this.textBox订单.Location = new System.Drawing.Point(71, 7);
            this.textBox订单.Name = "textBox订单";
            this.textBox订单.Size = new System.Drawing.Size(100, 21);
            this.textBox订单.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "订单：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(753, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "供应商";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(742, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(371, 132);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // com供应商
            // 
            this.com供应商.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.com供应商.Enabled = false;
            this.com供应商.FormattingEnabled = true;
            this.com供应商.Location = new System.Drawing.Point(800, 38);
            this.com供应商.Name = "com供应商";
            this.com供应商.Size = new System.Drawing.Size(119, 20);
            this.com供应商.TabIndex = 23;
            // 
            // text单价
            // 
            this.text单价.Enabled = false;
            this.text单价.Location = new System.Drawing.Point(969, 37);
            this.text单价.Name = "text单价";
            this.text单价.Size = new System.Drawing.Size(100, 21);
            this.text单价.TabIndex = 25;
            this.text单价.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(934, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "单价";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(753, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "原料名";
            // 
            // text原料名称
            // 
            this.text原料名称.Enabled = false;
            this.text原料名称.Location = new System.Drawing.Point(800, 72);
            this.text原料名称.Name = "text原料名称";
            this.text原料名称.Size = new System.Drawing.Size(119, 21);
            this.text原料名称.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(934, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "单位";
            // 
            // text单位
            // 
            this.text单位.Enabled = false;
            this.text单位.Location = new System.Drawing.Point(969, 72);
            this.text单位.Name = "text单位";
            this.text单位.Size = new System.Drawing.Size(100, 21);
            this.text单位.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(913, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "该供应商原料数量";
            // 
            // text余料
            // 
            this.text余料.Enabled = false;
            this.text余料.Location = new System.Drawing.Point(1020, 3);
            this.text余料.Name = "text余料";
            this.text余料.Size = new System.Drawing.Size(100, 21);
            this.text余料.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(717, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "需要原料数量";
            // 
            // text需要原料数量
            // 
            this.text需要原料数量.Enabled = false;
            this.text需要原料数量.Location = new System.Drawing.Point(800, 4);
            this.text需要原料数量.Name = "text需要原料数量";
            this.text需要原料数量.Size = new System.Drawing.Size(100, 21);
            this.text需要原料数量.TabIndex = 33;
            // 
            // 领料清单生成
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 301);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text需要原料数量);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text余料);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text单位);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text原料名称);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text单价);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.com供应商);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox订单);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "领料清单生成";
            this.Text = "领料清单生成";
            this.Load += new System.EventHandler(this.领料清单生成_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox订单;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox com供应商;
        private System.Windows.Forms.TextBox text单价;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text原料名称;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text单位;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text余料;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text需要原料数量;
    }
}
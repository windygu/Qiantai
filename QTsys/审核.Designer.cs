﻿namespace QTsys
{
    partial class 审核
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView订单明细 = new System.Windows.Forms.DataGridView();
            this.button拒绝订单 = new System.Windows.Forms.Button();
            this.button拒绝计划 = new System.Windows.Forms.Button();
            this.button通过订单 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView订单 = new System.Windows.Forms.DataGridView();
            this.button通过计划 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView生产计划 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_up = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.date_down = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox动作 = new System.Windows.Forms.TextBox();
            this.label_搜索栏目 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView订单明细)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView订单)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView生产计划)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView订单明细);
            this.tabPage2.Controls.Add(this.button拒绝订单);
            this.tabPage2.Controls.Add(this.button拒绝计划);
            this.tabPage2.Controls.Add(this.button通过订单);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView订单);
            this.tabPage2.Controls.Add(this.button通过计划);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView生产计划);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "审核流程";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "订单明细";
            // 
            // dataGridView订单明细
            // 
            this.dataGridView订单明细.AllowUserToAddRows = false;
            this.dataGridView订单明细.AllowUserToDeleteRows = false;
            this.dataGridView订单明细.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView订单明细.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView订单明细.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView订单明细.Location = new System.Drawing.Point(6, 485);
            this.dataGridView订单明细.Name = "dataGridView订单明细";
            this.dataGridView订单明细.ReadOnly = true;
            this.dataGridView订单明细.RowTemplate.Height = 23;
            this.dataGridView订单明细.Size = new System.Drawing.Size(751, 161);
            this.dataGridView订单明细.TabIndex = 8;
            // 
            // button拒绝订单
            // 
            this.button拒绝订单.Location = new System.Drawing.Point(774, 362);
            this.button拒绝订单.Name = "button拒绝订单";
            this.button拒绝订单.Size = new System.Drawing.Size(75, 23);
            this.button拒绝订单.TabIndex = 7;
            this.button拒绝订单.Text = "审核不通过";
            this.button拒绝订单.UseVisualStyleBackColor = true;
            this.button拒绝订单.Click += new System.EventHandler(this.button拒绝订单_Click);
            // 
            // button拒绝计划
            // 
            this.button拒绝计划.Location = new System.Drawing.Point(774, 138);
            this.button拒绝计划.Name = "button拒绝计划";
            this.button拒绝计划.Size = new System.Drawing.Size(75, 23);
            this.button拒绝计划.TabIndex = 6;
            this.button拒绝计划.Text = "审核不通过";
            this.button拒绝计划.UseVisualStyleBackColor = true;
            this.button拒绝计划.Click += new System.EventHandler(this.button拒绝计划_Click);
            // 
            // button通过订单
            // 
            this.button通过订单.Location = new System.Drawing.Point(774, 307);
            this.button通过订单.Name = "button通过订单";
            this.button通过订单.Size = new System.Drawing.Size(75, 23);
            this.button通过订单.TabIndex = 5;
            this.button通过订单.Text = "通过审核";
            this.button通过订单.UseVisualStyleBackColor = true;
            this.button通过订单.Click += new System.EventHandler(this.button通过订单_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "订单";
            // 
            // dataGridView订单
            // 
            this.dataGridView订单.AllowUserToAddRows = false;
            this.dataGridView订单.AllowUserToDeleteRows = false;
            this.dataGridView订单.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView订单.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView订单.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView订单.Location = new System.Drawing.Point(6, 261);
            this.dataGridView订单.Name = "dataGridView订单";
            this.dataGridView订单.ReadOnly = true;
            this.dataGridView订单.RowTemplate.Height = 23;
            this.dataGridView订单.Size = new System.Drawing.Size(751, 188);
            this.dataGridView订单.TabIndex = 3;
            this.dataGridView订单.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView订单_CellClick);
            // 
            // button通过计划
            // 
            this.button通过计划.Location = new System.Drawing.Point(774, 85);
            this.button通过计划.Name = "button通过计划";
            this.button通过计划.Size = new System.Drawing.Size(75, 23);
            this.button通过计划.TabIndex = 2;
            this.button通过计划.Text = "通过审核";
            this.button通过计划.UseVisualStyleBackColor = true;
            this.button通过计划.Click += new System.EventHandler(this.button通过计划_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "生产计划";
            // 
            // dataGridView生产计划
            // 
            this.dataGridView生产计划.AllowUserToAddRows = false;
            this.dataGridView生产计划.AllowUserToDeleteRows = false;
            this.dataGridView生产计划.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView生产计划.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView生产计划.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView生产计划.Location = new System.Drawing.Point(6, 27);
            this.dataGridView生产计划.Name = "dataGridView生产计划";
            this.dataGridView生产计划.ReadOnly = true;
            this.dataGridView生产计划.RowTemplate.Height = 23;
            this.dataGridView生产计划.Size = new System.Drawing.Size(751, 200);
            this.dataGridView生产计划.TabIndex = 0;
            this.dataGridView生产计划.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView生产计划_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox动作);
            this.tabPage1.Controls.Add(this.label_搜索栏目);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "操作记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_up);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_down);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(480, 532);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间范围";
            // 
            // date_up
            // 
            this.date_up.Location = new System.Drawing.Point(37, 20);
            this.date_up.Name = "date_up";
            this.date_up.Size = new System.Drawing.Size(200, 21);
            this.date_up.TabIndex = 5;
            this.date_up.ValueChanged += new System.EventHandler(this.date_up_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "到";
            // 
            // date_down
            // 
            this.date_down.Location = new System.Drawing.Point(37, 57);
            this.date_down.Name = "date_down";
            this.date_down.Size = new System.Drawing.Size(200, 21);
            this.date_down.TabIndex = 6;
            this.date_down.ValueChanged += new System.EventHandler(this.date_down_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "从";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "筛选";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox动作
            // 
            this.textBox动作.Location = new System.Drawing.Point(188, 529);
            this.textBox动作.Name = "textBox动作";
            this.textBox动作.Size = new System.Drawing.Size(129, 21);
            this.textBox动作.TabIndex = 3;
            // 
            // label_搜索栏目
            // 
            this.label_搜索栏目.AutoSize = true;
            this.label_搜索栏目.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_搜索栏目.ForeColor = System.Drawing.Color.Red;
            this.label_搜索栏目.Location = new System.Drawing.Point(117, 532);
            this.label_搜索栏目.Name = "label_搜索栏目";
            this.label_搜索栏目.Size = new System.Drawing.Size(44, 12);
            this.label_搜索栏目.TabIndex = 2;
            this.label_搜索栏目.Text = "操作员";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "筛选";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(852, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 678);
            this.tabControl1.TabIndex = 0;
            // 
            // 审核
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 702);
            this.Controls.Add(this.tabControl1);
            this.Name = "审核";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "审核流程";
            this.Load += new System.EventHandler(this.审核_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView订单明细)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView订单)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView生产计划)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView订单明细;
        private System.Windows.Forms.Button button拒绝订单;
        private System.Windows.Forms.Button button拒绝计划;
        private System.Windows.Forms.Button button通过订单;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView订单;
        private System.Windows.Forms.Button button通过计划;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView生产计划;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_up;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_down;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox动作;
        private System.Windows.Forms.Label label_搜索栏目;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;

    }
}
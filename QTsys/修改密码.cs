﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTsys
{
    public partial class 修改密码 : Form
    {
        private string ID;
        private string Type;

        public 修改密码(string 账户名, string 账户类型)
        {
            InitializeComponent();
            ID = 账户名;
            Type = 账户类型;
        }

        private void 修改密码_Load(object sender, EventArgs e)
        {

        }
    }
}

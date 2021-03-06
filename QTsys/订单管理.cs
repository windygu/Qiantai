﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QTsys.Common;
using QTsys.DataObjects;
using QTsys.DAO;
using QTsys.Manager;
using QTsys.Common.Constants;

namespace QTsys
{
    public partial class 订单管理 : Form
    {

        private OrderManager odm;
        private UserManager userMgr;
        private DataTable tempData1,tempData2;
      //  private bool tab;//true为tab0(订单)，false为tab1（订单明细）.
        private List<Customer> customers;

        public 订单管理()
        {
            InitializeComponent();
            odm = new OrderManager();
            userMgr = new UserManager();

            var role = Utils.GetLogonToken().Role;
            if (role == UserRoles.ADMIN)    // 超级管理员才能看所有人的订单
            {
                checkBox查看所有.Visible = true;
                checkBox查看所有.Checked = true;
            }
            else
            {
                checkBox查看所有.Visible = false;
                checkBox查看所有.Checked = false;
            }
        }

        private void 订单管理_Load(object sender, EventArgs e)
        {
            try
            {
             //   text订单编号.Text = "1";
               // tab = true;
                if (checkBox查看所有.Checked == false)
                {
                    tempData1 = this.odm.GetOrderByCreator(Utils.GetCurrentUsername());
                    //   tempData2 = this.odm.GetAllOrderDetailsBySerial(text订单编号.Text);
                    dataGridView1.DataSource = tempData1;
                    dataGridView1.Update();
                }
                //c是否库存.Items.Add("是");
                //c是否库存.Items.Add("否");
                text订单编号.Text = "1";

                // 初始化客户信息
                customers = userMgr.GetAllCustomerList();
                customers.Insert(0, new Customer() { Id = "-9999", Name = "" });
                //use dataSource make selectedValue works;
                com客户名.DataSource = customers;
                com客户名.DisplayMember = "Name";
                com客户名.ValueMember = "Id";

                // order status
                com订单状态.Items.AddRange(new string[]
                {
                    OrderStatus.PENDING,
                    OrderStatus.PROCESSING,
                    OrderStatus.PACKING,
                    OrderStatus.SHIPPED,
                    OrderStatus.SUCCEED,
                    OrderStatus.CANCEL
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString() + "加载失败！"); }
        }

        public void showgrid(){
            try
            {
                dataGridView1.DataSource = this.odm.GetAllOrdersByTime(dateTimePicker_up.Value, dateTimePicker_down.Value);
                dataGridView1.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString() + "加载失败！"); } 

        }
        

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //无
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            //无
        }

        private void dateTimePicker_up_ValueChanged(object sender, EventArgs e)
        {
            showgrid();
        }

        private void dateTimePicker_down_ValueChanged(object sender, EventArgs e)
        {
            showgrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                text订单编号.Text = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
                date创建时间.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["创建时间"].Value);
                date发货时间.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["发货时间"].Value);
                date最后更新时间.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["最后更新时间"].Value);
                com订单状态.Text = dataGridView1.Rows[e.RowIndex].Cells["订单状态"].Value.ToString();
                text快递单号.Text = dataGridView1.Rows[e.RowIndex].Cells["快递单号"].Value.ToString();
                com订金方式.Text = dataGridView1.Rows[e.RowIndex].Cells["订金方式"].Value.ToString();
                text收货地址.Text = dataGridView1.Rows[e.RowIndex].Cells["收货地址"].Value.ToString();
                com收货联系人.Text = dataGridView1.Rows[e.RowIndex].Cells["收货联系人"].Value.ToString();
                text收货电话.Text = dataGridView1.Rows[e.RowIndex].Cells["收货电话"].Value.ToString();
                com创建人.Text = dataGridView1.Rows[e.RowIndex].Cells["创建人"].Value.ToString();
                textBox客户订单号.Text = dataGridView1.Rows[e.RowIndex].Cells["客户订单号"].Value.ToString();
                textBox送货单号.Text = dataGridView1.Rows[e.RowIndex].Cells["送货单号"].Value.ToString();

                //var temp = from it in (com客户名.Items.Cast<Customer>())
                //            where it.Id == selectedCId
                //            select it;
                //com客户名.SelectedItem = temp.First();
                com客户名.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["客户编号"].Value.ToString();

                if (com订单状态.Text == "待审核")
                {
                    button修改并保存.Enabled = false;
                }
                else
                {
                    button修改并保存.Enabled = true;
                }
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Order od = new Order();
                od.OrderId = text订单编号.Text;
                od.CreateTime = date创建时间.Value;
                od.DeliverTime = date发货时间.Value;
                od.LastUpdateTime = date最后更新时间.Value;
                od.OrderStatus = com订单状态.Text;

                // temp solution
                if (od.OrderStatus == OrderStatus.SHIPPED)
                {
                    DateTime now = DateTime.Now;
                    od.DeliverNO = now.Year.ToString() + now.Month.ToString() + now.Day.ToString() +
                        now.Hour.ToString() + now.Minute.ToString();// +now.Second.ToString();
                }
                else
                {
                    od.DeliverNO = "";
                }

                od.ExpressNO = text快递单号.Text;
                od.DepositMode = com订金方式.Text;
                od.RecieverAddress = text收货地址.Text;
                od.RecieverName = com收货联系人.Text;
                od.RecieverPhone = text收货电话.Text;
                od.Creator = com创建人.Text;
                od.CustomerOrderId = textBox客户订单号.Text;
                od.DeliverNO = textBox送货单号.Text;
                if (this.odm.AltOrder(od))
                {
                    MessageBox.Show("订单修改成功！"); 
                    dataGridView1.DataSource = this.odm.GetAllOrders();
                    dataGridView1.Update();
                }
                else
                    MessageBox.Show("订单修改失败！");
            }
            catch (Exception ex) { MessageBox.Show("订单修改失败！"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Order od = new Order();
                od.OrderId = text订单编号.Text;
                od.CreateTime = date创建时间.Value;
                od.DeliverTime = date发货时间.Value;
                od.LastUpdateTime = date最后更新时间.Value;
                od.OrderStatus = com订单状态.Text;
                od.ExpressNO = text快递单号.Text;
                od.DepositMode = com订金方式.Text;
                od.RecieverAddress = text收货地址.Text;
                od.RecieverName = com收货联系人.Text;
                od.RecieverPhone = text收货电话.Text;
                od.Creator = com创建人.Text;
                if (this.odm.AddNewOrder(od)>0)
                {
                    MessageBox.Show("新订单建立成功！");
                    dataGridView1.DataSource = this.odm.GetAllOrders();
                    dataGridView1.Update();
                }
                else
                    MessageBox.Show("订单建立失败！");
            }
            catch (Exception ex) { MessageBox.Show("订单建立失败！"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.odm.DelOrder(text订单编号.Text))
                {
                    MessageBox.Show("订单【" + text订单编号.Text + "】删除成功！");
                    dataGridView1.DataSource = this.odm.GetAllOrders();
                    dataGridView1.Update();
                }
                else
                    MessageBox.Show("订单【" + text订单编号.Text + "】删除失败！");
            }
            catch (Exception ex) { MessageBox.Show("订单【" + text订单编号.Text + "】删除失败！"); }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
            try
            {
                /*if (e.TabPageIndex == 0)
                {
                    tab = true;
                    dataGridView1.DataSource = tempData1;
                    tempData1 = (DataTable)dataGridView1.DataSource;
                    dataGridView1.Update();
                }*/

                if (e.TabPageIndex == 1)
                {
                    //tab = false;
                    dataGridView2.DataSource = this.odm.GetAllOrderDetailsBySerial(text订单编号.Text);
                    dataGridView2.Update();
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.ToString() + "加载失败！"); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail od = new OrderDetail();
                od.OrderId = t订单编号.Text;
                od.ProductId = t产品编号.Text;
                od.Count = Convert.ToInt16(t数量.Text);
                od.Price = Convert.ToDouble(t单价.Text);
                od.Discount = Convert.ToDouble(t折扣.Text);
                od.RealPrice = Convert.ToDouble(t成交价.Text);
                //od.IsStorage = c是否库存.Text;
                if (this.odm.AltOrderDetail(od))
                {
                    MessageBox.Show("新订单明细修改成功！");
                    dataGridView2.DataSource = this.odm.GetAllOrderDetailsBySerial(text订单编号.Text);
                    dataGridView2.Update();
                }
                else
                    MessageBox.Show("修改失败！");
            }
            catch (Exception ex) { MessageBox.Show("订单明细 修改 失败！"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail od = new OrderDetail();
                od.OrderId = t订单编号.Text;
                od.ProductId = t产品编号.Text;
                od.Count = Convert.ToInt16(t数量.Text);
                od.Price = Convert.ToDouble(t单价.Text);
                od.Discount = Convert.ToDouble(t折扣.Text);
                od.RealPrice = Convert.ToDouble(t成交价.Text);
                //od.IsStorage = c是否库存.Text;
                if (this.odm.AddNewOrderDetail(od))
                {
                    MessageBox.Show("新订单明细新增成功！");
                    dataGridView2.DataSource = this.odm.GetAllOrderDetailsBySerial(text订单编号.Text);
                    dataGridView2.Update();
                }
                else
                    MessageBox.Show("建立失败！");
            }
            catch (Exception ex) { MessageBox.Show("订单明细 建立 失败！"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail od = new OrderDetail();
                od.OrderId = t订单编号.Text;
                od.ProductId = t产品编号.Text;
                od.Count = Convert.ToInt16(t数量.Text);
                od.Price = Convert.ToDouble(t单价.Text);
                od.Discount = Convert.ToDouble(t折扣.Text);
                od.RealPrice = Convert.ToDouble(t成交价.Text);
                //od.IsStorage = c是否库存.Text;
                if (this.odm.DelOrderDetail(od))
                {
                    MessageBox.Show("订单明细 删除 成功！");
                    dataGridView2.DataSource = this.odm.GetAllOrderDetailsBySerial(text订单编号.Text);
                    dataGridView2.Update();
                }
                else
                    MessageBox.Show("删除失败！");
            }
            catch (Exception ex) { MessageBox.Show("订单明细 删除 失败！"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex) { MessageBox.Show("加载失败！"); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            t订单编号.Text = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
            t产品编号.Text = dataGridView1.Rows[e.RowIndex].Cells["产品编号"].Value.ToString();
            t数量.Text = dataGridView1.Rows[e.RowIndex].Cells["数量"].Value.ToString();
            t单价.Text = dataGridView1.Rows[e.RowIndex].Cells["单价"].Value.ToString();
            t折扣.Text = dataGridView1.Rows[e.RowIndex].Cells["折扣"].Value.ToString();
            t成交价.Text = dataGridView1.Rows[e.RowIndex].Cells["成交价"].Value.ToString();
            //c是否库存.Text = dataGridView1.Rows[e.RowIndex].Cells["是否库存"].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show("加载失败！"); }
        }

        private void text订单编号_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox查看所有_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox查看所有.Checked)
            {
                tempData1 = this.odm.GetAllOrders();
                //   tempData2 = this.odm.GetAllOrderDetailsBySerial(text订单编号.Text);
                dataGridView1.DataSource = tempData1;
                dataGridView1.Update();
            }
            else
            {
                tempData1 = this.odm.GetOrderByCreator(Utils.GetCurrentUsername());
                //   tempData2 = this.odm.GetAllOrderDetailsBySerial(text订单编号.Text);
                dataGridView1.DataSource = tempData1;
                dataGridView1.Update();
            }
        }
    }
}

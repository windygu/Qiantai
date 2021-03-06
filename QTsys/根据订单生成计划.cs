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
    public partial class 根据订单生成计划 : Form
    {
        private OrderManager odm;
        private UserManager userMgr;
        private ProductionManager pm;
        private MaterialManager mt;
        private int index3;
        private int OrderId;
        private int selectedOrderRowIdx;
        private ProductPlanManager ppm;
        private ProductionPlan plan;
        private int selectedProdCount;


        public 根据订单生成计划()
        {
            InitializeComponent();
            odm = new OrderManager();
            userMgr = new UserManager();
            pm = new ProductionManager();
            mt = new MaterialManager();
            ppm = new ProductPlanManager();
            index3 = 0;
        }

        public 根据订单生成计划(string 是否样品, string 订单编号,string 客户编号)
      //  public 样品库存自动生成(ProductionPlan plant)
        {
            InitializeComponent();
            odm = new OrderManager();
            userMgr = new UserManager();
            pm = new ProductionManager();
            mt = new MaterialManager();
            ppm = new ProductPlanManager();
            plan = new ProductionPlan();
       //     plan = plant;
            index3 = 0;
          //  OrderId =Convert.ToInt16( plant.RelatedOrderId);
            OrderId = Convert.ToInt16(订单编号);
            plan.PlanType = 是否样品;
            plan.CustomerId = 客户编号;
           plan.RelatedOrderId = 订单编号;
        }

        private void 样品库存自动生成_Load(object sender, EventArgs e)
        {
            text订单编号.Text = OrderId.ToString();
            dataGridView产品订单数据.DataSource = odm.GetAllOrderDetailsBySerial(text订单编号.Text);

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView产品订单数据_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //根据产品编号查询数据
            //dataGridView1.Rows[e.RowIndex].Cells["产品编号"].Value.ToString()
            try
            {
                selectedOrderRowIdx = e.RowIndex;
                var selectedRow = dataGridView产品订单数据.Rows[selectedOrderRowIdx];

                var prodResult = pm.GetAllProductsByNameEX("产品编号", selectedRow.Cells["产品编号"].Value.ToString());
                dataGridView参数修正.DataSource = prodResult;
                dataGridView产品原料关系.DataSource = pm.GetMaterialProductRelationByProduct(selectedRow.Cells["产品编号"].Value.ToString());
                dataGridView参数修正.Update();
                dataGridView产品原料关系.Update();
                //

                label库存数.Text = prodResult.Rows[0]["库存数量"].ToString();
                selectedProdCount = int.Parse(selectedRow.Cells["数量"].Value.ToString());
                ////////
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

        }

        private void dataGridView参数修正_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            var selectedRow = dataGridView参数修正.Rows[idx];

            //label库存数.Text = selectedRow.Cells["库存数量"].Value.ToString();
            
            //text产品编号.Text = selectedRow.Cells["产品编号"].Value.ToString();
            //text产品名称.Text = selectedRow.Cells["产品名称"].Value.ToString();
            //text规格.Text = selectedRow.Cells["规格"].Value.ToString();
            //text材质.Text = selectedRow.Cells["材质"].Value.ToString();
            //text变位.Text = selectedRow.Cells["变位"].Value.ToString();
            //text实测变位.Text = selectedRow.Cells["实测变位"].Value.ToString();
            //text温度.Text = selectedRow.Cells["温度"].Value.ToString();
            //text生产耗时.Text = selectedRow.Cells["生产耗时"].Value.ToString();
            //text压力.Text = selectedRow.Cells["压力"].Value.ToString();
            //text树脂名称.Text = selectedRow.Cells["树脂名称"].Value.ToString();
            //text树脂比重.Text = selectedRow.Cells["树脂比重"].Value.ToString();
            //text含浸尺寸.Text = selectedRow.Cells["含浸尺寸"].Value.ToString();
            //text外盘.Text = selectedRow.Cells["外盘"].Value.ToString();
            //text内治具.Text = selectedRow.Cells["内治具"].Value.ToString();
            //text重量.Text = selectedRow.Cells["重量"].Value.ToString();
            //text成型模.Text = selectedRow.Cells["成型模"].Value.ToString();
            //text切模号.Text = selectedRow.Cells["切模号"].Value.ToString();
            //text单位.Text = selectedRow.Cells["单位"].Value.ToString();
            //text单价.Text = selectedRow.Cells["单价"].Value.ToString();
            //text库存数量.Text = selectedRow.Cells["库存数量"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // tabControl1.SelectedIndex = 1 ;
        }

        private void dataGridView产品原料关系_CellClick(object sender, DataGridViewCellEventArgs e)//产品原料关系
        {
            try
            {
                index3 = e.RowIndex;
                //  text原料数量.Text = dataGridView3.Rows[e.RowIndex].Cells["原料数量"].Value.ToString();
                // l原料数量.Text = "生产产品【" + dataGridView3.Rows[e.RowIndex].Cells["产品编号"].Value.ToString() + "】1件须消耗原料【" + dataGridView3.Rows[e.RowIndex].Cells["原料编号"].Value.ToString() + "】";
                textBox产品.Text = dataGridView产品原料关系.Rows[e.RowIndex].Cells["产品编号"].Value.ToString();
                textBox原料.Text = dataGridView产品原料关系.Rows[e.RowIndex].Cells["原料编号"].Value.ToString();
                textBox原料数量.Text = dataGridView产品原料关系.Rows[e.RowIndex].Cells["原料数量"].Value.ToString();
                dataGridView7.DataSource = mt.GetAllMaterialByName("原料编号", dataGridView产品原料关系.Rows[e.RowIndex].Cells["原料编号"].Value.ToString());
                dataGridView7.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView产品原料关系.Rows[index3].Cells["原料数量"].Value = textBox原料数量.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button加入生产计划_Click(object sender, EventArgs e)//制定生产计划
        {
            try
            {
                // validation
                var invalidPid = "";
                for (int i = 0; i < dataGridView产品订单数据.Rows.Count; i++)
                {
                    var pId = dataGridView产品订单数据.Rows[i].Cells["产品编号"].Value.ToString();

                    if (!pm.HasProductMaterialRelation(pId))
                    {
                        invalidPid += pId + ",";
                    }
                }
                if (invalidPid != "")
                {
                    invalidPid = invalidPid.TrimEnd(',');
                    DialogResult dr = MessageBox.Show("产品[" + invalidPid + "]没有建立产品原料关系，你确定要制定生产计划？", "请确认", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        MessageBox.Show("操作终止，去维护产品原料关系");
                        return;
                    }
                }

                // do add
                bool planok = true;
                for (int i = 0; i < dataGridView产品订单数据.Rows.Count; i++)
                {
                    plan.RelatedOrderId = text订单编号.Text;
                    plan.ProductId = dataGridView产品订单数据.Rows[i].Cells["产品编号"].Value.ToString();

                    // plan.CustomerId = l编号.Text;
                    plan.OrderTime = DateTime.Now;
                    plan.Count = Convert.ToInt16(dataGridView产品订单数据.Rows[i].Cells["数量"].Value);
                    plan.PlanningTime = date交付时间.Value;
                    plan.FinishTime = DateTime.Parse("2000-01-01");
                    plan.PlanState = ProductionPlanStatus.PENDING;
                    plan.InChargePerson = Utils.GetCurrentUsername();

                    plan.finishedCount = int.Parse(textBox库存件数.Text == "" ? "0" : textBox库存件数.Text);
                    if (checkBox1.Checked && plan.finishedCount > 0)
                    {
                        plan.hasFromStore = "是";
                        // 扣除库存
                        pm.UpdateProductStoreCount(-plan.finishedCount, plan.ProductId);
                        //if (plan.finishedCount >= selectedProdCount)
                        //{
                        //    plan.PlanState = ProductionPlanStatus.STORED;
                        //}
                    }

                    if (!ppm.AddNewPlan(plan))
                    {
                        MessageBox.Show("插入计划失败");
                        planok = false;
                        // 恢复库存
                        pm.UpdateProductStoreCount(plan.finishedCount, plan.ProductId);
                        break;
                    };
                }
                if (planok == true)
                {
                    if (odm.UpdateOrderStatus(OrderStatus.PROCESSING, text订单编号.Text))
                    {
                        MessageBox.Show("生产计划生成成功！"); this.Close();
                    }
                    else
                    {
                        MessageBox.Show("生产计划生成失败！");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox库存件数.Enabled = true;
            }
            else
            {
                textBox库存件数.Enabled = false;
            }
        }

        private void textBox库存件数_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int iUserSetted = int.Parse(textBox库存件数.Text == "" ? "0" : textBox库存件数.Text);
                int total = int.Parse(label库存数.Text);
                if (iUserSetted > total)
                {
                    MessageBox.Show("不能大于库存！请重新输入");
                    textBox库存件数.Text = total.ToString();
                    return;
                }
                if (iUserSetted > selectedProdCount)
                {
                    //MessageBox.Show()
                    DialogResult dr = MessageBox.Show("超交？", "请确认", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        //MessageBox.Show("操作终止，去维护产品原料关系");
                        textBox库存件数.Text = selectedProdCount.ToString();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

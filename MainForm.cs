﻿using CQ.Entity;
using CQ.Bll;
using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CQ.Utils;
using System.Data;

namespace CQ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.keyWord.Text = "玻璃胶";
            this.minPayNum.Text = "2";
            this.maxPayNum.Text = "100";
            this.userLike.Checked = true;
            this.collectNum.Text = "15";
            this.waitCheckItem.CurrentCellChanged += WaitCheckItem_CurrentCellChanged;
        }

        private void WaitCheckItem_CurrentCellChanged(object sender, EventArgs e)
        {

            try
            {
                string id = this.waitCheckItem.CurrentCell.Value.ToString();
                this.webBrowser2.Navigate("http://item.taobao.com/item.htm?id=" + id);
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoodsCondition gc = new GoodsCondition();
            gc.keyWord = this.keyWord.Text;
            gc.gltm = this.gltm1.Focus();
            if (!string.IsNullOrEmpty(this.minPayNum.Text))
            {
                gc.minPayNum = int.Parse(this.minPayNum.Text);
            }
            if (!string.IsNullOrEmpty(this.maxPayNum.Text))
            {
                gc.maxPayNum = int.Parse(this.maxPayNum.Text);
            }
            if (!string.IsNullOrEmpty(this.minPrice.Text))
            {
                gc.minPrice = decimal.Parse(this.minPrice.Text);
            }
            if (!string.IsNullOrEmpty(this.maxPrice.Text))
            {
                gc.maxPrice = decimal.Parse(this.maxPrice.Text);
            }
            if (!string.IsNullOrEmpty(this.collectNum.Text))
            {
                gc.collectNum = int.Parse(this.collectNum.Text);
            }
            gc.userLike = this.userLike.Focus();
            KeySearch ks = new KeySearch(gc);
            Application.DoEvents();
            List<Auction> result = ks.GetKeySearchResult();
            //this.keySearchResult.Columns.Add("Id", 90, HorizontalAlignment.Left);
            //this.keySearchResult.Columns.Add("标题", 375, HorizontalAlignment.Left);
            //this.keySearchResult.Columns.Add("价格", 56, HorizontalAlignment.Left);
            //this.keySearchResult.Columns.Add("店铺", 90, HorizontalAlignment.Left);
            // this.keySearchResult.BeginUpdate();
            DataTable dt = new DataTable();
            Type TYPE = "".GetType();
            DataColumn dc1 = new DataColumn("Id", TYPE);
            DataColumn dc2 = new DataColumn("标题", TYPE);
            DataColumn dc3 = new DataColumn("价格", TYPE);
            DataColumn dc4 = new DataColumn("店铺", TYPE);
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            keySearchResult.AutoGenerateColumns = false;
            foreach (Auction item in result)
            {
                DataRow dr = dt.NewRow();
                ListViewItem lvi = new ListViewItem();
                dr[0] = item.Nid;
                dr[1] = item.RawTitle;
                dr[2] = item.ViewPrice;
                dr[3] = item.Nick;
                dt.Rows.Add(dr);
            }
            keySearchResult.DataSource = dt;
            //  this.keySearchResult.EndUpdate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.keySearchResult.ListViewItemSorter = new ListViewColumnSorter();
            //this.keySearchResult.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gjz_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxpaynum_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void minpaynum_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string key = this.dropDownBoxKey.Text;
            CollectDropDownKey c = new CollectDropDownKey(key);
            string result = c.GetDropDownBoxText();
            this.dropDownBoxResult.Text = result;
        }

        private void dropDownBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string article = this.dropDownBoxResult.Text;
            WordAnalyzer wa = new WordAnalyzer();
            Dictionary<string, int> dic = wa.GetParticipleResult(article);
            //this.participleResult.Columns.Add("关键字", 120, HorizontalAlignment.Left);
            //this.participleResult.Columns.Add("出现次数", 120, HorizontalAlignment.Left);
            //this.participleResult.Columns.Add("出现频率", 120, HorizontalAlignment.Left);
            this.participleResult.BeginUpdate();
            int count = 1;
            foreach (int value in dic.Values)
            {
                count += value;
            }
            foreach (string key in dic.Keys)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = key;
                lvi.SubItems.Add(dic[key].ToString());
                lvi.SubItems.Add(Common.GetPercentResult(dic[key], count));
                this.participleResult.Items.Add(lvi);
            }
            this.participleResult.EndUpdate();
        }

        private void article_TextChanged(object sender, EventArgs e)
        {

        }

        private void participleResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void copy_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string type = this.copyType.Text;
            int index = 0;
            switch (type)
            {
                case "Id":
                    break;
                case "标题":
                    index = 1;
                    break;
                case "价格":
                    index = 2;
                    break;
                case "店铺":
                    index = 3;
                    break;
                default:
                    break;
            }
            for (int i = 0; i < keySearchResult.Rows.Count - 1; i++)
            {
                sb.AppendLine(keySearchResult.Rows[i].Cells[index].Value.ToString());
            }

            Clipboard.SetDataObject(sb.ToString(), true);
            MessageBox.Show(string.Format("已经将{0}复制到粘贴板", type));
        }

        private void copyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkPic_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("ID", "".GetType());
            dt.Columns.Add(dc1);
            DataColumn dc2 = new DataColumn("标题", "".GetType());
            dt.Columns.Add(dc2);
            waitCheckItem.AutoGenerateColumns = false;
            for (int i = 0; i < keySearchResult.Rows.Count - 1; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = keySearchResult.Rows[i].Cells[0].Value.ToString();
                dr[1] = keySearchResult.Rows[i].Cells[1].Value.ToString();
                dt.Rows.Add(dr);
            }
            waitCheckItem.DataSource = dt;
            this.tabControl1.SelectTab(2);
        }

        private void keySearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void previous_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = this.waitCheckItem.CurrentRow;
            int index = dgvr.Index - 1;
            if (index < 0)
            {
                MessageBox.Show("到顶了");
            }
            else if (index == this.waitCheckItem.Rows.Count)
            {
                MessageBox.Show("到底了");
            }
            else
            {
                this.waitCheckItem.CurrentCell = this.waitCheckItem.Rows[index].Cells[0];
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = this.waitCheckItem.CurrentRow;
            int index = dgvr.Index + 1;
            if (index < 0)
            {
                MessageBox.Show("到顶了");
            }
            else if (index == this.waitCheckItem.Rows.Count)
            {
                MessageBox.Show("到底了");
            }
            else
            {
                this.waitCheckItem.CurrentCell = this.waitCheckItem.Rows[index].Cells[0];
            }
        }

        private void qualify_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = waitCheckItem.CurrentRow;
            ListViewItem lvi = new ListViewItem();
            lvi.Text = dgvr.Cells[0].Value.ToString();
            lvi.SubItems.Add(dgvr.Cells[1].Value.ToString());
            checkItem.Items.Add(lvi);
        }

        private void copyChecked_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string type = this.comboBox1.Text;
            int index = 0;
            switch (type)
            {
                case "Id":
                    break;
                case "标题":
                    index = 1;
                    break;
                default:
                    break;
            }
            foreach (ListViewItem item in checkItem.Items)
            {
                sb.AppendLine(item.SubItems[index].Text);
            }

            Clipboard.SetDataObject(sb.ToString(), true);
            MessageBox.Show(string.Format("已经将{0}复制到粘贴板", type));
        }
    }
}

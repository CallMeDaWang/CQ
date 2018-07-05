using CQ.Entity;
using CQ.Bll;
using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CQ.Utils;

namespace CQ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            List<Auction> result = ks.GetKeySearchResult();
            //this.keySearchResult.Columns.Add("Id", 90, HorizontalAlignment.Left);
            //this.keySearchResult.Columns.Add("标题", 375, HorizontalAlignment.Left);
            //this.keySearchResult.Columns.Add("价格", 56, HorizontalAlignment.Left);
            //this.keySearchResult.Columns.Add("店铺", 90, HorizontalAlignment.Left);
            this.keySearchResult.BeginUpdate();
            foreach (Auction item in result)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Nid;
                lvi.SubItems.Add(item.RawTitle);
                lvi.SubItems.Add(item.ViewPrice);
                lvi.SubItems.Add(item.Nick);
                this.keySearchResult.Items.Add(lvi);
            }
            this.keySearchResult.EndUpdate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.keySearchResult.ListViewItemSorter = new ListViewColumnSorter();
            this.keySearchResult.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
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
            string article = this.article.Text;
            WordAnalyzer wa = new WordAnalyzer();
            Dictionary<string, int> dic = wa.GetParticipleResult(article);
            this.participleResult.Columns.Add("关键字", 120, HorizontalAlignment.Left);
            this.participleResult.Columns.Add("出现次数", 120, HorizontalAlignment.Left);
            this.participleResult.Columns.Add("出现频率", 120, HorizontalAlignment.Left);
            this.participleResult.BeginUpdate();
            int count = 1;
            foreach (int value in dic.Values)
            {
                count += value;
            }
            foreach (string key in dic.Keys)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text =  key;
                lvi.SubItems.Add(dic[key].ToString());
                lvi.SubItems.Add(getPercentResult(dic[key],count));
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
        private String getPercentResult(int a, int b)
        {
            String result = "{0}%";
            if (b == 0)
            {
                return result;
            }
            float c = (float)a / b;
            float x = (float)Math.Round((double)c, 4);
            return string.Format(result,x*100);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

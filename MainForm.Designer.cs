using OpenQA.Selenium.Chrome;
using System.Data;
using System.Windows.Forms;

namespace CQ
{
    partial class MainForm
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
            this.Submit = new System.Windows.Forms.Button();
            this.keyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userLike = new System.Windows.Forms.CheckBox();
            this.gltm2 = new System.Windows.Forms.RadioButton();
            this.gltm1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.collectNum = new System.Windows.Forms.TextBox();
            this.maxPayNum = new System.Windows.Forms.TextBox();
            this.minPayNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxPrice = new System.Windows.Forms.TextBox();
            this.minPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.关键字采集 = new System.Windows.Forms.TabPage();
            this.copy = new System.Windows.Forms.Button();
            this.keySearchResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.participleResult = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.dropDownBoxResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dropDownBoxKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.copyType = new System.Windows.Forms.ComboBox();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copyParticipleResult = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.关键字采集.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(196, 117);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "采集";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // keyWord
            // 
            this.keyWord.Location = new System.Drawing.Point(65, 35);
            this.keyWord.Name = "keyWord";
            this.keyWord.Size = new System.Drawing.Size(100, 21);
            this.keyWord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "关键字";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userLike);
            this.groupBox2.Controls.Add(this.gltm2);
            this.groupBox2.Controls.Add(this.gltm1);
            this.groupBox2.Controls.Add(this.Submit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.collectNum);
            this.groupBox2.Controls.Add(this.maxPayNum);
            this.groupBox2.Controls.Add(this.minPayNum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maxPrice);
            this.groupBox2.Controls.Add(this.minPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.keyWord);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 156);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "淘宝";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // userLike
            // 
            this.userLike.AutoSize = true;
            this.userLike.Location = new System.Drawing.Point(275, 66);
            this.userLike.Name = "userLike";
            this.userLike.Size = new System.Drawing.Size(72, 16);
            this.userLike.TabIndex = 16;
            this.userLike.Text = "用户最爱";
            this.userLike.UseVisualStyleBackColor = true;
            // 
            // gltm2
            // 
            this.gltm2.AutoSize = true;
            this.gltm2.Location = new System.Drawing.Point(286, 36);
            this.gltm2.Name = "gltm2";
            this.gltm2.Size = new System.Drawing.Size(35, 16);
            this.gltm2.TabIndex = 15;
            this.gltm2.TabStop = true;
            this.gltm2.Text = "否";
            this.gltm2.UseVisualStyleBackColor = true;
            // 
            // gltm1
            // 
            this.gltm1.AutoSize = true;
            this.gltm1.Location = new System.Drawing.Point(245, 35);
            this.gltm1.Name = "gltm1";
            this.gltm1.Size = new System.Drawing.Size(35, 16);
            this.gltm1.TabIndex = 14;
            this.gltm1.TabStop = true;
            this.gltm1.Text = "是";
            this.gltm1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "采集数量";
            // 
            // collectNum
            // 
            this.collectNum.Location = new System.Drawing.Point(65, 119);
            this.collectNum.Name = "collectNum";
            this.collectNum.Size = new System.Drawing.Size(100, 21);
            this.collectNum.TabIndex = 12;
            // 
            // maxPayNum
            // 
            this.maxPayNum.Location = new System.Drawing.Point(196, 90);
            this.maxPayNum.Name = "maxPayNum";
            this.maxPayNum.Size = new System.Drawing.Size(100, 21);
            this.maxPayNum.TabIndex = 11;
            // 
            // minPayNum
            // 
            this.minPayNum.Location = new System.Drawing.Point(65, 89);
            this.minPayNum.Name = "minPayNum";
            this.minPayNum.Size = new System.Drawing.Size(100, 21);
            this.minPayNum.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "付款人数";
            // 
            // maxPrice
            // 
            this.maxPrice.Location = new System.Drawing.Point(169, 63);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(100, 21);
            this.maxPrice.TabIndex = 8;
            // 
            // minPrice
            // 
            this.minPrice.Location = new System.Drawing.Point(65, 62);
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(100, 21);
            this.minPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "价格区间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "过滤天猫";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.关键字采集);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 474);
            this.tabControl1.TabIndex = 7;
            // 
            // 关键字采集
            // 
            this.关键字采集.Controls.Add(this.checkAll);
            this.关键字采集.Controls.Add(this.copyType);
            this.关键字采集.Controls.Add(this.copy);
            this.关键字采集.Controls.Add(this.keySearchResult);
            this.关键字采集.Controls.Add(this.groupBox2);
            this.关键字采集.Location = new System.Drawing.Point(4, 22);
            this.关键字采集.Name = "关键字采集";
            this.关键字采集.Padding = new System.Windows.Forms.Padding(3);
            this.关键字采集.Size = new System.Drawing.Size(899, 448);
            this.关键字采集.TabIndex = 1;
            this.关键字采集.Text = "关键字采集";
            this.关键字采集.UseVisualStyleBackColor = true;
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(161, 168);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(75, 23);
            this.copy.TabIndex = 17;
            this.copy.Text = "复制";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // keySearchResult
            // 
            this.keySearchResult.CheckBoxes = true;
            this.keySearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.keySearchResult.FullRowSelect = true;
            this.keySearchResult.GridLines = true;
            this.keySearchResult.Location = new System.Drawing.Point(6, 197);
            this.keySearchResult.Name = "keySearchResult";
            this.keySearchResult.Size = new System.Drawing.Size(887, 248);
            this.keySearchResult.TabIndex = 5;
            this.keySearchResult.UseCompatibleStateImageBehavior = false;
            this.keySearchResult.View = System.Windows.Forms.View.Details;
            this.keySearchResult.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "标题";
            this.columnHeader2.Width = 375;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "价格";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "店铺";
            this.columnHeader4.Width = 110;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.copyParticipleResult);
            this.tabPage1.Controls.Add(this.participleResult);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dropDownBoxResult);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dropDownBoxKey);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 448);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "标题组合";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // participleResult
            // 
            this.participleResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.participleResult.GridLines = true;
            this.participleResult.Location = new System.Drawing.Point(8, 259);
            this.participleResult.Name = "participleResult";
            this.participleResult.Size = new System.Drawing.Size(226, 183);
            this.participleResult.TabIndex = 8;
            this.participleResult.UseCompatibleStateImageBehavior = false;
            this.participleResult.View = System.Windows.Forms.View.Details;
            this.participleResult.SelectedIndexChanged += new System.EventHandler(this.participleResult_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "分词";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dropDownBoxResult
            // 
            this.dropDownBoxResult.Location = new System.Drawing.Point(8, 42);
            this.dropDownBoxResult.Multiline = true;
            this.dropDownBoxResult.Name = "dropDownBoxResult";
            this.dropDownBoxResult.Size = new System.Drawing.Size(226, 182);
            this.dropDownBoxResult.TabIndex = 3;
            this.dropDownBoxResult.TextChanged += new System.EventHandler(this.dropDownBoxResult_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "收集";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dropDownBoxKey
            // 
            this.dropDownBoxKey.Location = new System.Drawing.Point(53, 15);
            this.dropDownBoxKey.Name = "dropDownBoxKey";
            this.dropDownBoxKey.Size = new System.Drawing.Size(100, 21);
            this.dropDownBoxKey.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "关键词";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // copyType
            // 
            this.copyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.copyType.FormattingEnabled = true;
            this.copyType.Items.AddRange(new object[] {
            "Id",
            "标题",
            "价格",
            "店铺"});
            this.copyType.Location = new System.Drawing.Point(87, 170);
            this.copyType.Name = "copyType";
            this.copyType.Size = new System.Drawing.Size(68, 20);
            this.copyType.TabIndex = 18;
            this.copyType.SelectedIndexChanged += new System.EventHandler(this.copyType_SelectedIndexChanged);
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(9, 172);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(78, 16);
            this.checkAll.TabIndex = 17;
            this.checkAll.Text = "全选/反选";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "关键词";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "出现次数";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "出现频率";
            this.columnHeader7.Width = 70;
            // 
            // copyParticipleResult
            // 
            this.copyParticipleResult.Location = new System.Drawing.Point(89, 230);
            this.copyParticipleResult.Name = "copyParticipleResult";
            this.copyParticipleResult.Size = new System.Drawing.Size(75, 23);
            this.copyParticipleResult.TabIndex = 9;
            this.copyParticipleResult.Text = "复制";
            this.copyParticipleResult.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "lkl";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.关键字采集.ResumeLayout(false);
            this.关键字采集.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        //private ChromeDriver Browser;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox keyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 关键字采集;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox collectNum;
        private System.Windows.Forms.TextBox maxPayNum;
        private System.Windows.Forms.TextBox minPayNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxPrice;
        private System.Windows.Forms.TextBox minPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton gltm2;
        private System.Windows.Forms.RadioButton gltm1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dropDownBoxKey;
        private System.Windows.Forms.TextBox dropDownBoxResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView participleResult;
        private CheckBox userLike;
        private Button copy;
        private ListView keySearchResult;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox copyType;
        private CheckBox checkAll;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button copyParticipleResult;
    }
}


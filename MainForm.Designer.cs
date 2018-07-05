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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.participleResult = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.dropDownBoxResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dropDownBoxKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.copyType = new System.Windows.Forms.ComboBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copyParticipleResult = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.checkPic = new System.Windows.Forms.Button();
            this.waitCheckItem = new System.Windows.Forms.DataGridView();
            this.keySearchResult = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.标题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店铺 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previous = new System.Windows.Forms.Button();
            this.notQualify = new System.Windows.Forms.Button();
            this.qualify = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.copyChecked = new System.Windows.Forms.Button();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.标题1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.关键字采集.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitCheckItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySearchResult)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1377, 777);
            this.tabControl1.TabIndex = 7;
            // 
            // 关键字采集
            // 
            this.关键字采集.Controls.Add(this.keySearchResult);
            this.关键字采集.Controls.Add(this.checkPic);
            this.关键字采集.Controls.Add(this.copyType);
            this.关键字采集.Controls.Add(this.copy);
            this.关键字采集.Controls.Add(this.groupBox2);
            this.关键字采集.Location = new System.Drawing.Point(4, 22);
            this.关键字采集.Name = "关键字采集";
            this.关键字采集.Padding = new System.Windows.Forms.Padding(3);
            this.关键字采集.Size = new System.Drawing.Size(1369, 751);
            this.关键字采集.TabIndex = 1;
            this.关键字采集.Text = "关键字采集";
            this.关键字采集.UseVisualStyleBackColor = true;
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(80, 168);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(75, 23);
            this.copy.TabIndex = 17;
            this.copy.Text = "复制";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
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
            this.tabPage1.Size = new System.Drawing.Size(1369, 751);
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
            this.participleResult.Size = new System.Drawing.Size(226, 486);
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
            this.dropDownBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            this.copyType.Location = new System.Drawing.Point(6, 170);
            this.copyType.Name = "copyType";
            this.copyType.Size = new System.Drawing.Size(68, 20);
            this.copyType.TabIndex = 18;
            this.copyType.SelectedIndexChanged += new System.EventHandler(this.copyType_SelectedIndexChanged);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.checkItem);
            this.tabPage2.Controls.Add(this.copyChecked);
            this.tabPage2.Controls.Add(this.next);
            this.tabPage2.Controls.Add(this.qualify);
            this.tabPage2.Controls.Add(this.notQualify);
            this.tabPage2.Controls.Add(this.previous);
            this.tabPage2.Controls.Add(this.waitCheckItem);
            this.tabPage2.Controls.Add(this.webBrowser2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1369, 751);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "鉴图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(908, 745);
            this.webBrowser2.TabIndex = 1;
            // 
            // checkPic
            // 
            this.checkPic.Location = new System.Drawing.Point(161, 168);
            this.checkPic.Name = "checkPic";
            this.checkPic.Size = new System.Drawing.Size(75, 23);
            this.checkPic.TabIndex = 19;
            this.checkPic.Text = "鉴图";
            this.checkPic.UseVisualStyleBackColor = true;
            this.checkPic.Click += new System.EventHandler(this.checkPic_Click);
            // 
            // waitCheckItem
            // 
            this.waitCheckItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitCheckItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.标题1});
            this.waitCheckItem.Location = new System.Drawing.Point(923, 6);
            this.waitCheckItem.Name = "waitCheckItem";
            this.waitCheckItem.RowTemplate.Height = 23;
            this.waitCheckItem.Size = new System.Drawing.Size(446, 346);
            this.waitCheckItem.TabIndex = 10;
            // 
            // keySearchResult
            // 
            this.keySearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keySearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.标题,
            this.价格,
            this.店铺});
            this.keySearchResult.Location = new System.Drawing.Point(6, 197);
            this.keySearchResult.Name = "keySearchResult";
            this.keySearchResult.RowTemplate.Height = 23;
            this.keySearchResult.Size = new System.Drawing.Size(659, 548);
            this.keySearchResult.TabIndex = 20;
            this.keySearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.keySearchResult_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 80;
            // 
            // 标题
            // 
            this.标题.DataPropertyName = "标题";
            this.标题.HeaderText = "标题";
            this.标题.Name = "标题";
            this.标题.Width = 375;
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "价格";
            this.价格.HeaderText = "价格";
            this.价格.Name = "价格";
            this.价格.Width = 60;
            // 
            // 店铺
            // 
            this.店铺.DataPropertyName = "店铺";
            this.店铺.HeaderText = "店铺";
            this.店铺.Name = "店铺";
            this.店铺.Width = 70;
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(923, 358);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 11;
            this.previous.Text = "上一个";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // notQualify
            // 
            this.notQualify.Location = new System.Drawing.Point(1166, 358);
            this.notQualify.Name = "notQualify";
            this.notQualify.Size = new System.Drawing.Size(75, 23);
            this.notQualify.TabIndex = 12;
            this.notQualify.Text = "不合格";
            this.notQualify.UseVisualStyleBackColor = true;
            // 
            // qualify
            // 
            this.qualify.Location = new System.Drawing.Point(1085, 358);
            this.qualify.Name = "qualify";
            this.qualify.Size = new System.Drawing.Size(75, 23);
            this.qualify.TabIndex = 13;
            this.qualify.Text = "合格";
            this.qualify.UseVisualStyleBackColor = true;
            this.qualify.Click += new System.EventHandler(this.qualify_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(1004, 358);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 14;
            this.next.Text = "下一个";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // copyChecked
            // 
            this.copyChecked.Location = new System.Drawing.Point(1288, 357);
            this.copyChecked.Name = "copyChecked";
            this.copyChecked.Size = new System.Drawing.Size(75, 23);
            this.copyChecked.TabIndex = 15;
            this.copyChecked.Text = "复制";
            this.copyChecked.UseVisualStyleBackColor = true;
            this.copyChecked.Click += new System.EventHandler(this.copyChecked_Click);
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "ID";
            this.编号.FillWeight = 90F;
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.Width = 90;
            // 
            // 标题1
            // 
            this.标题1.DataPropertyName = "标题";
            this.标题1.FillWeight = 375F;
            this.标题1.HeaderText = "标题1";
            this.标题1.Name = "标题1";
            this.标题1.Width = 375;
            // 
            // checkItem
            // 
            this.checkItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.checkItem.GridLines = true;
            this.checkItem.Location = new System.Drawing.Point(923, 387);
            this.checkItem.Name = "checkItem";
            this.checkItem.Size = new System.Drawing.Size(440, 358);
            this.checkItem.TabIndex = 16;
            this.checkItem.UseCompatibleStateImageBehavior = false;
            this.checkItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "标题";
            this.columnHeader2.Width = 375;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Id",
            "标题"});
            this.comboBox1.Location = new System.Drawing.Point(1288, 386);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 20);
            this.comboBox1.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 801);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "lkl";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.关键字采集.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waitCheckItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySearchResult)).EndInit();
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
        private ComboBox copyType;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button copyParticipleResult;
        private TabPage tabPage2;
        private WebBrowser webBrowser2;
        private Button checkPic;
        private DataGridView waitCheckItem;
        private DataGridView keySearchResult;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn 标题;
        private DataGridViewTextBoxColumn 价格;
        private DataGridViewTextBoxColumn 店铺;
        private Button previous;
        private Button copyChecked;
        private Button next;
        private Button qualify;
        private Button notQualify;
        private DataGridViewTextBoxColumn 编号;
        private DataGridViewTextBoxColumn 标题1;
        private ListView checkItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ComboBox comboBox1;
    }
}


namespace EmojiForm
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bylabel = new System.Windows.Forms.RadioButton();
            this.bytarget = new System.Windows.Forms.RadioButton();
            this.byseries = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.Button();
            this.recommend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblTargetPeople = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.lblSeries = new System.Windows.Forms.Label();
            this.export = new System.Windows.Forms.Button();
            this.likes = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedText = new System.Windows.Forms.Label();
            this.dataGridViewImage = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTipCell = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.加入收藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除表情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmsRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.bylabel);
            this.flowLayoutPanel2.Controls.Add(this.bytarget);
            this.flowLayoutPanel2.Controls.Add(this.byseries);
            this.flowLayoutPanel2.Controls.Add(this.search);
            this.flowLayoutPanel2.Controls.Add(this.recommend);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1070, 155);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 27);
            this.textBox1.TabIndex = 15;
            // 
            // bylabel
            // 
            this.bylabel.AutoSize = true;
            this.bylabel.Checked = true;
            this.bylabel.Location = new System.Drawing.Point(331, 12);
            this.bylabel.Name = "bylabel";
            this.bylabel.Size = new System.Drawing.Size(80, 21);
            this.bylabel.TabIndex = 11;
            this.bylabel.TabStop = true;
            this.bylabel.Text = "按标签";
            this.bylabel.UseVisualStyleBackColor = true;
            this.bylabel.CheckedChanged += new System.EventHandler(this.bylabel_CheckedChanged);
            // 
            // bytarget
            // 
            this.bytarget.AutoSize = true;
            this.bytarget.Location = new System.Drawing.Point(417, 12);
            this.bytarget.Name = "bytarget";
            this.bytarget.Size = new System.Drawing.Size(80, 21);
            this.bytarget.TabIndex = 12;
            this.bytarget.Text = "按对象";
            this.bytarget.UseVisualStyleBackColor = true;
            this.bytarget.CheckedChanged += new System.EventHandler(this.bytarget_CheckedChanged);
            // 
            // byseries
            // 
            this.byseries.AutoSize = true;
            this.byseries.Location = new System.Drawing.Point(503, 12);
            this.byseries.Name = "byseries";
            this.byseries.Size = new System.Drawing.Size(80, 21);
            this.byseries.TabIndex = 13;
            this.byseries.Text = "按系列";
            this.byseries.UseVisualStyleBackColor = true;
            this.byseries.CheckedChanged += new System.EventHandler(this.byseries_CheckedChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(589, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(91, 35);
            this.search.TabIndex = 14;
            this.search.Text = "查找";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // recommend
            // 
            this.recommend.Location = new System.Drawing.Point(686, 12);
            this.recommend.Name = "recommend";
            this.recommend.Size = new System.Drawing.Size(112, 34);
            this.recommend.TabIndex = 15;
            this.recommend.Text = "热门表情";
            this.recommend.UseVisualStyleBackColor = true;
            this.recommend.Click += new System.EventHandler(this.recommend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.lblTargetPeople);
            this.panel2.Location = new System.Drawing.Point(13, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 40);
            this.panel2.TabIndex = 19;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(306, 13);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(80, 21);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "程序员";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(236, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(63, 21);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "恋人";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(167, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 21);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "父母";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(98, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 21);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "全部";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblTargetPeople
            // 
            this.lblTargetPeople.AutoSize = true;
            this.lblTargetPeople.Font = new System.Drawing.Font("宋体", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTargetPeople.Location = new System.Drawing.Point(-1, 0);
            this.lblTargetPeople.Name = "lblTargetPeople";
            this.lblTargetPeople.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblTargetPeople.Size = new System.Drawing.Size(98, 36);
            this.lblTargetPeople.TabIndex = 18;
            this.lblTargetPeople.Text = "适用对象";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton9);
            this.panel3.Controls.Add(this.radioButton8);
            this.panel3.Controls.Add(this.radioButton7);
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Controls.Add(this.lblSeries);
            this.panel3.Location = new System.Drawing.Point(13, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 40);
            this.panel3.TabIndex = 20;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(466, 9);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(63, 21);
            this.radioButton9.TabIndex = 5;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "其他";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(362, 9);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(97, 21);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "天线宝宝";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(292, 9);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(63, 21);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "宠物";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(206, 9);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(80, 21);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "熊猫头";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(102, 9);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(97, 21);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "猫和老鼠";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Font = new System.Drawing.Font("宋体", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSeries.Location = new System.Drawing.Point(0, 9);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(102, 21);
            this.lblSeries.TabIndex = 0;
            this.lblSeries.Text = "系    列";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(3, 3);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(130, 47);
            this.export.TabIndex = 17;
            this.export.Text = "批量导出";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // likes
            // 
            this.likes.Location = new System.Drawing.Point(3, 56);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(130, 47);
            this.likes.TabIndex = 14;
            this.likes.Text = "我的收藏";
            this.likes.UseVisualStyleBackColor = true;
            this.likes.Click += new System.EventHandler(this.likes_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.export);
            this.flowLayoutPanel1.Controls.Add(this.likes);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.selectedText);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(933, 155);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(137, 497);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "当前选中：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectedText
            // 
            this.selectedText.AutoSize = true;
            this.selectedText.Location = new System.Drawing.Point(10, 150);
            this.selectedText.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.selectedText.Name = "selectedText";
            this.selectedText.Size = new System.Drawing.Size(0, 17);
            this.selectedText.TabIndex = 21;
            // 
            // dataGridViewImage
            // 
            this.dataGridViewImage.AllowUserToAddRows = false;
            this.dataGridViewImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImage.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewImage.Name = "dataGridViewImage";
            this.dataGridViewImage.RowHeadersWidth = 62;
            this.dataGridViewImage.RowTemplate.Height = 30;
            this.dataGridViewImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewImage.Size = new System.Drawing.Size(927, 491);
            this.dataGridViewImage.TabIndex = 21;
            this.dataGridViewImage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImage_CellContentClick);
            this.dataGridViewImage.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewImage_CellMouseDown);
            this.dataGridViewImage.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImage_CellMouseEnter);
            this.dataGridViewImage.MouseHover += new System.EventHandler(this.dataGridViewImage_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(933, 497);
            this.panel1.TabIndex = 22;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolTipCell
            // 
            this.toolTipCell.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolTipCell.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTipCell.IsBalloon = true;
            this.toolTipCell.OwnerDraw = true;
            this.toolTipCell.ShowAlways = true;
            this.toolTipCell.ToolTipTitle = " ";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            // 
            // cmsRightClick
            // 
            this.cmsRightClick.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.cmsRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加入收藏ToolStripMenuItem,
            this.删除表情ToolStripMenuItem,
            this.查看属性ToolStripMenuItem});
            this.cmsRightClick.Name = "cmsRightClick";
            this.cmsRightClick.Size = new System.Drawing.Size(149, 88);
            // 
            // 加入收藏ToolStripMenuItem
            // 
            this.加入收藏ToolStripMenuItem.Name = "加入收藏ToolStripMenuItem";
            this.加入收藏ToolStripMenuItem.Size = new System.Drawing.Size(228, 28);
            this.加入收藏ToolStripMenuItem.Text = "加入收藏";
            this.加入收藏ToolStripMenuItem.Click += new System.EventHandler(this.加入收藏ToolStripMenuItem_Click);
            // 
            // 查看属性ToolStripMenuItem
            // 
            this.查看属性ToolStripMenuItem.Name = "查看属性ToolStripMenuItem";
            this.查看属性ToolStripMenuItem.Size = new System.Drawing.Size(228, 28);
            this.查看属性ToolStripMenuItem.Text = "查看属性";
            this.查看属性ToolStripMenuItem.Click += new System.EventHandler(this.查看属性ToolStripMenuItem_Click);
            // 
            // 删除表情ToolStripMenuItem
            // 
            this.删除表情ToolStripMenuItem.Name = "删除表情ToolStripMenuItem";
            this.删除表情ToolStripMenuItem.Size = new System.Drawing.Size(228, 28);
            this.删除表情ToolStripMenuItem.Text = "删除表情";
            this.删除表情ToolStripMenuItem.Click += new System.EventHandler(this.删除表情ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "MainForm";
            this.Text = "逗图";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.cmsRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton bylabel;
        private System.Windows.Forms.RadioButton bytarget;
        private System.Windows.Forms.RadioButton byseries;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button recommend;
        private System.Windows.Forms.Button likes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTargetPeople;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ToolTip toolTipCell;
        private System.Windows.Forms.ContextMenuStrip cmsRightClick;
        private System.Windows.Forms.ToolStripMenuItem 加入收藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除表情ToolStripMenuItem;
    }
}


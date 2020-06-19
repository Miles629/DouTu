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
            this.rbTargetProgrammer = new System.Windows.Forms.RadioButton();
            this.rbTargetLover = new System.Windows.Forms.RadioButton();
            this.rbTargetParents = new System.Windows.Forms.RadioButton();
            this.rbTargetAll = new System.Windows.Forms.RadioButton();
            this.lblTargetPeople = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbSeriesOthers = new System.Windows.Forms.RadioButton();
            this.rbSeriesBaby = new System.Windows.Forms.RadioButton();
            this.rbSeriesPets = new System.Windows.Forms.RadioButton();
            this.rbSeriesPanda = new System.Windows.Forms.RadioButton();
            this.rbSeriesTom = new System.Windows.Forms.RadioButton();
            this.lblSeries = new System.Windows.Forms.Label();
            this.export = new System.Windows.Forms.Button();
            this.likes = new System.Windows.Forms.Button();
            this.dataGridViewImage = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTipCell = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.加入收藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除表情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbSeriesAll = new System.Windows.Forms.RadioButton();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxTarget = new System.Windows.Forms.GroupBox();
            this.groupBoxSeries = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmsRightClick.SuspendLayout();
            this.groupBoxTarget.SuspendLayout();
            this.groupBoxSeries.SuspendLayout();
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
            this.flowLayoutPanel2.Controls.Add(this.export);
            this.flowLayoutPanel2.Controls.Add(this.likes);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1180, 155);
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
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBoxTarget);
            this.panel2.Controls.Add(this.lblTargetPeople);
            this.panel2.Location = new System.Drawing.Point(13, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 40);
            this.panel2.TabIndex = 19;
            // 
            // rbTargetProgrammer
            // 
            this.rbTargetProgrammer.AutoSize = true;
            this.rbTargetProgrammer.Location = new System.Drawing.Point(232, 6);
            this.rbTargetProgrammer.Name = "rbTargetProgrammer";
            this.rbTargetProgrammer.Size = new System.Drawing.Size(80, 21);
            this.rbTargetProgrammer.TabIndex = 22;
            this.rbTargetProgrammer.TabStop = true;
            this.rbTargetProgrammer.Text = "程序员";
            this.rbTargetProgrammer.UseVisualStyleBackColor = true;
            this.rbTargetProgrammer.CheckedChanged += new System.EventHandler(this.rbTargetProgrammer_CheckedChanged);
            // 
            // rbTargetLover
            // 
            this.rbTargetLover.AutoSize = true;
            this.rbTargetLover.Location = new System.Drawing.Point(163, 6);
            this.rbTargetLover.Name = "rbTargetLover";
            this.rbTargetLover.Size = new System.Drawing.Size(63, 21);
            this.rbTargetLover.TabIndex = 21;
            this.rbTargetLover.TabStop = true;
            this.rbTargetLover.Text = "恋人";
            this.rbTargetLover.UseVisualStyleBackColor = true;
            this.rbTargetLover.CheckedChanged += new System.EventHandler(this.rbTargetLover_CheckedChanged);
            // 
            // rbTargetParents
            // 
            this.rbTargetParents.AutoSize = true;
            this.rbTargetParents.Location = new System.Drawing.Point(85, 6);
            this.rbTargetParents.Name = "rbTargetParents";
            this.rbTargetParents.Size = new System.Drawing.Size(63, 21);
            this.rbTargetParents.TabIndex = 20;
            this.rbTargetParents.TabStop = true;
            this.rbTargetParents.Text = "父母";
            this.rbTargetParents.UseVisualStyleBackColor = true;
            this.rbTargetParents.CheckedChanged += new System.EventHandler(this.rbTargetParents_CheckedChanged);
            // 
            // rbTargetAll
            // 
            this.rbTargetAll.AutoSize = true;
            this.rbTargetAll.Location = new System.Drawing.Point(6, 6);
            this.rbTargetAll.Name = "rbTargetAll";
            this.rbTargetAll.Size = new System.Drawing.Size(63, 21);
            this.rbTargetAll.TabIndex = 19;
            this.rbTargetAll.TabStop = true;
            this.rbTargetAll.Text = "全部";
            this.rbTargetAll.UseVisualStyleBackColor = true;
            this.rbTargetAll.CheckedChanged += new System.EventHandler(this.rbTargetAll_CheckedChanged);
            // 
            // lblTargetPeople
            // 
            this.lblTargetPeople.AutoSize = true;
            this.lblTargetPeople.Font = new System.Drawing.Font("宋体", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTargetPeople.Location = new System.Drawing.Point(0, 0);
            this.lblTargetPeople.Name = "lblTargetPeople";
            this.lblTargetPeople.Padding = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.lblTargetPeople.Size = new System.Drawing.Size(103, 36);
            this.lblTargetPeople.TabIndex = 18;
            this.lblTargetPeople.Text = "适用对象";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxSeries);
            this.panel3.Controls.Add(this.lblSeries);
            this.panel3.Location = new System.Drawing.Point(13, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 40);
            this.panel3.TabIndex = 20;
            // 
            // rbSeriesOthers
            // 
            this.rbSeriesOthers.AutoSize = true;
            this.rbSeriesOthers.Location = new System.Drawing.Point(477, 0);
            this.rbSeriesOthers.Name = "rbSeriesOthers";
            this.rbSeriesOthers.Size = new System.Drawing.Size(63, 21);
            this.rbSeriesOthers.TabIndex = 5;
            this.rbSeriesOthers.TabStop = true;
            this.rbSeriesOthers.Text = "其他";
            this.rbSeriesOthers.UseVisualStyleBackColor = true;
            this.rbSeriesOthers.CheckedChanged += new System.EventHandler(this.rbSeriesOthers_CheckedChanged);
            // 
            // rbSeriesBaby
            // 
            this.rbSeriesBaby.AutoSize = true;
            this.rbSeriesBaby.Location = new System.Drawing.Point(364, 0);
            this.rbSeriesBaby.Name = "rbSeriesBaby";
            this.rbSeriesBaby.Size = new System.Drawing.Size(97, 21);
            this.rbSeriesBaby.TabIndex = 4;
            this.rbSeriesBaby.TabStop = true;
            this.rbSeriesBaby.Text = "天线宝宝";
            this.rbSeriesBaby.UseVisualStyleBackColor = true;
            this.rbSeriesBaby.CheckedChanged += new System.EventHandler(this.rbSeriesBaby_CheckedChanged);
            // 
            // rbSeriesPets
            // 
            this.rbSeriesPets.AutoSize = true;
            this.rbSeriesPets.Location = new System.Drawing.Point(290, 0);
            this.rbSeriesPets.Name = "rbSeriesPets";
            this.rbSeriesPets.Size = new System.Drawing.Size(63, 21);
            this.rbSeriesPets.TabIndex = 3;
            this.rbSeriesPets.TabStop = true;
            this.rbSeriesPets.Text = "宠物";
            this.rbSeriesPets.UseVisualStyleBackColor = true;
            this.rbSeriesPets.CheckedChanged += new System.EventHandler(this.rbSeriesPets_CheckedChanged);
            // 
            // rbSeriesPanda
            // 
            this.rbSeriesPanda.AutoSize = true;
            this.rbSeriesPanda.Location = new System.Drawing.Point(197, 0);
            this.rbSeriesPanda.Name = "rbSeriesPanda";
            this.rbSeriesPanda.Size = new System.Drawing.Size(80, 21);
            this.rbSeriesPanda.TabIndex = 2;
            this.rbSeriesPanda.TabStop = true;
            this.rbSeriesPanda.Text = "熊猫头";
            this.rbSeriesPanda.UseVisualStyleBackColor = true;
            this.rbSeriesPanda.CheckedChanged += new System.EventHandler(this.rbSeriesPanda_CheckedChanged);
            // 
            // rbSeriesTom
            // 
            this.rbSeriesTom.AutoSize = true;
            this.rbSeriesTom.Location = new System.Drawing.Point(85, 0);
            this.rbSeriesTom.Name = "rbSeriesTom";
            this.rbSeriesTom.Size = new System.Drawing.Size(97, 21);
            this.rbSeriesTom.TabIndex = 1;
            this.rbSeriesTom.TabStop = true;
            this.rbSeriesTom.Text = "猫和老鼠";
            this.rbSeriesTom.UseVisualStyleBackColor = true;
            this.rbSeriesTom.CheckedChanged += new System.EventHandler(this.rbSeriesTom_CheckedChanged);
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Font = new System.Drawing.Font("宋体", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSeries.Location = new System.Drawing.Point(0, 9);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(90, 21);
            this.lblSeries.TabIndex = 0;
            this.lblSeries.Text = "系   列";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(899, 12);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(110, 35);
            this.export.TabIndex = 17;
            this.export.Text = "批量导出";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // likes
            // 
            this.likes.Location = new System.Drawing.Point(1015, 12);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(109, 34);
            this.likes.TabIndex = 14;
            this.likes.Text = "我的收藏";
            this.likes.UseVisualStyleBackColor = true;
            this.likes.Click += new System.EventHandler(this.likes_Click);
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
            this.dataGridViewImage.Size = new System.Drawing.Size(1174, 491);
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
            this.panel1.Size = new System.Drawing.Size(1180, 497);
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
            this.查看属性ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.cmsRightClick.Name = "cmsRightClick";
            this.cmsRightClick.Size = new System.Drawing.Size(149, 116);
            // 
            // 加入收藏ToolStripMenuItem
            // 
            this.加入收藏ToolStripMenuItem.Name = "加入收藏ToolStripMenuItem";
            this.加入收藏ToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.加入收藏ToolStripMenuItem.Text = "加入收藏";
            this.加入收藏ToolStripMenuItem.Click += new System.EventHandler(this.加入收藏ToolStripMenuItem_Click);
            // 
            // 查看属性ToolStripMenuItem
            // 
            this.查看属性ToolStripMenuItem.Name = "查看属性ToolStripMenuItem";
            this.查看属性ToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.查看属性ToolStripMenuItem.Text = "查看属性";
            this.查看属性ToolStripMenuItem.Click += new System.EventHandler(this.查看属性ToolStripMenuItem_Click);
            // 
            // 删除表情ToolStripMenuItem
            // 
            this.删除表情ToolStripMenuItem.Name = "删除表情ToolStripMenuItem";
            this.删除表情ToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.删除表情ToolStripMenuItem.Text = "删除表情";
            this.删除表情ToolStripMenuItem.Click += new System.EventHandler(this.删除表情ToolStripMenuItem_Click);
            // 
            // rbSeriesAll
            // 
            this.rbSeriesAll.AutoSize = true;
            this.rbSeriesAll.Location = new System.Drawing.Point(6, 0);
            this.rbSeriesAll.Name = "rbSeriesAll";
            this.rbSeriesAll.Size = new System.Drawing.Size(63, 21);
            this.rbSeriesAll.TabIndex = 6;
            this.rbSeriesAll.TabStop = true;
            this.rbSeriesAll.Text = "全部";
            this.rbSeriesAll.UseVisualStyleBackColor = true;
            this.rbSeriesAll.CheckedChanged += new System.EventHandler(this.rbSeriesAll_CheckedChanged);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // groupBoxTarget
            // 
            this.groupBoxTarget.Controls.Add(this.rbTargetProgrammer);
            this.groupBoxTarget.Controls.Add(this.rbTargetAll);
            this.groupBoxTarget.Controls.Add(this.rbTargetLover);
            this.groupBoxTarget.Controls.Add(this.rbTargetParents);
            this.groupBoxTarget.Location = new System.Drawing.Point(109, 9);
            this.groupBoxTarget.Name = "groupBoxTarget";
            this.groupBoxTarget.Size = new System.Drawing.Size(337, 27);
            this.groupBoxTarget.TabIndex = 23;
            this.groupBoxTarget.TabStop = false;
            // 
            // groupBoxSeries
            // 
            this.groupBoxSeries.Controls.Add(this.rbSeriesAll);
            this.groupBoxSeries.Controls.Add(this.rbSeriesOthers);
            this.groupBoxSeries.Controls.Add(this.rbSeriesTom);
            this.groupBoxSeries.Controls.Add(this.rbSeriesBaby);
            this.groupBoxSeries.Controls.Add(this.rbSeriesPanda);
            this.groupBoxSeries.Controls.Add(this.rbSeriesPets);
            this.groupBoxSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSeries.Location = new System.Drawing.Point(109, 9);
            this.groupBoxSeries.Name = "groupBoxSeries";
            this.groupBoxSeries.Size = new System.Drawing.Size(558, 28);
            this.groupBoxSeries.TabIndex = 7;
            this.groupBoxSeries.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "MainForm";
            this.Text = "逗图";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.cmsRightClick.ResumeLayout(false);
            this.groupBoxTarget.ResumeLayout(false);
            this.groupBoxTarget.PerformLayout();
            this.groupBoxSeries.ResumeLayout(false);
            this.groupBoxSeries.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTargetPeople;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbTargetProgrammer;
        private System.Windows.Forms.RadioButton rbTargetLover;
        private System.Windows.Forms.RadioButton rbTargetParents;
        private System.Windows.Forms.RadioButton rbTargetAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbSeriesOthers;
        private System.Windows.Forms.RadioButton rbSeriesBaby;
        private System.Windows.Forms.RadioButton rbSeriesPets;
        private System.Windows.Forms.RadioButton rbSeriesPanda;
        private System.Windows.Forms.RadioButton rbSeriesTom;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ToolTip toolTipCell;
        private System.Windows.Forms.ContextMenuStrip cmsRightClick;
        private System.Windows.Forms.ToolStripMenuItem 加入收藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除表情ToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbSeriesAll;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTarget;
        private System.Windows.Forms.GroupBox groupBoxSeries;
    }
}


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
            this.bylabel = new System.Windows.Forms.RadioButton();
            this.bytarget = new System.Windows.Forms.RadioButton();
            this.byseries = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.recommend = new System.Windows.Forms.Button();
            this.addlike = new System.Windows.Forms.Button();
            this.likes = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewImage = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImage)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1015, 55);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // bylabel
            // 
            this.bylabel.AutoSize = true;
            this.bylabel.Checked = true;
            this.bylabel.Location = new System.Drawing.Point(331, 13);
            this.bylabel.Name = "bylabel";
            this.bylabel.Size = new System.Drawing.Size(87, 22);
            this.bylabel.TabIndex = 11;
            this.bylabel.TabStop = true;
            this.bylabel.Text = "按标签";
            this.bylabel.UseVisualStyleBackColor = true;
            this.bylabel.CheckedChanged += new System.EventHandler(this.bylabel_CheckedChanged);
            // 
            // bytarget
            // 
            this.bytarget.AutoSize = true;
            this.bytarget.Location = new System.Drawing.Point(424, 13);
            this.bytarget.Name = "bytarget";
            this.bytarget.Size = new System.Drawing.Size(87, 22);
            this.bytarget.TabIndex = 12;
            this.bytarget.Text = "按对象";
            this.bytarget.UseVisualStyleBackColor = true;
            this.bytarget.CheckedChanged += new System.EventHandler(this.bytarget_CheckedChanged);
            // 
            // byseries
            // 
            this.byseries.AutoSize = true;
            this.byseries.Location = new System.Drawing.Point(517, 13);
            this.byseries.Name = "byseries";
            this.byseries.Size = new System.Drawing.Size(87, 22);
            this.byseries.TabIndex = 13;
            this.byseries.Text = "按系列";
            this.byseries.UseVisualStyleBackColor = true;
            this.byseries.CheckedChanged += new System.EventHandler(this.byseries_CheckedChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(610, 13);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(91, 37);
            this.search.TabIndex = 14;
            this.search.Text = "查找";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(3, 3);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(128, 50);
            this.import.TabIndex = 18;
            this.import.Text = "添加表情";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(3, 59);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(130, 50);
            this.export.TabIndex = 17;
            this.export.Text = "批量导出";
            this.export.UseVisualStyleBackColor = true;
            // 
            // recommend
            // 
            this.recommend.Location = new System.Drawing.Point(707, 13);
            this.recommend.Name = "recommend";
            this.recommend.Size = new System.Drawing.Size(112, 36);
            this.recommend.TabIndex = 15;
            this.recommend.Text = "热门表情";
            this.recommend.UseVisualStyleBackColor = true;
            this.recommend.Click += new System.EventHandler(this.recommend_Click);
            // 
            // addlike
            // 
            this.addlike.Location = new System.Drawing.Point(3, 115);
            this.addlike.Name = "addlike";
            this.addlike.Size = new System.Drawing.Size(130, 50);
            this.addlike.TabIndex = 19;
            this.addlike.Text = "加入收藏";
            this.addlike.UseVisualStyleBackColor = true;
            // 
            // likes
            // 
            this.likes.Location = new System.Drawing.Point(3, 171);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(130, 50);
            this.likes.TabIndex = 14;
            this.likes.Text = "我的收藏";
            this.likes.UseVisualStyleBackColor = true;
            this.likes.Click += new System.EventHandler(this.likes_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.import);
            this.flowLayoutPanel1.Controls.Add(this.export);
            this.flowLayoutPanel1.Controls.Add(this.addlike);
            this.flowLayoutPanel1.Controls.Add(this.likes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(865, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 635);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // dataGridViewImage
            // 
            this.dataGridViewImage.AllowUserToAddRows = false;
            this.dataGridViewImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImage.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewImage.Name = "dataGridViewImage";
            this.dataGridViewImage.RowTemplate.Height = 30;
            this.dataGridViewImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewImage.Size = new System.Drawing.Size(859, 629);
            this.dataGridViewImage.TabIndex = 21;
            this.dataGridViewImage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImage_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(865, 635);
            this.panel1.TabIndex = 22;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 28);
            this.textBox1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "MainForm";
            this.Text = "逗图";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton bylabel;
        private System.Windows.Forms.RadioButton bytarget;
        private System.Windows.Forms.RadioButton byseries;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button recommend;
        private System.Windows.Forms.Button addlike;
        private System.Windows.Forms.Button likes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox textBox1;
    }
}


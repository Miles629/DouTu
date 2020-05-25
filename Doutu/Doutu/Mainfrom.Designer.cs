namespace Doutu
{
    partial class Mainfrom
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
            this.likes = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recent = new System.Windows.Forms.Button();
            this.recommend = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.export = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.addlike = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bylabel = new System.Windows.Forms.RadioButton();
            this.bytarget = new System.Windows.Forms.RadioButton();
            this.byseries = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // likes
            // 
            this.likes.Location = new System.Drawing.Point(8, 343);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(130, 50);
            this.likes.TabIndex = 3;
            this.likes.Text = "我的收藏";
            this.likes.UseVisualStyleBackColor = true;
            this.likes.Click += new System.EventHandler(this.likes_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(8, 8);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(130, 50);
            this.search.TabIndex = 4;
            this.search.Text = "查找";
            this.search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(667, 375);
            this.dataGridView1.TabIndex = 5;
            // 
            // recent
            // 
            this.recent.Location = new System.Drawing.Point(8, 231);
            this.recent.Name = "recent";
            this.recent.Size = new System.Drawing.Size(130, 50);
            this.recent.TabIndex = 7;
            this.recent.Text = "最近使用";
            this.recent.UseVisualStyleBackColor = true;
            this.recent.Click += new System.EventHandler(this.recent_Click);
            // 
            // recommend
            // 
            this.recommend.Location = new System.Drawing.Point(8, 175);
            this.recommend.Name = "recommend";
            this.recommend.Size = new System.Drawing.Size(130, 50);
            this.recommend.TabIndex = 6;
            this.recommend.Text = "热门表情";
            this.recommend.UseVisualStyleBackColor = true;
            this.recommend.Click += new System.EventHandler(this.recommend_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 26);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(8, 119);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(130, 50);
            this.export.TabIndex = 8;
            this.export.Text = "批量导出";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(8, 64);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(128, 49);
            this.import.TabIndex = 9;
            this.import.Text = "添加表情";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // addlike
            // 
            this.addlike.Location = new System.Drawing.Point(8, 287);
            this.addlike.Name = "addlike";
            this.addlike.Size = new System.Drawing.Size(130, 50);
            this.addlike.TabIndex = 10;
            this.addlike.Text = "加入收藏";
            this.addlike.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.search);
            this.flowLayoutPanel1.Controls.Add(this.import);
            this.flowLayoutPanel1.Controls.Add(this.export);
            this.flowLayoutPanel1.Controls.Add(this.recommend);
            this.flowLayoutPanel1.Controls.Add(this.recent);
            this.flowLayoutPanel1.Controls.Add(this.addlike);
            this.flowLayoutPanel1.Controls.Add(this.likes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(692, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(157, 450);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.comboBox1);
            this.flowLayoutPanel2.Controls.Add(this.bylabel);
            this.flowLayoutPanel2.Controls.Add(this.bytarget);
            this.flowLayoutPanel2.Controls.Add(this.byseries);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(687, 55);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // bylabel
            // 
            this.bylabel.AutoSize = true;
            this.bylabel.Location = new System.Drawing.Point(319, 13);
            this.bylabel.Name = "bylabel";
            this.bylabel.Size = new System.Drawing.Size(87, 22);
            this.bylabel.TabIndex = 11;
            this.bylabel.TabStop = true;
            this.bylabel.Text = "按标签";
            this.bylabel.UseVisualStyleBackColor = true;
            // 
            // bytarget
            // 
            this.bytarget.AutoSize = true;
            this.bytarget.Location = new System.Drawing.Point(412, 13);
            this.bytarget.Name = "bytarget";
            this.bytarget.Size = new System.Drawing.Size(87, 22);
            this.bytarget.TabIndex = 12;
            this.bytarget.TabStop = true;
            this.bytarget.Text = "按对象";
            this.bytarget.UseVisualStyleBackColor = true;
            // 
            // byseries
            // 
            this.byseries.AutoSize = true;
            this.byseries.Location = new System.Drawing.Point(505, 13);
            this.byseries.Name = "byseries";
            this.byseries.Size = new System.Drawing.Size(87, 22);
            this.byseries.TabIndex = 13;
            this.byseries.TabStop = true;
            this.byseries.Text = "按系列";
            this.byseries.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 60);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(687, 395);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "逗图";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button likes;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button recent;
        private System.Windows.Forms.Button recommend;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button addlike;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton bylabel;
        private System.Windows.Forms.RadioButton bytarget;
        private System.Windows.Forms.RadioButton byseries;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
    }
}


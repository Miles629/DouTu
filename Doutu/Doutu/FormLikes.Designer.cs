namespace Doutu
{
    partial class FormLikes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewLikeEmoji = new System.Windows.Forms.DataGridView();
            this.export = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.likeImageList = new System.Windows.Forms.ImageList(this.components);
            this.BtnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikeEmoji)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLikeEmoji
            // 
            this.dataGridViewLikeEmoji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLikeEmoji.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewLikeEmoji.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLikeEmoji.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLikeEmoji.Name = "dataGridViewLikeEmoji";
            this.dataGridViewLikeEmoji.RowTemplate.Height = 30;
            this.dataGridViewLikeEmoji.Size = new System.Drawing.Size(399, 300);
            this.dataGridViewLikeEmoji.TabIndex = 0;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(427, 223);
            this.export.Margin = new System.Windows.Forms.Padding(2);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(87, 33);
            this.export.TabIndex = 2;
            this.export.Text = "批量导出";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(427, 96);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.manage_Click);
            // 
            // likeImageList
            // 
            this.likeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.likeImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.likeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(427, 36);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(87, 33);
            this.BtnChange.TabIndex = 4;
            this.BtnChange.Text = "修改";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // FormLikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridViewLikeEmoji);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLikes";
            this.Text = "我的收藏";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikeEmoji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLikeEmoji;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList likeImageList;
        private System.Windows.Forms.Button BtnChange;
    }
}
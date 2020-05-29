namespace Doutu
{
    partial class FormAdd
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
            this.add = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.EmojiKeyword = new System.Windows.Forms.TextBox();
            this.series = new System.Windows.Forms.Label();
            this.EmojiSeries = new System.Windows.Forms.ComboBox();
            this.target = new System.Windows.Forms.Label();
            this.EmojiTargetPeople = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(87, 200);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(134, 50);
            this.add.TabIndex = 0;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 18);
            this.label.TabIndex = 1;
            this.label.Text = "标签：";
            // 
            // EmojiKeyword
            // 
            this.EmojiKeyword.Location = new System.Drawing.Point(87, 34);
            this.EmojiKeyword.Name = "EmojiKeyword";
            this.EmojiKeyword.Size = new System.Drawing.Size(163, 28);
            this.EmojiKeyword.TabIndex = 2;
            // 
            // series
            // 
            this.series.AutoSize = true;
            this.series.Location = new System.Drawing.Point(20, 90);
            this.series.Name = "series";
            this.series.Size = new System.Drawing.Size(62, 18);
            this.series.TabIndex = 3;
            this.series.Text = "系列：";
            // 
            // EmojiSeries
            // 
            this.EmojiSeries.FormattingEnabled = true;
            this.EmojiSeries.Items.AddRange(new object[] {
            "搞怪",
            "轻松",
            "吐槽"});
            this.EmojiSeries.Location = new System.Drawing.Point(87, 87);
            this.EmojiSeries.Name = "EmojiSeries";
            this.EmojiSeries.Size = new System.Drawing.Size(164, 26);
            this.EmojiSeries.TabIndex = 4;
            // 
            // target
            // 
            this.target.AutoSize = true;
            this.target.Location = new System.Drawing.Point(22, 142);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(62, 18);
            this.target.TabIndex = 5;
            this.target.Text = "对象：";
            // 
            // EmojiTargetPeople
            // 
            this.EmojiTargetPeople.FormattingEnabled = true;
            this.EmojiTargetPeople.Items.AddRange(new object[] {
            "小朋友",
            "小学生",
            "中学生"});
            this.EmojiTargetPeople.Location = new System.Drawing.Point(87, 138);
            this.EmojiTargetPeople.Name = "EmojiTargetPeople";
            this.EmojiTargetPeople.Size = new System.Drawing.Size(163, 26);
            this.EmojiTargetPeople.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmojiTargetPeople);
            this.panel1.Controls.Add(this.target);
            this.panel1.Controls.Add(this.EmojiSeries);
            this.panel1.Controls.Add(this.series);
            this.panel1.Controls.Add(this.EmojiKeyword);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 302);
            this.panel1.TabIndex = 7;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 302);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdd";
            this.Text = "添加表情";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox EmojiKeyword;
        private System.Windows.Forms.Label series;
        private System.Windows.Forms.ComboBox EmojiSeries;
        private System.Windows.Forms.Label target;
        private System.Windows.Forms.ComboBox EmojiTargetPeople;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace EmojiForm
{
    partial class ModifyForm
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
            System.Windows.Forms.Label labTargetPeople;
            this.labSeries = new System.Windows.Forms.Label();
            this.labKeyword = new System.Windows.Forms.Label();
            this.pictureBoxEmoji = new System.Windows.Forms.PictureBox();
            labTargetPeople = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmoji)).BeginInit();
            this.SuspendLayout();
            // 
            // labTargetPeople
            // 
            labTargetPeople.AutoSize = true;
            labTargetPeople.Location = new System.Drawing.Point(294, 199);
            labTargetPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labTargetPeople.Name = "labTargetPeople";
            labTargetPeople.Size = new System.Drawing.Size(80, 18);
            labTargetPeople.TabIndex = 7;
            labTargetPeople.Text = "面向人群";
            // 
            // labSeries
            // 
            this.labSeries.AutoSize = true;
            this.labSeries.Location = new System.Drawing.Point(294, 118);
            this.labSeries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSeries.Name = "labSeries";
            this.labSeries.Size = new System.Drawing.Size(44, 18);
            this.labSeries.TabIndex = 6;
            this.labSeries.Text = "系列";
            // 
            // labKeyword
            // 
            this.labKeyword.AutoSize = true;
            this.labKeyword.Location = new System.Drawing.Point(294, 37);
            this.labKeyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labKeyword.Name = "labKeyword";
            this.labKeyword.Size = new System.Drawing.Size(62, 18);
            this.labKeyword.TabIndex = 5;
            this.labKeyword.Text = "关键字";
            // 
            // pictureBoxEmoji
            // 
            this.pictureBoxEmoji.Location = new System.Drawing.Point(57, 37);
            this.pictureBoxEmoji.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEmoji.Name = "pictureBoxEmoji";
            this.pictureBoxEmoji.Size = new System.Drawing.Size(202, 202);
            this.pictureBoxEmoji.TabIndex = 4;
            this.pictureBoxEmoji.TabStop = false;
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 277);
            this.Controls.Add(labTargetPeople);
            this.Controls.Add(this.labSeries);
            this.Controls.Add(this.labKeyword);
            this.Controls.Add(this.pictureBoxEmoji);
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmoji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSeries;
        private System.Windows.Forms.Label labKeyword;
        private System.Windows.Forms.PictureBox pictureBoxEmoji;
    }
}
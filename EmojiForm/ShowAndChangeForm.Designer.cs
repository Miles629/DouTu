namespace Doutu
{
    partial class ShowAndChangeForm
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
            this.pictureBoxEmoji = new System.Windows.Forms.PictureBox();
            this.labKeyword = new System.Windows.Forms.Label();
            this.labSeries = new System.Windows.Forms.Label();
            labTargetPeople = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmoji)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEmoji
            // 
            this.pictureBoxEmoji.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEmoji.Name = "pictureBoxEmoji";
            this.pictureBoxEmoji.Size = new System.Drawing.Size(135, 135);
            this.pictureBoxEmoji.TabIndex = 0;
            this.pictureBoxEmoji.TabStop = false;
            // 
            // labKeyword
            // 
            this.labKeyword.AutoSize = true;
            this.labKeyword.Location = new System.Drawing.Point(170, 12);
            this.labKeyword.Name = "labKeyword";
            this.labKeyword.Size = new System.Drawing.Size(41, 12);
            this.labKeyword.TabIndex = 1;
            this.labKeyword.Text = "关键字";
            // 
            // labSeries
            // 
            this.labSeries.AutoSize = true;
            this.labSeries.Location = new System.Drawing.Point(170, 66);
            this.labSeries.Name = "labSeries";
            this.labSeries.Size = new System.Drawing.Size(29, 12);
            this.labSeries.TabIndex = 2;
            this.labSeries.Text = "系列";
            // 
            // labTargetPeople
            // 
            labTargetPeople.AutoSize = true;
            labTargetPeople.Location = new System.Drawing.Point(170, 120);
            labTargetPeople.Name = "labTargetPeople";
            labTargetPeople.Size = new System.Drawing.Size(53, 12);
            labTargetPeople.TabIndex = 3;
            labTargetPeople.Text = "面向人群";
            // 
            // ShowAndChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 158);
            this.Controls.Add(labTargetPeople);
            this.Controls.Add(this.labSeries);
            this.Controls.Add(this.labKeyword);
            this.Controls.Add(this.pictureBoxEmoji);
            this.Name = "ShowAndChangeForm";
            this.Text = "showAndChangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmoji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEmoji;
        private System.Windows.Forms.Label labKeyword;
        private System.Windows.Forms.Label labSeries;
    }
}
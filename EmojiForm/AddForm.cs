using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmojiManagement;

namespace EmojiForm
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            DragDrop += AddForm_DragDrop;
            DragEnter += AddForm_DragEnter;
            InitializeComponent();
        }

        private void AddForm_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.pictureBox1.Image = Image.FromFile(path);
            pathTextBox.Text = path;

        }

        private void AddForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emoji newemoji = new Emoji(pathTextBox.Text, keywordTextBox.Text, seriesTextBox.Text, targetTextBox.Text, 0, false);
            EmojiService.AddEmoji(newemoji);
        }
    }
}

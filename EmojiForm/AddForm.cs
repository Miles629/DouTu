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
using MySqlX.XDevAPI.Common;
//using EmojiOCR;
//这里.net freamwork 的东西好像不能引用.net core的

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

        //private string GetOCR(string path)
        //{
        //    string result =EmojiOCR.generalBasic(path);
        //    return result;
        //}

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
            try
            {
                EmojiService.AddEmoji(newemoji);
                MessageBox.Show("添加成功");
                pictureBox1.Image = null;
                pathTextBox.Text = "";
                keywordTextBox.Text = "";
                seriesTextBox.Text = "";
                targetTextBox.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //MainForm mm = new MainForm();
            // mm.ShowEmojis(MainForm.emojiList);
            //((MainForm)this.Owner).Refresh();
                this.Close();
        }
    }
}

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

        //获取表情包的文字信息，path为表情包路径
        private string GetOCR(string path)
        {
            string exepath = @"./EmojiOCR.exe";//路径可能有问题，还没调试

            //这里需要调用EmojiOCR类生成的exe,并传入参数path
            //System(exepath.data())
            //System.Diagnostics.Process.Start(@"EmojiOCR.exe", "path");
            //string result = EmojiOCR.generalBasic(path);
            //return result;

            //返回值格式是string，可以考虑转换成json后再操作，示例如↓：
            //{"log_id": 3371547277663409633, "words_result_num": 1, "words_result": [{"words": "阿瓦达索命"}]}
            //如果words_result_num=0，返回空字符串
            //否则，需要获取第一个words_result的words值，并返回
        }

        private void AddForm_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.pictureBox1.Image = Image.FromFile(path);
            pathTextBox.Text = path;
            //这里调用OCR
            keywordTextBox.Text = GetOCR(path);
            
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

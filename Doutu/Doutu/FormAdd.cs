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

namespace Doutu
{
    public partial class FormAdd : Form
    {
        public int cellLocation;
        public FormAdd(int cellRow,int cellColumn)
        {
            cellLocation = cellRow* 6 + cellColumn + 1;
            InitializeComponent();
        }
        /// <summary>
        /// 将选中图片的值存入数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            //如果是数据库中已有的
            //Mainfrom.emojiList[cellLocation].Keyword = EmojiKeyword.Text;
            //Mainfrom.emojiList[cellLocation].Series = EmojiSeries.SelectedText;
            //Mainfrom.emojiList[cellLocation].TargetPeople = EmojiTargetPeople.SelectedText;
            Emoji emoji = new Emoji();
            emoji.Keyword= EmojiKeyword.Text;
            emoji.Series= EmojiSeries.SelectedItem.ToString(); 
            emoji.TargetPeople= EmojiTargetPeople.SelectedItem.ToString();
            emoji.Path = Mainfrom.recommendImagePathList[cellLocation];
            EmojiService.AddEmoji(emoji);

        }
    }
}

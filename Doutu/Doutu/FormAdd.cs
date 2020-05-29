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
        public bool IsFavorite { set; get; }
        public FormAdd(int cellRow,int cellColumn)
        {
            cellLocation = cellRow* 6 + cellColumn + 1;
            InitializeComponent();
        }
        public FormAdd(int cellRow, int cellColumn,bool isFavorite)
        {
            cellLocation = cellRow * 6 + cellColumn + 1;
            IsFavorite = isFavorite;
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
            string Keyword = EmojiKeyword.Text;
            string Series = EmojiSeries.SelectedItem.ToString();
            string TargetPeople = EmojiTargetPeople.SelectedItem.ToString();
            string Path = Mainfrom.recommendImagePathList[cellLocation];
            if (EmojiService.Emojiexist(Path) == false)
            {
                Emoji emoji = new Emoji(Path, Keyword, Series, TargetPeople,0,false);
                EmojiService.AddEmoji(emoji);
            }
            else if(EmojiService.Emojiexist(Path)&&IsFavorite)
            {
                Emoji emoji = new Emoji(Path, Keyword, Series, TargetPeople, 0,true );
                EmojiService.ModifyEmoji();
            }
           
           

        }
    }
}

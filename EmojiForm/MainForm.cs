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
    public partial class MainForm : Form
    {
        //展示多少单元格
        private int row = 4;
        private int col = 5;

        //搜索条件 默认0(按标签)，1(按对象)，2(按系列)
        private int queryCondi = 0;

        /// <summary>
        /// 定义静态变量emojiList，便于在不同界面对数据库内容进行操作
        /// 赵文山
        /// /// 蒋沁月说只需要一个存储当前展示的表情列表就行了
        /// </summary>
        public static List<Emoji> emojiList = new List<Emoji>();

        //当前选中的表情
        Emoji emojiSelected=null;

        public MainForm()
        {
            InitializeComponent();
            //增加列
            for(int c = 0;c < col; c++)
            {
                DataGridViewImageColumn ic = new DataGridViewImageColumn();
                this.dataGridViewImage.Columns.Add(ic);
                this.dataGridViewImage.Columns[c].Width = 100;//限定列宽
                this.dataGridViewImage.Columns[c].DefaultCellStyle.NullValue = null;//当没有数据时，不会显示红叉，cell.Value 必须是null，对于空串这句无效
            }
            //增加行
            for (int r = 0; r < row; r++)
            {
                this.dataGridViewImage.Rows.Add();//增加行
                this.dataGridViewImage.Rows[r].Height = 100;//限定行宽
            }

            //展示热门表情
            emojiList = EmojiService.SortbyFrequency();
            ShowEmojis(EmojiService.SortbyFrequency());

        }

        private void ShowEmojis(List<Emoji> emojis)
        {
            //清空图片数据
            imageList.Images.Clear();
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    this.dataGridViewImage[c, r].Value = null;
                }
            }
            //防止图片失真
            this.imageList.ColorDepth = ColorDepth.Depth32Bit;
            //将图片加入imageList
            foreach(Emoji e in emojis)
            {
                this.imageList.Images.Add(Image.FromFile(e.Path));
            }
            //展示图片
            int count = 0;
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (count < emojis.Count)
                    {
                        this.dataGridViewImage[c,r ].Value = imageList.Images[count++];

                    }
                    else return;
                }
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
        }

        private void recommend_Click(object sender, EventArgs e)
        {
            emojiList.Clear();
            emojiList = EmojiService.SortbyFrequency();
            ShowEmojis(EmojiService.SortbyFrequency());
        }
        private void search_Click(object sender, EventArgs e)
        {
            switch (queryCondi)
            {
                case 0:
                    emojiList.Clear();
                    emojiList = EmojiService.SearchByKeyword(textBox1.Text);
                    ShowEmojis(emojiList);
                    break;
                case 1:
                    emojiList.Clear();
                    emojiList = EmojiService.SearchByTargetPeople(textBox1.Text);
                    ShowEmojis(emojiList);
                    break;
                case 2:
                    emojiList.Clear();
                    emojiList =EmojiService.SearchBySeries(textBox1.Text);
                    ShowEmojis(emojiList);
                    break;
            }
        }


        //选中一个单元格中的表情
        private void dataGridViewImage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r=dataGridViewImage.CurrentCell.RowIndex;
            int c= dataGridViewImage.CurrentCell.ColumnIndex;
            int location = r * col + c;
            if (location < emojiList.Count)
            {
                emojiSelected = emojiList[location];
                selectedText.Text = emojiSelected.ToString();
            }
        }

        private void likes_Click(object sender, EventArgs e)
        {
            FavoriteForm favoriteForm = new FavoriteForm();
            favoriteForm.ShowDialog();
        }

        private void addlike_Click(object sender, EventArgs e)
        {
            EmojiService.FrequencyPlus(emojiSelected);
            EmojiService.ModifyIsFavorite(emojiSelected,0);
            MessageBox.Show("加入收藏夹成功");
        }


        private void bytarget_CheckedChanged(object sender, EventArgs e)
        {
            queryCondi = 1;
        }
        private void byseries_CheckedChanged(object sender, EventArgs e)
        {
            queryCondi = 2;
        }
        private void bylabel_CheckedChanged(object sender, EventArgs e)
        {
            queryCondi = 0;
        }

        private void export_Click(object sender, EventArgs e)
        {
            EmojiService.ExportEmoji();
        }
    }
}

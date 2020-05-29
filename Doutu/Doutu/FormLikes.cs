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
    public partial class FormLikes : Form
    {
        public FormLikes()
        {
            Mainfrom.emojiList = EmojiService.SortbyFrequency();
            //防止图片失真
            this.likeImageList.ColorDepth = ColorDepth.Depth32Bit;
            foreach (Emoji emoji in Mainfrom.emojiList)
            {
                this.likeImageList.Images.Add(Image.FromFile(emoji.Path));
            }


            //增加6行和6列
            for (int i = 0; i < 6; i++)
            {
                DataGridViewImageColumn ic = new DataGridViewImageColumn();
                this.dataGridViewLikeEmoji.Columns.Add(ic);
                this.dataGridViewLikeEmoji.Rows.Add();//增加行

                this.dataGridViewLikeEmoji.Columns[i].DefaultCellStyle.NullValue = null;//当没有数据时，不会显示红叉，cell.Value 必须是null，对于空串这句无效
                this.dataGridViewLikeEmoji.Columns[i].Width = 100;//限定列宽
                this.dataGridViewLikeEmoji.Rows[i].Height = 100;//限定行宽
            }

            //展示imageList中的表情
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (count < Mainfrom.emojiList.Count)
                    {
                        this.dataGridViewLikeEmoji[i, j].Value = likeImageList.Images[count++];

                    }
                    else
                    {
                        return;
                    }
                }
            }
            InitializeComponent();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            DialogResult rst=MessageBox.Show("是否将该该表情包从收藏夹中删除？","",MessageBoxButtons.OKCancel);
            if (rst==DialogResult.OK)
            {
                EmojiService.DeleteEmoji();
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            EmojiService.ExportEmoji();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            int cellRow = dataGridViewLikeEmoji.CurrentCell.RowIndex;
            int cellColumn = dataGridViewLikeEmoji.CurrentCell.ColumnIndex;
            ShowAndChangeForm showAndChangeForm = new ShowAndChangeForm(cellRow,cellColumn);
            showAndChangeForm.ShowDialog();
        }
    }
}

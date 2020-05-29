using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EmojiManagement;

namespace Doutu
{
    public partial class Mainfrom : Form
    {
        /// <summary>
        /// 定义静态变量emojiList，便于在不同界面对数据库内容进行操作
        /// 赵文山
        /// </summary>
        public static List<Emoji> emojiList = new List<Emoji>();
        public static List<string> recommendImagePathList = new List<string>();
        public Mainfrom()
        {
            InitializeComponent();
           // showDataBasePicture();
        }

        private void showFilePicture(/*List<string> imagePathList*/)//需要传入路径的list
        {
            //显示所有本地图片
           
            DirectoryInfo dir = new DirectoryInfo("..\\..\\Resources");//获取目录
            FileInfo[] fileinfo = dir.GetFiles("*.JPG");//获取文件夹中的图片文件
            
            //防止图片失真
            this.imageList.ColorDepth = ColorDepth.Depth32Bit;
            foreach (FileInfo file in fileinfo)
            {
                recommendImagePathList.Add(file.FullName);//图片路径
                this.imageList.Images.Add(Image.FromFile(file.FullName));
            }
           

            //增加6行和6列
            for (int i = 0; i < 6; i++)
            {
                DataGridViewImageColumn ic = new DataGridViewImageColumn();
                this.dataGridViewImage.Columns.Add(ic);
                this.dataGridViewImage.Rows.Add();//增加行

                this.dataGridViewImage.Columns[i].DefaultCellStyle.NullValue = null;//当没有数据时，不会显示红叉，cell.Value 必须是null，对于空串这句无效
                this.dataGridViewImage.Columns[i].Width = 100;//限定列宽
                this.dataGridViewImage.Rows[i].Height = 100;//限定行宽
            }

            //展示imageList中的表情
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (count < recommendImagePathList.Count)
                    {
                        this.dataGridViewImage[i, j].Value = imageList.Images[count++];
                        
                    }
                    else
                    {
                        return;
                    }
                }
            }

            //this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;//不显示网格
            //this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);//自动调整列宽
            //this.dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);//自动调整行宽

        }
        private void showDataBasePicture()
        {
           
            //导出数据库中所有的数据，并创建EmojiList
           
            emojiList = EmojiService.SortbyFrequency();
            //防止图片失真
            this.imageList.ColorDepth = ColorDepth.Depth32Bit;
            foreach (Emoji emoji in emojiList)
            {
                //imagePathList.Add(file.FullName);//图片路径
                this.imageList.Images.Add(Image.FromFile(emoji.Path));
            }


            //增加6行和6列
            for (int i = 0; i < 6; i++)
            {
                DataGridViewImageColumn ic = new DataGridViewImageColumn();
                this.dataGridViewImage.Columns.Add(ic);
                this.dataGridViewImage.Rows.Add();//增加行

                this.dataGridViewImage.Columns[i].DefaultCellStyle.NullValue = null;//当没有数据时，不会显示红叉，cell.Value 必须是null，对于空串这句无效
                this.dataGridViewImage.Columns[i].Width = 100;//限定列宽
                this.dataGridViewImage.Rows[i].Height = 100;//限定行宽
            }

            //展示imageList中的表情
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (count < emojiList.Count)
                    {
                        this.dataGridViewImage[i, j].Value = imageList.Images[count++];

                    }
                    else
                    {
                        return;
                    }
                }
            }

            //this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;//不显示网格
            //this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);//自动调整列宽
            //this.dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);//自动调整行宽

        }

        private void recommend_Click(object sender, EventArgs e)
        {
            
            showFilePicture(/*recommendList*/);

        }

        private void export_Click(object sender, EventArgs e)
        {
            EmojiService.ExportEmoji();
        }

        private void likes_Click(object sender, EventArgs e)
        {
            FormLikes mlikes = new FormLikes();
            mlikes.ShowDialog();
        }

        private void import_Click(object sender, EventArgs e)
        { 
            int cellRow = dataGridViewImage.CurrentCell.RowIndex;
            int cellColumn = dataGridViewImage.CurrentCell.ColumnIndex;
            FormAdd madd = new FormAdd(cellRow,cellColumn);
            madd.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recent_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void addlike_Click(object sender, EventArgs e)
        {

        }
    }
}

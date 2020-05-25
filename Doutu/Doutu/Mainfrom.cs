using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doutu
{
    public partial class Mainfrom : Form
    {
        public Mainfrom()
        {
            InitializeComponent();
        }

        private void showpicture(/*List<string> imagePathList*/)//需要传入路径的list
        {
            //显示所有本地图片
            List<string> imagePathList = new List<string>();
            DirectoryInfo dir = new DirectoryInfo("..\\..\\Resources");//获取目录
            FileInfo[] fileinfo = dir.GetFiles("*.JPG");//获取文件夹中的图片文件
            //防止图片失真
            this.imageList1.ColorDepth = ColorDepth.Depth32Bit;
            foreach (FileInfo file in fileinfo)
            {
                imagePathList.Add(file.FullName);//图片路径
                this.imageList1.Images.Add(Image.FromFile(file.FullName));
            }


            //增加6行和6列
            for (int i = 0; i < 6; i++)
            {
                DataGridViewImageColumn ic = new DataGridViewImageColumn();
                this.dataGridView1.Columns.Add(ic);
                this.dataGridView1.Rows.Add();//增加行

                this.dataGridView1.Columns[i].DefaultCellStyle.NullValue = null;//当没有数据时，不会显示红叉，cell.Value 必须是null，对于空串这句无效
                this.dataGridView1.Columns[i].Width = 100;//限定列宽
                this.dataGridView1.Rows[i].Height = 100;//限定行宽
            }

            //展示imageList中的表情
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (count < imagePathList.Count)
                    {
                        this.dataGridView1[i, j].Value = imageList1.Images[count++];
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
            //getRecommendList
            showpicture(/*recommendList*/);
        }

        private void export_Click(object sender, EventArgs e)
        {

        }

        private void likes_Click(object sender, EventArgs e)
        {
            FormLikes mlikes = new FormLikes();
            mlikes.ShowDialog();
        }

        private void import_Click(object sender, EventArgs e)
        {
            FormAdd madd = new FormAdd();
            madd.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recent_Click(object sender, EventArgs e)
        {

        }
    }
}

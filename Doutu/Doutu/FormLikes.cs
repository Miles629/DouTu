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
            InitializeComponent();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            FormManage formManage = new FormManage();
            formManage.ShowDialog();
        }

        private void export_Click(object sender, EventArgs e)
        {
            ExportEmoji（）；
        }
    }
}

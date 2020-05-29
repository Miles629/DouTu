using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doutu
{
    public partial class ShowAndChangeForm : Form
    {
        public int EmojiLocation { set; get; }
        public ShowAndChangeForm(int cellRow,int cellColumn )
        {
            EmojiLocation = cellRow * 6 + cellColumn + 1;
            InitializeComponent();
            pictureBoxEmoji.Image = Image.FromFile(Mainfrom.emojiList[EmojiLocation].Path);
        }

    }
}

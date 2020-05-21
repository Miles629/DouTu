using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmojiManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Emoji e = new Emoji("","keyword","series","tgpeople");
            EmojiService.AddEmoji(e);
        }
    }
}

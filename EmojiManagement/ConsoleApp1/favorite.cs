using System;
using System.Collections.Generic;
using System.Text;

namespace EmojiManagement
{
    //收藏夹类
   public class Favorite
    {
        public string Id { set; get; }
        public List<Emoji> Emojis { set; get; }
        public Favorite() { }

    }
}

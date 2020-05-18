using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using EmojiManagment;


//目前只是把主要的函数和类写出来了，如果还需要什么类和函数自己加，写必要的注释

namespace EmojiManagment
{
    class EmojiService
    {
        

        public EmojiService() { }

        //从文件中添加图片
        public static void AddEmoji()
        {
            //席诺&马草原
        }

        public static void DeleteEmoji()
        {
            //张智敏&马草原
        }

        public static void ModifyEmoji()
        {
            //张智敏&马草原
        }

        //这个是一个综合的搜索，先空着
        public static IEnumerable<Emoji> SearchEmoji() 
        {
            //张智敏&马草原
            var query;
            return query;
        }

        //按关键词搜索
        public static IEnumerable<Emoji> SearchByKeyword(string info)
        {
            //张智敏&马草原
            var query;
            return query;
        }

        //按系列搜索
        public static IEnumerable<Emoji> SearchBySeries()
        {
            //张智敏&马草原
            var query;
            return query;
        }

        //按目标人群搜索
        public static IEnumerable<Emoji> SearchByTargetPeople()
        {
            //张智敏&马草原
            var query;
            return query;
        }

        //导入表情
        public static void ImportEmojis()
        {
            //席诺
        }

        //导出表情
        public static void ExportEmojis()
        {
            //席诺
        }
    }
}

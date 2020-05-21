using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using EmojiManagement;


//目前只是把主要的函数和类写出来了，如果还需要什么类和函数自己加，写必要的注释

namespace EmojiManagement
{
    class EmojiService
    {
        

        public EmojiService() { }

        //从文件中添加图片
        public static void AddEmoji(Emoji emoji)
        {
            //席诺&马草原
            try
            {
                using (var db = new EmojiContext())
                {
                    db.Emojis.Add(emoji);
                    db.SaveChanges();
                }
                return;
            }
            catch (Exception e)
            {
                //TODO 需要更加错误类型返回不同错误信息
                throw new ApplicationException($"添加错误: {e.Message}");
            }
        }

        public static void DeleteEmoji()
        {
            //张智敏&马草原
        }

        public static void ModifyEmoji()
        {
            //张智敏&马草原
        }

        public static IQueryable<Emoji> AllEmojis(EmojiContext db)
        {
            return db.Emojis.Include("");
        }


        //这个是一个综合的搜索，先空着
        public static List<Emoji> SearchEmoji(string info) 
        {
            //张智敏&马草原
            using (var db = new EmojiContext())
            {
                var query = AllEmojis(db)
                  .Where(e => e.Keyword == info);
                return query.ToList();
            }

        }

        //按关键词搜索
        public static List<Emoji> SearchByKeyword(string info)
        {
            //张智敏&马草原
            using (var db = new EmojiContext())
            {
                var query = AllEmojis(db)
                  .Where(e => e.Keyword == info);
                return query.ToList();
            }

        }

        //按系列搜索
        public static List<Emoji> SearchBySeries(string info)
        {
            //张智敏&马草原
            using (var db = new EmojiContext())
            {
                var query = AllEmojis(db)
                  .Where(e => e.Series == info);
                return query.ToList();
            }
        }

        //按目标人群搜索
        public static List<Emoji> SearchByTargetPeople(string info)
        {
            //张智敏&马草原
            using (var db = new EmojiContext())
            {
                var query = AllEmojis(db)
                  .Where(e => e.TargetPeople == info);
                return query.ToList();
            }
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using EmojiManagement;


//目前只是把主要的函数和类写出来了，如果还需要什么类和函数自己加，写必要的注释

namespace EmojiManagement
{
   public class EmojiService
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
                    //拷贝图片到指定文件夹
                    string picPath = emoji.Path;//这里记得传入图片的路径,通过可视化操作选中图片传参，参数记得改一下奥席诺同学
                    string filename = Path.GetFileName(picPath);
                    string targetPath = @"D:\emojifile\" + filename;
                    File.Copy(picPath, targetPath);
                    //在数据库里添加这个表情的信息
                    db.Emojis.Add(emoji);
                    db.SaveChanges();
                }
                return;
            }
            catch (Exception e)
            {
                //TODO 需要更加错误类型返回不同错误信息
                //throw new ApplicationException($"添加错误: {e.Message}");
            }
        }

        public static void DeleteEmoji()
        {
            //张智敏&马草原
            try
            {
                using (var db = new EmojiContext())
                {

                }
            }
            catch (Exception e)
            {
                //TODO 需要更加错误类型返回不同错误信息
                throw new ApplicationException($"删除订单错误!");
            }
        }

        public static void ModifyEmoji()
        {
            //张智敏&马草原
        }

        public static IQueryable<Emoji> AllEmojis(EmojiContext db)
        {
            return db.Emojis;
        }

        public static List<Emoji> SortbyFrequency()
        {
            using (var db = new EmojiContext())
            {
                var query = AllEmojis(db).ToList();
                query.Sort();
                return query;
            }
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
        internal class DbHelperSQL
        {
            internal DataTable GetDataTable(object targetDBCon, string v)
            {
                throw new NotImplementedException();
            }
        }
        //导入表情
        public static void ImportEmojis(String sourcePath, String targetTableName)
        {
            //席诺
            //连接字符串
            string connStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            string sql = string.Format("select * from dbo.StudentInfo");
            DataSet ds = new DataSet();
            using (SqlDataAdapter sda = new SqlDataAdapter(sql, connStr))
            {
                 sda.Fill(ds);
            }
             ds.WriteXml("b.xml");//将读出来的内容写到一个xml文件中
        }
        //导出表情
        public static void ExportEmoji()
        {
            //席诺
            //连接字符串
            string connStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            string sql = string.Format("select * from dbo.StudentInfo");
            DataSet ds = new DataSet();
            using (SqlDataAdapter sda = new SqlDataAdapter(sql, connStr))
            {
                sda.Fill(ds);
            }
            ds.WriteXml("b.xml");//将读出来的内容写到一个xml文件中
        }

    }
}

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
                    string str = System.Environment.CurrentDirectory;
                    string targetPath = @"str" + filename;
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

        /// <summary>
        /// 修改IsFavorite，参数i为0改为true，参数i为1改为false
        /// 蒋沁月
        /// </summary>
        public static void ModifyIsFavorite(Emoji e, int i)
        {
            using (var db = new EmojiContext())
            {
                var query = db.Emojis.Where(o => o.Id == e.Id);
                foreach(Emoji ee in query)
                {
                    if (i == 0)
                    {
                        ee.IsFavorite = true;
                    }else if (i == 1)
                    {
                        ee.IsFavorite = false;
                    }
                    
                }
                db.SaveChanges();
            }
        }

        //Frequency++ 蒋沁月
        public static void FrequencyPlus(Emoji e)
        {
            using (var db = new EmojiContext())
            {
                var query = db.Emojis.Where(o => o.Id == e.Id);
                foreach (Emoji ee in query)
                {
                    ee.Frequency++;
                }
                db.SaveChanges();
            }

        }


        //通过路径判断数据库中是否存在当前表情。
        public static bool Emojiexist(string path)
        {
            using (var db = new EmojiContext())
            {
                var queary = db.Emojis.Where(o => o.Path == path);
                if (queary == null)
                    return false;//不存在返回false
                else
                    return true;
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

        //因为要用所以我先写了 蒋沁月
        public static void ModifyEmoji(Emoji e,string key,string target,string series)
        {
            using (var db = new EmojiContext())
            {
                var query = db.Emojis.Where(o => o.Id == e.Id);
                foreach(Emoji ee in query)
                {
                    ee.Keyword = key;
                    ee.TargetPeople = target;
                    ee.Series = series;
                }
                db.SaveChanges();
            }

        }

        public static IQueryable<Emoji> AllEmojis(EmojiContext db)
        {
            return db.Emojis;
        }

        public static List<Emoji> GetAllEmojis()
        {
            using (var db = new EmojiContext())
            {
                var query = AllEmojis(db).ToList();
                return query;
            }
        }
        //返回数据库中为收藏的表情
        public static List<Emoji> FavoriteEmoji()
        {
            using (var db = new EmojiContext())
            {
                var query = AllEmojis(db).Where(emo => emo.IsFavorite == true);
                return query.ToList();
            }
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
            string sqlconn = System.Configuration.ConfigurationManager.ConnectionStrings["Strsqlconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();
            using (XmlTextReader xmlReader = new XmlTextReader(sourcePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(XmlReader.Create(sourcePath));//把数据读到DataSet这个过程有点慢，取决于XML文件大小
                using (SqlBulkCopy bcp = new SqlBulkCopy(conn))
                {
                    bcp.BatchSize = ds.Tables[0].Rows.Count;
                    bcp.DestinationTableName = targetTableName;
                    StringBuilder sbSQL = new StringBuilder();
                    sbSQL.AppendFormat("select Id * from {0}", targetTableName);
                    DbHelperSQL dbHelper = new DbHelperSQL();//自定义数据库操作类
                    DataTable dt = dbHelper.GetDataTable(conn, sbSQL.ToString());
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                        {
                            if (dt.Columns[i].ColumnName == ds.Tables[0].Columns[j].ColumnName)
                                bcp.ColumnMappings.Add(ds.Tables[0].Columns[j].ColumnName, dt.Columns[i].ColumnName);
                        }
                    }
                    bcp.WriteToServer(ds.Tables[0]);
                }
            }
        }
        //导出表情
        public static void ExportEmoji()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            string sql = string.Format("select * from db.Emojis");
            //我们创建的xml文件的根节点是emoji,节点属性是标签,属性值是label
            XDocument doc = new XDocument(new XElement("Emojis", new XAttribute("编号", "Id")));

            XElement root = doc.Root;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            while (Reader.Read())
                            {

                                int filedCount = Reader.FieldCount;
                                //从根节点下创建元素XElement对象，即展示在页面上就是创建元素，该元素的属性有StuId,值为Reader[0]中的值。                                  //创建的该元素的子元素为ClassId,文本值为Reader[1]的值
                                XElement ele = new XElement("Emoji", new XAttribute("label", Reader[0]), new XElement("path", Reader[1]));
                                doc.Root.Add(ele);

                            }
                        }
                    }
                }
                doc.Save("a.xml");//将所创建的一系列节点保存在a.xml文件中
            }
        }
    }
}
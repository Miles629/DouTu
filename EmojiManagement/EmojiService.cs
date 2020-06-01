using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
                    //string picPath = emoji.Path;//这里记得传入图片的路径,通过可视化操作选中图片传参，参数记得改一下奥席诺同学
                    //string filename = Path.GetFileName(picPath);
                    ////string str = System.Environment.CurrentDirectory;
                    //string str3 = Directory.GetCurrentDirectory();
                    //string targetPath;//= "str3//picture" + filename;
                    //if (Directory.Exists("str3\\" + "picture"))
                    //{
                    //    targetPath = "str3//picture";
                    //}
                    //else
                    //{
                    //    Directory.CreateDirectory("str3\\" + "picture");
                    //    targetPath = "str3//picture";
                    //}
                    //CopyDirectory(picPath, targetPath);
                    //emoji.Path = targetPath + filename;
                    db.Emojis.Add(emoji);
                    db.SaveChanges();
                }
            }
            catch (Exception e) { throw new ApplicationException($"错误!"); }
        }
        public static void CopyDirectory(string srcPath, string destPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //获取目录下（不包含子目录）的文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)     //判断是否文件夹
                    {
                        if (!Directory.Exists(destPath + "\\" + i.Name))
                        {
                            Directory.CreateDirectory(destPath + "\\" + i.Name);   //目标目录下不存在此文件夹即创建子文件夹
                        }
                        CopyDirectory(i.FullName, destPath + "\\" + i.Name);    //递归调用复制子文件夹
                    }
                    else
                    {
                        File.Copy(i.FullName, destPath + "\\" + i.Name, true);      //不是文件夹即复制文件，true表示可以覆盖同名文件
                    }
                }
            }
            catch (Exception e)
            {
                throw;
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
                foreach (Emoji ee in query)
                {
                    if (i == 0)
                    {
                        ee.IsFavorite = true;
                    }
                    else if (i == 1)
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


        //通过路径判断数据库中是否存在当前表情。马草原
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
        public static void DeleteNull()
        {
            using (var db = new EmojiContext())
            {

                var query = db.Emojis.Where(o => o.Id == null);
                foreach (Emoji e in query)
                {
                    db.Emojis.Remove(e);
                }
                db.SaveChanges();
            }
        }

        public static void DeleteEmoji(Emoji emoji)
        {
            //张智敏&马草原
            try
            {
                using (var db = new EmojiContext())
                {

                    var query = db.Emojis.Where(o => o.Id == emoji.Id);
                    foreach (Emoji e in query)
                    {
                        db.Emojis.Remove(e);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                //TODO 需要更加错误类型返回不同错误信息
                throw new ApplicationException($"删除订单错误!");
            }
        }


        //因为要用所以我先写了 蒋沁月
        public static void ModifyEmoji(Emoji e, string key, string target, string series)
        {
            using (var db = new EmojiContext())
            {
                var query = db.Emojis.Where(o => o.Id == e.Id);
                foreach (Emoji ee in query)
                {
                    ee.Keyword = key;
                    ee.TargetPeople = target;
                    ee.Series = series;
                }
                db.SaveChanges();
            }

        }
        //返回所有表情 马草原
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
        //返回数据库中为收藏的表情 马草原
        public static List<Emoji> FavoriteEmoji()
        {
            using (var db = new EmojiContext())
            {
                var query = AllEmojis(db).Where(emo => emo.IsFavorite == true);
                return query.ToList();
            }
        }

        //根据表情热度进行排序的结果 马草原
        public static List<Emoji> SortbyFrequency()
        {
            using (var db = new EmojiContext())
            {
                var query = AllEmojis(db).ToList();
                query.Sort();
                return query;
            }
        }


        //这个是一个综合的搜索
        public static List<Emoji> SearchEmoji(string info)
        {
            //张智敏&马草原
            using (var db = new EmojiContext())
            {
                var query1 = AllEmojis(db)
                  .Where(e => e.Keyword == info);
                var query2 = AllEmojis(db)
                  .Where(e => e.Series == info);
                var query3 = AllEmojis(db)
                  .Where(e => e.TargetPeople == info);
                var query = query1.Concat(query2);
                query = query.Concat(query3);
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
            using (SqlConnection con = new SqlConnection("Server=.;DataBase=EmojiDatabase;uid=root;pwd=root"))
            {
                con.Open();
                SqlCommand command = new SqlCommand("select * from Emojis", con);
                command.CommandType = CommandType.Text;
                DataSet ds = new DataSet("DATASET");
                //DATASET将成为XML文件中的根节点名称，否则系统将其命名为NewDataSet       
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                sda.Fill(ds, "DATATABLE");
                //DATATABLE为所生成XML文件中的子节点名称，否则系统将其命名为Table。    
                ds.WriteXml("dbxml.xml");
                // DataSet的方法WriteXml将数据写入到XML文件，就是这么一句话。如果不保存到文件，直接ds.GetXML()       
            }
        }
    }
}
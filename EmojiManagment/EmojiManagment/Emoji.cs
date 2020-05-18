using System;
using System.Collections.Generic;
using System.Text;

namespace EmojiManagment
{
    //表情类
    class Emoji
    {
        public string Id { set; get; }
        public string Path { set; get; }    //图片路径
        public string Keyword { set; get; }    //关键词
        public string Series { set; get; }      //图片所属系列
        public string TargetPeople { set; get; }    //目标人群
        public string Frequency { get; }    //使用频率

        public Emoji() {}

        public Emoji(string path, string keyword, string series, string targetpeople)
        {
            Path = path;
            Keyword = keyword;
            Series = series;
            TargetPeople = targetpeople;
        }

        //判断文件类型，看到了现成的我就直接copy过来了
        public bool IsImage(string path)
        { // *.BMP;*.JPG;*.GIF;*.jpeg;*.ico
            string ext = System.IO.Path.GetExtension(path).ToUpper();
            if (ext == ".BMP" || ext == ".JPG" || ext == ".GIF"
                 || ext == ".JPEG" || ext == ".ICO")
            {
                return true;//该文件是图像类型
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Id;
        }




    }
}

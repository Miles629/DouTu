using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EmojiManagement
{
    class EmojiContext:DbContext
    {
        public EmojiContext() : base("EmojiDatabase")
        {
            Database.SetInitializer(
            new DropCreateDatabaseIfModelChanges<EmojiContext>());
        }

        public DbSet<Emoji> Emojis { set; get; }
        public DbSet<Favorite> Favorates { set; get; }
    }
}

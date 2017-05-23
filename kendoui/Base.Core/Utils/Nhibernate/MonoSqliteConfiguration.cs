//https://github.com/MrSpiffy/MonoSqliteConfiguration/blob/master/MonoSqliteConfiguration.cs
//http://stackoverflow.com/questions/7626251/using-nhibernate-and-mono-data-sqlite
//http://stackoverflow.com/questions/6203597/trying-to-using-nhibernate-with-mono-sqlite-cant-find-system-data-sqlite
//http://blog.miraclespain.com/archive/2009/Aug-26.html

using NHibernate.Dialect;
using NHibernate.Driver;

namespace FluentNHibernate.Cfg.Db
{
    public class MonoSqliteConfiguration : PersistenceConfiguration<MonoSqliteConfiguration>
    {
        public static MonoSqliteConfiguration Standard
        {
            get { return new MonoSqliteConfiguration(); }
        }

        public MonoSqliteConfiguration()
        {
            Driver<MonoSqliteDriver>();
            Dialect<SQLiteDialect>();
            Raw("query.substitutions", "true=1;false=0");
        }

        public MonoSqliteConfiguration InMemory()
        {
            Raw("connection.release_mode", "on_close");
            return ConnectionString(c => c
                .Is("Data Source=:memory:;Version=3;New=True;"));

        }

        public MonoSqliteConfiguration UsingFile(string fileName)
        {
            return ConnectionString(c => c
                .Is(string.Format("Data Source={0};Version=3;New=True;", fileName)));
        }

        public MonoSqliteConfiguration UsingFileWithPassword(string fileName, string password)
        {
            return ConnectionString(c => c
                .Is(string.Format("Data Source={0};Version=3;New=True;Password={1};", fileName, password)));
        }
    }
}


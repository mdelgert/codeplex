//https://github.com/MrSpiffy/MonoSqliteConfiguration/blob/master/MonoSqliteConfiguration.cs
//http://stackoverflow.com/questions/7626251/using-nhibernate-and-mono-data-sqlite
//http://stackoverflow.com/questions/6203597/trying-to-using-nhibernate-with-mono-sqlite-cant-find-system-data-sqlite
//http://blog.miraclespain.com/archive/2009/Aug-26.html

namespace NHibernate.Driver
{
    //public class MonoSqliteDriver : ReflectionBasedDriver
    public class MonoSqliteDriver : NHibernate.Driver.ReflectionBasedDriver
    {
        public MonoSqliteDriver()
            : base("Mono.Data.Sqlite",
            "Mono.Data.Sqlite",
            "Mono.Data.Sqlite.SqliteConnection",
            "Mono.Data.Sqlite.SqliteCommand")
        {
        }

        public override bool UseNamedPrefixInSql
        {
            get { return true; }
        }

        public override bool UseNamedPrefixInParameter
        {
            get { return true; }
        }

        public override string NamedPrefix
        {
            get { return "@"; }
        }

        public override bool SupportsMultipleOpenReaders
        {
            get
            {
                return false;
            }
        }
    }
}


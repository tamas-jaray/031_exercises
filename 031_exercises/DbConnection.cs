using System;

namespace _031_exercises
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (!String.IsNullOrEmpty(connectionString))
            {
                this.ConnectionString = connectionString;
            }
            else
            {
                throw new InvalidOperationException("Empty string not tolerated");
            }
        }
        public abstract void openDb();
        public abstract void closeDb();
    }
}

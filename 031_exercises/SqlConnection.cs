namespace _031_exercises
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            
        }
        public override void closeDb()
        {
            System.Console.WriteLine("Close DB");
        }

        public override void openDb()
        {
            System.Console.WriteLine("Open DB");
        }
    }
}

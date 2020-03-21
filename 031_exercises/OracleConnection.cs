namespace _031_exercises
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
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

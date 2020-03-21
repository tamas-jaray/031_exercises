using System;

namespace _031_exercises
{
    public class DbCommand
    {
        DbConnection DbConnection;
        string InstructionAgainstDb;
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection != null && !String.IsNullOrEmpty(instruction))
            {
                this.DbConnection = dbConnection;
                this.InstructionAgainstDb = instruction;
            }
            else
            {
                throw new InvalidOperationException("Not valid dbConnection or instruction");
            }
        }
        public void Execute()
        {
            DbConnection.openDb();
            Console.WriteLine("Running the instruction: " + InstructionAgainstDb);
            DbConnection.closeDb();
        }
    }
}

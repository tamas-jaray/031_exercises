using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var DbCommand = new DbCommand(new OracleConnection("asd"), "Refresh DB");
            DbCommand.Execute();
        }
    }
}

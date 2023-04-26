using ExecFile;
using System.Threading.Tasks;
using Wrapper;

namespace Test
{
    public class Exec
    {
        static void Main(string[] args)
        {
            var tets = new ExecWrapper();
            tets.UseWrapperMethod();
        }
    }
}
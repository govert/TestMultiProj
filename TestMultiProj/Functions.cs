using ExcelDna.Integration;

namespace TestMultiProj
{
    public class Functions
    {
        [ExcelFunction(Name = "SayHelloFromFunctions", Description = "Say hello from Functions")]
        public static string SayHelloFromFunctions(string name) => $"Hello, {name} from Functions!";

    }
}

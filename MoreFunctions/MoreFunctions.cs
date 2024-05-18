using ExcelDna.Integration;

namespace MoreFunctions
{
    public class MoreFunctions
    {
        [ExcelFunction(Name = "SayHelloFromMoreFunctions", Description = "Say hello from MoreFunctions")]
        public static object SayHelloFromMoreFunctions(string name) => $"Hello, {name} from MoreFunctions!";
    }
}

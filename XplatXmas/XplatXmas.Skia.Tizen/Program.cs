using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace XplatXmas.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new XplatXmas.App(), args);
            host.Run();
        }
    }
}

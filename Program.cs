using System.Security.Cryptography.X509Certificates;

namespace HotKeyManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ManagerDemo());
        }
    }
}
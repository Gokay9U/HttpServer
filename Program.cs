using System;
using System.Diagnostics;
using System.IO;
using System.Net.Mime;

namespace WebUIShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicationPath = AppDomain.CurrentDomain.BaseDirectory;

            string UIPath = Path.Combine(applicationPath, "WebContent");
            SimpleHttpServer server = new SimpleHttpServer(UIPath, 80);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MessageAppTestFrame.Resources
{
    public static class DriverPaths
    {
        //public static string ChromeDriverPath = @"C:\Users\bogda\source\repos\MessageAppTestFrame\MessageAppTestFrame\Resources\";
        public static string ChromeDriverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "../../../Resources");
    }
}

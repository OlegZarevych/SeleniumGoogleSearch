using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGoogleSearch.Helper
{
    public class Logger
    {
        private static readonly ILog consoleLog = LogManager.GetLogger("ConsoleLoger");
        private static readonly ILog fileLog = LogManager.GetLogger("FileLoger");

        public static ILog ConsoleLog
        {
            get { return consoleLog; }
        }

        public static ILog FileLog  
        {
            get { return fileLog; }
        }
        
        public static void LogInfo(string msg)
        {
            Logger.ConsoleLog.Info(msg);
            Logger.FileLog.Info(msg);
        }

        public static void LogError(string msg)
        {
            Logger.ConsoleLog.Error(msg);
            Logger.FileLog.Error(msg);
        }
    }
}

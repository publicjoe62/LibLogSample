using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;
using MrkSysteme.RapPlugin.Core.Logging;

namespace LibLogSample
{
    class MainClass
    {
        private static readonly MrkSysteme.RapPlugin.Core.Logging.ILog mLogger = LogProvider.For<MainClass>();

        public static void Main(string[] args)
        {
            // configure logger as log4net logger via refelction
            //
            XmlConfigurator.Configure(
                            LogManager.GetRepository(Assembly.GetAssembly(typeof(LogManager))));

            mLogger.Debug("LibLog Sample1 :: start");

            foo.Bar();

            mLogger.Debug("LibLog Sample2 :: end");
        }
    }
}

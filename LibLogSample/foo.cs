using System;
using MrkSysteme.RapPlugin.Core.Logging;

namespace LibLogSample
{
    public class foo
    {
        private static readonly MrkSysteme.RapPlugin.Core.Logging.ILog mLogger = LogProvider.For<MainClass>();

        public foo()
        {

        }

        public static void Bar()
        {
            mLogger.Info("Bar()");
        }
    }
}

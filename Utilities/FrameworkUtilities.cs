using AppiumFramework.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AppiumFramework.Utilities
{
    public class FrameworkUtilities
    {
        public static void Sleep(int miliseconds)
        {
            Thread.Sleep(miliseconds * Settings.ThreadSleepMultiplicator);
        }
    }
}

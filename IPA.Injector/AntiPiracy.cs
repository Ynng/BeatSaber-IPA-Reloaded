using System;
using System.IO;
using IPA.Utilities;
#if NET3
using Net3_Proxy;
using Path = Net3_Proxy.Path;
using File = Net3_Proxy.File;
using Directory = Net3_Proxy.Directory;
#endif

namespace IPA.Injector
{
    internal class AntiPiracy
    {
        public static bool IsInvalid(string path)
        {
            var dataPlugins = Path.Combine(GameVersionEarly.ResolveDataPath(path), "Plugins");

            return false;
        }
    }
}

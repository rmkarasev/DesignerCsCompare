using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace DesignerCsCompare
{
    internal static class AppDataUtils
    {
        public static string GetAppDataDir()
        {
            var appName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            var appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var settingsDir = Path.Combine(appDataDir, appName);
            return settingsDir;
        }

        public static string GetAppDataDir(string subDir)
        {
            ArgumentNullException.ThrowIfNull(subDir);
            
            var appDataDir = GetAppDataDir();

            return Path.Combine(appDataDir, subDir);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace DesignerCsCompare.Settings
{
    public interface IUserSettingsRepository
    {
        UserSettings GetSettings();

        void SaveSettings(UserSettings userSettings);
    }
}

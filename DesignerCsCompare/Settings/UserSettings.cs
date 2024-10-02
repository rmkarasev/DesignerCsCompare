using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

#nullable enable
namespace DesignerCsCompare.Settings
{
    public class UserSettings
    {
        [JsonIgnore]
        public string LeftText { get; set; }
        
        [JsonIgnore]
        public string RightText { get; set; }

        public FormWindowState WindowState { get; set; }

        public Rectangle WindowBounds { get; set; }
    }
}

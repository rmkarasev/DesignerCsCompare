using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace DesignerCsCompare.Processing
{
    internal class LineContext
    {
        public string Text { get; }
        
        public string TrimmedText { get; }

        public bool HasMatch { get; set; }

        public LineContext(string text, string trimmedText)
        {
            Text = text;
            TrimmedText = trimmedText;
        }
    }
}

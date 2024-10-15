using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace DesignerCsCompare.Processing
{
    internal class Processor
    {
        private readonly string[] _leftText;
        private readonly string[] _rightText;

        public Processor(string[] leftText, string[] rightText)
        {
            _leftText = leftText;
            _rightText = rightText;
        }

        public (string[] leftText, string[] rightText) GetDifference()
        {
            var leftLines = new List<LineContext>();
            var rightLines = new List<LineContext>();

            foreach (var s in _leftText)
            {
                var trimmedText = TrimText(s);

                leftLines.Add(new LineContext(s, trimmedText));
            }

            foreach (var s in _rightText)
            {
                var trimmedText = TrimText(s);

                rightLines.Add(new LineContext(s, trimmedText));
            }

            foreach (var leftLine in leftLines)
            {
                if (leftLine.HasMatch)
                    continue;

                if (leftLine.TrimmedText == string.Empty)
                    continue;

                foreach (var rightLine in rightLines)
                {
                    if (rightLine.HasMatch)
                        continue;

                    if (rightLine.TrimmedText == string.Empty)
                        continue;

                    if (leftLine.TrimmedText == rightLine.TrimmedText)
                    {
                        leftLine.HasMatch = true;
                        rightLine.HasMatch = true;
                        break;
                    }
                }
            }

            var leftResult = leftLines.Where(x => !x.HasMatch).Select(x => x.Text).ToArray();
            var rightResult = rightLines.Where(x => !x.HasMatch).Select(x => x.Text).ToArray();
            return (leftResult, rightResult);
        }

        private static string TrimText(string str)
        {
            var trimmedText = str.TrimStart();

            // Rule 1
            // Remove EventHandler type
            // example this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            trimmedText = TrimEventHandlerType(trimmedText, "System.EventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "DevExpress.XtraEditors.Controls.ButtonPressedEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Forms.FilterItemEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Forms.FilterItemValueChangedEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Forms.FilterCustomizeParametersEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Data.FetchOverrideHandler");

            // Rule 2: remove '()' after ISupportInitialize
            if (trimmedText.StartsWith("((System.ComponentModel.ISupportInitialize)(this."))
            {
                var pos = trimmedText.IndexOf("(this.", StringComparison.Ordinal);
                trimmedText = trimmedText.Remove(pos, 1); // ( symbol

                pos = trimmedText.IndexOf(")", pos, StringComparison.Ordinal);
                if (pos > 0)
                    trimmedText = trimmedText.Remove(pos, 1); // ) symbol
            }

            // Rule 3: remove 'this.'
            trimmedText = trimmedText.Replace("this.", "");

            return trimmedText;
        }

        private static string TrimEventHandlerType(string str, string eventHandlerType)
        {
            var pattern = $"new {eventHandlerType}(";

            var pos = str.IndexOf(pattern);
            if (pos > -1)
            {
                str = str.Remove(pos, pattern.Length);

                pos = str.IndexOf(")", pos, StringComparison.Ordinal);
                if (pos > 0)
                    str = str.Remove(pos, 1);
            }

            return str;
        }
    }
}

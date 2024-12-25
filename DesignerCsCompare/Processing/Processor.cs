using DesignerCsCompare.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public ProcessorOptions Options { get; } = new();

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


            if (Options.PostProcessDataColumnDefaultValues)
                PostProcessDataColumnDefaultValues(rightLines);

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
            trimmedText = TrimEventHandlerType(trimmedText, "System.Windows.Forms.KeyEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "DevExpress.XtraEditors.Controls.ButtonPressedEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "DevExpress.XtraEditors.Controls.ChangingEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Forms.FilterItemEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Forms.FilterItemValueChangedEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Forms.FilterCustomizeParametersEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Data.FetchOverrideHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Data.GetFetchSqlEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Data.AfterFetchEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Data.BeforeApplyUpdatesEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Data.AfterApplyUpdatesEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Data.OverrideRecordUpdateSqlEventHandler");
            trimmedText = TrimEventHandlerType(trimmedText, "AestheticSoft.Onyx.Data.TransactionHandler");

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

            // Rule 4: AutoIncrement
            trimmedText = TrimAutoIncrement(trimmedText);

            return trimmedText;
        }

        private static readonly (string Origin, string Replacement)[] AutoIncrementPatterns =
        {
            ("AutoIncrementSeed = ((long)(-1000));", "AutoIncrementSeed = -1000L;"),
            ("AutoIncrementStep = ((long)(-1));", "AutoIncrementStep = -1L;"),
        };

        private static string TrimAutoIncrement(string str)
        {
            foreach (var pattern in AutoIncrementPatterns)
            {
                if (str.EndsWith(pattern.Origin))
                    str = str.Replace(pattern.Origin, pattern.Replacement);
            }

            return str;
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

        private void PostProcessDataColumnDefaultValues(IList<LineContext> lines)
        {
            // dataColumn14.Caption = "Type";
            // dataColumn14.DefaultValue = resources.GetObject("dataColumn14.DefaultValue");
            // dataColumn14.Namespace = "";

            for (var i = lines.Count - 1; i >= 0; i--)
            {
                var line = lines[i];
                if (Regex.IsMatch(line.TrimmedText, @"^dataColumn\d+\.Caption = "))
                {
                    lines.RemoveAt(i);
                    continue;
                }

                if (Regex.IsMatch(line.TrimmedText, @"^dataColumn\d+\.DefaultValue = resources"))
                {
                    lines.RemoveAt(i);
                    continue;
                }

                if (Regex.IsMatch(line.TrimmedText, @"^dataColumn\d+\.Namespace = \""\"";"))
                {
                    lines.RemoveAt(i);
                    continue;
                }
            }
        }
    }
}

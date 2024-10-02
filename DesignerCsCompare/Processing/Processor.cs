using System;
using System.Collections.Generic;
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

        private static string TrimText(string s)
        {
            var trimmedText = s.TrimStart();

            trimmedText = trimmedText.Replace("this.", "");

            return trimmedText;
        }
        
    }
}

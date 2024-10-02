using System.Diagnostics;
using DesignerCsCompare.Processing;

namespace DesignerCsCompare
{
    public partial class Form1 : Form
    {
        private int _runCount = 0;

        public Form1()
        {
            InitializeComponent();

            UpdateToolStrip(_runCount, TimeSpan.Zero);
        }

        private void btnRunCompare_Click(object sender, EventArgs e)
        {
            var sw = Stopwatch.StartNew();
            
            var leftText = txtSourceLeft.Lines;
            var rightText = txtSourceRight.Lines;

            var processor = new Processor(leftText, rightText);
            var (leftResult, rightResult) = processor.GetDifference();

            txtResultLeft.Lines = leftResult;
            txtResultRight.Lines = rightResult;

            UpdateToolStrip(++_runCount, sw.Elapsed);
        }

        private void UpdateToolStrip(int runCount, TimeSpan elapsedTime)
        {
            stripRunCount.Text = $"Run Count: {runCount}";
            stripRunTime.Text = $"Time: {Math.Round(elapsedTime.TotalSeconds, 2):F2} sec";
        }
    }
}

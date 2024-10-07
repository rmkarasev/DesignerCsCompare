using System.Diagnostics;
using DesignerCsCompare.Processing;
using DesignerCsCompare.Properties;
using DesignerCsCompare.Settings;

namespace DesignerCsCompare
{
    public partial class Form1 : Form
    {
        private readonly IUserSettingsRepository _userSettingsRepository;
        private UserSettings _userSettings;
        private int _runCount = 0;

        public Form1(IUserSettingsRepository userSettingsRepository)
        {
            InitializeComponent();

            Icon = Resources.icon;

            Size = new Size(1200, 700);
            StartPosition = FormStartPosition.CenterScreen;

            _userSettingsRepository = userSettingsRepository;

            UpdateToolStrip(_runCount, TimeSpan.Zero);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _userSettings = _userSettingsRepository.GetSettings();

            if (_userSettings.WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (_userSettings.WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Normal;

                var bounds = _userSettings.WindowBounds;
                if (bounds.Left >= 0 && bounds.Width > 20 && bounds.Width <= Screen.PrimaryScreen.WorkingArea.Width)
                    Bounds = bounds;
            }

            txtSourceLeft.Text = _userSettings.LeftText;
            txtSourceRight.Text = _userSettings.RightText;
            txtResultLeft.Text = "Run Compare to get difference";
            txtResultRight.Text = "Run Compare to get difference";

            txtBComp.Text = _userSettings.BeyondComparePath;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            _userSettings.WindowState = WindowState;
            _userSettings.WindowBounds = Bounds;
            _userSettings.LeftText = txtSourceLeft.Text;
            _userSettings.RightText = txtSourceRight.Text;
            _userSettings.BeyondComparePath = txtBComp.Text;
            _userSettingsRepository.SaveSettings(_userSettings);
        }

        private void btnRunCompare_Click(object sender, EventArgs e)
        {
            RunCompare();
        }

        private void btnRunCompareFromSource_Click(object sender, EventArgs e)
        {
            tcMain.SelectTab(tabCompare);
            RunCompare();
        }

        private void RunCompare()
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

        private void btnBComp_Click(object sender, EventArgs e)
        {
            using (var f = new OpenFileDialog())
            {
                if (!string.IsNullOrEmpty(txtBComp.Text))
                    f.FileName = txtBComp.Text;

                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    txtBComp.Text = f.FileName;

                    _userSettings.BeyondComparePath = txtBComp.Text;
                    _userSettingsRepository.SaveSettings(_userSettings);
                }
            }
        }

        private void btnSendToBComp_Click(object sender, EventArgs e)
        {
            var bCompPath = _userSettings.BeyondComparePath;

            if (string.IsNullOrEmpty(bCompPath))
            {
                MessageBox.Show("BComp path is not specified.");
                return;
            }

            if (!File.Exists(bCompPath))
            {
                MessageBox.Show($"BComp path is missing or invalid. Path: {bCompPath}");
                return;
            }

            var tempDir = AppDataUtils.GetAppDataDir("Temp");
            if (!Directory.Exists(tempDir))
                Directory.CreateDirectory(tempDir);

            var leftPath = Path.Combine(tempDir, $"leftResult-{DateTime.Now:yyyy-MM-dd_HH-mm-ss-fff}");
            var rightPath = Path.Combine(tempDir, $"rightResult-{DateTime.Now:yyyy-MM-dd_HH-mm-ss-fff}");

            File.WriteAllText(leftPath, txtResultLeft.Text ?? "");
            File.WriteAllText(rightPath, txtResultRight.Text ?? "");

            var startInfo = new ProcessStartInfo();
            startInfo.FileName = bCompPath;
            startInfo.Arguments = $"\"{leftPath}\" \"{rightPath}\"";
            Process.Start(startInfo);
        }

        private void btnClearBoth_Click(object sender, EventArgs e)
        {
            txtSourceLeft.Text = "";
            txtSourceRight.Text = "";
        }
    }
}

namespace DesignerCsCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            txtSourceLeft = new TextBox();
            txtSourceRight = new TextBox();
            tcMain = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            chkPostProcessDataColumnDefaultValues = new CheckBox();
            btnRunCompareFromSource = new Button();
            btnClearBoth = new Button();
            tabCompare = new TabPage();
            splitContainer2 = new SplitContainer();
            txtResultLeft = new TextBox();
            txtResultRight = new TextBox();
            toolStrip1 = new ToolStrip();
            stripRunCount = new ToolStripLabel();
            stripRunTime = new ToolStripLabel();
            groupBox1 = new GroupBox();
            btnSendToBComp = new Button();
            btnRunCompare = new Button();
            tabPage3 = new TabPage();
            btnBComp = new Button();
            txtBComp = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tcMain.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 72);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtSourceLeft);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtSourceRight);
            splitContainer1.Size = new Size(1091, 542);
            splitContainer1.SplitterDistance = 363;
            splitContainer1.TabIndex = 0;
            // 
            // txtSourceLeft
            // 
            txtSourceLeft.Dock = DockStyle.Fill;
            txtSourceLeft.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourceLeft.Location = new Point(0, 0);
            txtSourceLeft.MaxLength = 0;
            txtSourceLeft.Multiline = true;
            txtSourceLeft.Name = "txtSourceLeft";
            txtSourceLeft.ScrollBars = ScrollBars.Both;
            txtSourceLeft.Size = new Size(363, 542);
            txtSourceLeft.TabIndex = 0;
            txtSourceLeft.Text = resources.GetString("txtSourceLeft.Text");
            txtSourceLeft.WordWrap = false;
            // 
            // txtSourceRight
            // 
            txtSourceRight.Dock = DockStyle.Fill;
            txtSourceRight.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourceRight.Location = new Point(0, 0);
            txtSourceRight.MaxLength = 0;
            txtSourceRight.Multiline = true;
            txtSourceRight.Name = "txtSourceRight";
            txtSourceRight.ScrollBars = ScrollBars.Both;
            txtSourceRight.Size = new Size(724, 542);
            txtSourceRight.TabIndex = 1;
            txtSourceRight.Text = resources.GetString("txtSourceRight.Text");
            txtSourceRight.WordWrap = false;
            // 
            // tcMain
            // 
            tcMain.Appearance = TabAppearance.Buttons;
            tcMain.Controls.Add(tabPage1);
            tcMain.Controls.Add(tabCompare);
            tcMain.Controls.Add(tabPage3);
            tcMain.Dock = DockStyle.Fill;
            tcMain.ItemSize = new Size(100, 28);
            tcMain.Location = new Point(0, 3);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(1105, 653);
            tcMain.SizeMode = TabSizeMode.Fixed;
            tcMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1097, 617);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Source Text";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(chkPostProcessDataColumnDefaultValues);
            groupBox2.Controls.Add(btnRunCompareFromSource);
            groupBox2.Controls.Add(btnClearBoth);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1091, 69);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control Panel";
            // 
            // chkPostProcessDataColumnDefaultValues
            // 
            chkPostProcessDataColumnDefaultValues.AutoSize = true;
            chkPostProcessDataColumnDefaultValues.Location = new Point(280, 26);
            chkPostProcessDataColumnDefaultValues.Name = "chkPostProcessDataColumnDefaultValues";
            chkPostProcessDataColumnDefaultValues.Size = new Size(286, 19);
            chkPostProcessDataColumnDefaultValues.TabIndex = 3;
            chkPostProcessDataColumnDefaultValues.Text = "Post-process: remove DataColumn default values";
            chkPostProcessDataColumnDefaultValues.UseVisualStyleBackColor = true;
            chkPostProcessDataColumnDefaultValues.CheckedChanged += chkPostProcessDataColumnDefaultValues_CheckedChanged;
            // 
            // btnRunCompareFromSource
            // 
            btnRunCompareFromSource.Location = new Point(142, 22);
            btnRunCompareFromSource.Name = "btnRunCompareFromSource";
            btnRunCompareFromSource.Size = new Size(100, 25);
            btnRunCompareFromSource.TabIndex = 3;
            btnRunCompareFromSource.Text = "Run Compare";
            btnRunCompareFromSource.UseVisualStyleBackColor = true;
            btnRunCompareFromSource.Click += btnRunCompareFromSource_Click;
            // 
            // btnClearBoth
            // 
            btnClearBoth.Location = new Point(6, 22);
            btnClearBoth.Name = "btnClearBoth";
            btnClearBoth.Size = new Size(100, 25);
            btnClearBoth.TabIndex = 2;
            btnClearBoth.Text = "Clear Both";
            btnClearBoth.UseVisualStyleBackColor = true;
            btnClearBoth.Click += btnClearBoth_Click;
            // 
            // tabCompare
            // 
            tabCompare.Controls.Add(splitContainer2);
            tabCompare.Controls.Add(toolStrip1);
            tabCompare.Controls.Add(groupBox1);
            tabCompare.Location = new Point(4, 32);
            tabCompare.Name = "tabCompare";
            tabCompare.Padding = new Padding(3);
            tabCompare.Size = new Size(1097, 617);
            tabCompare.TabIndex = 1;
            tabCompare.Text = "Compare";
            tabCompare.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 70);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(txtResultLeft);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtResultRight);
            splitContainer2.Size = new Size(1091, 519);
            splitContainer2.SplitterDistance = 363;
            splitContainer2.TabIndex = 1;
            // 
            // txtResultLeft
            // 
            txtResultLeft.Dock = DockStyle.Fill;
            txtResultLeft.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultLeft.Location = new Point(0, 0);
            txtResultLeft.MaxLength = 0;
            txtResultLeft.Multiline = true;
            txtResultLeft.Name = "txtResultLeft";
            txtResultLeft.ScrollBars = ScrollBars.Both;
            txtResultLeft.Size = new Size(363, 519);
            txtResultLeft.TabIndex = 0;
            txtResultLeft.Text = resources.GetString("txtResultLeft.Text");
            txtResultLeft.WordWrap = false;
            // 
            // txtResultRight
            // 
            txtResultRight.Dock = DockStyle.Fill;
            txtResultRight.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultRight.Location = new Point(0, 0);
            txtResultRight.MaxLength = 0;
            txtResultRight.Multiline = true;
            txtResultRight.Name = "txtResultRight";
            txtResultRight.ScrollBars = ScrollBars.Both;
            txtResultRight.Size = new Size(724, 519);
            txtResultRight.TabIndex = 1;
            txtResultRight.Text = resources.GetString("txtResultRight.Text");
            txtResultRight.WordWrap = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { stripRunCount, stripRunTime });
            toolStrip1.Location = new Point(3, 589);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(1091, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // stripRunCount
            // 
            stripRunCount.AutoSize = false;
            stripRunCount.Name = "stripRunCount";
            stripRunCount.Size = new Size(100, 22);
            stripRunCount.Text = "Run Count:";
            stripRunCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stripRunTime
            // 
            stripRunTime.AutoSize = false;
            stripRunTime.Name = "stripRunTime";
            stripRunTime.Size = new Size(100, 22);
            stripRunTime.Text = "Time:";
            stripRunTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(btnSendToBComp);
            groupBox1.Controls.Add(btnRunCompare);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1091, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control Panel";
            // 
            // btnSendToBComp
            // 
            btnSendToBComp.Location = new Point(183, 22);
            btnSendToBComp.Name = "btnSendToBComp";
            btnSendToBComp.Size = new Size(180, 23);
            btnSendToBComp.TabIndex = 4;
            btnSendToBComp.Text = "Compare result in BComp";
            btnSendToBComp.UseVisualStyleBackColor = true;
            btnSendToBComp.Click += btnSendToBComp_Click;
            // 
            // btnRunCompare
            // 
            btnRunCompare.Location = new Point(6, 22);
            btnRunCompare.Name = "btnRunCompare";
            btnRunCompare.Size = new Size(100, 23);
            btnRunCompare.TabIndex = 2;
            btnRunCompare.Text = "Run Compare";
            btnRunCompare.UseVisualStyleBackColor = true;
            btnRunCompare.Click += btnRunCompare_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnBComp);
            tabPage3.Controls.Add(txtBComp);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1097, 617);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBComp
            // 
            btnBComp.Location = new Point(501, 28);
            btnBComp.Name = "btnBComp";
            btnBComp.Size = new Size(75, 28);
            btnBComp.TabIndex = 2;
            btnBComp.Text = "Browse";
            btnBComp.UseVisualStyleBackColor = true;
            btnBComp.Click += btnBComp_Click;
            // 
            // txtBComp
            // 
            txtBComp.Location = new Point(8, 31);
            txtBComp.Name = "txtBComp";
            txtBComp.ReadOnly = true;
            txtBComp.Size = new Size(487, 23);
            txtBComp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(198, 15);
            label1.TabIndex = 0;
            label1.Text = "Beyond Compare - BComp.exe path";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 3);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 656);
            Controls.Add(tcMain);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Designer.cs Compare";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tcMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabCompare.ResumeLayout(false);
            tabCompare.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtSourceLeft;
        private TabControl tcMain;
        private TabPage tabPage1;
        private TabPage tabCompare;
        private TabPage tabPage3;
        private TextBox txtSourceRight;
        private SplitContainer splitContainer2;
        private TextBox txtResultLeft;
        private TextBox txtResultRight;
        private GroupBox groupBox1;
        private Button btnRunCompare;
        private ToolStrip toolStrip1;
        private ToolStripLabel stripRunCount;
        private ToolStripLabel stripRunTime;
        private Panel panel1;
        private TextBox txtBComp;
        private Label label1;
        private Button btnBComp;
        private Button btnSendToBComp;
        private Button btnClearBoth;
        private GroupBox groupBox2;
        private Button btnRunCompareFromSource;
        private CheckBox chkPostProcessDataColumnDefaultValues;
    }
}

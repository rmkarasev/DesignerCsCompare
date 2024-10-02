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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            txtResultLeft = new TextBox();
            txtResultRight = new TextBox();
            toolStrip1 = new ToolStrip();
            stripRunCount = new ToolStripLabel();
            stripRunTime = new ToolStripLabel();
            groupBox1 = new GroupBox();
            btnRunCompare = new Button();
            tabPage3 = new TabPage();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtSourceLeft);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtSourceRight);
            splitContainer1.Size = new Size(1091, 616);
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
            txtSourceLeft.Size = new Size(363, 616);
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
            txtSourceRight.Size = new Size(724, 616);
            txtSourceRight.TabIndex = 1;
            txtSourceRight.Text = resources.GetString("txtSourceRight.Text");
            txtSourceRight.WordWrap = false;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(100, 23);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1105, 653);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1097, 622);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Source Text";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Controls.Add(toolStrip1);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1097, 622);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Compare";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 138);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(txtResultLeft);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtResultRight);
            splitContainer2.Size = new Size(1091, 456);
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
            txtResultLeft.Size = new Size(363, 456);
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
            txtResultRight.Size = new Size(724, 456);
            txtResultRight.TabIndex = 1;
            txtResultRight.Text = resources.GetString("txtResultRight.Text");
            txtResultRight.WordWrap = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { stripRunCount, stripRunTime });
            toolStrip1.Location = new Point(3, 594);
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
            groupBox1.Controls.Add(btnRunCompare);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1091, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control Panel";
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
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1097, 622);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
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
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Designer.cs Compare";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtSourceLeft;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
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
    }
}

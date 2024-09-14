namespace HotKeyManager
{
    partial class ManagerDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GroupBox groupBox1;
            Label label1;
            GroupBox groupBox2;
            Label label2;
            GroupBox groupBox3;
            Label label3;
            ToolStrip toolStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDemo));
            Hotkey1Test = new Button();
            Hotkey1TestSquare = new Panel();
            AddBlock5 = new Panel();
            AddBlock4 = new Panel();
            AddBlock3 = new Panel();
            AddBlock2 = new Panel();
            Hotkey3Test = new Button();
            Hotkey2Test = new Button();
            AddBlock1 = new Panel();
            Hotkey4Test = new Button();
            panel3 = new Panel();
            RandomNumber = new Label();
            label4 = new Label();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            CurrentHotkey = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            ResetDisplayTimer = new System.Windows.Forms.Timer(components);
            toolStripSeparator3 = new ToolStripSeparator();
            CurrentInput = new ToolStripLabel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label3 = new Label();
            toolStrip1 = new ToolStrip();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Hotkey1Test);
            groupBox1.Controls.Add(Hotkey1TestSquare);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 82);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "快速鍵一";
            // 
            // Hotkey1Test
            // 
            Hotkey1Test.Location = new Point(222, 37);
            Hotkey1Test.Name = "Hotkey1Test";
            Hotkey1Test.Size = new Size(75, 23);
            Hotkey1Test.TabIndex = 2;
            Hotkey1Test.Text = "快速鍵一";
            Hotkey1Test.UseVisualStyleBackColor = true;
            Hotkey1Test.Click += Hotkey1Test_Click;
            // 
            // Hotkey1TestSquare
            // 
            Hotkey1TestSquare.BackColor = SystemColors.ActiveCaption;
            Hotkey1TestSquare.BorderStyle = BorderStyle.FixedSingle;
            Hotkey1TestSquare.Location = new Point(9, 43);
            Hotkey1TestSquare.Name = "Hotkey1TestSquare";
            Hotkey1TestSquare.Size = new Size(26, 23);
            Hotkey1TestSquare.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 0;
            label1.Text = "可讓下方的Panel隨機變換顏色";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AddBlock5);
            groupBox2.Controls.Add(AddBlock4);
            groupBox2.Controls.Add(AddBlock3);
            groupBox2.Controls.Add(AddBlock2);
            groupBox2.Controls.Add(Hotkey3Test);
            groupBox2.Controls.Add(Hotkey2Test);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(AddBlock1);
            groupBox2.Location = new Point(31, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 81);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "快速鍵二、三";
            // 
            // AddBlock5
            // 
            AddBlock5.BackColor = SystemColors.Highlight;
            AddBlock5.BorderStyle = BorderStyle.Fixed3D;
            AddBlock5.Location = new Point(131, 42);
            AddBlock5.Name = "AddBlock5";
            AddBlock5.Size = new Size(24, 24);
            AddBlock5.TabIndex = 3;
            AddBlock5.Visible = false;
            // 
            // AddBlock4
            // 
            AddBlock4.BackColor = SystemColors.Highlight;
            AddBlock4.BorderStyle = BorderStyle.Fixed3D;
            AddBlock4.Location = new Point(101, 42);
            AddBlock4.Name = "AddBlock4";
            AddBlock4.Size = new Size(24, 24);
            AddBlock4.TabIndex = 3;
            AddBlock4.Visible = false;
            // 
            // AddBlock3
            // 
            AddBlock3.BackColor = SystemColors.Highlight;
            AddBlock3.BorderStyle = BorderStyle.Fixed3D;
            AddBlock3.Location = new Point(71, 42);
            AddBlock3.Name = "AddBlock3";
            AddBlock3.Size = new Size(24, 24);
            AddBlock3.TabIndex = 2;
            AddBlock3.Visible = false;
            // 
            // AddBlock2
            // 
            AddBlock2.BackColor = SystemColors.Highlight;
            AddBlock2.BorderStyle = BorderStyle.Fixed3D;
            AddBlock2.Location = new Point(41, 42);
            AddBlock2.Name = "AddBlock2";
            AddBlock2.Size = new Size(24, 24);
            AddBlock2.TabIndex = 1;
            AddBlock2.Visible = false;
            // 
            // Hotkey3Test
            // 
            Hotkey3Test.Location = new Point(303, 44);
            Hotkey3Test.Name = "Hotkey3Test";
            Hotkey3Test.Size = new Size(75, 23);
            Hotkey3Test.TabIndex = 4;
            Hotkey3Test.Text = "快速鍵三";
            Hotkey3Test.UseVisualStyleBackColor = true;
            Hotkey3Test.Click += Hotkey3Test_Click;
            // 
            // Hotkey2Test
            // 
            Hotkey2Test.Location = new Point(222, 43);
            Hotkey2Test.Name = "Hotkey2Test";
            Hotkey2Test.Size = new Size(75, 23);
            Hotkey2Test.TabIndex = 3;
            Hotkey2Test.Text = "快速鍵二";
            Hotkey2Test.UseVisualStyleBackColor = true;
            Hotkey2Test.Click += Hotkey2Test_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(194, 15);
            label2.TabIndex = 3;
            label2.Text = "減少或增加下方的方塊數量。(0~5)";
            // 
            // AddBlock1
            // 
            AddBlock1.BackColor = SystemColors.Highlight;
            AddBlock1.BorderStyle = BorderStyle.Fixed3D;
            AddBlock1.Location = new Point(11, 43);
            AddBlock1.Name = "AddBlock1";
            AddBlock1.Size = new Size(24, 24);
            AddBlock1.TabIndex = 0;
            AddBlock1.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Hotkey4Test);
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(31, 222);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(397, 86);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "快速鍵四";
            // 
            // Hotkey4Test
            // 
            Hotkey4Test.Location = new Point(222, 44);
            Hotkey4Test.Name = "Hotkey4Test";
            Hotkey4Test.Size = new Size(75, 23);
            Hotkey4Test.TabIndex = 5;
            Hotkey4Test.Text = "快速鍵四";
            Hotkey4Test.UseVisualStyleBackColor = true;
            Hotkey4Test.Click += Hotkey4Test_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 255, 128);
            panel3.Controls.Add(RandomNumber);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(6, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 25);
            panel3.TabIndex = 5;
            // 
            // RandomNumber
            // 
            RandomNumber.AutoSize = true;
            RandomNumber.BackColor = Color.White;
            RandomNumber.Location = new Point(64, 6);
            RandomNumber.MinimumSize = new Size(120, 0);
            RandomNumber.Name = "RandomNumber";
            RandomNumber.Size = new Size(120, 15);
            RandomNumber.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 5;
            label4.Text = "隨機數字";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(187, 15);
            label3.TabIndex = 3;
            label3.Text = "產生一個隨機數字並顯示在下方。";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripLabel1, CurrentHotkey, toolStripSeparator2, CurrentInput, toolStripSeparator3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(457, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "Functinos";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(71, 22);
            toolStripButton1.Text = "管理快速鍵";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(147, 22);
            toolStripLabel1.Text = "HotkeyManager測試視窗";
            // 
            // CurrentHotkey
            // 
            CurrentHotkey.ForeColor = Color.Fuchsia;
            CurrentHotkey.Name = "CurrentHotkey";
            CurrentHotkey.Size = new Size(43, 22);
            CurrentHotkey.Text = "快速鍵";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // ResetDisplayTimer
            // 
            ResetDisplayTimer.Enabled = true;
            ResetDisplayTimer.Tick += ResetHotkeyDisplay;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // CurrentInput
            // 
            CurrentInput.ForeColor = Color.Green;
            CurrentInput.Name = "CurrentInput";
            CurrentInput.Size = new Size(55, 22);
            CurrentInput.Text = "當下按鍵";
            // 
            // ManagerDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 326);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            KeyPreview = true;
            Name = "ManagerDemo";
            Text = "ManagerDemo";
            KeyDown += ManagerDemoKeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private GroupBox groupBox1;
        private Label label1;
        private Panel Hotkey1TestSquare;
        private GroupBox groupBox2;
        private Label label2;
        private Panel AddBlock1;
        private GroupBox groupBox3;
        private Label label3;
        private Button Hotkey1Test;
        private Button Hotkey3Test;
        private Button Hotkey2Test;
        private Button Hotkey4Test;
        private Panel panel3;
        private Label label4;
        private Label RandomNumber;
        private Panel AddBlock5;
        private Panel AddBlock4;
        private Panel AddBlock3;
        private Panel AddBlock2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel CurrentHotkey;
        private ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer ResetDisplayTimer;
        private ToolStripLabel CurrentInput;
        private ToolStripSeparator toolStripSeparator3;
    }
}
namespace HotKeyManager
{
    partial class HotKeyManager
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
            HotkeyList = new ListBox();
            SaveHotkeyConfig = new Button();
            LoadHotkeyConfig = new Button();
            UpdateHotkey = new Button();
            TestMode = new Button();
            HotkeyTestPad = new HotkeyPad();
            groupBox1 = new GroupBox();
            HotkeyDescription = new Label();
            LoadConfigFile = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // HotkeyList
            // 
            HotkeyList.FormattingEnabled = true;
            HotkeyList.ItemHeight = 15;
            HotkeyList.Location = new Point(12, 27);
            HotkeyList.Name = "HotkeyList";
            HotkeyList.Size = new Size(172, 259);
            HotkeyList.TabIndex = 3;
            HotkeyList.SelectedIndexChanged += HotkeyList_SelectedIndexChanged;
            // 
            // SaveHotkeyConfig
            // 
            SaveHotkeyConfig.Location = new Point(284, 27);
            SaveHotkeyConfig.Name = "SaveHotkeyConfig";
            SaveHotkeyConfig.Size = new Size(86, 23);
            SaveHotkeyConfig.TabIndex = 8;
            SaveHotkeyConfig.Text = "儲存";
            SaveHotkeyConfig.UseVisualStyleBackColor = true;
            SaveHotkeyConfig.Click += SaveHotkeyConfig_Click;
            // 
            // LoadHotkeyConfig
            // 
            LoadHotkeyConfig.Location = new Point(190, 27);
            LoadHotkeyConfig.Name = "LoadHotkeyConfig";
            LoadHotkeyConfig.Size = new Size(88, 23);
            LoadHotkeyConfig.TabIndex = 9;
            LoadHotkeyConfig.Text = "載入設定";
            LoadHotkeyConfig.UseVisualStyleBackColor = true;
            LoadHotkeyConfig.Click += LoadHotkeyConfig_Click;
            // 
            // UpdateHotkey
            // 
            UpdateHotkey.Location = new Point(190, 61);
            UpdateHotkey.Name = "UpdateHotkey";
            UpdateHotkey.Size = new Size(88, 23);
            UpdateHotkey.TabIndex = 10;
            UpdateHotkey.Text = "更新快速鍵";
            UpdateHotkey.UseVisualStyleBackColor = true;
            UpdateHotkey.Click += SetHotkey_Click;
            // 
            // TestMode
            // 
            TestMode.Location = new Point(284, 61);
            TestMode.Name = "TestMode";
            TestMode.Size = new Size(86, 23);
            TestMode.TabIndex = 11;
            TestMode.Text = "測試模式";
            TestMode.UseVisualStyleBackColor = true;
            TestMode.Click += TestMode_Click;
            // 
            // HotkeyTestPad
            // 
            HotkeyTestPad.Location = new Point(190, 89);
            HotkeyTestPad.Margin = new Padding(0);
            HotkeyTestPad.Name = "HotkeyTestPad";
            HotkeyTestPad.Size = new Size(180, 28);
            HotkeyTestPad.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HotkeyDescription);
            groupBox1.Location = new Point(190, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 153);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "功能";
            // 
            // HotkeyDescription
            // 
            HotkeyDescription.AutoEllipsis = true;
            HotkeyDescription.Location = new Point(12, 20);
            HotkeyDescription.Name = "HotkeyDescription";
            HotkeyDescription.Size = new Size(162, 100);
            HotkeyDescription.TabIndex = 0;
            HotkeyDescription.Text = "HotkeyDescription";
            // 
            // LoadConfigFile
            // 
            LoadConfigFile.FileName = "Hotkeys.xml";
            // 
            // HotKeyManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 299);
            Controls.Add(groupBox1);
            Controls.Add(HotkeyTestPad);
            Controls.Add(TestMode);
            Controls.Add(UpdateHotkey);
            Controls.Add(LoadHotkeyConfig);
            Controls.Add(SaveHotkeyConfig);
            Controls.Add(HotkeyList);
            KeyPreview = true;
            Name = "HotKeyManager";
            Text = "HotKeyManager";
            Shown += HotkeyManagerShown;
            KeyDown += HotkeyDown;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox HotkeyList;
        private HotkeyEditor hotkeyEditor1;
        private Button SaveHotkeyConfig;
        private Button LoadHotkeyConfig;
        private Button UpdateHotkey;
        private Button TestMode;
        private HotkeyPad HotkeyTestPad;
        private GroupBox groupBox1;
        private Label HotkeyDescription;
        private OpenFileDialog LoadConfigFile;
    }
}

namespace HotKeyManager
{
    partial class HotkeyEditor
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            HotkeyCombination = new CheckedListBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // HotkeyCombination
            // 
            HotkeyCombination.FormattingEnabled = true;
            HotkeyCombination.Location = new Point(31, 29);
            HotkeyCombination.Name = "HotkeyCombination";
            HotkeyCombination.Size = new Size(172, 220);
            HotkeyCombination.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HotkeyCombination);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 263);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editor";
            // 
            // HotkeyEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "HotkeyEditor";
            Size = new Size(228, 273);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CheckedListBox HotkeyCombination;
        private GroupBox groupBox1;
    }
}

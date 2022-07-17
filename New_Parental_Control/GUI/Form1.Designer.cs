namespace New_Parental_Control
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.All_App_listBox = new System.Windows.Forms.ListBox();
            this.LockApplistBox = new System.Windows.Forms.ListBox();
            this.UnLockAppListBox = new System.Windows.Forms.ListBox();
            this.TempLockApplistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // All_App_listBox
            // 
            this.All_App_listBox.FormattingEnabled = true;
            this.All_App_listBox.Location = new System.Drawing.Point(12, 23);
            this.All_App_listBox.Name = "All_App_listBox";
            this.All_App_listBox.Size = new System.Drawing.Size(120, 95);
            this.All_App_listBox.TabIndex = 0;
            // 
            // LockApplistBox
            // 
            this.LockApplistBox.FormattingEnabled = true;
            this.LockApplistBox.Location = new System.Drawing.Point(176, 23);
            this.LockApplistBox.Name = "LockApplistBox";
            this.LockApplistBox.Size = new System.Drawing.Size(120, 95);
            this.LockApplistBox.TabIndex = 1;
            // 
            // UnLockAppListBox
            // 
            this.UnLockAppListBox.FormattingEnabled = true;
            this.UnLockAppListBox.Location = new System.Drawing.Point(339, 23);
            this.UnLockAppListBox.Name = "UnLockAppListBox";
            this.UnLockAppListBox.Size = new System.Drawing.Size(120, 95);
            this.UnLockAppListBox.TabIndex = 2;
            // 
            // TempLockApplistBox
            // 
            this.TempLockApplistBox.FormattingEnabled = true;
            this.TempLockApplistBox.Location = new System.Drawing.Point(500, 23);
            this.TempLockApplistBox.Name = "TempLockApplistBox";
            this.TempLockApplistBox.Size = new System.Drawing.Size(120, 95);
            this.TempLockApplistBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TempLockApplistBox);
            this.Controls.Add(this.UnLockAppListBox);
            this.Controls.Add(this.LockApplistBox);
            this.Controls.Add(this.All_App_listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox All_App_listBox;
        private System.Windows.Forms.ListBox LockApplistBox;
        private System.Windows.Forms.ListBox UnLockAppListBox;
        private System.Windows.Forms.ListBox TempLockApplistBox;
        private System.Windows.Forms.Label label1;
    }
}


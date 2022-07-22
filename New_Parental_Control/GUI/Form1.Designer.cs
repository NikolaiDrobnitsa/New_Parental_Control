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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LockToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnlockToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TImeLockToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExapleTImetoolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Check_timer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripButton,
            this.LockToolStripButton,
            this.UnlockToolStripButton,
            this.TImeLockToolStripButton,
            this.ExapleTImetoolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RefreshToolStripButton
            // 
            this.RefreshToolStripButton.Image = global::New_Parental_Control.Properties.Resources.refresh;
            this.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshToolStripButton.Name = "RefreshToolStripButton";
            this.RefreshToolStripButton.Size = new System.Drawing.Size(81, 22);
            this.RefreshToolStripButton.Text = "Обновить";
            // 
            // LockToolStripButton
            // 
            this.LockToolStripButton.Image = global::New_Parental_Control.Properties.Resources._lock;
            this.LockToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LockToolStripButton.Name = "LockToolStripButton";
            this.LockToolStripButton.Size = new System.Drawing.Size(111, 22);
            this.LockToolStripButton.Text = "Заблокировать";
            this.LockToolStripButton.Click += new System.EventHandler(this.LockToolStripButton_Click);
            // 
            // UnlockToolStripButton
            // 
            this.UnlockToolStripButton.Image = global::New_Parental_Control.Properties.Resources.lock_btn1;
            this.UnlockToolStripButton.ImageTransparentColor = System.Drawing.Color.Lime;
            this.UnlockToolStripButton.Name = "UnlockToolStripButton";
            this.UnlockToolStripButton.Size = new System.Drawing.Size(116, 22);
            this.UnlockToolStripButton.Text = "Разблокировать";
            this.UnlockToolStripButton.Click += new System.EventHandler(this.UnlockToolStripButton_Click);
            // 
            // TImeLockToolStripButton
            // 
            this.TImeLockToolStripButton.Image = global::New_Parental_Control.Properties.Resources.time_lock;
            this.TImeLockToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TImeLockToolStripButton.Name = "TImeLockToolStripButton";
            this.TImeLockToolStripButton.Size = new System.Drawing.Size(175, 22);
            this.TImeLockToolStripButton.Text = "Временно разблокировать";
            this.TImeLockToolStripButton.Click += new System.EventHandler(this.TImeLockToolStripButton_Click);
            // 
            // ExapleTImetoolStripComboBox1
            // 
            this.ExapleTImetoolStripComboBox1.Items.AddRange(new object[] {
            "5 мин",
            "10 мин",
            "15 мин",
            "20 мин"});
            this.ExapleTImetoolStripComboBox1.Name = "ExapleTImetoolStripComboBox1";
            this.ExapleTImetoolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Фильтр";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 50);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 400);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название приложения";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Состояние приложения";
            this.columnHeader2.Width = 200;
            // 
            // Check_timer
            // 
            this.Check_timer.Enabled = true;
            this.Check_timer.Tick += new System.EventHandler(this.Check_timer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(437, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 231);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RefreshToolStripButton;
        private System.Windows.Forms.ToolStripButton LockToolStripButton;
        private System.Windows.Forms.ToolStripButton UnlockToolStripButton;
        private System.Windows.Forms.ToolStripButton TImeLockToolStripButton;
        private System.Windows.Forms.ToolStripComboBox ExapleTImetoolStripComboBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer Check_timer;
        private System.Windows.Forms.TextBox textBox1;
    }
}


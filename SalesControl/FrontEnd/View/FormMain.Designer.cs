namespace SalesControl.FrontEnd.View {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cart_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employees_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.products_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.make_backup_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.restore_backup_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.quit_session_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.user_lbl = new System.Windows.Forms.Label();
            this.menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_strip
            // 
            this.menu_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.cartToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu_strip.Size = new System.Drawing.Size(743, 24);
            this.menu_strip.TabIndex = 0;
            this.menu_strip.Text = "menuStrip1";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cart_btn});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.salesToolStripMenuItem.Text = "Продажи";
            // 
            // cart_btn
            // 
            this.cart_btn.Name = "cart_btn";
            this.cart_btn.Size = new System.Drawing.Size(180, 22);
            this.cart_btn.Text = "Новая покупка";
            this.cart_btn.Click += new System.EventHandler(this.CartButtonClickEvent);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employees_btn,
            this.products_btn});
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cartToolStripMenuItem.Text = "Управление";
            // 
            // employees_btn
            // 
            this.employees_btn.Name = "employees_btn";
            this.employees_btn.Size = new System.Drawing.Size(180, 22);
            this.employees_btn.Text = "Сотрудники";
            this.employees_btn.Click += new System.EventHandler(this.EmployeesButtonClickEvent);
            // 
            // products_btn
            // 
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(180, 22);
            this.products_btn.Text = "Товары";
            this.products_btn.Click += new System.EventHandler(this.ProductsButtonClickEvent);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.make_backup_btn,
            this.restore_backup_btn,
            this.quit_session_btn});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // make_backup_btn
            // 
            this.make_backup_btn.Name = "make_backup_btn";
            this.make_backup_btn.Size = new System.Drawing.Size(252, 22);
            this.make_backup_btn.Text = "Сделать резервную копию";
            this.make_backup_btn.Click += new System.EventHandler(this.MakeBackupButtonClickEvent);
            // 
            // restore_backup_btn
            // 
            this.restore_backup_btn.Name = "restore_backup_btn";
            this.restore_backup_btn.Size = new System.Drawing.Size(252, 22);
            this.restore_backup_btn.Text = "Восстановить резервную копию";
            this.restore_backup_btn.Click += new System.EventHandler(this.RestoreBackupButtonClickEvent);
            // 
            // quit_session_btn
            // 
            this.quit_session_btn.Name = "quit_session_btn";
            this.quit_session_btn.Size = new System.Drawing.Size(252, 22);
            this.quit_session_btn.Text = "Закончить сессию";
            this.quit_session_btn.Click += new System.EventHandler(this.QuitSessionButtonClickEvent);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_btn});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "Помощь";
            // 
            // about_btn
            // 
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(180, 22);
            this.about_btn.Text = "О приложении";
            this.about_btn.Click += new System.EventHandler(this.AboutBtnClickEvent);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 15, 8);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(354, 387);
            this.label2.TabIndex = 16;
            this.label2.Text = "Система Контроля Продаж(СКП) @ 2024";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.user_lbl.Location = new System.Drawing.Point(19, 43);
            this.user_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(296, 37);
            this.user_lbl.TabIndex = 23;
            this.user_lbl.Text = "Добро пожаловать!";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(743, 411);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menu_strip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_strip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система Контроля Продаж (СКП)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employees_btn;
        private System.Windows.Forms.ToolStripMenuItem products_btn;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem make_backup_btn;
        private System.Windows.Forms.ToolStripMenuItem restore_backup_btn;
        private System.Windows.Forms.ToolStripMenuItem quit_session_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cart_btn;
        private System.Windows.Forms.ToolStripMenuItem about_btn;
    }
}
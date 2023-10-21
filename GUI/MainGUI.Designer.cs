namespace PRN_ASG2.GUI
{
    partial class MainGUI
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
            show = new Label();
            login = new Label();
            logout = new Label();
            SuspendLayout();
            // 
            // show
            // 
            show.AutoSize = true;
            show.Location = new Point(12, 9);
            show.Name = "show";
            show.Size = new Size(45, 20);
            show.TabIndex = 0;
            show.Text = "Show";
            show.Click += show_Click;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(63, 9);
            login.Name = "login";
            login.Size = new Size(46, 20);
            login.TabIndex = 1;
            login.Text = "Login";
            login.Click += login_Click;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.Location = new Point(63, 9);
            logout.Name = "logout";
            logout.Size = new Size(112, 20);
            logout.TabIndex = 2;
            logout.Text = "Logout (admin)";
            logout.Click += logout_Click;
            // 
            // MainGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(login);
            Controls.Add(show);
            Name = "MainGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainGUI";
            Load += MainGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label show;
        private Label login;
        private Label logout;
    }
}
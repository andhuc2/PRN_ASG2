namespace PRN_ASG2.GUI
{
    partial class ShowGUI
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
            logout = new Label();
            show = new Label();
            table = new DataGridView();
            count = new Label();
            add = new Button();
            film = new ComboBox();
            label1 = new Label();
            date = new DateTimePicker();
            room = new ComboBox();
            search = new Button();
            label2 = new Label();
            label3 = new Label();
            login = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.Location = new Point(67, 9);
            logout.Name = "logout";
            logout.Size = new Size(112, 20);
            logout.TabIndex = 5;
            logout.Text = "Logout (admin)";
            logout.Click += logout_Click;
            // 
            // show
            // 
            show.AutoSize = true;
            show.Location = new Point(10, 9);
            show.Name = "show";
            show.Size = new Size(45, 20);
            show.TabIndex = 3;
            show.Text = "Show";
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(10, 258);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.RowTemplate.Height = 29;
            table.Size = new Size(1051, 277);
            table.TabIndex = 6;
            table.CellContentClick += table_CellContentClick;
            // 
            // count
            // 
            count.AutoSize = true;
            count.Location = new Point(10, 235);
            count.Name = "count";
            count.Size = new Size(157, 20);
            count.TabIndex = 7;
            count.Text = "The number of shows: ";
            // 
            // add
            // 
            add.Location = new Point(10, 193);
            add.Name = "add";
            add.Size = new Size(179, 29);
            add.TabIndex = 8;
            add.Text = "Add a new ...";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // film
            // 
            film.DropDownStyle = ComboBoxStyle.DropDownList;
            film.FormattingEnabled = true;
            film.Location = new Point(132, 48);
            film.Name = "film";
            film.Size = new Size(151, 28);
            film.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 10;
            label1.Text = "Film:";
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(132, 98);
            date.Name = "date";
            date.Size = new Size(151, 27);
            date.TabIndex = 11;
            // 
            // room
            // 
            room.DropDownStyle = ComboBoxStyle.DropDownList;
            room.FormattingEnabled = true;
            room.Location = new Point(132, 149);
            room.Name = "room";
            room.Size = new Size(151, 28);
            room.TabIndex = 12;
            // 
            // search
            // 
            search.Location = new Point(334, 148);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 13;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 98);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 14;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 152);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 15;
            label3.Text = "Room:";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(67, 9);
            login.Name = "login";
            login.Size = new Size(46, 20);
            login.TabIndex = 16;
            login.Text = "Login";
            login.Click += login_Click;
            // 
            // ShowGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 547);
            Controls.Add(login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(search);
            Controls.Add(room);
            Controls.Add(date);
            Controls.Add(label1);
            Controls.Add(film);
            Controls.Add(add);
            Controls.Add(count);
            Controls.Add(table);
            Controls.Add(logout);
            Controls.Add(show);
            Name = "ShowGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowGUI";
            Load += ShowGUI_Load;
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logout;
        private Label show;
        private DataGridView table;
        private Label count;
        private Button add;
        private ComboBox film;
        private Label label1;
        private DateTimePicker date;
        private ComboBox room;
        private Button search;
        private Label label2;
        private Label label3;
        private Label login;
    }
}
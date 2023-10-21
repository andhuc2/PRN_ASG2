namespace PRN_ASG2.GUI
{
    partial class BookingGUI
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
            roomMap = new TableLayoutPanel();
            table = new DataGridView();
            count = new Label();
            add = new Button();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // roomMap
            // 
            roomMap.Anchor = AnchorStyles.None;
            roomMap.AutoSize = true;
            roomMap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            roomMap.ColumnCount = 10;
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roomMap.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            roomMap.Location = new Point(216, 27);
            roomMap.Name = "roomMap";
            roomMap.RowCount = 10;
            roomMap.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            roomMap.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            roomMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roomMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roomMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roomMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roomMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roomMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roomMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roomMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roomMap.Size = new Size(160, 160);
            roomMap.TabIndex = 0;
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(12, 261);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.RowTemplate.Height = 29;
            table.Size = new Size(776, 177);
            table.TabIndex = 1;
            // 
            // count
            // 
            count.AutoSize = true;
            count.Location = new Point(12, 229);
            count.Name = "count";
            count.Size = new Size(149, 20);
            count.TabIndex = 2;
            count.Text = "Number of bookings:";
            // 
            // add
            // 
            add.Location = new Point(12, 184);
            add.Name = "add";
            add.Size = new Size(184, 29);
            add.TabIndex = 3;
            add.Text = "Create a new booking";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // back
            // 
            back.Location = new Point(694, 220);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 4;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // BookingGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(add);
            Controls.Add(count);
            Controls.Add(table);
            Controls.Add(roomMap);
            Name = "BookingGUI";
            Text = "BookingGUI";
            Load += BookingGUI_Load;
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel roomMap;
        private DataGridView table;
        private Label count;
        private Button add;
        private Button back;
    }
}
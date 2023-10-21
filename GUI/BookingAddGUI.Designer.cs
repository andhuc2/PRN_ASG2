namespace PRN_ASG2.GUI
{
    partial class BookingAddGUI
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
            label1 = new Label();
            label2 = new Label();
            name = new TextBox();
            amount = new TextBox();
            Save = new Button();
            back = new Button();
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
            roomMap.Location = new Point(159, 40);
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
            roomMap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 242);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 295);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Amount:";
            // 
            // name
            // 
            name.Location = new Point(129, 242);
            name.Name = "name";
            name.Size = new Size(169, 27);
            name.TabIndex = 4;
            // 
            // amount
            // 
            amount.Location = new Point(129, 295);
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Size = new Size(169, 27);
            amount.TabIndex = 5;
            amount.Text = "0";
            // 
            // Save
            // 
            Save.Location = new Point(204, 385);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 6;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // back
            // 
            back.Location = new Point(401, 385);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 7;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // BookingAddGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(Save);
            Controls.Add(amount);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roomMap);
            Name = "BookingAddGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookingAddGUI";
            Load += BookingAddGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel roomMap;
        private Label label1;
        private Label label2;
        private TextBox name;
        private TextBox amount;
        private Button Save;
        private Button back;
    }
}
namespace PRN_ASG2.GUI
{
    partial class ShowAddEditGUI
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
            roomText = new Label();
            room = new ComboBox();
            date = new DateTimePicker();
            slot = new ComboBox();
            film = new ComboBox();
            price = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            save = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // roomText
            // 
            roomText.AutoSize = true;
            roomText.Location = new Point(178, 46);
            roomText.Name = "roomText";
            roomText.Size = new Size(52, 20);
            roomText.TabIndex = 0;
            roomText.Text = "Room:";
            // 
            // room
            // 
            room.DropDownStyle = ComboBoxStyle.DropDownList;
            room.FormattingEnabled = true;
            room.Location = new Point(257, 43);
            room.Name = "room";
            room.Size = new Size(151, 28);
            room.TabIndex = 1;
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(257, 95);
            date.Name = "date";
            date.Size = new Size(151, 27);
            date.TabIndex = 2;
            // 
            // slot
            // 
            slot.DropDownStyle = ComboBoxStyle.DropDownList;
            slot.FormattingEnabled = true;
            slot.Location = new Point(257, 158);
            slot.Name = "slot";
            slot.Size = new Size(151, 28);
            slot.TabIndex = 3;
            // 
            // film
            // 
            film.DropDownStyle = ComboBoxStyle.DropDownList;
            film.FormattingEnabled = true;
            film.Location = new Point(257, 224);
            film.Name = "film";
            film.Size = new Size(151, 28);
            film.TabIndex = 4;
            // 
            // price
            // 
            price.Location = new Point(257, 293);
            price.Name = "price";
            price.Size = new Size(125, 27);
            price.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 100);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 6;
            label1.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 161);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 7;
            label2.Text = "Slot:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 227);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 8;
            label3.Text = "Film:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 296);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 9;
            label4.Text = "Price:";
            // 
            // save
            // 
            save.Location = new Point(178, 375);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 10;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(373, 375);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 11;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // ShowAddEditGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(price);
            Controls.Add(film);
            Controls.Add(slot);
            Controls.Add(date);
            Controls.Add(room);
            Controls.Add(roomText);
            Name = "ShowAddEditGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowAddEditGUI";
            Load += ShowAddEditGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roomText;
        private ComboBox room;
        private DateTimePicker date;
        private ComboBox slot;
        private ComboBox film;
        private TextBox price;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button save;
        private Button cancel;
    }
}
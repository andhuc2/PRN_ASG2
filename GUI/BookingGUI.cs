﻿using PRN_ASG2.DAL;
using PRN_ASG2.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_ASG2.GUI
{
    public partial class BookingGUI : Form
    {
        private int showID = -1;

        public BookingGUI()
        {
            InitializeComponent();
        }

        public BookingGUI(int showId)
        {
            InitializeComponent();
            this.showID = showId;
        }

        private void BookingGUI_Load(object sender, EventArgs e)
        {
            Show show = new ShowDAO().FindShowById(showID);
            Room room = new RoomDAO().FindRoomById(show.RoomID);

            // Clear existing controls in the TableLayoutPanel
            roomMap.Controls.Clear();

            // Set TableLayoutPanel properties
            roomMap.Anchor = AnchorStyles.None;

            renderRoomMap(room.Rows, room.Cols);
            renderGrid(new BookingDAO().FindBookingsByShowID(showID));

        }

        private void renderGrid(List<Booking> data)
        {
            //clear column
            table.Columns.Clear();

            count.Text = "The number of bookings: " + data.Count;

            table.DataSource = data;
            table.Columns["BookingID"].Visible = false;
            table.Columns["ShowID"].Visible = false;
            newColumnButton("Detail");
            newColumnButton("Delete");
        }

        private void renderRoomMap(int rowCount, int columnCount)
        {
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    CheckBox checkbox = new CheckBox
                    {
                        Text = "",
                        AutoSize = false, // Allow custom size
                        Size = new Size(20, 20), // Adjust the size as needed
                        Margin = new Padding(0), // No margin around the checkbox
                        CheckAlign = ContentAlignment.MiddleCenter, // Center the checkmark
                        TextAlign = ContentAlignment.MiddleCenter, // Center any text (empty in this case)
                    };

                    checkbox.Enabled = false;

                    roomMap.Controls.Add(checkbox, col, row);
                }
            }
        }

        private void newColumnButton(string name)
        {
            // Create a new column and set its properties
            DataGridViewButtonColumn newColumn = new DataGridViewButtonColumn();
            newColumn.HeaderText = name;
            newColumn.Name = name;

            // Customize the appearance of the button cells
            newColumn.DefaultCellStyle.BackColor = Color.Gray; // Background color

            table.Columns.Add(newColumn);

            // Iterate through the rows and set the cell values
            foreach (DataGridViewRow row in table.Rows)
            {
                // Access the newly added cell by column name or index
                DataGridViewCell cell = row.Cells[name]; // Or use index: row.Cells[newColumn.Index]
                cell.Value = name; // Set the cell text
            }
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;

            if (checkbox.Checked)
            {
                if (checkbox.Checked)
                {
                    // Checkbox is checked
                    int row = roomMap.GetRow(checkbox); // Get the row index
                    int column = roomMap.GetColumn(checkbox); // Get the column index

                    // Create a message to display the row and column index
                    string message = $"Checkbox at Row {row}, Column {column} is checked.";
                }
            }
            else
            {
                // Checkbox is unchecked
                // Add your code for handling the unchecked state
            }
        }


        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

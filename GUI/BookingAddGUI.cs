using PRN_ASG2.DAL;
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
    public partial class BookingAddGUI : Form
    {
        private int showID = -1;
        private int count = 0;
        private string seatStatus = "";
        public BookingAddGUI()
        {
            InitializeComponent();
        }

        public BookingAddGUI(int showID)
        {
            InitializeComponent();
            this.showID = showID;
        }

        private List<String> GetSeatStatusRoom()
        {
            List<Booking> bookings = new BookingDAO().FindBookingsByShowID(showID);
            List<string> ans = new List<string>();

            foreach (Booking booking in bookings)
            {
                string[] temp = booking.SeatStatus.Split(',');

                foreach (string item in temp)
                {
                    ans.Add(item);
                }
            }

            return ans;
        }

        private void BookingAddGUI_Load(object sender, EventArgs e)
        {
            Show show = new ShowDAO().FindShowById(showID);
            Room room = new RoomDAO().FindRoomById(show.RoomID);

            // Clear existing controls in the TableLayoutPanel
            roomMap.Controls.Clear();

            // Set TableLayoutPanel properties
            roomMap.Anchor = AnchorStyles.None;

            renderRoomMap(room.Rows, room.Cols);
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;

            // Checkbox is checked
            int row = roomMap.GetRow(checkbox); // Get the row index
            int column = roomMap.GetColumn(checkbox); // Get the column index

            if (checkbox.Checked)
            {
                if (checkbox.Checked)
                {
                    count++;

                    //update seat status
                    seatStatus += row + "-" + column + ",";
                }
            }
            else
            {
                count--;

                RemoveSubstring(seatStatus, row + "-" + column + ",");
            }

            Show show = new ShowDAO().FindShowById(showID);
            amount.Text = (show.Price * count).ToString();
        }

        public static string RemoveSubstring(string originalString, string substring)
        {
            // Replace all occurrences of the substring with an empty string.
            string result = originalString.Replace(substring, string.Empty);

            return result;
        }

        private void renderRoomMap(int rowCount, int columnCount)
        {
            List<string> seatStatusRoom = GetSeatStatusRoom();

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

                    if (seatStatusRoom.Contains(row + "-" + col))
                    {
                        checkbox.Checked = true;
                        checkbox.Enabled = false;
                    }

                    checkbox.CheckedChanged += Checkbox_CheckedChanged;

                    roomMap.Controls.Add(checkbox, col, row);
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();

            try
            {
                booking.Name = name.Text;
                booking.Amount = decimal.Parse(amount.Text);
                booking.ShowID = showID;
                booking.SeatStatus = seatStatus;
            } catch (Exception ex)
            {
                MessageBox.Show("Booked failed!");
            }

            if (new BookingDAO().InsertBooking(booking))
            {
                MessageBox.Show("Booked success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Booked failed!");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

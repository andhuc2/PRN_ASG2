using Microsoft.IdentityModel.Tokens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRN_ASG2.GUI
{
    public partial class ShowAddEditGUI : Form
    {
        private int showId = -1;
        public ShowAddEditGUI()
        {
            InitializeComponent();
        }

        public ShowAddEditGUI(int id)
        {
            InitializeComponent();
            this.showId = id;
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void ShowAddEditGUI_Load(object sender, EventArgs e)
        {
            RenderComboBox(room, new RoomDAO().FindAllRooms());
            RenderComboBox(slot, new ShowDAO().FindEmptySlot(date.Value));

            if (showId == -1)
            {

            }
            else
            {
                Show show = new ShowDAO().FindShowById(showId);

                room.Text = new RoomDAO().FindRoomById(show.RoomID).Name;
                date.Text = show.ShowDate.ToString();
                room.Enabled = false; date.Enabled = false;
                RenderComboBox(slot, new ShowDAO().FindEmptySlot(date.Value));

                slot.Text = show.Slot.ToString();
                slot.Items.Add(show.Slot);
                film.Text = show.FilmID.ToString();
                price.Text = show.Price.ToString();
            }
        }

        private void RenderComboBox<T>(System.Windows.Forms.ComboBox comboBox, List<T> list)
        {
            comboBox.Items.Clear();
            if(list.IsNullOrEmpty()) { return; }

            foreach (T item in list)
            {
                comboBox.Items.Add(item.ToString());
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

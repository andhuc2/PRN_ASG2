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
using static System.Reflection.Metadata.BlobBuilder;
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
            if (showId == -1)
            {
                Show show = new Show();

                show.RoomID = new RoomDAO().FindRoomByName(room.Text).RoomId;
                show.ShowDate = date.Value;
                show.Slot = int.Parse(slot.Text);
                show.Price = decimal.Parse(price.Text);
                show.FilmID = new FilmDAO().FindFilmByTitle(film.Text).FilmID;

                if (new ShowDAO().InsertShow(show))
                {
                    MessageBox.Show("A new show is added!");
                }
                else
                {
                    MessageBox.Show("Add failed!");
                }
                /*try
                {
                    Show show = new Show();

                    show.RoomID = int.Parse(room.Text);
                    show.ShowDate = date.Value;
                    show.Slot = int.Parse(slot.Text);
                    show.Price = decimal.Parse(price.Text);
                    show.FilmID = new FilmDAO().FindFilmByTitle(film.Text).FilmID;

                    if (new ShowDAO().InsertShow(show))
                    {
                        MessageBox.Show("A new show is added!");
                    }
                    else
                    {
                        MessageBox.Show("Add failed!");
                    }

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/

            }
            else
            {
                try
                {
                    Show show = new ShowDAO().FindShowById(showId);

                    show.Slot = int.Parse(slot.Text);
                    show.Price = decimal.Parse(price.Text);
                    show.FilmID = new FilmDAO().FindFilmByTitle(film.Text).FilmID;

                    if (new ShowDAO().UpdateShow(show))
                    {
                        MessageBox.Show("That show is edited!");
                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShowAddEditGUI_Load(object sender, EventArgs e)
        {
            RenderComboBox(room, new RoomDAO().FindAllRooms());
            RenderComboBox(slot, Enumerable.Range(1, 9).ToList());
            RenderComboBox(film, new FilmDAO().FindAllFilms());

            if (showId == -1)
            {

            }
            else
            {
                Show show = new ShowDAO().FindShowById(showId);

                room.Text = new RoomDAO().FindRoomById(show.RoomID).Name;
                date.Text = show.ShowDate.ToString();
                room.Enabled = false; date.Enabled = false;
                RenderComboBox(slot, new ShowDAO().FindEmptySlot(date.Value, show.RoomID));

                slot.Text = show.Slot.ToString();
                slot.Items.Add(show.Slot);

                Film filmShow = new FilmDAO().FindFilmById(show.FilmID);
                film.Text = filmShow.Title;

                price.Text = show.Price.ToString();
            }
        }

        private void RenderComboBox<T>(System.Windows.Forms.ComboBox comboBox, List<T> list)
        {
            comboBox.Items.Clear();
            if (list.IsNullOrEmpty()) { return; }

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

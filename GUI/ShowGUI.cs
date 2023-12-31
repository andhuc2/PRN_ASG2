﻿using Microsoft.IdentityModel.Tokens;
using PRN_ASG;
using PRN_ASG.DAL;
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
    public partial class ShowGUI : Form
    {
        private Boolean isLogined = false;

        public ShowGUI()
        {
            InitializeComponent();
        }

        public ShowGUI(bool isLogined)
        {
            InitializeComponent();
            this.isLogined = isLogined;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new MainGUI().Show();
            this.Hide();
        }

        private void ShowGUI_Load(object sender, EventArgs e)
        {
            //check logined
            if (!isLogined)
            {
                add.Hide();
                logout.Hide();
            }
            else
            {
                login.Hide();
            }

            //combo box search 
            RenderComboBox(room, new RoomDAO().FindAllRooms());
            RenderComboBox(film, new FilmDAO().FindAllFilms());

            //data grid
            List<Show> data = new ShowDAO().FindAllShows();
            renderGrid(data);
        }

        private void renderGrid(List<Show> data)
        {
            //clear column
            table.Columns.Clear();

            count.Text = "The number of shows: " + data.Count;

            table.DataSource = data;
            table.Columns["ShowID"].Visible = false;
            table.Columns["Status"].Visible = false;
            newColumnButton("Booking");
            //check logined?
            if (isLogined)
            {
                newColumnButton("Edit");
                newColumnButton("Delete");
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

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //booking
            if (table.Columns[e.ColumnIndex].Name == "Booking")
            {
                int id = (int)table.Rows[e.RowIndex].Cells["ShowID"].Value;

                new BookingGUI(id).ShowDialog();

                //reload
                ShowGUI_Load(sender, e);
            }

            //edit
            if (table.Columns[e.ColumnIndex].Name == "Edit")
            {
                int id = (int)table.Rows[e.RowIndex].Cells["ShowID"].Value;

                new ShowAddEditGUI(id).ShowDialog();

                //reload
                ShowGUI_Load(sender, e);
            }

            //delete
            if (table.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = (int)table.Rows[e.RowIndex].Cells["ShowID"].Value;
                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (new ShowDAO().DeleteShow(id))
                    {
                        MessageBox.Show("This show is deleted");
                    }
                    else
                    {
                        MessageBox.Show("Delete failed!");
                    }
                }

                //reload
                ShowGUI_Load(sender, e);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            new ShowAddEditGUI().ShowDialog();
            //reload
            ShowGUI_Load(sender, e);
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                Show show = new Show();

                show.RoomID = new RoomDAO().FindRoomByName(room.Text).RoomId;
                show.ShowDate = date.Value;
                show.FilmID = new FilmDAO().FindFilmByTitle(film.Text).FilmID;

                List<Show> data = new ShowDAO().FindShowsByCriteria(show);
                renderGrid(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant be empty!");
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
    }
}

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
        public ShowGUI()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new MainGUI().Show();
            this.Hide();
        }

        private void ShowGUI_Load(object sender, EventArgs e)
        {
            List<Show> data = new ShowDAO().FindAllShows();
            count.Text = "The number of shows: " + data.Count;

            table.DataSource = data;
            table.Columns["ShowID"].Visible = false;
            table.Columns["Status"].Visible = false;
            newColumnButton("Booking");
            newColumnButton("Edit");
            newColumnButton("Delete");
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
            if (table.Columns[e.ColumnIndex].Name == "Edit")
            {
                int id = (int)table.Rows[e.RowIndex].Cells["ShowID"].Value;

                new ShowAddEditGUI(id).ShowDialog();
            }

            if (table.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = (int)table.Rows[e.RowIndex].Cells["ShowID"].Value;
                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (new ShowDAO().DeleteShow(id))
                    {
                        MessageBox.Show("This show is deleted");
                        ShowGUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed!");
                    }
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

        }
    }
}

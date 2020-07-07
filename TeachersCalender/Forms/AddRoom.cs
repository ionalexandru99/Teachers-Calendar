using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachersCalender.Entities;
using TeachersCalender.Settings;

namespace TeachersCalender.Forms
{
    public partial class AddRoom : Form
    {
        private List<Room> rooms;
        SQLInterpretor interpretor = null;
        private bool isName = false;
        private bool isSize = false;

        public Room activRoom = null;

        public AddRoom()
        {
            InitializeComponent();
            interpretor = new SQLInterpretor();
            rooms = new List<Room>();
            btnAdd.Enabled = false;
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            try
            {
                interpretor.LoadRooms(out rooms);
                DisplayRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayRooms()
        {
            lvRooms.Items.Clear();
            UpdateRoomCount();
            foreach (Room room in rooms)
            {
                string[] row = { room.Name, room.Size.ToString() };
                ListViewItem item = new ListViewItem(row)
                {
                    Tag = room
                };
                lvRooms.Items.Add(item);
            }
        }

        private void UpdateRoomCount()
        {
            labelStatusNumberRooms.Text = rooms.Count.ToString();
        }
        #region Filter
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                isName = false;
                errorProv.SetError(tbName, "Field must not be empty!");
                btnAdd.Enabled = false;
                e.Cancel = true;
            }
            else
            {
                foreach (Room room in rooms)
                {
                    if (room.Name.Equals(tbName.Text))
                    {
                        isName = false;
                        errorProv.SetError(tbName, "Value already in the database!");
                        btnAdd.Enabled = false;
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        private void tbName_Validated(object sender, EventArgs e)
        {
            errorProv.SetError(tbName, null);
            isName = true;

            if (isName && isSize)
            {
                btnAdd.Enabled = true;
            }
        }

        private void tbSize_Validating(object sender, CancelEventArgs e)
        {
            int value = -1;
            if (String.IsNullOrWhiteSpace(tbSize.Text))
            {
                isName = false;
                errorProv.SetError(tbSize, "Field must not be empty!");
                btnAdd.Enabled = false;
                e.Cancel = true;
            }
            else if (!Int32.TryParse(tbSize.Text, out value))
            {
                isName = false;
                errorProv.SetError(tbSize, "Value must be a natural number!");
                btnAdd.Enabled = false;
                e.Cancel = true;
            }
            else if (value < 0)
            {
                isName = false;
                errorProv.SetError(tbSize, "Value must be a positiv number!");
                btnAdd.Enabled = false;
                e.Cancel = true;
            }
        }

        private void tbSize_Validated(object sender, EventArgs e)
        {
            errorProv.SetError(tbSize, null);
            isSize = true;

            if (isName && isSize)
            {
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Length == 0 && tbSize.Text.Length == 0)
            {
                return;
            }

            Room room = new Room(tbName.Text, Int32.Parse(tbSize.Text));
            interpretor.AddRoom(room, rooms);
            ClearAdd();
            DisplayRooms();
        }

        private void ClearAdd()
        {
            tbName.Text = String.Empty;
            tbSize.Text = String.Empty;
            isName = false;
            isSize = false;

            errorProv.SetError(tbName, null);
            errorProv.SetError(tbSize, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAdd();

            try
            {
                interpretor.LoadRooms(out rooms);
                DisplayRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void lvRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                activRoom = lvRooms.SelectedItems[0].Tag as Room;
            }
            catch { }
        }
    }
}

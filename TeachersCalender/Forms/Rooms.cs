using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeachersCalender.Entities;
using TeachersCalender.Settings;

namespace TeachersCalender.Forms
{
    public partial class Rooms : Form
    {
        private List<Room> rooms = null;
        private SQLInterpretor interpretor;
        private bool isMin = false;
        private bool isMax = false;

        public Room activRoom = null;

        public Rooms()
        {
            InitializeComponent();
            rooms = new List<Room>();
            interpretor = new SQLInterpretor();
            lvRooms.Show();
            btnFilter.Enabled = false;
        }

        public void DisplayRooms()
        {
            lvRooms.Items.Clear();
            UpdateRoomCount();
            foreach(Room room in rooms)
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

        private void Rooms_Load(object sender, System.EventArgs e)
        {
            try
            {
                interpretor.LoadRooms(out rooms);
                DisplayRooms();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Filter
        private void tbMinRange_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int value = -1;
            if(String.IsNullOrWhiteSpace(tbMinRange.Text))
            {
                errorProv.SetError(tbMinRange, "Value must not be empty!");
                isMin = false;
                e.Cancel = true;
            }
            else if (!Int32.TryParse(tbMinRange.Text, out value))
            {
                errorProv.SetError(tbMinRange, "Value must be a natural number!");
                isMin = false;
                e.Cancel = true;
            }
            else if (value < 0)
            {
                errorProv.SetError(tbMinRange, "Value must be a number bigger or equal to 0!");
                isMin = false;
                e.Cancel = true;
            }
        }

        private void tbMinRange_Validated(object sender, EventArgs e)
        {
            errorProv.SetError(tbMinRange, null);
            isMin = true;

            if(isMin && isMax)
            {
                btnFilter.Enabled = true;
            }
        }

        private void tbMaxRange_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int value = -1;
            int minValue;
            if (String.IsNullOrWhiteSpace(tbMaxRange.Text))
            {
                errorProv.SetError(tbMaxRange, "Value must not be empty!");
                isMax = false;
                e.Cancel = true;
            }
            else if (!Int32.TryParse(tbMaxRange.Text, out value))
            {
                errorProv.SetError(tbMaxRange, "Value must be a natural number!");
                isMax = false;
                e.Cancel = true;
            }
            else if (value < 0)
            {
                errorProv.SetError(tbMaxRange, "Value must be a number bigger or equal to 0!");
                isMax = false;
                e.Cancel = true;
            }
            else if(Int32.TryParse(tbMinRange.Text, out minValue))
            {
                if(value < minValue)
                {
                    errorProv.SetError(tbMaxRange, "Max value must be bigger than min value!");
                    isMax = false;
                    e.Cancel = true;
                }
            }
        }

        private void tbMaxRange_Validated(object sender, EventArgs e)
        {
            errorProv.SetError(tbMaxRange, null);
            isMax = true;

            if (isMin && isMax)
            {
                btnFilter.Enabled = true;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(tbMinRange.Text);
            int max = Int32.Parse(tbMaxRange.Text);
            interpretor.RoomFilter(out rooms, min, max);
            Console.WriteLine(rooms.Count);
            DisplayRooms();
            ClearFilter();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFilter();

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

        private void ClearFilter()
        {
            tbMaxRange.Text = String.Empty;
            tbMinRange.Text = String.Empty;
            isMax = false;
            isMin = false;

            errorProv.SetError(tbMaxRange, null);
            errorProv.SetError(tbMinRange, null);

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

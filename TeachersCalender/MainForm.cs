using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeachersCalender.Entities;
using System.Runtime.InteropServices;
using TeachersCalender.Forms;
using System.IO;
using Newtonsoft.Json;
using TeachersCalender.Settings;

namespace TeachersCalender
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        private SQLInterpretor interpretor;

        #region MoveWindows properties
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public MainForm()
        {
            InitializeComponent();
            disablePanels();

            interpretor = new SQLInterpretor();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        #region TopPanel
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region MoveWindows

        private void menuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #region Dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            disablePanels();
        }

        #endregion

        #region Rooms

        private void btnRooms_Click(object sender, EventArgs e)
        {
            disablePanels();
            panelRooms.Visible = true;
        }

        private void btnRoomsShow_Click(object sender, EventArgs e)
        {
            Rooms roomsForm = new Rooms();
            openForm(roomsForm);
        }

        private void btnRoomsSerialize_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON | *.json";
            saveFileDialog.Title = "Save as JSON file";
            List<Room> rooms = new List<Room>();
            try
            {
                interpretor.LoadRooms(out rooms);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(rooms));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRoomsDeserialize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Inserting a new file will delete all the old data from the Database", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON | *.json";
            openFileDialog.Title = "Select JSON file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFile = File.ReadAllText(openFileDialog.FileName);
                List<Room> rooms = new List<Room>();
                rooms = JsonConvert.DeserializeObject<List<Room>>(jsonFile);

                try
                {
                    interpretor.DeleteRooms();
                    foreach (Room room in rooms)
                    {
                        interpretor.AddRoom(room, null);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                btnRoomsShow.PerformClick();
            }
        }

        private void btnRoomsAdd_Click(object sender, EventArgs e)
        {
            AddRoom roomsForm = new AddRoom();
            openForm(roomsForm);
        }

        private void btnRoomsEdit_Click(object sender, EventArgs e)
        {
            if(activeForm == null)
            {
                EditRoom edit = new EditRoom(null);
                openForm(edit);
            }

            if (activeForm is AddRoom)
            {
                AddRoom addRoom = activeForm as AddRoom;
                Room room = addRoom.activRoom;

                EditRoom edit = new EditRoom(room);
                openForm(edit);
            }
            else if (activeForm is Rooms)
            {
                Rooms addRoom = activeForm as Rooms;
                Room room = addRoom.activRoom;

                EditRoom edit = new EditRoom(room);
                openForm(edit);
            }
            else if (activeForm is EditRoom)
            {
                EditRoom addRoom = activeForm as EditRoom;
                Room room = addRoom.activRoom;

                EditRoom edit = new EditRoom(room);
                openForm(edit);
            }
        }

        private void btnRoomsDelete_Click(object sender, EventArgs e)
        {
            if(activeForm == null)
            {
                return;
            }

            if(activeForm is AddRoom)
            {
                AddRoom addRoom = activeForm as AddRoom;
                Room room = addRoom.activRoom;

                interpretor.DeleteRoom(room);

                btnRoomsAdd.PerformClick();
            }
            else if(activeForm is Rooms)
            {
                Rooms addRoom = activeForm as Rooms;
                Room room = addRoom.activRoom;

                interpretor.DeleteRoom(room);

                btnRoomsShow.PerformClick();
            }
            else if(activeForm is EditRoom)
            {
                EditRoom addRoom = activeForm as EditRoom;
                Room room = addRoom.activRoom;

                interpretor.DeleteRoom(room);

                btnRoomsShow.PerformClick();
            }


        }

        #endregion

        #region Teachers
        private void btnTeachers_Click(object sender, EventArgs e)
        {
            disablePanels();
            panelTeachers.Visible = true;
        }

        private void btnTeachersShow_Click(object sender, EventArgs e)
        {
            Teachers form = new Teachers();
            openForm(form);
        }

        private void btnTeachersSerialize_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON | *.json";
            saveFileDialog.Title = "Save Teachers as JSON file";
            List<Teacher> teachers = new List<Teacher>();
            try
            {
                interpretor.LoadTeachers(out teachers);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(teachers));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON | *.json";
            saveFileDialog.Title = "Save Lectures as JSON file";
            List<Lecture> lectures = new List<Lecture>();
            try
            {
                interpretor.LoadLectures(out lectures);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(lectures));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTeachersDeserialize_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Inserting a new file will delete all the old data from the Database", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON | *.json";
            openFileDialog.Title = "Select JSON file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFile = File.ReadAllText(openFileDialog.FileName);
                List<Teacher> teachers = new List<Teacher>();
                teachers = JsonConvert.DeserializeObject<List<Teacher>>(jsonFile);

                try
                {
                    interpretor.DeleteRooms();
                    foreach (Teacher teacher in teachers)
                    {
                        interpretor.AddTeacher(teacher, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                btnRoomsShow.PerformClick();
            }


            btnTeachersShow.PerformClick();
        }

        private void btnTeachersAdd_Click(object sender, EventArgs e)
        {
            AddTeacher form = new AddTeacher();
            openForm(form);
        }

        private void btnTeachersEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnTeachersDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Subjects
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            disablePanels();
            panelSubjects.Visible = true;
        }

        private void btnSubjectsShow_Click(object sender, EventArgs e)
        {
            Subjects form = new Subjects();
            openForm(form);
        }

        private void btnSubjectsSerialize_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON | *.json";
            saveFileDialog.Title = "Save as JSON file";
            List<Subject> subjects = new List<Subject>();
            try
            {
                interpretor.LoadSubjects(out subjects);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(subjects));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubjectsDeserialize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Inserting a new file will delete all the old data from the Database", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON | *.json";
            openFileDialog.Title = "Select JSON file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFile = File.ReadAllText(openFileDialog.FileName);
                List<Subject> subjects = new List<Subject>();
                subjects = JsonConvert.DeserializeObject<List<Subject>>(jsonFile);

                try
                {
                    interpretor.DeleteSubjects();
                    Console.WriteLine(subjects.Count.ToString());
                    foreach (Subject subject in subjects)
                    {
                        interpretor.AddSubject(subject, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                btnSubjectsShow.PerformClick();
            }
        }

        private void btnSubjectsAdd_Click(object sender, EventArgs e)
        {
            AddSubject form = new AddSubject();
            openForm(form);
        }

        private void btnSubjectsEdit_Click(object sender, EventArgs e)
        {
            if (activeForm == null)
            {
                EditSubject edit = new EditSubject(null);
                openForm(edit);
            }

            if (activeForm is AddSubject)
            {
                AddSubject form = activeForm as AddSubject;
                Subject subject = form.activSubject;

                EditSubject edit = new EditSubject(subject);
                openForm(edit);
            }
            else if (activeForm is Subjects)
            {
                Subjects form = activeForm as Subjects;
                Subject subject = form.activSubject;

                EditSubject edit = new EditSubject(subject);
                openForm(edit);
            }
            else if (activeForm is EditSubject)
            {
                EditSubject form = activeForm as EditSubject;
                Subject subject = form.activSubject;

                EditSubject edit = new EditSubject(subject);
                openForm(edit);
            }
        }

        private void btnSubjectsDelete_Click(object sender, EventArgs e)
        {
            if(activeForm == null)
            {
                return;
            }

            if (activeForm is AddSubject)
            {
                AddSubject form = activeForm as AddSubject;
                Subject subject = form.activSubject;

                interpretor.DeleteSubject(subject);
                btnSubjectsAdd.PerformClick();
            }
            else if (activeForm is Subjects)
            {
                Subjects form = activeForm as Subjects;
                Subject subject = form.activSubject;

                interpretor.DeleteSubject(subject);
                btnSubjectsShow.PerformClick();
            }
            else if (activeForm is EditSubject)
            {
                EditSubject form = activeForm as EditSubject;
                Subject subject = form.activSubject;

                interpretor.DeleteSubject(subject);
                btnSubjectsEdit.PerformClick();
            }
        }

        #endregion

        #region Panel management
        private void openForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void disablePanels()
        {
            panelRooms.Visible = false;
            panelTeachers.Visible = false;
            panelSubjects.Visible = false;
        }


        #endregion
        private void imagePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = null;
        }
    }
}

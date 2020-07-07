using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachersCalender.Entities;
using TeachersCalender.Settings;

namespace TeachersCalender.Forms
{
    public partial class AddTeacher : Form
    {
        private List<Teacher> teachers;
        private SQLInterpretor interpretor;
        private List<Lecture> lectures;

        public Teacher activeTeacher = null;

        public AddTeacher()
        {
            InitializeComponent();

            interpretor = new SQLInterpretor();
            teachers = new List<Teacher>();
            lectures = new List<Lecture>();

            CancelSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbName.Text))
            {
                string teacherString = tbName.Text;
                Teacher teacher = new Teacher(teacherString);

                try
                {
                    interpretor.AddTeacher(teacher, teachers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                LoadTeachers();
                Reload();
                Display();
                return;
            }

            try
            {
                string roomName = lbRoom.SelectedItem.ToString();
                string subjectName = lbSubject.SelectedItem.ToString();
                string teacherName = lbTeacher.SelectedItem.ToString();
                DateTime date = DateTime.ParseExact(tbDate.Text, "M/d/yyyy", CultureInfo.CurrentCulture);

                Lecture lecture = new Lecture(teacherName, subjectName, roomName, date);
                try
                {
                    interpretor.AddLecture(lecture, lectures);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                CancelSelection();

                LoadTeachers();
                Reload();
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelSelection();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                Reload();
                Display();

                LoadLists();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Display()
        {
            lvTeachers.Items.Clear();
            UpdateCount();
            foreach (Teacher teacher in teachers)
            {
                bool added = false;
                string[] row = { teacher.Name };
                foreach (Lecture lecture in lectures)
                {
                    if (lecture.Teacher.Equals(teacher.Name))
                    {
                        added = true;
                        string[] longRow = { row[0], lecture.Subject, lecture.Date.ToShortDateString() };
                        ListViewItem item = new ListViewItem(longRow)
                        {
                            Tag = lecture
                        };
                        lvTeachers.Items.Add(item);
                    }
                }

                if (!added)
                {
                    ListViewItem viewItem = new ListViewItem(row);
                    lvTeachers.Items.Add(viewItem);
                }

            }

            lvTeachers.Show();
        }

        private void UpdateCount()
        {
            labelStatusNumberTeachers.Text = teachers.Count.ToString();
        }

        public void Reload()
        {
            interpretor.LoadTeachers(out teachers);
            interpretor.LoadLectures(out lectures);
        }

        private void CancelSelection()
        {
            tbName.Text = String.Empty;
            tbDate.Text = String.Empty;
            lbRoom.ClearSelected();
            lbSubject.ClearSelected();
            lbTeacher.ClearSelected();
        }

        private void tbDate_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbDate.Text))
            {
                return;
            }
            try
            {
                DateTime date = DateTime.ParseExact(tbDate.Text, "M/d/yyyy", CultureInfo.CurrentCulture);
            }
            catch
            {
                errorProv.SetError(tbDate, "Date format is incorrect! Use format: M/d/yyyy");
                btnAdd.Enabled = false;
                e.Cancel = true;
            }
        }

        private void tbDate_Validated(object sender, EventArgs e)
        {
            errorProv.SetError(tbDate, null);
            btnAdd.Enabled = true;
        }

        private void LoadLists()
        {
            LoadRooms();
            LoadSubjects();
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            lbTeacher.Items.Clear();
            foreach (Teacher teacher in teachers)
            {
                lbTeacher.Items.Add(teacher.Name);
            }
        }

        private void LoadRooms()
        {
            lbRoom.Items.Clear();

            List<Room> rooms = new List<Room>();
            interpretor.LoadRooms(out rooms);

            foreach (Room room in rooms)
            {
                lbRoom.Items.Add(room.Name);
            }
        }

        public void LoadSubjects()
        {
            lbSubject.Items.Clear();

            List<Subject> subjects = new List<Subject>();
            interpretor.LoadSubjects(out subjects);

            foreach (Subject subject in subjects)
            {
                lbSubject.Items.Add(subject.Name);
            }
        }
    }
}

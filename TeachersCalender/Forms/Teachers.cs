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
    public partial class Teachers : Form
    {
        private List<Teacher> teachers;
        private SQLInterpretor interpretor;
        private List<Lecture> lectures;

        public Teacher activeTeacher = null;

        public Teachers()
        {
            InitializeComponent();

            interpretor = new SQLInterpretor();
            teachers = new List<Teacher>();
            lectures = new List<Lecture>();
        }

        #region Validations

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
                btnFilter.Enabled = false;
                e.Cancel = true;
            }
        }

        private void tbDate_Validated(object sender, EventArgs e)
        {
            errorProv.SetError(tbDate, null);
            btnFilter.Enabled = true;
        }

        #endregion

        private void Teachers_Load(object sender, EventArgs e)
        {
            try
            {
                Reload();
                Display();
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
                string[] row = { teacher.Name};
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string teacher = String.IsNullOrWhiteSpace(tbName.Text) ? null : tbName.Text;
            string subject = String.IsNullOrWhiteSpace(tbSubject.Text) ? null : tbSubject.Text;
            string date = String.IsNullOrWhiteSpace(tbDate.Text) ? null : tbDate.Text;

            Reload();

            if (teacher != null)
            {
                interpretor.TeacherFilter(teachers, teacher);
                lectures = interpretor.LectureFilter(new Teacher(teacher));
            }

            if (subject != null)
            {
                lectures = interpretor.LectureFilter(subject, lectures);
            }

            if (date != null)
            {
                DateTime dateTime = DateTime.ParseExact(date, "M/d/yyyy", CultureInfo.CurrentCulture);
                lectures = interpretor.LectureFilter(dateTime, lectures);
            }
            CancelFilter();
            Display();
        }

        private void CancelFilter()
        {
            tbDate.Text = String.Empty;
            tbName.Text = String.Empty;
            tbSubject.Text = String.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelFilter();
            Reload();
            Display();
        }

        public void Reload()
        {
            interpretor.LoadTeachers(out teachers);
            interpretor.LoadLectures(out lectures);
        }
    }
}

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
    public partial class EditSubject : Form
    {
        private List<Subject> subjects;
        private bool isName = false;
        SQLInterpretor interpretor;
        private bool isCredits = false;

        public Subject activSubject;

        public EditSubject(Subject subject)
        {
            InitializeComponent();
            subjects = new List<Subject>();
            interpretor = new SQLInterpretor();

            if (subject != null)
            {
                tbName.Text = subject.Name;
                tbCredits.Text = subject.Credits.ToString();
                activSubject = subject;

            }
        }

        private void UpdateRoomCount()
        {
            labelStatusNumberSubjects.Text = subjects.Count.ToString();
        }

        #region Validating
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                isName = false;
                errorProv.SetError(tbName, "Field must not be empty!");
                btnEdit.Enabled = false;
                e.Cancel = true;
            }
            else
            {
                foreach (Subject subject in subjects)
                {
                    if (subject.Name.Equals(tbName.Text))
                    {
                        isName = false;
                        errorProv.SetError(tbName, "Value already in the database!");
                        btnEdit.Enabled = false;
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

            if (isName && isCredits)
            {
                btnEdit.Enabled = true;
            }
        }

        private void tbCredits_Validating(object sender, CancelEventArgs e)
        {
            int value = -1;
            if (String.IsNullOrWhiteSpace(tbCredits.Text))
            {
                isName = false;
                errorProv.SetError(tbCredits, "Field must not be empty!");
                btnEdit.Enabled = false;
                e.Cancel = true;
            }
            else if (!Int32.TryParse(tbCredits.Text, out value))
            {
                isName = false;
                errorProv.SetError(tbCredits, "Value must be a natural number!");
                btnEdit.Enabled = false;
                e.Cancel = true;
            }
            else if (value < 0)
            {
                isName = false;
                errorProv.SetError(tbCredits, "Value must be a positiv number!");
                btnEdit.Enabled = false;
                e.Cancel = true;
            }
        }

        private void tbCredits_Validated(object sender, EventArgs e)
        {
            errorProv.SetError(tbCredits, null);
            isCredits = true;

            if (isName && isCredits)
            {
                btnEdit.Enabled = true;
            }
        }


        #endregion

        private void EditSubject_Load(object sender, EventArgs e)
        {
            try
            {
                interpretor.LoadSubjects(out subjects);
                DisplaySubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplaySubjects()
        {
            lvSubjects.Items.Clear();
            UpdateSubjectCount();
            foreach (Subject subject in subjects)
            {
                string[] row = { subject.Name, subject.Credits.ToString() };
                ListViewItem item = new ListViewItem(row)
                {
                    Tag = subject
                };
                lvSubjects.Items.Add(item);
            }
        }

        private void UpdateSubjectCount()
        {
            labelStatusNumberSubjects.Text = subjects.Count.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearEdit();

            try
            {
                interpretor.LoadSubjects(out subjects);
                DisplaySubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearEdit()
        {
            tbName.Text = String.Empty;
            tbCredits.Text = String.Empty;
            isName = false;
            isCredits = false;

            errorProv.SetError(tbName, null);
            errorProv.SetError(tbCredits, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject(tbName.Text, Int32.Parse(tbCredits.Text));
            interpretor.EditSubject(activSubject, subject, subjects);
            ClearEdit();
            DisplaySubjects();
        }

        private void lvSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                activSubject = lvSubjects.SelectedItems[0].Tag as Subject;
                tbName.Text = activSubject.Name;
                tbCredits.Text = activSubject.Credits.ToString();
            }
            catch { }
        }
    }
}

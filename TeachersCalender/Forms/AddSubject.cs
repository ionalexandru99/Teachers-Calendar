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
    public partial class AddSubject : Form
    {
        private List<Subject> subjects;
        SQLInterpretor interpretor = null;
        private bool isName = false;
        private bool isCredits = false;

        public Subject activSubject = null;

        public AddSubject()
        {
            InitializeComponent();
            interpretor = new SQLInterpretor();
            subjects = new List<Subject>();
            btnAdd.Enabled = false;
        }

        private void DisplaySubjects()
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
                foreach (Subject subject in subjects)
                {
                    if (subject.Name.Equals(tbName.Text))
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

            if (isName && isCredits)
            {
                btnAdd.Enabled = true;
            }
        }

        private void tbCredits_Validating(object sender, CancelEventArgs e)
        {
            int value = -1;
            if (String.IsNullOrWhiteSpace(tbCredits.Text))
            {
                isName = false;
                errorProv.SetError(tbCredits, "Field must not be empty!");
                btnAdd.Enabled = false;
                e.Cancel = true;
            }
            else if (!Int32.TryParse(tbCredits.Text, out value))
            {
                isName = false;
                errorProv.SetError(tbCredits, "Value must be a natural number!");
                btnAdd.Enabled = false;
                e.Cancel = true;
            }
            else if (value < 0)
            {
                isName = false;
                errorProv.SetError(tbCredits, "Value must be a positiv number!");
                btnAdd.Enabled = false;
                e.Cancel = true;
            }
        }

        private void tbCredits_Validated(object sender, EventArgs e)
        {
            errorProv.SetError(tbCredits, null);
            isCredits = true;

            if (isName && isCredits)
            {
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length == 0 && tbCredits.Text.Length == 0)
            {
                return;
            }

            Subject subject = new Subject(tbName.Text, Int32.Parse(tbCredits.Text));
            interpretor.AddSubject(subject, subjects);
            ClearAdd();
            DisplaySubjects();
        }

        private void ClearAdd()
        {
            tbName.Text = String.Empty;
            tbCredits.Text = String.Empty;
            isName = false;
            isCredits = false;

            errorProv.SetError(tbName, null);
            errorProv.SetError(tbCredits, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAdd();

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

        private void AddSubject_Load(object sender, EventArgs e)
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

        

        #endregion
        private void UpdateSubjectCount()
        {
            labelStatusNumberSubjects.Text = subjects.Count.ToString();
        }

        private void lvSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                activSubject = lvSubjects.SelectedItems[0].Tag as Subject;
            }catch { }
        }
    }
}

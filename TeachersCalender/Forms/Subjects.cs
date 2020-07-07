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
    public partial class Subjects : Form
    {
        private List<Subject> subjects = null;
        private SQLInterpretor interpretor;
        private bool isMin = false;
        private bool isMax = false;

        public Subject activSubject = null;

        public Subjects()
        {
            InitializeComponent();
            subjects = new List<Subject>();
            interpretor = new SQLInterpretor();
            lvSubjects.Show();
            btnFilter.Enabled = false;
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

        #region Filter subjects

        private void tbMinRange_Validating(object sender, CancelEventArgs e)
        {
            int value = -1;
            if (String.IsNullOrWhiteSpace(tbMinRange.Text))
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

            if (isMin && isMax)
            {
                btnFilter.Enabled = true;
            }
        }

        private void tbMaxRange_Validating(object sender, CancelEventArgs e)
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
            else if (Int32.TryParse(tbMinRange.Text, out minValue))
            {
                if (value < minValue)
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
            interpretor.SubjectFilter(out subjects, min, max);
            Console.WriteLine(subjects.Count);
            DisplaySubjects();
            ClearFilter();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFilter();

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

        private void Subjects_Load(object sender, EventArgs e)
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

        private void lvSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                activSubject = lvSubjects.SelectedItems[0].Tag as Subject;
            }
            catch { }
        }
    }
}

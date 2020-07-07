namespace TeachersCalender.Forms
{
    partial class AddTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacher));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelStatusNumberTeachers = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbLecture = new System.Windows.Forms.GroupBox();
            this.lbTeacher = new System.Windows.Forms.ListBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.ListBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.ListBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.gbAddTeacher = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvTeachers = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelStatus.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.gbLecture.SuspendLayout();
            this.gbAddTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelStatus.Controls.Add(this.labelStatusNumberTeachers);
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 615);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(5);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(962, 29);
            this.panelStatus.TabIndex = 2;
            // 
            // labelStatusNumberTeachers
            // 
            this.labelStatusNumberTeachers.AutoSize = true;
            this.labelStatusNumberTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusNumberTeachers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStatusNumberTeachers.Location = new System.Drawing.Point(160, 4);
            this.labelStatusNumberTeachers.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatusNumberTeachers.Name = "labelStatusNumberTeachers";
            this.labelStatusNumberTeachers.Size = new System.Drawing.Size(17, 18);
            this.labelStatusNumberTeachers.TabIndex = 1;
            this.labelStatusNumberTeachers.Text = "0";
            this.labelStatusNumberTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStatus.Location = new System.Drawing.Point(0, 0);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(155, 22);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Number of Teachers:";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.UseCompatibleTextRendering = true;
            // 
            // gbAdd
            // 
            this.gbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.gbLecture);
            this.gbAdd.Controls.Add(this.gbAddTeacher);
            this.gbAdd.Controls.Add(this.btnCancel);
            this.gbAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAdd.Location = new System.Drawing.Point(0, 0);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(962, 155);
            this.gbAdd.TabIndex = 3;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(753, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 129);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbLecture
            // 
            this.gbLecture.Controls.Add(this.lbTeacher);
            this.gbLecture.Controls.Add(this.labelTeacher);
            this.gbLecture.Controls.Add(this.lbRoom);
            this.gbLecture.Controls.Add(this.labelRoom);
            this.gbLecture.Controls.Add(this.tbDate);
            this.gbLecture.Controls.Add(this.lbSubject);
            this.gbLecture.Controls.Add(this.labelDate);
            this.gbLecture.Controls.Add(this.labelSubject);
            this.gbLecture.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbLecture.Location = new System.Drawing.Point(314, 26);
            this.gbLecture.Name = "gbLecture";
            this.gbLecture.Size = new System.Drawing.Size(436, 111);
            this.gbLecture.TabIndex = 7;
            this.gbLecture.TabStop = false;
            this.gbLecture.Text = "Lecture";
            // 
            // lbTeacher
            // 
            this.lbTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTeacher.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTeacher.FormattingEnabled = true;
            this.lbTeacher.ItemHeight = 20;
            this.lbTeacher.Location = new System.Drawing.Point(292, 74);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.ScrollAlwaysVisible = true;
            this.lbTeacher.Size = new System.Drawing.Size(119, 22);
            this.lbTeacher.TabIndex = 8;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(212, 74);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(83, 20);
            this.labelTeacher.TabIndex = 7;
            this.labelTeacher.Text = "Teacher:";
            // 
            // lbRoom
            // 
            this.lbRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRoom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbRoom.FormattingEnabled = true;
            this.lbRoom.ItemHeight = 20;
            this.lbRoom.Location = new System.Drawing.Point(93, 74);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.ScrollAlwaysVisible = true;
            this.lbRoom.Size = new System.Drawing.Size(115, 22);
            this.lbRoom.TabIndex = 6;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(24, 74);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(63, 20);
            this.labelRoom.TabIndex = 5;
            this.labelRoom.Text = "Room:";
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbDate.Location = new System.Drawing.Point(270, 28);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(141, 27);
            this.tbDate.TabIndex = 4;
            this.tbDate.Validating += new System.ComponentModel.CancelEventHandler(this.tbDate_Validating);
            this.tbDate.Validated += new System.EventHandler(this.tbDate_Validated);
            // 
            // lbSubject
            // 
            this.lbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lbSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSubject.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbSubject.FormattingEnabled = true;
            this.lbSubject.ItemHeight = 20;
            this.lbSubject.Location = new System.Drawing.Point(93, 31);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.ScrollAlwaysVisible = true;
            this.lbSubject.Size = new System.Drawing.Size(115, 22);
            this.lbSubject.TabIndex = 3;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDate.Location = new System.Drawing.Point(212, 33);
            this.labelDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(55, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelSubject.Location = new System.Drawing.Point(12, 31);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(78, 20);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "Subject:";
            // 
            // gbAddTeacher
            // 
            this.gbAddTeacher.Controls.Add(this.tbName);
            this.gbAddTeacher.Controls.Add(this.labelName);
            this.gbAddTeacher.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbAddTeacher.Location = new System.Drawing.Point(12, 26);
            this.gbAddTeacher.Name = "gbAddTeacher";
            this.gbAddTeacher.Size = new System.Drawing.Size(296, 111);
            this.gbAddTeacher.TabIndex = 6;
            this.gbAddTeacher.TabStop = false;
            this.gbAddTeacher.Text = "Teacher";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbName.Location = new System.Drawing.Point(84, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(186, 27);
            this.tbName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelName.Location = new System.Drawing.Point(18, 51);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(856, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 129);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lvTeachers
            // 
            this.lvTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSubject,
            this.columnDate});
            this.lvTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTeachers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lvTeachers.FullRowSelect = true;
            this.lvTeachers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTeachers.HideSelection = false;
            this.lvTeachers.Location = new System.Drawing.Point(0, 155);
            this.lvTeachers.Margin = new System.Windows.Forms.Padding(0);
            this.lvTeachers.MultiSelect = false;
            this.lvTeachers.Name = "lvTeachers";
            this.lvTeachers.Size = new System.Drawing.Size(962, 460);
            this.lvTeachers.TabIndex = 5;
            this.lvTeachers.UseCompatibleStateImageBehavior = false;
            this.lvTeachers.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 314;
            // 
            // columnSubject
            // 
            this.columnSubject.Text = "Subject";
            this.columnSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSubject.Width = 314;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDate.Width = 330;
            // 
            // errorProv
            // 
            this.errorProv.BlinkRate = 0;
            this.errorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProv.ContainerControl = this;
            this.errorProv.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProv.Icon")));
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(962, 644);
            this.Controls.Add(this.lvTeachers);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.panelStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbLecture.ResumeLayout(false);
            this.gbLecture.PerformLayout();
            this.gbAddTeacher.ResumeLayout(false);
            this.gbAddTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelStatusNumberTeachers;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox gbAddTeacher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbLecture;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.ListBox lbSubject;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.ListBox lbRoom;
        private System.Windows.Forms.ListView lvTeachers;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ListBox lbTeacher;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}
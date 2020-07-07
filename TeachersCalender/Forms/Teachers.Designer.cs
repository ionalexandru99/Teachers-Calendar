namespace TeachersCalender.Forms
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelStatusNumberTeachers = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.lvTeachers = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelStatus.SuspendLayout();
            this.gbFilter.SuspendLayout();
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
            this.panelStatus.TabIndex = 1;
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
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbFilter.Controls.Add(this.tbDate);
            this.gbFilter.Controls.Add(this.labelDate);
            this.gbFilter.Controls.Add(this.tbSubject);
            this.gbFilter.Controls.Add(this.labelSubject);
            this.gbFilter.Controls.Add(this.btnCancel);
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.tbName);
            this.gbFilter.Controls.Add(this.labelName);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(5);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(5);
            this.gbFilter.Size = new System.Drawing.Size(962, 110);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbDate.Location = new System.Drawing.Point(373, 28);
            this.tbDate.Margin = new System.Windows.Forms.Padding(5);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(186, 27);
            this.tbDate.TabIndex = 9;
            this.tbDate.Validating += new System.ComponentModel.CancelEventHandler(this.tbDate_Validating);
            this.tbDate.Validated += new System.EventHandler(this.tbDate_Validated);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(310, 30);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(55, 20);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date:";
            // 
            // tbSubject
            // 
            this.tbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSubject.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbSubject.Location = new System.Drawing.Point(91, 68);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(5);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(186, 27);
            this.tbSubject.TabIndex = 7;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(8, 70);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(78, 20);
            this.labelSubject.TabIndex = 6;
            this.labelSubject.Text = "Subject:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(798, 30);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 60);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(666, 30);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(103, 60);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbName.Location = new System.Drawing.Point(91, 28);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(186, 27);
            this.tbName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelName.Location = new System.Drawing.Point(23, 30);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
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
            this.lvTeachers.Location = new System.Drawing.Point(0, 110);
            this.lvTeachers.Margin = new System.Windows.Forms.Padding(0);
            this.lvTeachers.MultiSelect = false;
            this.lvTeachers.Name = "lvTeachers";
            this.lvTeachers.Size = new System.Drawing.Size(962, 505);
            this.lvTeachers.TabIndex = 4;
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
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(962, 644);
            this.Controls.Add(this.lvTeachers);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.panelStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelStatusNumberTeachers;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListView lvTeachers;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.TextBox tbDate;
    }
}
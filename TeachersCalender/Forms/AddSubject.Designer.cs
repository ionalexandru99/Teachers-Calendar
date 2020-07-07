﻿namespace TeachersCalender.Forms
{
    partial class AddSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelStatusNumberSubjects = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.gbAddRoom = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbCredits = new System.Windows.Forms.TextBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.lvSubjects = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelStatus.SuspendLayout();
            this.gbAddRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelStatus.Controls.Add(this.labelStatusNumberSubjects);
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 615);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(5);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(962, 29);
            this.panelStatus.TabIndex = 3;
            // 
            // labelStatusNumberSubjects
            // 
            this.labelStatusNumberSubjects.AutoSize = true;
            this.labelStatusNumberSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusNumberSubjects.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStatusNumberSubjects.Location = new System.Drawing.Point(160, 4);
            this.labelStatusNumberSubjects.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatusNumberSubjects.Name = "labelStatusNumberSubjects";
            this.labelStatusNumberSubjects.Size = new System.Drawing.Size(17, 18);
            this.labelStatusNumberSubjects.TabIndex = 1;
            this.labelStatusNumberSubjects.Text = "0";
            this.labelStatusNumberSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.labelStatus.Size = new System.Drawing.Size(150, 22);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Number of Subjects:";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.UseCompatibleTextRendering = true;
            // 
            // gbAddRoom
            // 
            this.gbAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbAddRoom.Controls.Add(this.btnCancel);
            this.gbAddRoom.Controls.Add(this.btnAdd);
            this.gbAddRoom.Controls.Add(this.tbCredits);
            this.gbAddRoom.Controls.Add(this.labelCredits);
            this.gbAddRoom.Controls.Add(this.tbName);
            this.gbAddRoom.Controls.Add(this.labelName);
            this.gbAddRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAddRoom.Location = new System.Drawing.Point(0, 0);
            this.gbAddRoom.Name = "gbAddRoom";
            this.gbAddRoom.Size = new System.Drawing.Size(962, 110);
            this.gbAddRoom.TabIndex = 4;
            this.gbAddRoom.TabStop = false;
            this.gbAddRoom.Text = "Add Room";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(798, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 60);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(666, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbCredits
            // 
            this.tbCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCredits.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbCredits.Location = new System.Drawing.Point(148, 68);
            this.tbCredits.Name = "tbCredits";
            this.tbCredits.Size = new System.Drawing.Size(186, 27);
            this.tbCredits.TabIndex = 3;
            this.tbCredits.Validating += new System.ComponentModel.CancelEventHandler(this.tbCredits_Validating);
            this.tbCredits.Validated += new System.EventHandler(this.tbCredits_Validated);
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCredits.Location = new System.Drawing.Point(63, 70);
            this.labelCredits.Margin = new System.Windows.Forms.Padding(0);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(76, 20);
            this.labelCredits.TabIndex = 2;
            this.labelCredits.Text = "Credits:";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbName.Location = new System.Drawing.Point(148, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(186, 27);
            this.tbName.TabIndex = 1;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelName.Location = new System.Drawing.Point(76, 29);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // lvSubjects
            // 
            this.lvSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnCredits});
            this.lvSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSubjects.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lvSubjects.FullRowSelect = true;
            this.lvSubjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSubjects.HideSelection = false;
            this.lvSubjects.Location = new System.Drawing.Point(0, 110);
            this.lvSubjects.Margin = new System.Windows.Forms.Padding(0);
            this.lvSubjects.MultiSelect = false;
            this.lvSubjects.Name = "lvSubjects";
            this.lvSubjects.ShowGroups = false;
            this.lvSubjects.Size = new System.Drawing.Size(962, 505);
            this.lvSubjects.TabIndex = 5;
            this.lvSubjects.UseCompatibleStateImageBehavior = false;
            this.lvSubjects.View = System.Windows.Forms.View.Details;
            this.lvSubjects.SelectedIndexChanged += new System.EventHandler(this.lvSubjects_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 472;
            // 
            // columnCredits
            // 
            this.columnCredits.Text = "Credits";
            this.columnCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCredits.Width = 472;
            // 
            // errorProv
            // 
            this.errorProv.BlinkRate = 0;
            this.errorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProv.ContainerControl = this;
            this.errorProv.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProv.Icon")));
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(962, 644);
            this.Controls.Add(this.lvSubjects);
            this.Controls.Add(this.gbAddRoom);
            this.Controls.Add(this.panelStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.gbAddRoom.ResumeLayout(false);
            this.gbAddRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelStatusNumberSubjects;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox gbAddRoom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbCredits;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListView lvSubjects;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCredits;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}
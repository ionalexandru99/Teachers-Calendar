namespace TeachersCalender.Forms
{
    partial class EditRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRoom));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelStatusNumberRooms = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.gbEditRoom = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.lvRooms = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelStatus.SuspendLayout();
            this.gbEditRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelStatus.Controls.Add(this.labelStatusNumberRooms);
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 615);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(962, 29);
            this.panelStatus.TabIndex = 2;
            // 
            // labelStatusNumberRooms
            // 
            this.labelStatusNumberRooms.AutoSize = true;
            this.labelStatusNumberRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusNumberRooms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStatusNumberRooms.Location = new System.Drawing.Point(145, 4);
            this.labelStatusNumberRooms.Name = "labelStatusNumberRooms";
            this.labelStatusNumberRooms.Size = new System.Drawing.Size(17, 18);
            this.labelStatusNumberRooms.TabIndex = 1;
            this.labelStatusNumberRooms.Text = "0";
            this.labelStatusNumberRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStatus.Location = new System.Drawing.Point(0, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(139, 22);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Number of Rooms:";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.UseCompatibleTextRendering = true;
            // 
            // gbEditRoom
            // 
            this.gbEditRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbEditRoom.Controls.Add(this.btnCancel);
            this.gbEditRoom.Controls.Add(this.btnEdit);
            this.gbEditRoom.Controls.Add(this.tbSize);
            this.gbEditRoom.Controls.Add(this.labelSize);
            this.gbEditRoom.Controls.Add(this.tbName);
            this.gbEditRoom.Controls.Add(this.labelName);
            this.gbEditRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEditRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbEditRoom.Location = new System.Drawing.Point(0, 0);
            this.gbEditRoom.Name = "gbEditRoom";
            this.gbEditRoom.Padding = new System.Windows.Forms.Padding(0);
            this.gbEditRoom.Size = new System.Drawing.Size(962, 110);
            this.gbEditRoom.TabIndex = 3;
            this.gbEditRoom.TabStop = false;
            this.gbEditRoom.Text = "Edit Room";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(801, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 60);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(669, 27);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 60);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbSize
            // 
            this.tbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbSize.Location = new System.Drawing.Point(148, 68);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(186, 27);
            this.tbSize.TabIndex = 3;
            this.tbSize.Validating += new System.ComponentModel.CancelEventHandler(this.tbSize_Validating);
            this.tbSize.Validated += new System.EventHandler(this.tbSize_Validated);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelSize.Location = new System.Drawing.Point(84, 67);
            this.labelSize.Margin = new System.Windows.Forms.Padding(0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(52, 20);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Size:";
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
            this.labelName.Location = new System.Drawing.Point(73, 26);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // lvRooms
            // 
            this.lvRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lvRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSize});
            this.lvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRooms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lvRooms.FullRowSelect = true;
            this.lvRooms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRooms.HideSelection = false;
            this.lvRooms.Location = new System.Drawing.Point(0, 110);
            this.lvRooms.Margin = new System.Windows.Forms.Padding(0);
            this.lvRooms.MultiSelect = false;
            this.lvRooms.Name = "lvRooms";
            this.lvRooms.ShowGroups = false;
            this.lvRooms.Size = new System.Drawing.Size(962, 505);
            this.lvRooms.TabIndex = 4;
            this.lvRooms.UseCompatibleStateImageBehavior = false;
            this.lvRooms.View = System.Windows.Forms.View.Details;
            this.lvRooms.SelectedIndexChanged += new System.EventHandler(this.lvRooms_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 472;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            this.columnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSize.Width = 472;
            // 
            // errorProv
            // 
            this.errorProv.BlinkRate = 0;
            this.errorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProv.ContainerControl = this;
            this.errorProv.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProv.Icon")));
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(962, 644);
            this.Controls.Add(this.lvRooms);
            this.Controls.Add(this.gbEditRoom);
            this.Controls.Add(this.panelStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditRoom";
            this.Text = "EditRoom";
            this.Load += new System.EventHandler(this.EditRoom_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.gbEditRoom.ResumeLayout(false);
            this.gbEditRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelStatusNumberRooms;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox gbEditRoom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListView lvRooms;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}
namespace TeachersCalender.Forms
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelStatusNumberRooms = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tbMaxRange = new System.Windows.Forms.TextBox();
            this.labelMaximum = new System.Windows.Forms.Label();
            this.tbMinRange = new System.Windows.Forms.TextBox();
            this.labelMininum = new System.Windows.Forms.Label();
            this.lvRooms = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbFilter.SuspendLayout();
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
            this.panelStatus.Margin = new System.Windows.Forms.Padding(5);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(962, 29);
            this.panelStatus.TabIndex = 0;
            // 
            // labelStatusNumberRooms
            // 
            this.labelStatusNumberRooms.AutoSize = true;
            this.labelStatusNumberRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusNumberRooms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStatusNumberRooms.Location = new System.Drawing.Point(145, 4);
            this.labelStatusNumberRooms.Margin = new System.Windows.Forms.Padding(0);
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
            this.labelStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(139, 22);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Number of Rooms:";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.gbFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 110);
            this.panel1.TabIndex = 2;
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbFilter.Controls.Add(this.btnCancel);
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.tbMaxRange);
            this.gbFilter.Controls.Add(this.labelMaximum);
            this.gbFilter.Controls.Add(this.tbMinRange);
            this.gbFilter.Controls.Add(this.labelMininum);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(5);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(5);
            this.gbFilter.Size = new System.Drawing.Size(962, 110);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
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
            // tbMaxRange
            // 
            this.tbMaxRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbMaxRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaxRange.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbMaxRange.Location = new System.Drawing.Point(190, 63);
            this.tbMaxRange.Margin = new System.Windows.Forms.Padding(5);
            this.tbMaxRange.Name = "tbMaxRange";
            this.tbMaxRange.Size = new System.Drawing.Size(186, 27);
            this.tbMaxRange.TabIndex = 3;
            this.tbMaxRange.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaxRange_Validating);
            this.tbMaxRange.Validated += new System.EventHandler(this.tbMaxRange_Validated);
            // 
            // labelMaximum
            // 
            this.labelMaximum.AutoSize = true;
            this.labelMaximum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMaximum.Location = new System.Drawing.Point(36, 65);
            this.labelMaximum.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaximum.Name = "labelMaximum";
            this.labelMaximum.Size = new System.Drawing.Size(153, 20);
            this.labelMaximum.TabIndex = 2;
            this.labelMaximum.Text = "Maximum Range:";
            // 
            // tbMinRange
            // 
            this.tbMinRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbMinRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMinRange.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbMinRange.Location = new System.Drawing.Point(190, 23);
            this.tbMinRange.Margin = new System.Windows.Forms.Padding(5);
            this.tbMinRange.Name = "tbMinRange";
            this.tbMinRange.Size = new System.Drawing.Size(186, 27);
            this.tbMinRange.TabIndex = 1;
            this.tbMinRange.Validating += new System.ComponentModel.CancelEventHandler(this.tbMinRange_Validating);
            this.tbMinRange.Validated += new System.EventHandler(this.tbMinRange_Validated);
            // 
            // labelMininum
            // 
            this.labelMininum.AutoSize = true;
            this.labelMininum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMininum.Location = new System.Drawing.Point(36, 25);
            this.labelMininum.Margin = new System.Windows.Forms.Padding(0);
            this.labelMininum.Name = "labelMininum";
            this.labelMininum.Size = new System.Drawing.Size(149, 20);
            this.labelMininum.TabIndex = 0;
            this.labelMininum.Text = "Minimum Range:";
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
            this.lvRooms.TabIndex = 3;
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
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(962, 644);
            this.Controls.Add(this.lvRooms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelStatusNumberRooms;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvRooms;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox tbMaxRange;
        private System.Windows.Forms.Label labelMaximum;
        private System.Windows.Forms.TextBox tbMinRange;
        private System.Windows.Forms.Label labelMininum;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}
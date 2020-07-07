namespace TeachersCalender
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panelSubjects = new System.Windows.Forms.Panel();
            this.btnSubjectsDelete = new System.Windows.Forms.Button();
            this.btnSubjectsEdit = new System.Windows.Forms.Button();
            this.btnSubjectsAdd = new System.Windows.Forms.Button();
            this.btnSubjectsDeserialize = new System.Windows.Forms.Button();
            this.btnSubjectsSerialize = new System.Windows.Forms.Button();
            this.btnSubjectsShow = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.panelTeachers = new System.Windows.Forms.Panel();
            this.btnTeachersAdd = new System.Windows.Forms.Button();
            this.btnTeachersDeserialize = new System.Windows.Forms.Button();
            this.btnTeachersSerialize = new System.Windows.Forms.Button();
            this.btnTeachersShow = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.btnRoomsDelete = new System.Windows.Forms.Button();
            this.btnRoomsEdit = new System.Windows.Forms.Button();
            this.btnRoomsAdd = new System.Windows.Forms.Button();
            this.btnRoomsDeserialize = new System.Windows.Forms.Button();
            this.btnRoomsSerialize = new System.Windows.Forms.Button();
            this.btnRoomsShow = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.panelSubjects.SuspendLayout();
            this.panelTeachers.SuspendLayout();
            this.panelRooms.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.MenuText;
            this.menuPanel.Controls.Add(this.btnExit);
            this.menuPanel.Controls.Add(this.imagePanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1200, 36);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::TeachersCalender.Properties.Resources.exitIcon_35x35;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1165, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.BackgroundImage = global::TeachersCalender.Properties.Resources.logo_transparent_35x35;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(35, 36);
            this.imagePanel.TabIndex = 0;
            this.imagePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseClick);
            // 
            // sidePanel
            // 
            this.sidePanel.AllowDrop = true;
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sidePanel.Controls.Add(this.panelSubjects);
            this.sidePanel.Controls.Add(this.btnSubjects);
            this.sidePanel.Controls.Add(this.panelTeachers);
            this.sidePanel.Controls.Add(this.btnTeachers);
            this.sidePanel.Controls.Add(this.panelRooms);
            this.sidePanel.Controls.Add(this.btnRooms);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 36);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(238, 644);
            this.sidePanel.TabIndex = 1;
            // 
            // panelSubjects
            // 
            this.panelSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelSubjects.Controls.Add(this.btnSubjectsDelete);
            this.panelSubjects.Controls.Add(this.btnSubjectsEdit);
            this.panelSubjects.Controls.Add(this.btnSubjectsAdd);
            this.panelSubjects.Controls.Add(this.btnSubjectsDeserialize);
            this.panelSubjects.Controls.Add(this.btnSubjectsSerialize);
            this.panelSubjects.Controls.Add(this.btnSubjectsShow);
            this.panelSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubjects.Location = new System.Drawing.Point(0, 567);
            this.panelSubjects.Margin = new System.Windows.Forms.Padding(0);
            this.panelSubjects.Name = "panelSubjects";
            this.panelSubjects.Size = new System.Drawing.Size(217, 245);
            this.panelSubjects.TabIndex = 6;
            // 
            // btnSubjectsDelete
            // 
            this.btnSubjectsDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjectsDelete.FlatAppearance.BorderSize = 0;
            this.btnSubjectsDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSubjectsDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSubjectsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectsDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubjectsDelete.Location = new System.Drawing.Point(0, 200);
            this.btnSubjectsDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectsDelete.Name = "btnSubjectsDelete";
            this.btnSubjectsDelete.Size = new System.Drawing.Size(217, 40);
            this.btnSubjectsDelete.TabIndex = 5;
            this.btnSubjectsDelete.Text = "Delete";
            this.btnSubjectsDelete.UseVisualStyleBackColor = true;
            this.btnSubjectsDelete.Click += new System.EventHandler(this.btnSubjectsDelete_Click);
            // 
            // btnSubjectsEdit
            // 
            this.btnSubjectsEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjectsEdit.FlatAppearance.BorderSize = 0;
            this.btnSubjectsEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSubjectsEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSubjectsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectsEdit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubjectsEdit.Location = new System.Drawing.Point(0, 160);
            this.btnSubjectsEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectsEdit.Name = "btnSubjectsEdit";
            this.btnSubjectsEdit.Size = new System.Drawing.Size(217, 40);
            this.btnSubjectsEdit.TabIndex = 4;
            this.btnSubjectsEdit.Text = "Edit";
            this.btnSubjectsEdit.UseVisualStyleBackColor = true;
            this.btnSubjectsEdit.Click += new System.EventHandler(this.btnSubjectsEdit_Click);
            // 
            // btnSubjectsAdd
            // 
            this.btnSubjectsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjectsAdd.FlatAppearance.BorderSize = 0;
            this.btnSubjectsAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSubjectsAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSubjectsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectsAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubjectsAdd.Location = new System.Drawing.Point(0, 120);
            this.btnSubjectsAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectsAdd.Name = "btnSubjectsAdd";
            this.btnSubjectsAdd.Size = new System.Drawing.Size(217, 40);
            this.btnSubjectsAdd.TabIndex = 3;
            this.btnSubjectsAdd.Text = "Add";
            this.btnSubjectsAdd.UseVisualStyleBackColor = true;
            this.btnSubjectsAdd.Click += new System.EventHandler(this.btnSubjectsAdd_Click);
            // 
            // btnSubjectsDeserialize
            // 
            this.btnSubjectsDeserialize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjectsDeserialize.FlatAppearance.BorderSize = 0;
            this.btnSubjectsDeserialize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSubjectsDeserialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSubjectsDeserialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectsDeserialize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubjectsDeserialize.Location = new System.Drawing.Point(0, 80);
            this.btnSubjectsDeserialize.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectsDeserialize.Name = "btnSubjectsDeserialize";
            this.btnSubjectsDeserialize.Size = new System.Drawing.Size(217, 40);
            this.btnSubjectsDeserialize.TabIndex = 2;
            this.btnSubjectsDeserialize.Text = "Deserialize";
            this.btnSubjectsDeserialize.UseVisualStyleBackColor = true;
            this.btnSubjectsDeserialize.Click += new System.EventHandler(this.btnSubjectsDeserialize_Click);
            // 
            // btnSubjectsSerialize
            // 
            this.btnSubjectsSerialize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjectsSerialize.FlatAppearance.BorderSize = 0;
            this.btnSubjectsSerialize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSubjectsSerialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSubjectsSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectsSerialize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubjectsSerialize.Location = new System.Drawing.Point(0, 40);
            this.btnSubjectsSerialize.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectsSerialize.Name = "btnSubjectsSerialize";
            this.btnSubjectsSerialize.Size = new System.Drawing.Size(217, 40);
            this.btnSubjectsSerialize.TabIndex = 1;
            this.btnSubjectsSerialize.Text = "Serialize";
            this.btnSubjectsSerialize.UseVisualStyleBackColor = true;
            this.btnSubjectsSerialize.Click += new System.EventHandler(this.btnSubjectsSerialize_Click);
            // 
            // btnSubjectsShow
            // 
            this.btnSubjectsShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjectsShow.FlatAppearance.BorderSize = 0;
            this.btnSubjectsShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSubjectsShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSubjectsShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectsShow.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubjectsShow.Location = new System.Drawing.Point(0, 0);
            this.btnSubjectsShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectsShow.Name = "btnSubjectsShow";
            this.btnSubjectsShow.Size = new System.Drawing.Size(217, 40);
            this.btnSubjectsShow.TabIndex = 0;
            this.btnSubjectsShow.Text = "Show";
            this.btnSubjectsShow.UseVisualStyleBackColor = true;
            this.btnSubjectsShow.Click += new System.EventHandler(this.btnSubjectsShow_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjects.FlatAppearance.BorderSize = 0;
            this.btnSubjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSubjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSubjects.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubjects.Location = new System.Drawing.Point(0, 517);
            this.btnSubjects.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(217, 50);
            this.btnSubjects.TabIndex = 5;
            this.btnSubjects.Text = "Subjects";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // panelTeachers
            // 
            this.panelTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelTeachers.Controls.Add(this.btnTeachersAdd);
            this.panelTeachers.Controls.Add(this.btnTeachersDeserialize);
            this.panelTeachers.Controls.Add(this.btnTeachersSerialize);
            this.panelTeachers.Controls.Add(this.btnTeachersShow);
            this.panelTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTeachers.Location = new System.Drawing.Point(0, 345);
            this.panelTeachers.Margin = new System.Windows.Forms.Padding(0);
            this.panelTeachers.Name = "panelTeachers";
            this.panelTeachers.Size = new System.Drawing.Size(217, 172);
            this.panelTeachers.TabIndex = 4;
            // 
            // btnTeachersAdd
            // 
            this.btnTeachersAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachersAdd.FlatAppearance.BorderSize = 0;
            this.btnTeachersAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTeachersAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTeachersAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachersAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTeachersAdd.Location = new System.Drawing.Point(0, 120);
            this.btnTeachersAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeachersAdd.Name = "btnTeachersAdd";
            this.btnTeachersAdd.Size = new System.Drawing.Size(217, 40);
            this.btnTeachersAdd.TabIndex = 3;
            this.btnTeachersAdd.Text = "Add";
            this.btnTeachersAdd.UseVisualStyleBackColor = true;
            this.btnTeachersAdd.Click += new System.EventHandler(this.btnTeachersAdd_Click);
            // 
            // btnTeachersDeserialize
            // 
            this.btnTeachersDeserialize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachersDeserialize.FlatAppearance.BorderSize = 0;
            this.btnTeachersDeserialize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTeachersDeserialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTeachersDeserialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachersDeserialize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTeachersDeserialize.Location = new System.Drawing.Point(0, 80);
            this.btnTeachersDeserialize.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeachersDeserialize.Name = "btnTeachersDeserialize";
            this.btnTeachersDeserialize.Size = new System.Drawing.Size(217, 40);
            this.btnTeachersDeserialize.TabIndex = 2;
            this.btnTeachersDeserialize.Text = "Deserialize";
            this.btnTeachersDeserialize.UseVisualStyleBackColor = true;
            this.btnTeachersDeserialize.Click += new System.EventHandler(this.btnTeachersDeserialize_Click);
            // 
            // btnTeachersSerialize
            // 
            this.btnTeachersSerialize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachersSerialize.FlatAppearance.BorderSize = 0;
            this.btnTeachersSerialize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTeachersSerialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTeachersSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachersSerialize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTeachersSerialize.Location = new System.Drawing.Point(0, 40);
            this.btnTeachersSerialize.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeachersSerialize.Name = "btnTeachersSerialize";
            this.btnTeachersSerialize.Size = new System.Drawing.Size(217, 40);
            this.btnTeachersSerialize.TabIndex = 1;
            this.btnTeachersSerialize.Text = "Serialize";
            this.btnTeachersSerialize.UseVisualStyleBackColor = true;
            this.btnTeachersSerialize.Click += new System.EventHandler(this.btnTeachersSerialize_Click);
            // 
            // btnTeachersShow
            // 
            this.btnTeachersShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachersShow.FlatAppearance.BorderSize = 0;
            this.btnTeachersShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTeachersShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTeachersShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachersShow.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTeachersShow.Location = new System.Drawing.Point(0, 0);
            this.btnTeachersShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeachersShow.Name = "btnTeachersShow";
            this.btnTeachersShow.Size = new System.Drawing.Size(217, 40);
            this.btnTeachersShow.TabIndex = 0;
            this.btnTeachersShow.Text = "Show";
            this.btnTeachersShow.UseVisualStyleBackColor = true;
            this.btnTeachersShow.Click += new System.EventHandler(this.btnTeachersShow_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnTeachers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTeachers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTeachers.Location = new System.Drawing.Point(0, 295);
            this.btnTeachers.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(217, 50);
            this.btnTeachers.TabIndex = 3;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // panelRooms
            // 
            this.panelRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelRooms.Controls.Add(this.btnRoomsDelete);
            this.panelRooms.Controls.Add(this.btnRoomsEdit);
            this.panelRooms.Controls.Add(this.btnRoomsAdd);
            this.panelRooms.Controls.Add(this.btnRoomsDeserialize);
            this.panelRooms.Controls.Add(this.btnRoomsSerialize);
            this.panelRooms.Controls.Add(this.btnRoomsShow);
            this.panelRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRooms.Location = new System.Drawing.Point(0, 50);
            this.panelRooms.Margin = new System.Windows.Forms.Padding(0);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(217, 245);
            this.panelRooms.TabIndex = 2;
            // 
            // btnRoomsDelete
            // 
            this.btnRoomsDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomsDelete.FlatAppearance.BorderSize = 0;
            this.btnRoomsDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRoomsDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRoomsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomsDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRoomsDelete.Location = new System.Drawing.Point(0, 200);
            this.btnRoomsDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomsDelete.Name = "btnRoomsDelete";
            this.btnRoomsDelete.Size = new System.Drawing.Size(217, 40);
            this.btnRoomsDelete.TabIndex = 5;
            this.btnRoomsDelete.Text = "Delete";
            this.btnRoomsDelete.UseVisualStyleBackColor = true;
            this.btnRoomsDelete.Click += new System.EventHandler(this.btnRoomsDelete_Click);
            // 
            // btnRoomsEdit
            // 
            this.btnRoomsEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomsEdit.FlatAppearance.BorderSize = 0;
            this.btnRoomsEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRoomsEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRoomsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomsEdit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRoomsEdit.Location = new System.Drawing.Point(0, 160);
            this.btnRoomsEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomsEdit.Name = "btnRoomsEdit";
            this.btnRoomsEdit.Size = new System.Drawing.Size(217, 40);
            this.btnRoomsEdit.TabIndex = 4;
            this.btnRoomsEdit.Text = "Edit";
            this.btnRoomsEdit.UseVisualStyleBackColor = true;
            this.btnRoomsEdit.Click += new System.EventHandler(this.btnRoomsEdit_Click);
            // 
            // btnRoomsAdd
            // 
            this.btnRoomsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomsAdd.FlatAppearance.BorderSize = 0;
            this.btnRoomsAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRoomsAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRoomsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomsAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRoomsAdd.Location = new System.Drawing.Point(0, 120);
            this.btnRoomsAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomsAdd.Name = "btnRoomsAdd";
            this.btnRoomsAdd.Size = new System.Drawing.Size(217, 40);
            this.btnRoomsAdd.TabIndex = 3;
            this.btnRoomsAdd.Text = "Add";
            this.btnRoomsAdd.UseVisualStyleBackColor = true;
            this.btnRoomsAdd.Click += new System.EventHandler(this.btnRoomsAdd_Click);
            // 
            // btnRoomsDeserialize
            // 
            this.btnRoomsDeserialize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomsDeserialize.FlatAppearance.BorderSize = 0;
            this.btnRoomsDeserialize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRoomsDeserialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRoomsDeserialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomsDeserialize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRoomsDeserialize.Location = new System.Drawing.Point(0, 80);
            this.btnRoomsDeserialize.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomsDeserialize.Name = "btnRoomsDeserialize";
            this.btnRoomsDeserialize.Size = new System.Drawing.Size(217, 40);
            this.btnRoomsDeserialize.TabIndex = 2;
            this.btnRoomsDeserialize.Text = "Deserialize";
            this.btnRoomsDeserialize.UseVisualStyleBackColor = true;
            this.btnRoomsDeserialize.Click += new System.EventHandler(this.btnRoomsDeserialize_Click);
            // 
            // btnRoomsSerialize
            // 
            this.btnRoomsSerialize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomsSerialize.FlatAppearance.BorderSize = 0;
            this.btnRoomsSerialize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRoomsSerialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRoomsSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomsSerialize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRoomsSerialize.Location = new System.Drawing.Point(0, 40);
            this.btnRoomsSerialize.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomsSerialize.Name = "btnRoomsSerialize";
            this.btnRoomsSerialize.Size = new System.Drawing.Size(217, 40);
            this.btnRoomsSerialize.TabIndex = 1;
            this.btnRoomsSerialize.Text = "Serialize";
            this.btnRoomsSerialize.UseVisualStyleBackColor = true;
            this.btnRoomsSerialize.Click += new System.EventHandler(this.btnRoomsSerialize_Click);
            // 
            // btnRoomsShow
            // 
            this.btnRoomsShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomsShow.FlatAppearance.BorderSize = 0;
            this.btnRoomsShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRoomsShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRoomsShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomsShow.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRoomsShow.Location = new System.Drawing.Point(0, 0);
            this.btnRoomsShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomsShow.Name = "btnRoomsShow";
            this.btnRoomsShow.Size = new System.Drawing.Size(217, 40);
            this.btnRoomsShow.TabIndex = 0;
            this.btnRoomsShow.Text = "Show";
            this.btnRoomsShow.UseVisualStyleBackColor = true;
            this.btnRoomsShow.Click += new System.EventHandler(this.btnRoomsShow_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRooms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRooms.Location = new System.Drawing.Point(0, 0);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(0);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(217, 50);
            this.btnRooms.TabIndex = 1;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(238, 36);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(962, 644);
            this.panelForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::TeachersCalender.Properties.Resources.logo_transparent_350x350;
            this.pictureBox1.ErrorImage = global::TeachersCalender.Properties.Resources.logoTransparent;
            this.pictureBox1.Location = new System.Drawing.Point(330, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.menuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 680);
            this.Name = "MainForm";
            this.Text = "Teachers Calendar";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.panelSubjects.ResumeLayout(false);
            this.panelTeachers.ResumeLayout(false);
            this.panelRooms.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.Button btnRoomsDelete;
        private System.Windows.Forms.Button btnRoomsEdit;
        private System.Windows.Forms.Button btnRoomsAdd;
        private System.Windows.Forms.Button btnRoomsDeserialize;
        private System.Windows.Forms.Button btnRoomsSerialize;
        private System.Windows.Forms.Button btnRoomsShow;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Panel panelTeachers;
        private System.Windows.Forms.Button btnTeachersAdd;
        private System.Windows.Forms.Button btnTeachersDeserialize;
        private System.Windows.Forms.Button btnTeachersSerialize;
        private System.Windows.Forms.Button btnTeachersShow;
        private System.Windows.Forms.Panel panelSubjects;
        private System.Windows.Forms.Button btnSubjectsDelete;
        private System.Windows.Forms.Button btnSubjectsEdit;
        private System.Windows.Forms.Button btnSubjectsAdd;
        private System.Windows.Forms.Button btnSubjectsDeserialize;
        private System.Windows.Forms.Button btnSubjectsSerialize;
        private System.Windows.Forms.Button btnSubjectsShow;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


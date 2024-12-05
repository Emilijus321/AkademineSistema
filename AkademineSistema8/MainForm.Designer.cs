namespace AkademineSistema8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddSubjectBtn = new System.Windows.Forms.Button();
            this.AddGroupBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AddTeachers_Btn = new System.Windows.Forms.Button();
            this.AddStudents_Btn = new System.Windows.Forms.Button();
            this.Dashboard_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addSubjectForm1 = new AkademineSistema8.AddSubjectForm();
            this.addGroupForm1 = new AkademineSistema8.AddGroupForm();
            this.dashboardForm1 = new AkademineSistema8.DashboardForm();
            this.addStudentForm1 = new AkademineSistema8.AddStudentForm();
            this.addTeacherForm1 = new AkademineSistema8.AddTeacherForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 38);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(1069, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Akademinė Sistema | Main Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.AddSubjectBtn);
            this.panel2.Controls.Add(this.AddGroupBtn);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.AddTeachers_Btn);
            this.panel2.Controls.Add(this.AddStudents_Btn);
            this.panel2.Controls.Add(this.Dashboard_Btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 562);
            this.panel2.TabIndex = 1;
            // 
            // AddSubjectBtn
            // 
            this.AddSubjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSubjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddSubjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddSubjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSubjectBtn.ForeColor = System.Drawing.Color.White;
            this.AddSubjectBtn.Image = global::AkademineSistema8.Properties.Resources.photo20;
            this.AddSubjectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSubjectBtn.Location = new System.Drawing.Point(13, 416);
            this.AddSubjectBtn.Name = "AddSubjectBtn";
            this.AddSubjectBtn.Size = new System.Drawing.Size(242, 40);
            this.AddSubjectBtn.TabIndex = 8;
            this.AddSubjectBtn.Text = "Add Subject";
            this.AddSubjectBtn.UseVisualStyleBackColor = true;
            this.AddSubjectBtn.Click += new System.EventHandler(this.AddSubjectBtn_Click);
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGroupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddGroupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddGroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGroupBtn.ForeColor = System.Drawing.Color.White;
            this.AddGroupBtn.Image = global::AkademineSistema8.Properties.Resources.photo19;
            this.AddGroupBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddGroupBtn.Location = new System.Drawing.Point(13, 361);
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.Size = new System.Drawing.Size(242, 40);
            this.AddGroupBtn.TabIndex = 6;
            this.AddGroupBtn.Text = "Add Group";
            this.AddGroupBtn.UseVisualStyleBackColor = true;
            this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 528);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddTeachers_Btn
            // 
            this.AddTeachers_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeachers_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddTeachers_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddTeachers_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeachers_Btn.ForeColor = System.Drawing.Color.White;
            this.AddTeachers_Btn.Image = global::AkademineSistema8.Properties.Resources.photo9;
            this.AddTeachers_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTeachers_Btn.Location = new System.Drawing.Point(12, 305);
            this.AddTeachers_Btn.Name = "AddTeachers_Btn";
            this.AddTeachers_Btn.Size = new System.Drawing.Size(242, 40);
            this.AddTeachers_Btn.TabIndex = 4;
            this.AddTeachers_Btn.Text = "Add Teachers";
            this.AddTeachers_Btn.UseVisualStyleBackColor = true;
            this.AddTeachers_Btn.Click += new System.EventHandler(this.AddTeachers_Btn_Click);
            // 
            // AddStudents_Btn
            // 
            this.AddStudents_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudents_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddStudents_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddStudents_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudents_Btn.ForeColor = System.Drawing.Color.White;
            this.AddStudents_Btn.Image = global::AkademineSistema8.Properties.Resources.photo8;
            this.AddStudents_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudents_Btn.Location = new System.Drawing.Point(12, 249);
            this.AddStudents_Btn.Name = "AddStudents_Btn";
            this.AddStudents_Btn.Size = new System.Drawing.Size(242, 40);
            this.AddStudents_Btn.TabIndex = 3;
            this.AddStudents_Btn.Text = "Add Students";
            this.AddStudents_Btn.UseVisualStyleBackColor = true;
            this.AddStudents_Btn.Click += new System.EventHandler(this.AddStudents_Btn_Click);
            // 
            // Dashboard_Btn
            // 
            this.Dashboard_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Dashboard_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Dashboard_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_Btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_Btn.Image = global::AkademineSistema8.Properties.Resources.photo7;
            this.Dashboard_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard_Btn.Location = new System.Drawing.Point(12, 192);
            this.Dashboard_Btn.Name = "Dashboard_Btn";
            this.Dashboard_Btn.Size = new System.Drawing.Size(242, 40);
            this.Dashboard_Btn.TabIndex = 2;
            this.Dashboard_Btn.Text = "Dashboard";
            this.Dashboard_Btn.UseVisualStyleBackColor = true;
            this.Dashboard_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AkademineSistema8.Properties.Resources.photo5;
            this.pictureBox1.Location = new System.Drawing.Point(89, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addSubjectForm1);
            this.panel3.Controls.Add(this.addGroupForm1);
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Controls.Add(this.addStudentForm1);
            this.panel3.Controls.Add(this.addTeacherForm1);
            this.panel3.Location = new System.Drawing.Point(272, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(828, 570);
            this.panel3.TabIndex = 2;
            // 
            // addSubjectForm1
            // 
            this.addSubjectForm1.Location = new System.Drawing.Point(0, 0);
            this.addSubjectForm1.Name = "addSubjectForm1";
            this.addSubjectForm1.Size = new System.Drawing.Size(828, 570);
            this.addSubjectForm1.TabIndex = 4;
            // 
            // addGroupForm1
            // 
            this.addGroupForm1.Location = new System.Drawing.Point(0, 0);
            this.addGroupForm1.Name = "addGroupForm1";
            this.addGroupForm1.Size = new System.Drawing.Size(828, 570);
            this.addGroupForm1.TabIndex = 3;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(828, 570);
            this.dashboardForm1.TabIndex = 2;
            // 
            // addStudentForm1
            // 
            this.addStudentForm1.Location = new System.Drawing.Point(0, 0);
            this.addStudentForm1.Name = "addStudentForm1";
            this.addStudentForm1.Size = new System.Drawing.Size(828, 570);
            this.addStudentForm1.TabIndex = 1;
            // 
            // addTeacherForm1
            // 
            this.addTeacherForm1.Location = new System.Drawing.Point(0, 0);
            this.addTeacherForm1.Name = "addTeacherForm1";
            this.addTeacherForm1.Size = new System.Drawing.Size(828, 570);
            this.addTeacherForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AddTeachers_Btn;
        private System.Windows.Forms.Button AddStudents_Btn;
        private System.Windows.Forms.Button Dashboard_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private AddTeacherForm addTeacherForm1;
        private AddStudentForm addStudentForm1;
        private DashboardForm dashboardForm1;
        private System.Windows.Forms.Button AddGroupBtn;
        private AddGroupForm addGroupForm1;
        private System.Windows.Forms.Button AddSubjectBtn;
        private AddSubjectForm addSubjectForm1;
    }
}
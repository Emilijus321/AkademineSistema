namespace AkademineSistema8
{
    partial class AddStudentForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.student_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.TextBox();
            this.student_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.student_group = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.student_usertype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.student_deleteBtn = new System.Windows.Forms.Button();
            this.student_clearBtn = new System.Windows.Forms.Button();
            this.student_updateBtn = new System.Windows.Forms.Button();
            this.student_addBtn = new System.Windows.Forms.Button();
            this.student_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.student_studentData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.school1DataSet = new AkademineSistema8.school1DataSet();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new AkademineSistema8.school1DataSetTableAdapters.groupTableAdapter();
            this.groupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_studentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.student_status);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.student_id);
            this.panel2.Controls.Add(this.student_name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.student_group);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.student_usertype);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.student_deleteBtn);
            this.panel2.Controls.Add(this.student_clearBtn);
            this.panel2.Controls.Add(this.student_updateBtn);
            this.panel2.Controls.Add(this.student_addBtn);
            this.panel2.Controls.Add(this.student_surname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 231);
            this.panel2.TabIndex = 3;
            // 
            // student_status
            // 
            this.student_status.FormattingEnabled = true;
            this.student_status.Items.AddRange(new object[] {
            "Enrolled",
            "Pending",
            "Graduated"});
            this.student_status.Location = new System.Drawing.Point(433, 110);
            this.student_status.Name = "student_status";
            this.student_status.Size = new System.Drawing.Size(157, 24);
            this.student_status.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Student Status:";
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(139, 17);
            this.student_id.Multiline = true;
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(157, 25);
            this.student_id.TabIndex = 28;
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(139, 62);
            this.student_name.Multiline = true;
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(157, 25);
            this.student_name.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Student Name:";
            // 
            // student_group
            // 
            this.student_group.FormattingEnabled = true;
            this.student_group.Items.AddRange(new object[] {
            "PI23A",
            "PI23B",
            "PI23C",
            "PI24"});
            this.student_group.Location = new System.Drawing.Point(433, 64);
            this.student_group.Name = "student_group";
            this.student_group.Size = new System.Drawing.Size(157, 24);
            this.student_group.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Student Group:";
            // 
            // student_usertype
            // 
            this.student_usertype.FormattingEnabled = true;
            this.student_usertype.Items.AddRange(new object[] {
            "Student"});
            this.student_usertype.Location = new System.Drawing.Point(433, 22);
            this.student_usertype.Name = "student_usertype";
            this.student_usertype.Size = new System.Drawing.Size(157, 24);
            this.student_usertype.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student Usertype:";
            // 
            // student_deleteBtn
            // 
            this.student_deleteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.student_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_deleteBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.student_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.student_deleteBtn.Location = new System.Drawing.Point(548, 160);
            this.student_deleteBtn.Name = "student_deleteBtn";
            this.student_deleteBtn.Size = new System.Drawing.Size(122, 51);
            this.student_deleteBtn.TabIndex = 13;
            this.student_deleteBtn.Text = "Delete";
            this.student_deleteBtn.UseVisualStyleBackColor = false;
            this.student_deleteBtn.Click += new System.EventHandler(this.student_deleteBtn_Click);
            // 
            // student_clearBtn
            // 
            this.student_clearBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.student_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_clearBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.student_clearBtn.ForeColor = System.Drawing.Color.White;
            this.student_clearBtn.Location = new System.Drawing.Point(410, 160);
            this.student_clearBtn.Name = "student_clearBtn";
            this.student_clearBtn.Size = new System.Drawing.Size(122, 51);
            this.student_clearBtn.TabIndex = 12;
            this.student_clearBtn.Text = "Clear";
            this.student_clearBtn.UseVisualStyleBackColor = false;
            this.student_clearBtn.Click += new System.EventHandler(this.student_clearBtn_Click);
            // 
            // student_updateBtn
            // 
            this.student_updateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.student_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_updateBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.student_updateBtn.ForeColor = System.Drawing.Color.White;
            this.student_updateBtn.Location = new System.Drawing.Point(271, 160);
            this.student_updateBtn.Name = "student_updateBtn";
            this.student_updateBtn.Size = new System.Drawing.Size(122, 51);
            this.student_updateBtn.TabIndex = 11;
            this.student_updateBtn.Text = "Update";
            this.student_updateBtn.UseVisualStyleBackColor = false;
            this.student_updateBtn.Click += new System.EventHandler(this.student_updateBtn_Click);
            // 
            // student_addBtn
            // 
            this.student_addBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.student_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_addBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.student_addBtn.ForeColor = System.Drawing.Color.White;
            this.student_addBtn.Location = new System.Drawing.Point(133, 160);
            this.student_addBtn.Name = "student_addBtn";
            this.student_addBtn.Size = new System.Drawing.Size(122, 51);
            this.student_addBtn.TabIndex = 10;
            this.student_addBtn.Text = "Add";
            this.student_addBtn.UseVisualStyleBackColor = false;
            this.student_addBtn.Click += new System.EventHandler(this.student_addBtn_Click);
            // 
            // student_surname
            // 
            this.student_surname.Location = new System.Drawing.Point(139, 104);
            this.student_surname.Multiline = true;
            this.student_surname.Name = "student_surname";
            this.student_surname.Size = new System.Drawing.Size(157, 25);
            this.student_surname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Surname :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.student_studentData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 296);
            this.panel1.TabIndex = 2;
            // 
            // student_studentData
            // 
            this.student_studentData.AllowUserToAddRows = false;
            this.student_studentData.AllowUserToDeleteRows = false;
            this.student_studentData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.student_studentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.student_studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_studentData.EnableHeadersVisualStyles = false;
            this.student_studentData.Location = new System.Drawing.Point(21, 54);
            this.student_studentData.Name = "student_studentData";
            this.student_studentData.ReadOnly = true;
            this.student_studentData.RowHeadersVisible = false;
            this.student_studentData.RowHeadersWidth = 51;
            this.student_studentData.RowTemplate.Height = 24;
            this.student_studentData.Size = new System.Drawing.Size(765, 228);
            this.student_studentData.TabIndex = 4;
            this.student_studentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_studentData_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Data";
            // 
            // school1DataSet
            // 
            this.school1DataSet.DataSetName = "school1DataSet";
            this.school1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "group";
            this.groupBindingSource.DataSource = this.school1DataSet;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // groupBindingSource1
            // 
            this.groupBindingSource1.DataMember = "group";
            this.groupBindingSource1.DataSource = this.school1DataSet;
            // 
            // groupBindingSource2
            // 
            this.groupBindingSource2.DataMember = "group";
            this.groupBindingSource2.DataSource = this.school1DataSet;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudentForm";
            this.Size = new System.Drawing.Size(828, 570);
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_studentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button student_deleteBtn;
        private System.Windows.Forms.Button student_clearBtn;
        private System.Windows.Forms.Button student_updateBtn;
        private System.Windows.Forms.Button student_addBtn;
        private System.Windows.Forms.TextBox student_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox student_group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox student_usertype;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView student_studentData;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private school1DataSet school1DataSet;
        private school1DataSetTableAdapters.groupTableAdapter groupTableAdapter;
        private System.Windows.Forms.BindingSource groupBindingSource1;
        private System.Windows.Forms.BindingSource groupBindingSource2;
        private System.Windows.Forms.ComboBox student_status;
        private System.Windows.Forms.Label label5;
    }
}

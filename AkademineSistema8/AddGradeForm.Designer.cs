namespace AkademineSistema8
{
    partial class AddGradeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grade_deleteBtn = new System.Windows.Forms.Button();
            this.grade_clearBtn = new System.Windows.Forms.Button();
            this.grade_updateBtn = new System.Windows.Forms.Button();
            this.grade_addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grade_gridData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grade_student = new System.Windows.Forms.ComboBox();
            this.grade_subject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grade_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grade_gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grade_id);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.grade);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.grade_subject);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.grade_student);
            this.panel2.Controls.Add(this.grade_deleteBtn);
            this.panel2.Controls.Add(this.grade_clearBtn);
            this.panel2.Controls.Add(this.grade_updateBtn);
            this.panel2.Controls.Add(this.grade_addBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 231);
            this.panel2.TabIndex = 7;
            // 
            // grade_deleteBtn
            // 
            this.grade_deleteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grade_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grade_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grade_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grade_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grade_deleteBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.grade_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.grade_deleteBtn.Location = new System.Drawing.Point(548, 160);
            this.grade_deleteBtn.Name = "grade_deleteBtn";
            this.grade_deleteBtn.Size = new System.Drawing.Size(122, 51);
            this.grade_deleteBtn.TabIndex = 13;
            this.grade_deleteBtn.Text = "Delete";
            this.grade_deleteBtn.UseVisualStyleBackColor = false;
            this.grade_deleteBtn.Click += new System.EventHandler(this.grade_deleteBtn_Click);
            // 
            // grade_clearBtn
            // 
            this.grade_clearBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grade_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grade_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grade_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grade_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grade_clearBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.grade_clearBtn.ForeColor = System.Drawing.Color.White;
            this.grade_clearBtn.Location = new System.Drawing.Point(410, 160);
            this.grade_clearBtn.Name = "grade_clearBtn";
            this.grade_clearBtn.Size = new System.Drawing.Size(122, 51);
            this.grade_clearBtn.TabIndex = 12;
            this.grade_clearBtn.Text = "Clear";
            this.grade_clearBtn.UseVisualStyleBackColor = false;
            this.grade_clearBtn.Click += new System.EventHandler(this.grade_clearBtn_Click);
            // 
            // grade_updateBtn
            // 
            this.grade_updateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grade_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grade_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grade_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grade_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grade_updateBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.grade_updateBtn.ForeColor = System.Drawing.Color.White;
            this.grade_updateBtn.Location = new System.Drawing.Point(271, 160);
            this.grade_updateBtn.Name = "grade_updateBtn";
            this.grade_updateBtn.Size = new System.Drawing.Size(122, 51);
            this.grade_updateBtn.TabIndex = 11;
            this.grade_updateBtn.Text = "Update";
            this.grade_updateBtn.UseVisualStyleBackColor = false;
            this.grade_updateBtn.Click += new System.EventHandler(this.grade_updateBtn_Click);
            // 
            // grade_addBtn
            // 
            this.grade_addBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grade_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grade_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grade_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grade_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grade_addBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.grade_addBtn.ForeColor = System.Drawing.Color.White;
            this.grade_addBtn.Location = new System.Drawing.Point(133, 160);
            this.grade_addBtn.Name = "grade_addBtn";
            this.grade_addBtn.Size = new System.Drawing.Size(122, 51);
            this.grade_addBtn.TabIndex = 10;
            this.grade_addBtn.Text = "Add";
            this.grade_addBtn.UseVisualStyleBackColor = false;
            this.grade_addBtn.Click += new System.EventHandler(this.grade_addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grade_gridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 296);
            this.panel1.TabIndex = 6;
            // 
            // grade_gridData
            // 
            this.grade_gridData.AllowUserToAddRows = false;
            this.grade_gridData.AllowUserToDeleteRows = false;
            this.grade_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grade_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grade_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade_gridData.EnableHeadersVisualStyles = false;
            this.grade_gridData.Location = new System.Drawing.Point(21, 51);
            this.grade_gridData.Name = "grade_gridData";
            this.grade_gridData.ReadOnly = true;
            this.grade_gridData.RowHeadersVisible = false;
            this.grade_gridData.RowHeadersWidth = 51;
            this.grade_gridData.RowTemplate.Height = 24;
            this.grade_gridData.Size = new System.Drawing.Size(765, 228);
            this.grade_gridData.TabIndex = 1;
            this.grade_gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grade_gridData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Grade\'s Data";
            // 
            // grade_student
            // 
            this.grade_student.FormattingEnabled = true;
            this.grade_student.Location = new System.Drawing.Point(131, 64);
            this.grade_student.Name = "grade_student";
            this.grade_student.Size = new System.Drawing.Size(157, 24);
            this.grade_student.TabIndex = 31;
            // 
            // grade_subject
            // 
            this.grade_subject.FormattingEnabled = true;
            this.grade_subject.Location = new System.Drawing.Point(131, 102);
            this.grade_subject.Name = "grade_subject";
            this.grade_subject.Size = new System.Drawing.Size(157, 24);
            this.grade_subject.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Student Subject:";
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.grade.Location = new System.Drawing.Point(427, 23);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(157, 24);
            this.grade.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Student Grade:";
            // 
            // grade_id
            // 
            this.grade_id.Location = new System.Drawing.Point(131, 23);
            this.grade_id.Multiline = true;
            this.grade_id.Name = "grade_id";
            this.grade_id.Size = new System.Drawing.Size(157, 25);
            this.grade_id.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID:";
            // 
            // AddGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddGradeForm";
            this.Size = new System.Drawing.Size(828, 570);
            this.Load += new System.EventHandler(this.AddGradeForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grade_gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button grade_deleteBtn;
        private System.Windows.Forms.Button grade_clearBtn;
        private System.Windows.Forms.Button grade_updateBtn;
        private System.Windows.Forms.Button grade_addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grade_gridData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox grade_student;
        private System.Windows.Forms.ComboBox grade_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grade_id;
        private System.Windows.Forms.Label label5;
    }
}

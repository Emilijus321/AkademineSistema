namespace AkademineSistema8
{
    partial class AddTeacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teacher_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.teacher_deleteBtn = new System.Windows.Forms.Button();
            this.teacher_clearBtn = new System.Windows.Forms.Button();
            this.teacher_updateBtn = new System.Windows.Forms.Button();
            this.teacher_addBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacher_gridData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_surname = new System.Windows.Forms.TextBox();
            this.teacher_usertype = new System.Windows.Forms.ComboBox();
            this.teacher_subject = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.teacher_subject);
            this.panel2.Controls.Add(this.teacher_usertype);
            this.panel2.Controls.Add(this.teacher_surname);
            this.panel2.Controls.Add(this.teacher_status);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.teacher_deleteBtn);
            this.panel2.Controls.Add(this.teacher_clearBtn);
            this.panel2.Controls.Add(this.teacher_updateBtn);
            this.panel2.Controls.Add(this.teacher_addBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teacher_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.teacher_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 231);
            this.panel2.TabIndex = 3;
            // 
            // teacher_status
            // 
            this.teacher_status.FormattingEnabled = true;
            this.teacher_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.teacher_status.Location = new System.Drawing.Point(491, 92);
            this.teacher_status.Name = "teacher_status";
            this.teacher_status.Size = new System.Drawing.Size(157, 24);
            this.teacher_status.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Status:";
            // 
            // teacher_deleteBtn
            // 
            this.teacher_deleteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teacher_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_deleteBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.teacher_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_deleteBtn.Location = new System.Drawing.Point(548, 160);
            this.teacher_deleteBtn.Name = "teacher_deleteBtn";
            this.teacher_deleteBtn.Size = new System.Drawing.Size(122, 51);
            this.teacher_deleteBtn.TabIndex = 13;
            this.teacher_deleteBtn.Text = "Delete";
            this.teacher_deleteBtn.UseVisualStyleBackColor = false;
            this.teacher_deleteBtn.Click += new System.EventHandler(this.teacher_deleteBtn_Click);
            // 
            // teacher_clearBtn
            // 
            this.teacher_clearBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teacher_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_clearBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.teacher_clearBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_clearBtn.Location = new System.Drawing.Point(410, 160);
            this.teacher_clearBtn.Name = "teacher_clearBtn";
            this.teacher_clearBtn.Size = new System.Drawing.Size(122, 51);
            this.teacher_clearBtn.TabIndex = 12;
            this.teacher_clearBtn.Text = "Clear";
            this.teacher_clearBtn.UseVisualStyleBackColor = false;
            this.teacher_clearBtn.Click += new System.EventHandler(this.teacher_clearBtn_Click);
            // 
            // teacher_updateBtn
            // 
            this.teacher_updateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teacher_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_updateBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.teacher_updateBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_updateBtn.Location = new System.Drawing.Point(271, 160);
            this.teacher_updateBtn.Name = "teacher_updateBtn";
            this.teacher_updateBtn.Size = new System.Drawing.Size(122, 51);
            this.teacher_updateBtn.TabIndex = 11;
            this.teacher_updateBtn.Text = "Update";
            this.teacher_updateBtn.UseVisualStyleBackColor = false;
            this.teacher_updateBtn.Click += new System.EventHandler(this.teacher_updateBtn_Click);
            // 
            // teacher_addBtn
            // 
            this.teacher_addBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teacher_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_addBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.teacher_addBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_addBtn.Location = new System.Drawing.Point(133, 160);
            this.teacher_addBtn.Name = "teacher_addBtn";
            this.teacher_addBtn.Size = new System.Drawing.Size(122, 51);
            this.teacher_addBtn.TabIndex = 10;
            this.teacher_addBtn.Text = "Add";
            this.teacher_addBtn.UseVisualStyleBackColor = false;
            this.teacher_addBtn.Click += new System.EventHandler(this.teacher_addBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teacher Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teaacher Usertype:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teacher Surname:";
            // 
            // teacher_name
            // 
            this.teacher_name.Location = new System.Drawing.Point(133, 52);
            this.teacher_name.Multiline = true;
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(157, 25);
            this.teacher_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher Name:";
            // 
            // teacher_id
            // 
            this.teacher_id.Location = new System.Drawing.Point(133, 14);
            this.teacher_id.Multiline = true;
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.Size = new System.Drawing.Size(157, 25);
            this.teacher_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.teacher_gridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 296);
            this.panel1.TabIndex = 2;
            // 
            // teacher_gridData
            // 
            this.teacher_gridData.AllowUserToAddRows = false;
            this.teacher_gridData.AllowUserToDeleteRows = false;
            this.teacher_gridData.AllowUserToResizeRows = false;
            this.teacher_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.teacher_gridData.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacher_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.teacher_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_gridData.EnableHeadersVisualStyles = false;
            this.teacher_gridData.Location = new System.Drawing.Point(21, 51);
            this.teacher_gridData.Name = "teacher_gridData";
            this.teacher_gridData.ReadOnly = true;
            this.teacher_gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.teacher_gridData.RowHeadersVisible = false;
            this.teacher_gridData.RowHeadersWidth = 51;
            this.teacher_gridData.RowTemplate.Height = 24;
            this.teacher_gridData.Size = new System.Drawing.Size(765, 228);
            this.teacher_gridData.TabIndex = 1;
            this.teacher_gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacher_gridData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher\'s Data";
            // 
            // teacher_surname
            // 
            this.teacher_surname.Location = new System.Drawing.Point(133, 95);
            this.teacher_surname.Multiline = true;
            this.teacher_surname.Name = "teacher_surname";
            this.teacher_surname.Size = new System.Drawing.Size(157, 25);
            this.teacher_surname.TabIndex = 18;
            // 
            // teacher_usertype
            // 
            this.teacher_usertype.FormattingEnabled = true;
            this.teacher_usertype.Items.AddRange(new object[] {
            "Teacher"});
            this.teacher_usertype.Location = new System.Drawing.Point(491, 16);
            this.teacher_usertype.Name = "teacher_usertype";
            this.teacher_usertype.Size = new System.Drawing.Size(157, 24);
            this.teacher_usertype.TabIndex = 19;
            // 
            // teacher_subject
            // 
            this.teacher_subject.FormattingEnabled = true;
            this.teacher_subject.Items.AddRange(new object[] {
            "Teacher"});
            this.teacher_subject.Location = new System.Drawing.Point(491, 55);
            this.teacher_subject.Name = "teacher_subject";
            this.teacher_subject.Size = new System.Drawing.Size(157, 24);
            this.teacher_subject.TabIndex = 20;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTeacherForm";
            this.Size = new System.Drawing.Size(828, 570);
            this.Load += new System.EventHandler(this.AddTeacherForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button teacher_deleteBtn;
        private System.Windows.Forms.Button teacher_clearBtn;
        private System.Windows.Forms.Button teacher_updateBtn;
        private System.Windows.Forms.Button teacher_addBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView teacher_gridData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacher_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox teacher_usertype;
        private System.Windows.Forms.TextBox teacher_surname;
        private System.Windows.Forms.ComboBox teacher_subject;
    }
}

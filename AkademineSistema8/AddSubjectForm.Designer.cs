namespace AkademineSistema8
{
    partial class AddSubjectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subject_deleteBtn = new System.Windows.Forms.Button();
            this.subject_clearBtn = new System.Windows.Forms.Button();
            this.subject_updateBtn = new System.Windows.Forms.Button();
            this.subject_addBtn = new System.Windows.Forms.Button();
            this.subject_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subject_gridData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subject_gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.subject_deleteBtn);
            this.panel2.Controls.Add(this.subject_clearBtn);
            this.panel2.Controls.Add(this.subject_updateBtn);
            this.panel2.Controls.Add(this.subject_addBtn);
            this.panel2.Controls.Add(this.subject_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 231);
            this.panel2.TabIndex = 5;
            // 
            // subject_deleteBtn
            // 
            this.subject_deleteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.subject_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subject_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subject_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subject_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_deleteBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.subject_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.subject_deleteBtn.Location = new System.Drawing.Point(548, 160);
            this.subject_deleteBtn.Name = "subject_deleteBtn";
            this.subject_deleteBtn.Size = new System.Drawing.Size(122, 51);
            this.subject_deleteBtn.TabIndex = 13;
            this.subject_deleteBtn.Text = "Delete";
            this.subject_deleteBtn.UseVisualStyleBackColor = false;
            this.subject_deleteBtn.Click += new System.EventHandler(this.subject_deleteBtn_Click);
            // 
            // subject_clearBtn
            // 
            this.subject_clearBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.subject_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subject_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subject_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subject_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_clearBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.subject_clearBtn.ForeColor = System.Drawing.Color.White;
            this.subject_clearBtn.Location = new System.Drawing.Point(410, 160);
            this.subject_clearBtn.Name = "subject_clearBtn";
            this.subject_clearBtn.Size = new System.Drawing.Size(122, 51);
            this.subject_clearBtn.TabIndex = 12;
            this.subject_clearBtn.Text = "Clear";
            this.subject_clearBtn.UseVisualStyleBackColor = false;
            this.subject_clearBtn.Click += new System.EventHandler(this.subject_clearBtn_Click);
            // 
            // subject_updateBtn
            // 
            this.subject_updateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.subject_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subject_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subject_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subject_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_updateBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.subject_updateBtn.ForeColor = System.Drawing.Color.White;
            this.subject_updateBtn.Location = new System.Drawing.Point(271, 160);
            this.subject_updateBtn.Name = "subject_updateBtn";
            this.subject_updateBtn.Size = new System.Drawing.Size(122, 51);
            this.subject_updateBtn.TabIndex = 11;
            this.subject_updateBtn.Text = "Update";
            this.subject_updateBtn.UseVisualStyleBackColor = false;
            this.subject_updateBtn.Click += new System.EventHandler(this.subject_updateBtn_Click);
            // 
            // subject_addBtn
            // 
            this.subject_addBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.subject_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subject_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subject_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subject_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_addBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.subject_addBtn.ForeColor = System.Drawing.Color.White;
            this.subject_addBtn.Location = new System.Drawing.Point(133, 160);
            this.subject_addBtn.Name = "subject_addBtn";
            this.subject_addBtn.Size = new System.Drawing.Size(122, 51);
            this.subject_addBtn.TabIndex = 10;
            this.subject_addBtn.Text = "Add";
            this.subject_addBtn.UseVisualStyleBackColor = false;
            this.subject_addBtn.Click += new System.EventHandler(this.subject_addBtn_Click);
            // 
            // subject_name
            // 
            this.subject_name.Location = new System.Drawing.Point(112, 24);
            this.subject_name.Multiline = true;
            this.subject_name.Name = "subject_name";
            this.subject_name.Size = new System.Drawing.Size(157, 25);
            this.subject_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.subject_gridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 296);
            this.panel1.TabIndex = 4;
            // 
            // subject_gridData
            // 
            this.subject_gridData.AllowUserToAddRows = false;
            this.subject_gridData.AllowUserToDeleteRows = false;
            this.subject_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subject_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.subject_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subject_gridData.EnableHeadersVisualStyles = false;
            this.subject_gridData.Location = new System.Drawing.Point(21, 51);
            this.subject_gridData.Name = "subject_gridData";
            this.subject_gridData.ReadOnly = true;
            this.subject_gridData.RowHeadersVisible = false;
            this.subject_gridData.RowHeadersWidth = 51;
            this.subject_gridData.RowTemplate.Height = 24;
            this.subject_gridData.Size = new System.Drawing.Size(765, 228);
            this.subject_gridData.TabIndex = 1;
            this.subject_gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_studentData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject\'s Data";
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSubjectForm";
            this.Size = new System.Drawing.Size(828, 570);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subject_gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button subject_deleteBtn;
        private System.Windows.Forms.Button subject_clearBtn;
        private System.Windows.Forms.Button subject_updateBtn;
        private System.Windows.Forms.Button subject_addBtn;
        private System.Windows.Forms.TextBox subject_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView subject_gridData;
        private System.Windows.Forms.Label label1;
    }
}

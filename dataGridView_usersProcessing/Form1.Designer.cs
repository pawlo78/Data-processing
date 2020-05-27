namespace dataGridView_usersProcessing
{
    partial class FormUsersView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvUsersView = new System.Windows.Forms.DataGridView();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbLevelAdd = new System.Windows.Forms.ComboBox();
            this.tbSurnameAdd = new System.Windows.Forms.TextBox();
            this.tbNameAdd = new System.Windows.Forms.TextBox();
            this.gbMod = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblLevelMod = new System.Windows.Forms.Label();
            this.lblSurnameMod = new System.Windows.Forms.Label();
            this.lblNameMod = new System.Windows.Forms.Label();
            this.cbLevelMod = new System.Windows.Forms.ComboBox();
            this.tbSurnameMod = new System.Windows.Forms.TextBox();
            this.tbNameMod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersView)).BeginInit();
            this.gbAdd.SuspendLayout();
            this.gbMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(637, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(649, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(649, 266);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(649, 431);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvUsersView
            // 
            this.dgvUsersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersView.Location = new System.Drawing.Point(12, 226);
            this.dgvUsersView.Name = "dgvUsersView";
            this.dgvUsersView.Size = new System.Drawing.Size(619, 239);
            this.dgvUsersView.TabIndex = 5;
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.lblLevel);
            this.gbAdd.Controls.Add(this.lblSurname);
            this.gbAdd.Controls.Add(this.lblName);
            this.gbAdd.Controls.Add(this.cbLevelAdd);
            this.gbAdd.Controls.Add(this.tbSurnameAdd);
            this.gbAdd.Controls.Add(this.tbNameAdd);
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAdd.Location = new System.Drawing.Point(12, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(738, 91);
            this.gbAdd.TabIndex = 6;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add user";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(495, 38);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(42, 17);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "Level";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(233, 38);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // cbLevelAdd
            // 
            this.cbLevelAdd.FormattingEnabled = true;
            this.cbLevelAdd.Location = new System.Drawing.Point(498, 58);
            this.cbLevelAdd.Name = "cbLevelAdd";
            this.cbLevelAdd.Size = new System.Drawing.Size(121, 24);
            this.cbLevelAdd.TabIndex = 4;
            // 
            // tbSurnameAdd
            // 
            this.tbSurnameAdd.Location = new System.Drawing.Point(236, 58);
            this.tbSurnameAdd.Name = "tbSurnameAdd";
            this.tbSurnameAdd.Size = new System.Drawing.Size(240, 23);
            this.tbSurnameAdd.TabIndex = 3;
            // 
            // tbNameAdd
            // 
            this.tbNameAdd.Location = new System.Drawing.Point(10, 58);
            this.tbNameAdd.Name = "tbNameAdd";
            this.tbNameAdd.Size = new System.Drawing.Size(200, 23);
            this.tbNameAdd.TabIndex = 2;
            // 
            // gbMod
            // 
            this.gbMod.Controls.Add(this.btnDone);
            this.gbMod.Controls.Add(this.lblLevelMod);
            this.gbMod.Controls.Add(this.lblSurnameMod);
            this.gbMod.Controls.Add(this.lblNameMod);
            this.gbMod.Controls.Add(this.cbLevelMod);
            this.gbMod.Controls.Add(this.tbSurnameMod);
            this.gbMod.Controls.Add(this.tbNameMod);
            this.gbMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbMod.Location = new System.Drawing.Point(12, 109);
            this.gbMod.Name = "gbMod";
            this.gbMod.Size = new System.Drawing.Size(738, 91);
            this.gbMod.TabIndex = 8;
            this.gbMod.TabStop = false;
            this.gbMod.Text = "Modify user";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(637, 52);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(91, 34);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblLevelMod
            // 
            this.lblLevelMod.AutoSize = true;
            this.lblLevelMod.Location = new System.Drawing.Point(495, 38);
            this.lblLevelMod.Name = "lblLevelMod";
            this.lblLevelMod.Size = new System.Drawing.Size(42, 17);
            this.lblLevelMod.TabIndex = 7;
            this.lblLevelMod.Text = "Level";
            // 
            // lblSurnameMod
            // 
            this.lblSurnameMod.AutoSize = true;
            this.lblSurnameMod.Location = new System.Drawing.Point(233, 38);
            this.lblSurnameMod.Name = "lblSurnameMod";
            this.lblSurnameMod.Size = new System.Drawing.Size(65, 17);
            this.lblSurnameMod.TabIndex = 6;
            this.lblSurnameMod.Text = "Surname";
            // 
            // lblNameMod
            // 
            this.lblNameMod.AutoSize = true;
            this.lblNameMod.Location = new System.Drawing.Point(7, 38);
            this.lblNameMod.Name = "lblNameMod";
            this.lblNameMod.Size = new System.Drawing.Size(45, 17);
            this.lblNameMod.TabIndex = 5;
            this.lblNameMod.Text = "Name";
            // 
            // cbLevelMod
            // 
            this.cbLevelMod.FormattingEnabled = true;
            this.cbLevelMod.Location = new System.Drawing.Point(498, 58);
            this.cbLevelMod.Name = "cbLevelMod";
            this.cbLevelMod.Size = new System.Drawing.Size(121, 24);
            this.cbLevelMod.TabIndex = 4;
            // 
            // tbSurnameMod
            // 
            this.tbSurnameMod.Location = new System.Drawing.Point(236, 58);
            this.tbSurnameMod.Name = "tbSurnameMod";
            this.tbSurnameMod.Size = new System.Drawing.Size(240, 23);
            this.tbSurnameMod.TabIndex = 3;
            // 
            // tbNameMod
            // 
            this.tbNameMod.Location = new System.Drawing.Point(10, 58);
            this.tbNameMod.Name = "tbNameMod";
            this.tbNameMod.Size = new System.Drawing.Size(200, 23);
            this.tbNameMod.TabIndex = 2;
            // 
            // FormUsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 477);
            this.Controls.Add(this.gbMod);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.dgvUsersView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Name = "FormUsersView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users View";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersView)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbMod.ResumeLayout(false);
            this.gbMod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvUsersView;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.TextBox tbSurnameAdd;
        private System.Windows.Forms.TextBox tbNameAdd;
        private System.Windows.Forms.ComboBox cbLevelAdd;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbMod;
        private System.Windows.Forms.Label lblLevelMod;
        private System.Windows.Forms.Label lblSurnameMod;
        private System.Windows.Forms.Label lblNameMod;
        private System.Windows.Forms.ComboBox cbLevelMod;
        private System.Windows.Forms.TextBox tbSurnameMod;
        private System.Windows.Forms.TextBox tbNameMod;
        private System.Windows.Forms.Button btnDone;
    }
}


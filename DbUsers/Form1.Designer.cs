
namespace DbUsers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgDateUsers = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTreeView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDateUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDateUsers
            // 
            this.dgDateUsers.AllowUserToAddRows = false;
            this.dgDateUsers.AllowUserToDeleteRows = false;
            this.dgDateUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDateUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colPhoto,
            this.colName,
            this.colRole,
            this.colEmail});
            this.dgDateUsers.Location = new System.Drawing.Point(22, 59);
            this.dgDateUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDateUsers.Name = "dgDateUsers";
            this.dgDateUsers.ReadOnly = true;
            this.dgDateUsers.RowHeadersWidth = 51;
            this.dgDateUsers.RowTemplate.Height = 29;
            this.dgDateUsers.Size = new System.Drawing.Size(679, 160);
            this.dgDateUsers.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colPhoto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "System.Drawing.Bitmap";
            this.colPhoto.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPhoto.HeaderText = "Фото";
            this.colPhoto.MinimumWidth = 6;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.ReadOnly = true;
            this.colPhoto.Width = 125;
            // 
            // colName
            // 
            this.colName.HeaderText = "Прізвище та ім’я";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colRole
            // 
            this.colRole.HeaderText = "Роль";
            this.colRole.MinimumWidth = 6;
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email актора";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 200;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.Navy;
            this.btnEdit.Location = new System.Drawing.Point(22, 239);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 45);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(285, 239);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTreeView
            // 
            this.btnTreeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTreeView.ForeColor = System.Drawing.Color.Navy;
            this.btnTreeView.Location = new System.Drawing.Point(232, 10);
            this.btnTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Size = new System.Drawing.Size(246, 45);
            this.btnTreeView.TabIndex = 3;
            this.btnTreeView.Text = "Open TreeView";
            this.btnTreeView.UseVisualStyleBackColor = true;
            this.btnTreeView.Click += new System.EventHandler(this.btnTreeView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 342);
            this.Controls.Add(this.btnTreeView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgDateUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Відомості про акторів";
            ((System.ComponentModel.ISupportInitialize)(this.dgDateUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDateUsers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Button btnTreeView;
    }
}


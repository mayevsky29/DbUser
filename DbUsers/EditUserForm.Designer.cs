
namespace DbUsers
{
    partial class EditUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.txtNameRole = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище та ім’я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Роль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(38, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Додати фото актора";
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(198, 22);
            this.txtNameUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(278, 23);
            this.txtNameUser.TabIndex = 4;
            // 
            // txtNameRole
            // 
            this.txtNameRole.Location = new System.Drawing.Point(93, 62);
            this.txtNameRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameRole.Name = "txtNameRole";
            this.txtNameRole.Size = new System.Drawing.Size(383, 23);
            this.txtNameRole.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 97);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(383, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(393, 280);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(38, 172);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(260, 142);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 8;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 338);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNameRole);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditUserForm";
            this.Text = "Редагування даних актора";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.TextBox txtNameRole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbPhoto;
    }
}
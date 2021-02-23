using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DbUsers.Entities;
using DbUsers.Helpers;

namespace DbUsers
{
    public partial class EditUserForm : Form
    {
        private readonly int _id;
        private readonly EFContext _context;
        private string fileSelected = string.Empty;

        public string oldPhoto { get; set; } = null;
        public EditUserForm(int id)
        {
            InitializeComponent();
            _id = id;
            _context = new EFContext();
            initDataEdit();
        }
        private void initDataEdit()
        {
            var user = _context.Users
             .SingleOrDefault(p => p.Id == _id);
           txtNameUser.Text = $"{user.UserName} {user.NormalizedUserName}";

            txtEmail.Text = user.Email;
            
            var role = _context.Roles
             .SingleOrDefault(p => p.Id == _id);
            txtNameRole.Text = role.Name;

            string imageDir = "images";
            string dirImagePath = Path.Combine(Directory.GetCurrentDirectory(),
                imageDir); // обєднує  
            if (!Directory.Exists(dirImagePath)) // створення папки, якщо її існує
            {
                Directory.CreateDirectory(dirImagePath);
            }
            if (!string.IsNullOrEmpty(user.Image))
            {
                var dir = Path.Combine(Directory.GetCurrentDirectory(),
                    "images", user.Image);
                if (File.Exists(dir))
                {
                    pbPhoto.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(dir)));
                }
               
            }
            //  MessageBox.Show(dir);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = _context.Users
               .SingleOrDefault(p => p.Id == _id);
            user.UserName = txtNameUser.Text;
            user.Email = txtEmail.Text;

            var role = _context.Roles
                .SingleOrDefault(p => p.Id == _id);
            role.Name = txtNameRole.Text;
            string oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "images", user.Image);

            if (!string.IsNullOrEmpty(fileSelected))
            {
               
                string ext = Path.GetExtension(fileSelected);
                string fileName = Path.GetRandomFileName() + ext;
                string fileSavePath = Path.Combine(Directory.GetCurrentDirectory(), "images", fileName);

                using (var bmp = ImageWorker.CreateImage(
                    new MemoryStream(File.ReadAllBytes(fileSelected)), 75, 75))
                {
                   // bmp.Save(fileSavePath);
                    user.Image = fileName;
                }

               // File.Copy(fileSelected, fileSavePath);
               // user.Image = fileName;
                if (File.Exists(oldImagePath))
                {
                    this.oldPhoto = oldImagePath;

                }

            }
            _context.SaveChanges();
            _context.Dispose();
            this.DialogResult = DialogResult.OK;
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); // OpenFileDialog - дозволяє завантажувати зображення
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) " +
                "| *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                //fileSelected = dlg.FileName;
                fileSelected = dlg.FileName;
                //pbPhoto.Image = Image.FromFile(dlg.FileName);
                pbPhoto.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(dlg.FileName)));
            }
        }
    }
}

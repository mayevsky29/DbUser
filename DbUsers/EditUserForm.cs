using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

         
            string dirImagePath = Path.Combine(Directory.GetCurrentDirectory(), "images");

            if (!Directory.Exists(dirImagePath))
            {
                Directory.CreateDirectory(dirImagePath);
            }

            if (!string.IsNullOrEmpty(user.Image))
            {
                var dir = Path.Combine(Directory.GetCurrentDirectory(),
                    "images", user.Image);
                if (File.Exists(dir))
                {
                    var streamPhoto = File.OpenRead(dir);
                    pbPhoto.Image = Image.FromStream(streamPhoto);
                    oldPhoto = dir;
                    streamPhoto.Close();
                }
            }
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

            
            if (!string.IsNullOrEmpty(fileSelected))
            {


                string ext = Path.GetExtension(fileSelected);
                string fileName = Path.GetFileNameWithoutExtension(fileSelected) + ext;
                string fileSavePath = Path.Combine(Directory.GetCurrentDirectory(), "images", fileName);

                
                //if (File.Exists(fileName))
                //{
                    /// <summary>
                    /// видалення старого фото із системи при оновлені
                    /// </summary>
                    File.Delete(oldPhoto);
                //}
                var bmp = ImageWorker.CreateImage(
                    new Bitmap(Image.FromFile(fileSelected)), 75, 75);
                bmp.Save(fileSavePath, ImageFormat.Jpeg);
                user.Image = fileName;

            }

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); // OpenFileDialog - дозволяє завантажувати зображення
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) " +
                "| *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //fileSelected = dlg.FileName;
                fileSelected = dlg.FileName;
                pbPhoto.Image = Image.FromFile(dlg.FileName);
                
            }
        }
    }
}

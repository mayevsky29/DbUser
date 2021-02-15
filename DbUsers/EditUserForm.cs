using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DbUsers.Entities;

namespace DbUsers
{
    public partial class EditUserForm : Form
    {
        private readonly int _id;
        private readonly EFContext _context;
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
            
            //txtNameUser.Text = user.User.UserName;
            // txtNameUser.Text = user.User.NormalizedUserName;
            //txtNameRole.Text = user.Role.Name;

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
            //user.User.UserName = txtNameUser.Text;
            //user.User.NormalizedUserName = txtNameUser.Text;
            // user.Role.Name = txtNameRole.Text;
            //user.User.Email = txtEmail.Text;
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }
    }
}

using System;
using DbUsers.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DbUsers.Models;
using DbUsers.Helpers;

namespace DbUsers
{
    public partial class Form1 : Form
    {
        private readonly EFContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new EFContext();
            EFSeeder.SeedDatabase(_context);
            loadDateUsers();
        }

        // метод для читання даних з БД і виведення в DateGrid
        private void loadDateUsers()
        {
            //dgDateUsers.Rows.Clear();
            //var query = _context.UserRoles
            //    .AsQueryable();

            //var list = query.Select(x => new
            //{
            //    Id = x.UserId,
            //    Image = x.User.Image,
            //    Name = x.User.NormalizedUserName+" "+x.User.UserName,
            //    //UserName + " " + x.NormalizedUserName,
            //    RoleName = x.Role.Name,
            //    Email = x.User.Email
            //})
            //    .AsQueryable().ToList(); 

            //foreach (var item in list)
            //{
            //    string path = Path.Combine(Directory.GetCurrentDirectory(), "images");
            //    object[] row =
            //    {
            //        item.Id,
            //        item.Image == null || !File.Exists(Path.Combine(path, item.Image)) ?
            //        null: Image.FromStream(new MemoryStream(File.ReadAllBytes(Path.Combine(path, item.Image)))),
            //        item.Name,
            //        item.RoleName,
            //        item.Email
            //    };
            //    this.dgDateUsers.Rows.Add(row);
            //}

            #region Begin work Category

            var categories = _context.Categories.Select(ic => new CategoryGroupVM
            {
                Id = ic.Id,
                Name = ic.Name,
                UrlSlug = ic.UrlSlug,
                ParentId = ic.ParentId
            }).ToList();

            var tree = categories.BuildTree(); //Зробити дерево

            #endregion
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgDateUsers.CurrentRow != null)
            {
                int id = int.Parse(dgDateUsers["ColId", dgDateUsers.CurrentRow.Index].Value.ToString());
                EditUserForm dlg = new EditUserForm(id);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if(!string.IsNullOrEmpty(dlg.oldPhoto))
                    {
                        if(File.Exists(dlg.oldPhoto))
                        {
                            File.Delete(dlg.oldPhoto);
                        }
                    }
                    loadDateUsers();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTreeView_Click(object sender, EventArgs e)
        {
            TreeViewForm dlg = new TreeViewForm(_context);
            dlg.ShowDialog();
        }
    }
}

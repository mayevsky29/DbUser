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
            dgDateUsers.Rows.Clear();
            var query = _context.UserRoles
                .AsQueryable();

            var list = query.Select(x => new
            {
                Id = x.UserId,
                Name = x.User.NormalizedUserName+" "+x.User.UserName,
                //UserName + " " + x.NormalizedUserName,
                RoleName = x.Role.Name,
                Email = x.User.Email
            })
                .AsQueryable().ToList(); 

            foreach (var item in list)
            {
                object[] row =
                {
                    item.Id,
                    item.Name,
                    item.RoleName,
                    item.Email
                };
                dgDateUsers.Rows.Add(row);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgDateUsers.CurrentRow != null)
            {
                int id = int.Parse(dgDateUsers["ColId", dgDateUsers.CurrentRow.Index].Value.ToString());
                EditUserForm dlg = new EditUserForm(id);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    loadDateUsers();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

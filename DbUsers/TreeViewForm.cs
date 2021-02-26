using DbUsers.Entities;
using DbUsers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DbUsers
{
    public partial class TreeViewForm : Form
    {
        private readonly EFContext _context;
        public TreeViewForm(EFContext context)
        {
            InitializeComponent();
            _context = context;

        }
        private void TreeViewForm_Load(object sender, EventArgs e)
        {
            var list = _context.Categories
                .Where(x => x.ParentId == null)
                .Select(x => new CategoryVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                    UrlSlug = x.UrlSlug
                }).ToList();
            foreach (var item in list)
            {
                AddParent(item);

            }
            tvCategories.Focus();
        }


        private void AddParent(CategoryVM breed)
        {
            TreeNode node = new TreeNode();
            node.Text = breed.Name;
            node.Name = breed.Id.ToString();
            node.Tag = breed;
            node.Nodes.Add("");


            tvCategories.Nodes.Add(node);
        }

        private void AddChild(TreeNode parent, CategoryVM breed)
        {
            TreeNode node = new TreeNode();
            node.Text = breed.Name;
            node.Name = breed.Id.ToString();
            node.Tag = breed;
            node.Nodes.Add("");
            parent.Nodes.Add(node);
        }

        

        private void tvCategories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                var parent = e.Node;
                var parentId = (parent.Tag as CategoryVM).Id;
                parent.Nodes.Clear();
                var list = _context.Categories
                .Where(x => x.ParentId == parentId)
                .Select(x => new CategoryVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                    UrlSlug = x.UrlSlug
                }).ToList();

                foreach (var item in list)
                {
                    AddChild(parent, item);
                }
                // MessageBox.Show(parentId.ToString());
            }
        }






        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

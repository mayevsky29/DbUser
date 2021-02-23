using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TreeView.Entities;

namespace TreeView
{
    public partial class CategoryForm : Form
    {
        private readonly EFContext eFContext;

        public CategoryForm(EFContext context)
        {
            eFContext = context;
            Seeder.SeedDatabase(context);
            InitializeComponent();
        }

        public CategoryForm()
        {
           
           
        }
    }
}

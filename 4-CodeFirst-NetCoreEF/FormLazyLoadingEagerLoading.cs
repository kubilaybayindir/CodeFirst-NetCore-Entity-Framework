using _4_CodeFirst_NetCoreEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_CodeFirst_NetCoreEF
{
    public partial class FormLazyLoadingEagerLoading : Form
    {
        MyShopAppContext db=new MyShopAppContext();

        public FormLazyLoadingEagerLoading()
        {
            InitializeComponent();
        }


        private void BtGetCategories_Click(object sender, EventArgs e)
        {
            LbxCategories.DataSource = null;
            //LbxCategories.DataSource = db.Categories.ToList();
            LbxCategories.DataSource = db.Categories.Include(c => c.Products).ToList();
            LbxCategories.DisplayMember = "Name";
            LbxCategories.ValueMember = "Id";
        }

        private void LbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbxCategories.SelectedIndex > -1)
            {
                Category selectedCategory = LbxCategories.SelectedItem as Category;

                //Manuel Veri çekme işlemi
                //List<Product> productsByCategory = db.Products.Where(p => p.Category.Id == selectedCategory.Id).ToList();

                //Lazy Loading.. : Kategoriyi çekerken verileri de çeker.
                List<Product> productsByCategory = selectedCategory.Products;

                LbxProducts.DataSource = null;
                LbxProducts.DataSource = productsByCategory;
                LbxProducts.DisplayMember = "Name";
                LbxProducts.ValueMember = "Id";
            }
        }
        private void FormLazyLoadingEagerLoading_Load(object sender, EventArgs e)
        {
            ProductGenerator();
        }

        private void ProductGenerator()
        {
            Random random = new Random();
            List<Category> categories = db.Categories.ToList();
            
            for (int i = 0; i < 10; i++)
            {
                Product product = new Product
                {
                    Name = $"Product - {i + 1}",
                    Description = $"Description - {i + 1}",
                    IsContinued = i % 2 == 0 ? true : false,
                    Stock = random.Next(10, 250),
                    UnitPrice = random.Next(10, 1000),
                    Category = categories[random.Next(0, categories.Count - 1)],
                };
                db.Products.Add(product);
            }
            db.SaveChanges();
        }
    }
}

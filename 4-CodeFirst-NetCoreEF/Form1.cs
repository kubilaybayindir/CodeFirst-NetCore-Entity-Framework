using _4_CodeFirst_NetCoreEF.Models;

namespace _4_CodeFirst_NetCoreEF
{
    public partial class Form1 : Form
    {
        MyShopAppContext db = new MyShopAppContext();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void LoadCategories()
        {
            LbxCategories.DataSource = null;
            LbxCategories.DataSource = db.Categories.ToList();
            LbxCategories.DisplayMember = "Name";
            LbxCategories.ValueMember = "Id";
        }
        private void BtGetCategories_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void BtDeleteCategory_Click(object sender, EventArgs e)
        {
            if (LbxCategories.SelectedIndex >-1)
            {
                Category category = LbxCategories.SelectedItem as Category;

                DialogResult dialogResult = MessageBox.Show($"Are sure about deleting {category.Name} category", "Deleting Process", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.Yes)
                {
                    db.Remove(category);
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Deleting process has been done successfully", "Delete");
                        LoadCategories();
                    }
                    else
                    {
                        MessageBox.Show("A error occured during deleting process", "Delete");
                    }
                }
            }
        }
        private void BtAddNewCategory_Click(object sender, EventArgs e)
        {
            if (TbxNewName.Text == "" || TbxNewDesc.Text == "")
            {
                MessageBox.Show("Fill In The Blanks", "Add Error");
                return;
            }
            else
            {
                Category category = new Category();
                category.Name = TbxNewName.Text;
                category.Description = TbxNewDesc.Text;
                db.Add(category);

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Category has been added successfully", "Add");
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("A error occured during adding process", "Add Error");
                }
            }
        }
        private void BtUpdateCategory_Click(object sender, EventArgs e)
        {
            if (LbxCategories.SelectedIndex > -1)
            {
                Category category = LbxCategories.SelectedItem as Category;

                category.Name = TbxUpdateName.Text;
                category.Description = TbxUpdateDesc.Text;

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Category has been updated successfully", "Update");
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("A error occured during updating process", "Update Error");
                }
            }
        }

        private void BtGoLazyLoadingScreen_Click(object sender, EventArgs e)
        {
            FormLazyLoadingEagerLoading formLazyLoadingEagerLoading = new FormLazyLoadingEagerLoading();
            formLazyLoadingEagerLoading.ShowDialog();
        }
    }
}
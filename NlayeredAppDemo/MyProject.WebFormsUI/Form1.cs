using MyProject.Busines.Abstract;
using MyProject.Busines.Concrete;
using MyProject.DataAccess.Concrete.EntityFramework;
using MyProject.DataAccess.Concrete.NHibernate;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.WebFormsUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

        }


        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }


        private void LoadCategories()
        {
            cbx_kategori.DataSource = _categoryService.GetAll();
            cbx_kategori.DisplayMember = "CategoryName";  //Görünen ismi olmalı ala biz seçtiğimizde bunun Id si lazım.
            cbx_kategori.ValueMember = "CategoryId";


            cbx_categoriadd.DataSource = _categoryService.GetAll();
            cbx_categoriadd.DisplayMember = "CategoryName";  //Görünen ismi olmalı ala biz seçtiğimizde bunun Id si lazım.
            cbx_categoriadd.ValueMember = "CategoryId";



            txt_Categorupdate.DataSource = _categoryService.GetAll();
            txt_Categorupdate.DisplayMember = "CategoryName";  //Görünen ismi olmalı ala biz seçtiğimizde bunun Id si lazım.
            txt_Categorupdate.ValueMember = "CategoryId";



        }

        private void cleartextbox()
        {
            txt_productadd.Clear();
            txt_priceadd.Clear();
            txt_stockquantity.Clear();
            txt_unitpcs.Clear();


            textBox4.Clear();
            txt_priceupdate.Clear();
            txt_stockupdate.Clear();
            txt_unitupdate.Clear();
         }



        private void cbx_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbx_kategori.SelectedValue));
            }
            catch
            {

            }
        }

        private void txt_urun_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_urun.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(txt_urun.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
               CategoryId=Convert.ToInt32(cbx_categoriadd.SelectedValue),
               ProdutName=txt_productadd.Text,
               QuantityPerUnit=txt_priceadd.Text,
               UnitPrice=Convert.ToDecimal(txt_stockquantity.Text),
               UnitInStock=Convert.ToInt16(txt_unitpcs.Text)

            });

            LoadProducts();
            cleartextbox();
            MessageBox.Show("Ürün Kaydedildi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProdutName = textBox4.Text,
                CategoryId=Convert.ToInt32(txt_Categorupdate.SelectedValue),
                QuantityPerUnit = txt_priceupdate.Text,
                UnitPrice = Convert.ToDecimal(txt_stockupdate.Text),
                UnitInStock = Convert.ToInt16(txt_unitupdate.Text)
            });
           
            LoadCategories();
            LoadProducts();
            cleartextbox();

            MessageBox.Show("Ürün GÜNCELLENDİ ");

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            textBox4.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            txt_priceupdate.Text = row.Cells[3].Value.ToString();
            txt_Categorupdate.SelectedValue = row.Cells[2].Value;
            txt_unitupdate.Text = row.Cells[4].Value.ToString();
            txt_stockupdate.Text = row.Cells[5].Value.ToString();   
        }



        private void btn_sil_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
            });

            MessageBox.Show("Ürün Silindi");
            LoadProducts();
        }
    }
}

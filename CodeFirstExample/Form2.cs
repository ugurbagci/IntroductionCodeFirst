using CodeFirstExample.DAL.ORM.Context;
using CodeFirstExample.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Add_Date = DateTime.Now;
            product.Name = txtAd.Text;
            product.UnitPrice = decimal.Parse(txtFiyat.Text);
            product.UnitsInStock = short.Parse(txtStok.Text);
            product.QuantityPerUnit = txtBirim.Text;
            product.isActive = true;
            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("Ürün ekleme işlemi başarılı");
        }
        
    }
}

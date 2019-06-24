using CodeFirstExample.DAL.ORM.Context;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (db.AppUsers.Any(x=> x.UserName==txtAd.Text && x.Password==txtSifre.Text))
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizi kontrol ediniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }
    }
}

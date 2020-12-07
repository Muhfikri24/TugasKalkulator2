using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasKalkulator2
{
    public partial class Form2 : Form
    {
        public delegate void CreateUpdateEventHandler(Kalkulator klk);
        public event Form2.CreateUpdateEventHandler OnCreate;
        private Kalkulator klk;


        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            klk = new Kalkulator();
            klk.nama = this.cmbOperasi.Text.ToLower();
            klk.operasi = string.Empty;
            klk.hasil = 0;
            klk.nilaia = Double.Parse(this.txtNilaiA.Text);
            klk.nilaib = Double.Parse(this.txtNilaiB.Text);


            if (this.cmbOperasi.SelectedIndex == -1)
            {
                MessageBox.Show("Silahkan Pilih Dulu Operasinya!!!");
            }
            else if (this.cmbOperasi.SelectedIndex == 0)
            {
                klk.hasil = klk.nilaia + klk.nilaib;
                klk.operasi = "+";

            }
            else if (this.cmbOperasi.SelectedIndex == 1)
            {
                klk.hasil = klk.nilaia - klk.nilaib;
                klk.operasi = "-";
            }
            else if (this.cmbOperasi.SelectedIndex == 2)
            {
                klk.hasil = klk.nilaia * klk.nilaib;
                klk.operasi = "*";
            }
            else if (this.cmbOperasi.SelectedIndex == 3)
            {
                klk.hasil = klk.nilaia / klk.nilaib;
                klk.operasi = "/";
            }

            this.OnCreate(klk);
        }
    }
}

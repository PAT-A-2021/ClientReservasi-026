using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_026
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Form1()
        {
            
            InitializeComponent();
            TampilData();
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string IDPemesanan = tbID.Text;
            string NamaCustomer = tbNama.Text;
            string NoTelpon = tbNoTelp.Text;
            string idLokasi = tbIDLok.Text;
            int jumlahpemesanan = int.Parse(tbJumlah.Text);

            var a = service.pemesanan(IDPemesanan, NamaCustomer, NoTelpon, jumlahpemesanan, idLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string IDPemesanan = tbID.Text;
            string NamaCustomer = tbNama.Text;
            string NoTelpon = tbNoTelp.Text;

            var a = service.editpemesanan(IDPemesanan, NamaCustomer, NoTelpon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string IDPemesanan = tbID.Text;
            var a = service.deletePemesanan(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }
        public void TampilData()
        {
            var List = service.Pemesanan1();
            dtPemesanan.DataSource = List;
        }
        
        public void Clear()
        {
            tbID.Clear();
            tbIDLok.Clear();
            tbJumlah.Clear();
            tbNama.Clear();
            tbNoTelp.Clear();

            tbJumlah.Enabled = true;
            tbIDLok.Enabled = true;
            btnSimpan.Enabled = true;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
            tbID.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtPemesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtPemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbID.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[0].Value);
            tbNama.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[1].Value);
            tbNoTelp.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[2].Value);
            tbJumlah.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[3].Value);
            tbIDLok.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[4].Value);

            tbJumlah.Enabled = false;
            tbIDLok.Enabled = false;

            btnUpdate.Enabled = true;
            btnHapus.Enabled = true;
            btnSimpan.Enabled = false;
            tbID.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

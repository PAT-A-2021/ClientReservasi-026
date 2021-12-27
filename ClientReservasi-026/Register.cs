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
    public partial class Register : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Register()
        {
            InitializeComponent();
            TampilData();
            tbID.Visible = false;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassowrd.Text;
            string kategori = cbKategori.Text;
            string a = service.Register(username, password, kategori);

            if (tbUsername.Text == "" || tbPassowrd.Text == "" || cbKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }

        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassowrd.Text;
            string kategori = cbKategori.Text;
            int id = Convert.ToInt32(tbID.Text);
            string a = service.UpdateRegister(username, password, kategori, id);

            if (tbUsername.Text == "" || tbPassowrd.Text == "" || cbKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;

            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini", "Hapus data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string a = service.DeleteRegister(username); // Mengambil return value servis
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            tbUsername.Clear();
            tbPassowrd.Clear();
            cbKategori.SelectedItem = null;

            btnSimpan.Enabled = true;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
        }
        public void TampilData()
        {
            var list = service.dataRegist();
            dtRegister.DataSource = list;
        }

        private void dtRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[0].Value);
            tbUsername.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[1].Value);
            tbPassowrd.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[2].Value);
            cbKategori.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[3].Value);

            btnUpdate.Enabled = true;
            btnHapus.Enabled = true;

            btnSimpan.Enabled = false;
        }
    }
}

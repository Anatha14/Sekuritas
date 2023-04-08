using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UAS_Anatha
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int umur = DateTime.Now.Year - dateTimePicker1.Value.Year;
            string password = textBox4.Text;
           
            if (textBox1.Text == "")
            {
                MessageBox.Show("Mohon Untuk Mengisi Bagian Nama Depan" + "\nSilahkan Masukan Nama Depan Anda",
                                "Nama Tidak Ada",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text =="")
            {
                MessageBox.Show("Mohon Untuk Mengisi Bagian Nama Belakang" + "\nSilahkan Masukan Nama Belakang Anda",
                                "Nama Tidak Ada",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (umur <= 17)
            {
                MessageBox.Show("Anda Tidak Diperkenankan Membuat Akun Karena Masih Dibawah Umur",
                                "Belum Cukup Umur",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Mohon Untuk Mengisi Bagian Username" + "\nSilahkan Masukan Username yang Ingin Digunakan",
                                "Username Tidak Ada",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password == "")
            {
                MessageBox.Show("Mohon Untuk Mengisi Bagian Password" + "\nSilahkan Masukan Pasword",
                                "Password Tidak Ada",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Mohon Untuk Mengisi Bagian Password" + "\nSilahkan Masukan Pasword",
                                "Password Tidak Ada",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox5.Text != password)
            {
                MessageBox.Show("Password yang Anda Masukan Berbeda" + "\nSilahkan Masukan Pasword Ulang", 
                                "Password Salah",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.Close();
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

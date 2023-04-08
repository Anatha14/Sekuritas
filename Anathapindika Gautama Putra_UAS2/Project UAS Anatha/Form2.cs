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
    public partial class Form2 : Form
    {
        public Form2(string nama)
        {
            InitializeComponent();
            label1.Text = "Hallo," + nama;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timerstatus_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long harga = Convert.ToInt64 (textBox1.Text);
            long Kuantitas = Convert.ToInt64 (textBox2.Text) * 100 ;
            long total = harga * Kuantitas ;

            string Waktu = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();

            listPerusahaan.Items.Add(comboBox1.Text);
            listAksi.Items.Add(comboBox2.Text);
            listHarga.Items.Add("Rp " + textBox1.Text);
            listJumlah.Items.Add(Kuantitas + "Lembar");
            listTotal.Items.Add("Rp " + total);
            listTanggal.Items.Add(Waktu);

            listBox1.Items.Add(string.Format("{0} \t || \t {1} \t || \t {2} \t || \t {3} \t || \t {4} \t || \t {5}",
                Waktu,comboBox1.Text, comboBox2.Text, "Rp " + textBox1.Text, Kuantitas + "Lembar", "Rp " + total));
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Simpan Order";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.StreamWriter tulis =
                    new System.IO.StreamWriter(saveFileDialog1.FileName);

                tulis.WriteLine("Waktu \t || \t Nama Perusahaan \t || \t Aksi \t || \t Harga / Lembar" +
                    " \t || \t Jumlah Saham \t || \t Harga Total");
                foreach (string data in listBox1.Items)
                    tulis.WriteLine(data);

                
                tulis.Close();
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soccer Sekuritas \n  Made by Anatha", "About This Program", MessageBoxButtons.OK);
        }

        private void saveOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Simpan Order";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.StreamWriter tulis =
                    new System.IO.StreamWriter(saveFileDialog1.FileName);

                tulis.WriteLine("Waktu \t || \t Nama Perusahaan \t || \t Aksi \t || \t Harga / Lembar" +
                    " \t || \t Jumlah Saham \t || \t Harga Total");
                foreach (string data in listBox1.Items)
                    tulis.WriteLine(data);


                tulis.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void iHSGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(iHSGToolStripMenuItem.Checked)
            {
                IHSG1DPhoto.Visible = false;
                label16.Visible = false;
                iHSGToolStripMenuItem.Checked = false;
            }
            else
            {
                IHSG1DPhoto.Visible = true;
                label16.Visible = true;
                iHSGToolStripMenuItem.Checked = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iDX30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(iDX30ToolStripMenuItem.Checked)
            {
                IDX30Photo.Visible=false;
                label13.Visible = false;
                iDX30ToolStripMenuItem.Checked=false;
            }
            else
            {
                IDX30Photo.Visible=true;
                label13.Visible = true;
                iDX30ToolStripMenuItem.Checked = true;
                label13.BringToFront();
                IDX30Photo.BringToFront();
            }
        }

        private void lQ45ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lQ45ToolStripMenuItem.Checked)
            {
                LQ45Photo.Visible = false;
                label14.Visible = false;
                lQ45ToolStripMenuItem.Checked = false; 
            }
            else
            {
                LQ45Photo.Visible = true;
                label14.Visible = true;
                lQ45ToolStripMenuItem.Checked = true;
                label14.BringToFront();
                LQ45Photo.BringToFront();
            }
        }

        private void jIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jIIToolStripMenuItem.Checked)
            {
                JIIPhoto.Visible = false;
                label15.Visible = false;
                jIIToolStripMenuItem.Checked = false;
            }
            else
            {
                JIIPhoto.Visible = true;
                label15.Visible = true;
                jIIToolStripMenuItem.Checked = true;
                label15.BringToFront();
                JIIPhoto.BringToFront();
            }
        }

        private void switchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openSavedOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

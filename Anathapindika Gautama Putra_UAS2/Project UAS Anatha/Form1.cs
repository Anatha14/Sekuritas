namespace Project_UAS_Anatha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Masukan Username dan Password Dengan Benar",
                                "Masukan Username dan password",
                                MessageBoxButtons.OK);
            }

            else
            {
                Form2 Fr = new Form2(textBox1.Text);
                
                Fr.ShowDialog();
                
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Blue;
            Form3 Fe = new Form3();
            Fe.ShowDialog();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
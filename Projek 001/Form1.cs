namespace Projek_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar=='*')
                textBox2.PasswordChar= '\0';
            else
                textBox2.PasswordChar= '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult a1 = MessageBox.Show("KAMU YAKIN INGIN KELUAR?", "Warning", MessageBoxButtons.YesNo);
            if (a1 == DialogResult.Yes)
            Application.Exit();
         
        }
    }
}
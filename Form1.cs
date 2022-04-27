namespace Assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jan Lenard L. Rodriguez", "Name");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BS Computer Engineering", "Course");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BSCOE1-4", "Section");
        }

        int i = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                pictureBox1.Visible = true;
                i++;
            }
            else
            {
                pictureBox1.Visible = false;
                i++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
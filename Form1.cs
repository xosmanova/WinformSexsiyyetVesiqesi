namespace WinformSexsiyyetVesiqesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text; 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text; 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label5.Text = textBox5.Text; 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label6.Text = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label7.Text = textBox7.Text; 
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label8.Text = textBox8.Text; 
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            label9.Text = textBox9.Text; 
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox10.Text; 
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            label11.Text = textBox11.Text; 
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG Faylları (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            timer1.Start();

            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox8.Text) ||
                string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox10.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox12.Text))
            {
                
                MessageBox.Show("Məlumatlar tam daxil edilməyib", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                MessageBox.Show("Yadda saxlandı", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show("Əməliyyat tamamlandı", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    progressBar1.Visible = false;
                }
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";

            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;
        }
    }
}

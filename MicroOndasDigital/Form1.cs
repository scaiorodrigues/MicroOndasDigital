namespace MicroOndasDigital
{
    public partial class Form1 : Form
    {
        int tempo = 0;
        int minuto = 0;
        int segundo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPotencia_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            segundo--;
            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            txtDisplay.Text = "" + minuto + ":" + segundo;
            if(minuto == 0 && segundo == 0)
            {
                timer1.Enabled = false;             
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tempo = Convert.ToInt32(txtDisplay.Text);
            if (tempo < 1)
            {
                txtDisplay.Text = "0";
                txtPotencia.Text = "Incerir tempo maior que 1 segundos.";           
            }
            else if (tempo > 120)
            {
                txtDisplay.Text = "0";
                txtPotencia.Text = "Incerir tempo menor que 2 minutos.";
            }
            else if (tempo >= 60)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;
            }
            else
            {
                minuto = 0;
                segundo = tempo;
            }
            txtDisplay.Text = 0 + minuto + ":" + segundo;
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            tempo = 0;
            minuto = 0;
            segundo = 0;

            timer1.Enabled = false;
        }
    }
}
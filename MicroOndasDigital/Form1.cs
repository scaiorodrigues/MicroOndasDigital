namespace MicroOndasDigital
{
    public partial class Form1 : Form
    {
        int tempo = 0;
        int minuto = 0;
        int segundo = 0;
        int potencia = 10;

        public Form1()
        {
            InitializeComponent();
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
            if (minuto == 0 && segundo == 0)
            {
                timer1.Enabled = false;
                txtDisplay.Text = "0";
                txtPotencia.Text = "Aquecimento Concluído";
                return;
            }
            segundo--;
            if (segundo < 0)
            {
                if (minuto > 0)
                {
                    segundo = 59;
                    minuto--;
                }
                else
                {
                    timer1.Enabled = false;
                    return;
                }
            }
            string stringAquecimento = "";
            for (int i = 0; i < potencia; i++)
            {
                stringAquecimento += ".";
            }
            txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
            txtPotencia.Text = stringAquecimento + " - POTENCIA: " + potencia;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                tempo += 30;
                minuto = tempo / 60;
                segundo = tempo % 60;
                txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
            }
            else
            {

                tempo = Convert.ToInt32(txtDisplay.Text);
                if (tempo < 1)
                {
                    txtDisplay.Text = "0";
                    txtPotencia.Text = "Incerir tempo maior que 1 segundos.";
                    timer1.Enabled = false;
                    txtDisplay.Text = "0";
                    tempo = 0;
                    minuto = 0;
                    segundo = 0;
                }
                else if (tempo > 120)
                {
                    txtDisplay.Text = "0";
                    txtPotencia.Text = "Incerir tempo menor que 2 minutos.";
                    timer1.Enabled = false;
                    txtDisplay.Text = "0";
                    tempo = 0;
                    minuto = 0;
                    segundo = 0;
                }
                else
                {
                    minuto = tempo / 60;
                    segundo = tempo % 60;
                    txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
                    txtPotencia.Text = "";
                    timer1.Enabled = true;
                }
            }
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
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                txtPotencia.Text = "PAUSADO";
            }
            else
            {
            tempo = 0;
            minuto = 0;
            segundo = 0;
            txtDisplay.Text = "";
            txtPotencia.Text = "";
            timer1.Enabled = false;
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            potencia++;
            if (potencia > 10)
                potencia = 1;

            string potenciaText = $"POTENCIA {potencia}";
            txtPotencia.Text = potenciaText;
        }
    }
}
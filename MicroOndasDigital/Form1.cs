namespace MicroOndasDigital
{
    public partial class Form1 : Form
    {
        int tempo = 0;
        int minuto = 0;
        int segundo = 0;
        int potencia = 10;
        string alimento;
        string ponto;
        string totalPonto;
        string instru;
        bool aquecimentoPausado = false;

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
                timer1.Stop();
                txtDisplay.Text = "";
                txtPotencia.Text = "Aquecimento Concluído";
                totalPonto = "";
                btnInicio.Enabled = true;
                btnPotencia.Enabled = true;
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
            for (int i = 1; i <= potencia; i++)
            {
                totalPonto += ".";
            }
            txtPotencia.Text = totalPonto;
            txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                if (aquecimentoPausado)
                {
                    timer1.Start();
                    txtPotencia.Text = "";
                    aquecimentoPausado = false;
                }
                else
                {
                    tempo += 30;
                    minuto = tempo / 60;
                    segundo = tempo % 60;
                    txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
                }
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
                    timer1.Start();
                }
            }
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
            if (timer1.Enabled)
            {
                timer1.Stop();
                txtPotencia.Text = "PAUSADO";
                aquecimentoPausado = true;
            }
            else
            {
                tempo = 0;
                minuto = 0;
                segundo = 0;
                txtDisplay.Text = "";
                txtPotencia.Text = "";
                timer1.Stop();
                totalPonto = "";
                aquecimentoPausado = false;
                btnInicio.Enabled = true;
                btnPotencia.Enabled = true;
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            potencia++;
            if (potencia > 10)
                potencia = 1;

            string potenciaText = $"POTENCIA: {potencia}";
            txtPotencia.Text = potenciaText;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (minuto == 0 && segundo == 0)
            {
                alimento = "Pipoca (de micro-ondas)";
                potencia = 7;
                tempo = 180;
                instru = "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.";

                txtPotencia.Text = instru;
                minuto = tempo / 60;
                segundo = tempo % 60;
                txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
                timer1.Start();

                btnInicio.Enabled = false;
                btnPotencia.Enabled = false;                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (minuto == 0 && segundo == 0)
            {
                alimento = "Carne em pedaço ou fatias";
                tempo = 840;
                potencia = 4;
                instru = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.";

                txtPotencia.Text = instru;
                minuto = tempo / 60;
                segundo = tempo % 60;
                txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
                timer1.Start();

                btnInicio.Enabled = false;
                btnPotencia.Enabled = false;
            }
        }

        private void btnLeite_Click(object sender, EventArgs e)
        {
            if (minuto == 0 && segundo == 0)
            {
                alimento = "Leite";
                tempo = 300;
                potencia = 5;
                instru = "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.";

                txtPotencia.Text = instru;
                minuto = tempo / 60;
                segundo = tempo % 60;
                txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
                timer1.Start();

                btnInicio.Enabled = false;
                btnPotencia.Enabled = false;
            }
        }

        private void btnFrango_Click(object sender, EventArgs e)
        {
            alimento = "Frango (qualquer corte)";
            tempo = 480;
            potencia = 7;
            instru = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.";

            txtPotencia.Text = instru;
            minuto = tempo / 60;
            segundo = tempo % 60;
            txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
            timer1.Start();

            btnInicio.Enabled = false;
            btnPotencia.Enabled = false;
        }

        private void btnFeijao_Click(object sender, EventArgs e)
        {
            alimento = "Feijão congelado";
            tempo = 480;
            potencia = 9;
            instru = "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas.";

            txtPotencia.Text = instru;
            minuto = tempo / 60;
            segundo = tempo % 60;
            txtDisplay.Text = $"{minuto:D2}:{segundo:D2}";
            timer1.Start();

            btnInicio.Enabled = false;
            btnPotencia.Enabled = false;
        }
    }
}
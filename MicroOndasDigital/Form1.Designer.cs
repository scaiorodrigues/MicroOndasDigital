﻿namespace MicroOndasDigital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtPotencia = new TextBox();
            label1 = new Label();
            txtDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            groupBox1 = new GroupBox();
            btnPotencia = new Button();
            btnCancela = new Button();
            groupBox2 = new GroupBox();
            btnInicio = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnBoi = new Button();
            btnLeite = new Button();
            btnPipoca = new Button();
            btnFrango = new Button();
            btnFeijao = new Button();
            btnCustom = new Button();
            btnGravar = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(txtPotencia);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDisplay);
            panel1.Location = new Point(71, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 150);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // txtPotencia
            // 
            txtPotencia.BackColor = Color.Black;
            txtPotencia.Font = new Font("DS-Digital", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPotencia.ForeColor = Color.Lime;
            txtPotencia.Location = new Point(9, 112);
            txtPotencia.Name = "txtPotencia";
            txtPotencia.ReadOnly = true;
            txtPotencia.ScrollBars = ScrollBars.Horizontal;
            txtPotencia.Size = new Size(180, 24);
            txtPotencia.TabIndex = 2;
            txtPotencia.TextAlign = HorizontalAlignment.Right;
            txtPotencia.TextChanged += txtPotencia_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 54);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.Black;
            txtDisplay.Font = new Font("DS-Digital", 48F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplay.ForeColor = Color.Lime;
            txtDisplay.Location = new Point(9, 15);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(180, 87);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(4, 14);
            button1.Name = "button1";
            button1.Size = new Size(65, 50);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 14);
            button2.Name = "button2";
            button2.Size = new Size(65, 50);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(132, 14);
            button3.Name = "button3";
            button3.Size = new Size(65, 50);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(4, 63);
            button4.Name = "button4";
            button4.Size = new Size(65, 50);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(68, 63);
            button5.Name = "button5";
            button5.Size = new Size(65, 50);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(132, 63);
            button6.Name = "button6";
            button6.Size = new Size(65, 50);
            button6.TabIndex = 4;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(4, 113);
            button7.Name = "button7";
            button7.Size = new Size(65, 50);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(68, 113);
            button8.Name = "button8";
            button8.Size = new Size(65, 50);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(132, 113);
            button9.Name = "button9";
            button9.Size = new Size(65, 50);
            button9.TabIndex = 7;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(68, 163);
            button0.Name = "button0";
            button0.Size = new Size(65, 50);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGravar);
            groupBox1.Controls.Add(btnPotencia);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button0);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button7);
            groupBox1.Location = new Point(71, 318);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 220);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnPotencia
            // 
            btnPotencia.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPotencia.Location = new Point(132, 163);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(65, 50);
            btnPotencia.TabIndex = 11;
            btnPotencia.Text = "Potência";
            btnPotencia.UseVisualStyleBackColor = true;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnCancela
            // 
            btnCancela.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancela.Location = new Point(4, 14);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(80, 50);
            btnCancela.TabIndex = 13;
            btnCancela.Text = " PAUSAR \r\ncancelar";
            btnCancela.UseVisualStyleBackColor = true;
            btnCancela.Click += btnCancela_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnInicio);
            groupBox2.Controls.Add(btnCancela);
            groupBox2.Location = new Point(71, 537);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 70);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.Location = new Point(85, 14);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(112, 50);
            btnInicio.TabIndex = 14;
            btnInicio.Text = "INÍCIO\r\n+30s";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // btnBoi
            // 
            btnBoi.Location = new Point(200, 220);
            btnBoi.Name = "btnBoi";
            btnBoi.Size = new Size(65, 50);
            btnBoi.TabIndex = 17;
            btnBoi.Text = "Boi";
            btnBoi.UseVisualStyleBackColor = true;
            btnBoi.Click += button10_Click;
            // 
            // btnLeite
            // 
            btnLeite.Location = new Point(136, 220);
            btnLeite.Name = "btnLeite";
            btnLeite.Size = new Size(65, 50);
            btnLeite.TabIndex = 16;
            btnLeite.Text = "Leite";
            btnLeite.UseVisualStyleBackColor = true;
            btnLeite.Click += btnLeite_Click;
            // 
            // btnPipoca
            // 
            btnPipoca.Location = new Point(72, 220);
            btnPipoca.Name = "btnPipoca";
            btnPipoca.Size = new Size(65, 50);
            btnPipoca.TabIndex = 15;
            btnPipoca.Text = "Pipoca";
            btnPipoca.UseVisualStyleBackColor = true;
            btnPipoca.Click += button12_Click_1;
            // 
            // btnFrango
            // 
            btnFrango.Location = new Point(72, 269);
            btnFrango.Name = "btnFrango";
            btnFrango.Size = new Size(65, 50);
            btnFrango.TabIndex = 20;
            btnFrango.Text = "Frango";
            btnFrango.UseVisualStyleBackColor = true;
            btnFrango.Click += btnFrango_Click;
            // 
            // btnFeijao
            // 
            btnFeijao.Location = new Point(136, 269);
            btnFeijao.Name = "btnFeijao";
            btnFeijao.Size = new Size(65, 50);
            btnFeijao.TabIndex = 19;
            btnFeijao.Text = "Feijão";
            btnFeijao.UseVisualStyleBackColor = true;
            btnFeijao.Click += btnFeijao_Click;
            // 
            // btnCustom
            // 
            btnCustom.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustom.Location = new Point(200, 269);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(65, 50);
            btnCustom.TabIndex = 18;
            btnCustom.Text = "Custom";
            btnCustom.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(4, 163);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(65, 50);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += button10_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 715);
            Controls.Add(btnBoi);
            Controls.Add(btnLeite);
            Controls.Add(btnPipoca);
            Controls.Add(btnFrango);
            Controls.Add(btnFeijao);
            Controls.Add(btnCustom);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtPotencia;
        private Button btnPotencia;
        private Button btnCancela;
        private GroupBox groupBox2;
        private Button btnInicio;
        private System.Windows.Forms.Timer timer1;
        private Button btnBoi;
        private Button btnLeite;
        private Button btnPipoca;
        private Button btnFrango;
        private Button btnFeijao;
        private Button btnCustom;
        private Button btnGravar;
    }
}
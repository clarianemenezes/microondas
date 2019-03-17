namespace Clariane_Menezes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbSaidaTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbTempo = new System.Windows.Forms.MaskedTextBox();
            this.mtbPotencia = new System.Windows.Forms.MaskedTextBox();
            this.cbbPrefefinidos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInicioRapido = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ttbEntrada = new System.Windows.Forms.TextBox();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ttbInstrucoes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbNomeNovo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbTempoNovo = new System.Windows.Forms.MaskedTextBox();
            this.mtbPotenciaNovo = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ttbInstrucoesNovo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ttbCaractereNovo = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(285, 261);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(100, 28);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada / Caminho do arquivo";
            // 
            // ttbSaidaTexto
            // 
            this.ttbSaidaTexto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ttbSaidaTexto.Location = new System.Drawing.Point(0, 0);
            this.ttbSaidaTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ttbSaidaTexto.Multiline = true;
            this.ttbSaidaTexto.Name = "ttbSaidaTexto";
            this.ttbSaidaTexto.ReadOnly = true;
            this.ttbSaidaTexto.Size = new System.Drawing.Size(275, 333);
            this.ttbSaidaTexto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Potência";
            // 
            // mtbTempo
            // 
            this.mtbTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTempo.Location = new System.Drawing.Point(282, 75);
            this.mtbTempo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbTempo.Mask = "00:00";
            this.mtbTempo.Name = "mtbTempo";
            this.mtbTempo.Size = new System.Drawing.Size(100, 22);
            this.mtbTempo.TabIndex = 5;
            this.mtbTempo.Text = "0030";
            this.mtbTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTempo.ValidatingType = typeof(System.DateTime);
            // 
            // mtbPotencia
            // 
            this.mtbPotencia.Location = new System.Drawing.Point(389, 75);
            this.mtbPotencia.Mask = "00";
            this.mtbPotencia.Name = "mtbPotencia";
            this.mtbPotencia.Size = new System.Drawing.Size(100, 22);
            this.mtbPotencia.TabIndex = 6;
            this.mtbPotencia.Text = "10";
            this.mtbPotencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbPotencia.ValidatingType = typeof(int);
            // 
            // cbbPrefefinidos
            // 
            this.cbbPrefefinidos.FormattingEnabled = true;
            this.cbbPrefefinidos.Location = new System.Drawing.Point(285, 124);
            this.cbbPrefefinidos.Name = "cbbPrefefinidos";
            this.cbbPrefefinidos.Size = new System.Drawing.Size(204, 24);
            this.cbbPrefefinidos.TabIndex = 7;
            this.cbbPrefefinidos.SelectedIndexChanged += new System.EventHandler(this.cbbPrefefinidos_SelectedIndexChanged);
            //this.cbbPrefefinidos.Enter += new System.EventHandler(this.cbbPrefefinidos_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pre-definidos";
            // 
            // btnInicioRapido
            // 
            this.btnInicioRapido.Location = new System.Drawing.Point(393, 261);
            this.btnInicioRapido.Name = "btnInicioRapido";
            this.btnInicioRapido.Size = new System.Drawing.Size(99, 28);
            this.btnInicioRapido.TabIndex = 9;
            this.btnInicioRapido.Text = "Inicio Rapido";
            this.btnInicioRapido.UseVisualStyleBackColor = true;
            this.btnInicioRapido.Click += new System.EventHandler(this.btnInicioRapido_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(285, 297);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(100, 28);
            this.btnPausar.TabIndex = 10;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(392, 297);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ttbEntrada
            // 
            this.ttbEntrada.Location = new System.Drawing.Point(282, 30);
            this.ttbEntrada.MaxLength = 1000;
            this.ttbEntrada.Name = "ttbEntrada";
            this.ttbEntrada.Size = new System.Drawing.Size(337, 22);
            this.ttbEntrada.TabIndex = 12;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(626, 27);
            this.btnArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(118, 28);
            this.btnArquivo.TabIndex = 13;
            this.btnArquivo.Text = "Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Instruçoes de aquecimento";
            // 
            // ttbInstrucoes
            // 
            this.ttbInstrucoes.Enabled = false;
            this.ttbInstrucoes.Location = new System.Drawing.Point(285, 175);
            this.ttbInstrucoes.Multiline = true;
            this.ttbInstrucoes.Name = "ttbInstrucoes";
            this.ttbInstrucoes.Size = new System.Drawing.Size(204, 69);
            this.ttbInstrucoes.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.ttbCaractereNovo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ttbInstrucoesNovo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.mtbPotenciaNovo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mtbTempoNovo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ttbNomeNovo);
            this.groupBox1.Location = new System.Drawing.Point(509, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 268);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar novo programa pre-definido";
            // 
            // ttbNomeNovo
            // 
            this.ttbNomeNovo.Enabled = false;
            this.ttbNomeNovo.Location = new System.Drawing.Point(10, 41);
            this.ttbNomeNovo.MaxLength = 20;
            this.ttbNomeNovo.Name = "ttbNomeNovo";
            this.ttbNomeNovo.Size = new System.Drawing.Size(207, 22);
            this.ttbNomeNovo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Novo programa pre-definido *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Caractere *";
            // 
            // mtbTempoNovo
            // 
            this.mtbTempoNovo.Enabled = false;
            this.mtbTempoNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTempoNovo.Location = new System.Drawing.Point(10, 86);
            this.mtbTempoNovo.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTempoNovo.Mask = "00:00";
            this.mtbTempoNovo.Name = "mtbTempoNovo";
            this.mtbTempoNovo.Size = new System.Drawing.Size(100, 22);
            this.mtbTempoNovo.TabIndex = 16;
            this.mtbTempoNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTempoNovo.ValidatingType = typeof(System.DateTime);
            // 
            // mtbPotenciaNovo
            // 
            this.mtbPotenciaNovo.Enabled = false;
            this.mtbPotenciaNovo.Location = new System.Drawing.Point(117, 86);
            this.mtbPotenciaNovo.Mask = "00";
            this.mtbPotenciaNovo.Name = "mtbPotenciaNovo";
            this.mtbPotenciaNovo.Size = new System.Drawing.Size(100, 22);
            this.mtbPotenciaNovo.TabIndex = 17;
            this.mtbPotenciaNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbPotenciaNovo.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tempo *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Potência *";
            // 
            // ttbInstrucoesNovo
            // 
            this.ttbInstrucoesNovo.Enabled = false;
            this.ttbInstrucoesNovo.Location = new System.Drawing.Point(10, 132);
            this.ttbInstrucoesNovo.MaxLength = 250;
            this.ttbInstrucoesNovo.Multiline = true;
            this.ttbInstrucoesNovo.Name = "ttbInstrucoesNovo";
            this.ttbInstrucoesNovo.Size = new System.Drawing.Size(207, 37);
            this.ttbInstrucoesNovo.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Instruçoes de aquecimento *";
            // 
            // ttbCaractereNovo
            // 
            this.ttbCaractereNovo.Enabled = false;
            this.ttbCaractereNovo.Location = new System.Drawing.Point(10, 191);
            this.ttbCaractereNovo.MaxLength = 1;
            this.ttbCaractereNovo.Name = "ttbCaractereNovo";
            this.ttbCaractereNovo.Size = new System.Drawing.Size(207, 22);
            this.ttbCaractereNovo.TabIndex = 22;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(10, 231);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 28);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(117, 231);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ttbInstrucoes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.ttbEntrada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnInicioRapido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbPrefefinidos);
            this.Controls.Add(this.mtbPotencia);
            this.Controls.Add(this.mtbTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttbSaidaTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microondas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbSaidaTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbTempo;
        private System.Windows.Forms.MaskedTextBox mtbPotencia;
        private System.Windows.Forms.ComboBox cbbPrefefinidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInicioRapido;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox ttbEntrada;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttbInstrucoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox ttbCaractereNovo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ttbInstrucoesNovo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbPotenciaNovo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbTempoNovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttbNomeNovo;
    }
}


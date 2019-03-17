using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroondasBLL;
using MicroondasModels;

namespace Clariane_Menezes
{
    public partial class Form1 : Form
    {
        Microondas testebll;
        String caractere;
        Timer tmResposta;

        public Form1()
        {
            InitializeComponent();

            tmResposta = new Timer();
            tmResposta.Interval = 1000;
            tmResposta.Tick += TmResposta_Tick;
            tmResposta.Start();

            testebll = new MicroondasBLL.Microondas();

            cbbPrefefinidos.DataSource = testebll.ProgramaAquecimento;
            cbbPrefefinidos.DisplayMember = "Nome";
            cbbPrefefinidos.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MicroondasBLL.Microondas testebll = new MicroondasBLL.Microondas();

            MicroondasModels.Aquecimento objAquecimento = new Aquecimento();

            
        }
        private void TmResposta_Tick(object sender, EventArgs e)
        {
            ttbSaidaTexto.Text = testebll.mensagem?.ToString();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            int tempo = -1, potencia=-1;
            int.TryParse(mtbTempo.Text.Replace(":", "").Trim(), out tempo);
            int.TryParse(mtbPotencia.Text.Trim(), out potencia);
            testebll.Inicio(tempo.ToString(), potencia.ToString(), caractere);
            IniciarAquecimento();
        }

        private void btnInicioRapido_Click(object sender, EventArgs e)
        {
            testebll.InicioRapido();
            mtbTempo.Text = testebll.objAquecimento.Tempo;
            mtbPotencia.Text = testebll.objAquecimento.Potencia;

            IniciarAquecimento();
        }

        private void IniciarAquecimento()
        {
            var s = string.Empty;
            var retorno = string.Empty;

            Task transac = Task.Factory.StartNew(() => retorno = testebll.LigarMicroondas());
            Task aguardaTransac = Task.Factory.StartNew(() =>
            {
                Task.WaitAll(transac); // aguarda a comclusao da transacao
                transac.Dispose(); // apos o termino da transacao, a thread eh finalizada
            });
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ttbNomeNovo.ResetText();
            mtbTempoNovo.ResetText();
            mtbPotenciaNovo.ResetText();
            ttbInstrucoesNovo.ResetText();
            ttbCaractereNovo.ResetText();

            ttbNomeNovo.Enabled = true;
            mtbTempoNovo.Enabled = true;
            mtbPotenciaNovo.Enabled = true;
            ttbInstrucoesNovo.Enabled = true;
            ttbCaractereNovo.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            testebll.IncluiNovoProgramaAquecimento(ttbNomeNovo.Text, mtbTempoNovo.Text.Remove(2, 1), mtbPotenciaNovo.Text, ttbInstrucoesNovo.Text, ttbCaractereNovo.Text);

            cbbPrefefinidos.DataSource = null;
            cbbPrefefinidos.DataSource = testebll.ProgramaAquecimento;
            cbbPrefefinidos.DisplayMember = "Nome";
            cbbPrefefinidos.SelectedIndex = -1;

            ttbNomeNovo.ResetText();
            mtbTempoNovo.ResetText();
            mtbPotenciaNovo.ResetText();
            ttbInstrucoesNovo.ResetText();
            ttbCaractereNovo.ResetText();

            ttbNomeNovo.Enabled = false;
            mtbTempoNovo.Enabled = false;
            mtbPotenciaNovo.Enabled = false;
            ttbInstrucoesNovo.Enabled = false;
            ttbCaractereNovo.Enabled = false;
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {

        }

        private void cbbPrefefinidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbbPrefefinidos.SelectedIndex;
            if (index > -1)
            {
                testebll.objAquecimento = new Aquecimento();
                testebll.objAquecimento = testebll.ProgramaAquecimento.ElementAt(index);
                mtbTempo.Text = testebll.objAquecimento.Tempo.ToString();
                mtbPotencia.Text = testebll.objAquecimento.Potencia.ToString();
                ttbInstrucoes.Text = testebll.objAquecimento.Instrucoes.ToString();
                caractere = testebll.objAquecimento.Caracter.ToString();
            }
            else
            {
                mtbTempo.ResetText();
                mtbPotencia.ResetText();
                ttbInstrucoes.ResetText();
                caractere = ".";
            }
        }
    }
}

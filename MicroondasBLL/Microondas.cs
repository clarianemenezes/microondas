using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroondasModels;

namespace MicroondasBLL
{
    public class Microondas
    {
        public List<Aquecimento> ProgramaAquecimento { get; set; }
        public Aquecimento objAquecimento { get; set; }
        public StringBuilder mensagem { get; set; }

        public Microondas()
        {
            ProgramaAquecimento = new List<Aquecimento>();
            InicializaProgramaAquecimento();

            this.mensagem = new StringBuilder();
        }

        private bool PotenciaIsNULL()
        { return objAquecimento?.Potencia == "-1"; }

        private bool TempoIsNULL()
        { return objAquecimento?.Tempo == "-1"; }

        public bool ValidaPotencia()
        {   return (Convert.ToInt32(objAquecimento.Potencia) > 0 && Convert.ToInt32(objAquecimento.Potencia) < 11);
        }

        public bool ValidaTempo()
        { 
            int tempo = Convert.ToInt32(objAquecimento.Tempo);
            return (tempo > 0 && tempo <= 200);
        }

        public string TextoPorSegundo(int potencia, string caracter)
        {
            string textoNovo = "";
            for (int i = 0; i < potencia; i++)
                textoNovo += caracter;
            return textoNovo;
        }
        public string Aquecer()
        {
            int tempo = -1, potencia = -1;
            int.TryParse(objAquecimento.Tempo, out tempo);
            int.TryParse(objAquecimento.Potencia, out potencia);
            this.mensagem.Clear();

            for (int i = 0; i < tempo; i++)
            {
                string textoNovo = "";
                for (int j = 0; j < potencia; j++)
                    textoNovo += objAquecimento.Caracter;
                this.mensagem.Append(textoNovo);
            }

            this.mensagem.Append("aquecida");
            return "aquecida";
        }

        public void InicioRapido()
        {
            objAquecimento = new Aquecimento();

            objAquecimento.Potencia = "08";
            objAquecimento.Tempo = "0030";
            objAquecimento.Caracter = ".";
        }

        public void Inicio(string tempo, string potencia, string caractere)
        {
            objAquecimento = new Aquecimento();

            objAquecimento.Potencia = potencia;
            objAquecimento.Tempo = tempo;
            objAquecimento.Caracter = caractere;
        }

        public string LigarMicroondas()
        {
            try
            {
                if (!TempoIsNULL())
                { 
                    if (ValidaTempo())
                    {
                        if (!PotenciaIsNULL())
                        {
                            if (ValidaPotencia())
                            {
                                return Aquecer();
                            }   
                            else throw new System.ArgumentException("Parametrize a potência corretamente, entre 1 e 10!");
                        }
                        else throw new System.ArgumentException("Parametrize a potência antes de iniciar o aquecimento!");
                    }
                    else throw new System.ArgumentException("Parametrize o tempo corretamente, entre 1 segundo e 2 minutos!");
                }
                else throw new System.ArgumentException("Parametrize o tempo antes de iniciar o aquecimento!");
            }
            catch (System.ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Microondas - ERRO", System.Windows.Forms.MessageBoxButtons.OK);
                return "";
            }
        }

        public void InicializaProgramaAquecimento()
        {
            ProgramaAquecimento.Add(new Aquecimento("Lasanha", "0200", "10", "esquentar lasanha", "!"));
            ProgramaAquecimento.Add(new Aquecimento("Pipoca", "0150", "06", "estourar pipoca", "@"));
            ProgramaAquecimento.Add(new Aquecimento("Pizza", "0200", "08", "esquentar pizza", "#"));
            ProgramaAquecimento.Add(new Aquecimento("Bebidas", "0100", "04", "esquentar bebidas", "$"));
            ProgramaAquecimento.Add(new Aquecimento("Vegetais", "0050", "03", "esquentar vegetais", "%"));
            ProgramaAquecimento.Add(new Aquecimento("Reaquecer", "0130", "07", "reaquecer comida", "&"));
        }

        public void IncluiNovoProgramaAquecimento(string nome, string tempo, string potencia, string instrucoes, string caracter)
        {
            ProgramaAquecimento.Add(new Aquecimento(nome, tempo, potencia, instrucoes, caracter));
        }

        public bool Gravar(Aquecimento objAquecimento)
        {
            return true;
        }
    }
}

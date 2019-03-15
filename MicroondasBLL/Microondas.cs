using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroondasModels;

namespace MicroondasBLL
{
    public class Microondas
    {
        public List<Aquecimento> ProgramaAquecimento { get; set; }
        private Aquecimento objAquecimento;
        public Task transac;
        public Task aguardaTransac;

        private bool PotenciaIsNULL()
        { return objAquecimento.Potencia == -1; }

        private bool TempoIsNULL()
        { return objAquecimento.Tempo == -1; }

        public bool ValidaPotencia()
        {   return (objAquecimento.Potencia > 0 && objAquecimento.Potencia < 11);
        }

        public bool ValidaTempo()
        {   return (objAquecimento.Tempo > 0 && objAquecimento.Tempo < 200);
        }

        public string MostrarTexto(string textoAntigo, int pontos)
        {
            string textoNovo = "";
            for (int i = 0; i < pontos; i++)
                textoNovo += ".";
            return textoAntigo + textoNovo;
        }
        public string Aquecer(Aquecimento objAquecimento)
        {

            return "aquecida";
        }

        public string InicioRapido()
        {
            Aquecimento objAquecimento = new Aquecimento();

            objAquecimento.Potencia = 8;
            objAquecimento.Tempo = 30;

            // objAquecimento.Potencia = ProgramaAquecimento.Pipoca.Potencia;
            //objAquecimento.Tempo = ProgramaAquecimento.Pipoca.Tempo;

            return Aquecer(objAquecimento);
        }

        public void Inicio()
        {

        }

        public void LigarMicroondas()
        {
            if (!TempoIsNULL())
            {
                if (ValidaTempo())
                {
                    if (!PotenciaIsNULL())
                    {
                        if (ValidaPotencia())
                        {
                            this.transac = Task.Factory.StartNew(() => Inicio());
                            this.transac.Wait();
                        }
                        else throw new System.ArgumentException("Parametrize a potência corretamente, entre 1 e 10!");
                    }
                    else throw new System.ArgumentException("Parametrize a potência antes de iniciar o aquecimento!");
                }
                else throw new System.ArgumentException("Parametrize o tempo corretamente, entre 1 segundo e 2 minutos!");
            }
            else throw new System.ArgumentException("Parametrize o tempo antes de iniciar o aquecimento!");
        }

        public void InicializaProgramaAquecimento()
        {
            ProgramaAquecimento.Add(new Aquecimento("Lasanha", "650", "10", "esquentar lasanha", ""));
            ProgramaAquecimento.Add(new Aquecimento("Pipoca", "300", "6", "estourar pipoca", ""));
            ProgramaAquecimento.Add(new Aquecimento("Pizza", "500", "8", "esquentar pizza", ""));
            ProgramaAquecimento.Add(new Aquecimento("Bebidas", "200", "4", "esquentar bebidas", ""));
            ProgramaAquecimento.Add(new Aquecimento("Vegetais", "150", "5", "esquentar vegetais", ""));
            ProgramaAquecimento.Add(new Aquecimento("Reaquecer", "250", "7", "reaquecer comida", ""));
        }

        public bool Gravar(Aquecimento objAquecimento)
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class Elevador
    {
        public Elevador()
        {
            AndarAtual = 0;
            QuantPessoas = 0;
        }
        public int AndarAtual { get; set; }
        public int TotalAndares { get; set; }
        public int QuantPessoas { get; set; }
        public int CapDoElevador { get; set; }

        public void Inicializar(int capacidadeElevador, int totalAndares)
        {
            CapDoElevador = capacidadeElevador;
            TotalAndares = totalAndares;
        }
        public string Entrar()
        {
            if (QuantPessoas <= CapDoElevador)
            {
                QuantPessoas++;
                if (AndarAtual == 0)
                    return "Entrou uma pessoa, elevador no térreo e tem " + QuantPessoas + " pessoas no elevador";
                else
                    return "Entrou uma pessoa, elevador no " + AndarAtual + "º andar e tem " + QuantPessoas + " pessoas no elevador";
            }
            else
            {
                return "Elevador com capacidade total";

            }
        }
        public string Sair()
        {
            if (QuantPessoas > 0)
            {

                QuantPessoas--;
                return "Saiu uma pessoa, elevador esta no " + AndarAtual + "º andar e tem " + QuantPessoas + " pessoa no elevador";
            }

            else
            {
                return "Elevador vazio";

            }
        }

        public string Subir()
        {
            if (AndarAtual < TotalAndares)
            {
                AndarAtual++;
                return "Subiu um andar, está no " + AndarAtual + "º andar e tem " + QuantPessoas + " pessoa no elevador";
            }

            else
            {
                return "Elevador não pode subir,já está no ultimo andar e tem  " + QuantPessoas + " pessoa no elevador";

            }
        }

        public string Descer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                return "Desceu um andar, está no " + AndarAtual + "º andar e tem " + QuantPessoas + " pessoa no elevador";

            }
            else
            {
                return "Elevador não pode descer, já está no térreo";

            }
        }

    }
}


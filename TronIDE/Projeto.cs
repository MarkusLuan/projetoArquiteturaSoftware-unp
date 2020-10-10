using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronIDE
{
    public class Projeto
    {
        private string modelo;
        private string nome;
        private string pasta;

        public Projeto(string modelo)
        {
            this.modelo = modelo;
        }

        public string getModelo()
        {
            return modelo;
        }

        public string getNome()
        {
            return nome;
        }

        public string getPasta()
        {
            return pasta;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setPasta(string pasta)
        {
            this.pasta = pasta;
        }
    }
}

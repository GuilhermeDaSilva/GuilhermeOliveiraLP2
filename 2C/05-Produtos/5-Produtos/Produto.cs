using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Produtos
{
    class Produto
    {       
        private int id;
        public int Id{ get { return id; } }

        private string nome;
        public string Nome { get { return nome; } }

        private double preco;
        public double Preco { get { return preco; } }

        private int quantidade;
        public int Quantidade { get { return quantidade; } }
        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }
        public void Reposicao(int quantidade)
        {
            this.quantidade += quantidade;           
        }
        public void Retirada(int qtd)
        {
            if (this.Quantidade >= qtd) {this.quantidade -= qtd;}
            else
                throw new Exception();
        }
        public string Imprimir()
        {
            return string.Format("{0}, {1}, {2:0.00}", id, nome, preco);
        }
 
    }
}

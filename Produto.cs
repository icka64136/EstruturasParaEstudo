using System;
using System.Globalization;

namespace Loja
{
    class Produto
    {
        // Ordem  de Organização do Programa: 1° Atributo Privado !
        private string _nome; // Encapsulamento // o Nome Não Pode Ter Autro Properties neste Caso Pois Ha uma Lógica Por Trás dele !
        // 2° Propriedades Auto Emplementadas.
        public double Preco { get; private set; }//Auto Properties Pode Adicionar o Valor mas com o Private Set Não Pode Alterar o Valor!
        public int Quantidade { get; set; }
        //3° Construtores
        public Produto()//CONSTRUTOR
        {

        }
        public Produto(string nome, double preco, int quantidade) // Construtor tem o mesmo Nome que a Classe .
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        // 4° Propriedades Customizadas
        public string Nome // Properties Manual
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) // só faz a Atribuição se o nome Recebido não for Nulo e Tiver mais de um Caracteres.
                {
                    _nome = value; // Value é o Parâmetro Passado Para o Metodo Set fazendo a Atribuição.
                }
            }
        }
        //5° Outros Metodos

        /*public double Preco
        {
            get { return _preco; }//Autorização Para o Usuario Exibir o Preço do Produto
            set { _preco = value; }//Autorização Para o Usuario Modificar o Preço do Produto
        }*/
        /*public int Quantidade
        {
            get { return _quantidade; }//Autorização Para o Usuario Exibir a Quantidade do Produto
            set { _quantidade = value; } //Autorização Para o Usuario Modificar a Quantidade do Produto           
        }*/
        public double ValorTotal()
        {

            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade)// a Função vai ser Void Pous não vai retornar valor de Saida
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString() // Serve para Fazer a Re Ultilização  dO Código, e Deixar o Programa Mais Limpo.
        {
            return "Produto : " + _nome + " , Preço : $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
               + ", Quantidade : " + Quantidade + ", Valor Total : $" + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

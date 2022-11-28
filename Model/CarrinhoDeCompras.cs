using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCarrinhoCompras.Model;

namespace TDDCarrinhoCompras.Model
{
    public class CarrinhoDeCompras

    {
        public IList<Item> Itens { get; private set; }

        public CarrinhoDeCompras()
        {
            Itens = new List<Item>();
        }

        public void Adiciona(Item item)
        {
            Itens.Add(item);
        }

        public double MaiorValor()
        {
            if (Itens.Count == 0) return 0;

            double maior = Itens[0].ValorTotal;

            foreach (Item item in Itens)
            {
                if (maior < item.ValorTotal)
                {
                    maior = item.ValorTotal;
                }
            }
            return maior;
        }
    }
}

//public class CarrinhoDeCompraBuilder
//{
//    public CarrinhoDeCompras carrinho;

//    public CarrinhoDeCompraBuilder()
//    {
//        carrinho = new CarrinhoDeCompras();
//    }

//    public CarrinhoDeCompraBuilder ComItens(double valores)
//    {
//        foreach (double valor in valores)
//        {
//            carrinho.Adiciona(new Item("item", 1, valor));
//        }
//        return this;
//    }

//    public CarrinhoDeCompras Cria()
//    {
//        return carrinho;
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCarrinhoCompras.Model
{
    public class Item
    {
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }

        public Item(string descricao, int quantidade, double valorUnitario)
        {
            Descricao = descricao;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public double ValorTotal => ValorUnitario * Quantidade;
    }
}
﻿using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public CarrinhoViewModel(List<ItemPedido> itens)
        {
            Itens = itens;
        }

        public List<ItemPedido> Itens { get; }
        public decimal Total => Itens.Sum(i => i.PrecoUnitario * i.Quantidade);

    }
}

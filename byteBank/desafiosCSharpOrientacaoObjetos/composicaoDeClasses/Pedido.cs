using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.desafiosCSharpOrientacaoObjetos.composicaoDeClasses
{
    public class Pedido
    {
        public int numero_Pedido;
        public Cliente cliente;
        public ItemPedido item;
        public float total_Pedido;
    }
}

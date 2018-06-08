using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio
{
    public class Bebida : Produto
    {
        public long Tamanho { get; set; }

        public override string Descricao()
        {
            return Id + " - " + Nome + " - " + Tamanho + "ml" + " - R$" + Valor;
        }
    }
}

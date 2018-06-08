using FoodTruck.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTruck.Grafico
{
    public partial class Detalhes : Form
    {
        private Pedido pedido;
        public Detalhes(long Id)
        {
            InitializeComponent();
            this.dgLanches.ReadOnly = true;
            this.dbBebidas.ReadOnly = true;
            this.pedido = Util.Gerenciador.BuscarPedidoPorCodigo(Id);
            this.dgLanches.DataSource = this.pedido.Lanches;
            this.dbBebidas.DataSource = this.pedido.Bebidas;
            this.lbCliente.Text = this.pedido.Cliente.Nome;
            this.lbId.Text = this.pedido.Id.ToString();
            this.lbTotal.Text = (this.pedido.Bebidas.Sum(e => e.Valor) + this.pedido.Lanches.Sum(e => e.Valor)).ToString();
        }
    }
}

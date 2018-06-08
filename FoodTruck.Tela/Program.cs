using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTruck.Negocio;

namespace FoodTruck.Tela
{
    class Program
    {
        static Gerenciador gerenciador = new Gerenciador();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== FOODTRUCK MANAGER ======");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Lanche");
                Console.WriteLine("3 - Cadastrar Bebidas");
                Console.WriteLine("4 - Criar Pedido");
                Console.WriteLine("5 - Adicionar Item ao Pedido");
                Console.WriteLine("6 - Mostrar NF");
                Console.WriteLine("7 - Mostrar relatório geral");
                Console.WriteLine("0 - Sair");

                Int32 opcao = 0;
                bool conseguiu = Int32.TryParse(Console.ReadLine(), out opcao);
                if (!conseguiu)
                {
                    Console.WriteLine("A opção digitada não é um número");
                    Console.ReadLine();
                    continue;
                }

                switch (opcao)
                {
                    case 0: break;
                    case 1: GerenciarClientes();
                        break;
                    case 2: GerenciarLanches();
                        break;
                    case 3: GerenciarBebidas();
                        break;
                    case 4: GerenciarPedidos();
                        break;
                    case 5: AdicionarItemPedido();
                        break;
                    case 6: NotaFiscalPedido();
                        break;
                    case 7: MostrarRelatorio();
                        break;

                }

                if (opcao == 0)
                    break;


            }
        }

        private static void NotaFiscalPedido()
        {
            Console.Clear();
            try
            {
                Int64 codigoPedido = 0;
                Console.WriteLine("Informe o código do pedido");
                bool conseguiu = Int64.TryParse(Console.ReadLine(), out codigoPedido);
                if (!conseguiu)
                    throw new Exception("O código precisa ser um número");

                Pedido pedido = gerenciador.BuscarPedidoPorCodigo(codigoPedido);
                if (pedido == null)
                    throw new Exception("O pedido informado não existe");

                Console.WriteLine(pedido.GerarNotaFiscal());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void AdicionarItemPedido()
        {
            Console.Clear();
            try
            {
                Int64 codigoPedido = 0;
                Console.WriteLine("Informe o código do pedido");
                bool conseguiu = Int64.TryParse(Console.ReadLine(), out codigoPedido);
                if (!conseguiu)
                    throw new Exception("O código precisa ser um número");

                Pedido pedido = gerenciador.BuscarPedidoPorCodigo(codigoPedido);
                if (pedido == null)
                    throw new Exception("O pedido informado não existe");

                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Lanches");
                Console.WriteLine("2 - Bebidas");
                Console.WriteLine("0 - Sair");
                int opcao = 0;
                conseguiu = Int32.TryParse(Console.ReadLine(), out opcao);
                if (!conseguiu)
                    throw new Exception("A opção precisa ser um número");

                switch (opcao)
                {
                    case 1: AdicionaLancheAoPedido(pedido);
                        break;
                    case 2: AdicionaBebidaAoPedido(pedido);
                        break;
                    case 0: break;
                    default: throw new Exception("Opção inválida");
                        
                }


            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        private static void AdicionaBebidaAoPedido(Pedido pedido)
        {
            foreach(Bebida bebida in gerenciador.BebidasCadastradas())
            {
                Console.WriteLine(bebida.Descricao());
            }

            Console.WriteLine("Informe o código da bebida");
            long codigoBebida = 0;
            bool conseguiu = Int64.TryParse(Console.ReadLine(), out codigoBebida);
            if (!conseguiu)
                throw new Exception("O código precisa ser um número");

            Bebida bebidaSecionada = gerenciador.BuscarBebidaPorCodigo(codigoBebida);
            if (bebidaSecionada == null)
                throw new Exception("Não existe bebida com o código informado");

            gerenciador.AdicionarBebidaAoPedido(pedido, bebidaSecionada);
            Console.WriteLine("Bebida {0} adicionada ao pedido {1}", bebidaSecionada.Nome, pedido.Id);
            Console.ReadLine();

        }

        private static void AdicionaLancheAoPedido(Pedido pedido)
        {
            foreach (Lanche lanche in gerenciador.LanchesCadastrados())
            {
                Console.WriteLine(lanche.Descricao());
            }

            Console.WriteLine("Informe o código do lanche");
            long codigoLanche = 0;
            bool conseguiu = Int64.TryParse(Console.ReadLine(), out codigoLanche);
            if (!conseguiu)
                throw new Exception("O código precisa ser um número");

            Lanche lancheSecionado = gerenciador.BuscarLanchePorCodigo(codigoLanche);
            if (lancheSecionado == null)
                throw new Exception("Não existe lanche com o código informado");

            gerenciador.AdicionarLancheAoPedido(pedido, lancheSecionado);
            Console.WriteLine("Lanche {0} adicionada ao pedido {1}", lancheSecionado.Nome, pedido.Id);
            Console.ReadLine();
        }

        private static void MostrarRelatorio()
        {
            Console.WriteLine(gerenciador.GerarRelatorioGeral());
            Console.ReadLine();
        }

        private static void GerenciarPedidos()
        {
            Console.Clear();
            Console.WriteLine("==== NOVO PEDIDO ====");
            try
            {
                Pedido pedido = new Pedido();
                Int64 codigoPedido = 0;
                Console.WriteLine("Informe o código do pedido");
                bool conseguiu = Int64.TryParse(Console.ReadLine(), out codigoPedido);
                if (!conseguiu)
                    throw new Exception("O código precisa ser um número");
                
                pedido.Id = codigoPedido;
                Console.WriteLine("Informe a data do pedido");
                DateTime dataPedido;
                conseguiu = DateTime.TryParseExact(Console.ReadLine(), 
                                                   "dd/MM/yyyy HH:mm", 
                                                   null, 
                                                   System.Globalization.DateTimeStyles.None, 
                                                   out dataPedido);
                if (!conseguiu)
                    throw new Exception("Formato de data inválido");
                 
                pedido.Data = dataPedido;

                Console.WriteLine("Informe o CPF do cliente");
                String cpfCliente = Console.ReadLine();
                Cliente cliente = gerenciador.BuscarClientePorCPF(cpfCliente);
                if(cliente == null)
                {
                    throw new Exception("O cliente informado não existe na base");
                }else
                {
                    Console.WriteLine("Cliente: {0}", cliente.Nome);
                }

                pedido.Cliente = cliente;

                gerenciador.AdicionarPedido(pedido);

                Console.WriteLine("Pedido {0} cadastrado com sucesso!", pedido.Id);
                Console.ReadLine();

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void GerenciarBebidas()
        {
            Console.Clear();
            try
            {
                Bebida bebida = new Bebida();
                Console.WriteLine("Informe o código da bebida");
                Int64 codigoBebida = 0;
                bool conseguiu = Int64.TryParse(Console.ReadLine(), out codigoBebida);
                if (!conseguiu)
                    throw new Exception("O código precisa ser um número");
                 

                bebida.Id = codigoBebida;
                Console.WriteLine("Informe o nome da bebida");
                bebida.Nome = Console.ReadLine();

                decimal valor = 0m;
                Console.WriteLine("Informe o valor");
                conseguiu = Decimal.TryParse(Console.ReadLine(), out valor);
                if (!conseguiu)
                    throw new Exception("O valor precisa ser um número");
                

                bebida.Valor = valor;

                long tamanho = 0;
                Console.WriteLine("Informe o tamanho (em ml)");
                conseguiu = long.TryParse(Console.ReadLine(), out tamanho);
                if (!conseguiu)
                    throw new Exception("O tamanho precisa ser um número");

                bebida.Tamanho = tamanho;
                gerenciador.AdicionarBebida(bebida);
                Console.WriteLine("Bebida cadastrada com sucesso!");
                Console.ReadLine();
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void GerenciarLanches()
        {
            Console.Clear();
            try
            {
                Lanche lanche = new Lanche();
                Console.WriteLine("Informe o código do lanche");
                int codigoLanche = 0;
                bool conseguiu = Int32.TryParse(Console.ReadLine(), out codigoLanche);
                if (!conseguiu)
                    throw new Exception("O código do lanche precisa ser um número");

                lanche.Id = codigoLanche;
                Console.WriteLine("Informe o nome do lanche");
                lanche.Nome = Console.ReadLine();
                Console.WriteLine("Informe o valor do lanche");
                Decimal valorLanche = 0.0m;
                conseguiu = Decimal.TryParse(Console.ReadLine(), out valorLanche);
                if (!conseguiu)
                    throw new Exception("O valor precisa ser um número");

                lanche.Valor = valorLanche;
                gerenciador.AdicionarLanche(lanche);
                Console.WriteLine("Lanche cadastrado com sucesso!");
                Console.ReadLine();
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void GerenciarClientes()
        {
            Console.Clear();
            try
            {
                Cliente cliente = new Cliente();
                Console.WriteLine("Informe o CPF");
                cliente.CPF = Console.ReadLine();
                Console.WriteLine("Informe o nome");
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("Informe o email");
                cliente.Email = Console.ReadLine();
                gerenciador.AdicionarCliente(cliente);
                Console.WriteLine("Cliente adicionado com sucesso!");
                Console.ReadLine();

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}

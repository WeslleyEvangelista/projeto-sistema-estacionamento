namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> pátio = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Pedir para o usuário digitar uma placa e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para entrar no pátio:");
            pátio.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover do pátio:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();


            // Verifica se o veículo existe
            if (pátio.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no pátio:");

                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu no pátio
                // E calcular a permanência total do veículo                
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // Remove a placa digitada do pátio (lista de veículos) e cobra o valor total ao cliente
                pátio.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não consta no pátio. Verifique a placa novamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no pátio
            if (pátio.Any())
            {
                Console.WriteLine("Veículos no pátio:");
                // Exibindo todos os veículos no pátio
                foreach (var placa in pátio)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos no pátio.");
            }
        }
    }
}

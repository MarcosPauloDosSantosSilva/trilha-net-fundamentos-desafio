namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial =0 ;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            for(int  contador=0; contador<1; contador++ ){
               string placa  = Console.ReadLine();
               veiculos.Add(placa);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");          
            string placa = Console.ReadLine();
                       
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");                            
                int horas = int.Parse(Console.ReadLine()); 
                decimal valorTotal = precoInicial + precoPorHora*horas;              
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");               
                int contadorForeach = 0;

                foreach( string placa in veiculos){
                Console.WriteLine($"placa :{placa}");
                }                
            }
           
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

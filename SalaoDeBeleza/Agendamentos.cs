
namespace SalaoDeBeleza
{
    public class Agendamentos
    {

        public string Nome { get; set; }
        public int Horario { get; set; }
        public int OpcaoFuncao { get; set; }

        public void DadosClientes(int horario)
        {
            Console.Write("Digite seu nome: ");
            Nome = Console.ReadLine();
            Horario = 9 + 1;
            Console.WriteLine("Agendamento feito com sucesso!");
        }

    }
}

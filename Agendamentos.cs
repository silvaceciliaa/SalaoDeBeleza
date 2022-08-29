namespace SalaoDeBeleza
{
    public class Agendamentos
    {

        public string NomeM { get; set; }
        public string NomeS { get; set; }
        public string NomeC { get; set; }
        public int Horario { get; set; }
        public int OpcaoFuncao { get; set; }
        public string Funcao { get; set; }

        public void DadosManicure(int horario)
        {
            Console.Write("Digite seu nome: ");
            NomeM = Console.ReadLine();
            Console.WriteLine($"Agendamento feito com sucesso!");
        }
        public void DadosSobrancelhas(int horario)
        {
            Console.Write("Digite seu nome: ");
            NomeS = Console.ReadLine();
            Console.WriteLine($"Agendamento feito com sucesso!");
        }
        public void DadosCabelo(int horario)
        {
            Console.Write("Digite seu nome: ");
            NomeC = Console.ReadLine();
            Console.WriteLine($"Agendamento feito com sucesso!");
        }
        public void LimparDadosM()
        {
            NomeM = null;
            Horario = 0;
            Console.WriteLine("Dados apagados com sucesso!");
        }
        public void LimparDadosS()
        {
            NomeS = null;
            Horario = 0;
            Console.WriteLine("Dados apagados com sucesso!");
        }
        public void LimparDadosC()
        {
            NomeC = null;
            Horario = 0;
            Console.WriteLine("Dados apagados com sucesso!");
        }
    }
}

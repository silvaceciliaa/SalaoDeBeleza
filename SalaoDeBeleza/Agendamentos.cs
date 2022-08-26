
namespace SalaoDeBeleza
{
    public class Agendamentos
    {

        public string Nome { get; set; }
        public string Horario { get; set; }

        public void DadosClientes()
        {
            Console.Write("Digite seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Escolha um dos horários para agendar: (a)09:00 - (b)15:00 - (c)18:00");
            string opcaoHorario = Console.ReadLine();

            if(opcaoHorario == "a")
            {
                int nove = 0;
               
             if(nove == 3)
                {
                    Console.WriteLine("Não existem horários disponíveis.");
                }
             else
                {
                    Console.WriteLine("Horário marcado com sucesso!");
                }
                nove++;
            }
            if (opcaoHorario == "b")
            {
                int tres = 0;
                tres++;
                if (tres == 3)
                {
                    Console.WriteLine("Não existem horários disponíveis.");
                }
            }
            if(opcaoHorario == "c")
            {
                int seis = 0;
                seis++;
                if (seis == 3)
                {
                    Console.WriteLine("Não existem horários disponíveis.");
                }
            }
        }
    }
}

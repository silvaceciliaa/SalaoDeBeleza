using System.Security.Cryptography.X509Certificates;

namespace SalaoDeBeleza
{
    public class Agendamentos
    {

        public string Nome { get; set; }
        public int Horario { get; set; }

        public string Funcao { get; set; }
        public int OpcaoFuncao { get; set; }

        public void DadosClientes()
        {
            Console.Write("Digite seu nome: ");
            Nome = Console.ReadLine();
            if (OpcaoFuncao == 1)
            {
                Horario = 9 + 1;

            }
            if (OpcaoFuncao == 2)
            {
                Horario = 9 + 1;

            }
            if (OpcaoFuncao == 3)
            {
                Horario = 9 + 1;

            }
            Console.WriteLine("Agendamento feito com sucesso!");
        }

        public void Agendar()
        {
            int[] clientes = new int[10];
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Selecione uma das opções para agendamento");
                Console.WriteLine(" 1 - Manicure\n 2 - Design de sobrancelhas\n 3 - Corte de cabelo\n");
                int OpcaoFuncao = Convert.ToInt32(Console.ReadLine());

                if (OpcaoFuncao < 4 && OpcaoFuncao > 0)
                {
                    bool disponibilidade = false;
                    for (int i = 0; i < clientes.Length; i++)
                    {
                        if (Nome == null)
                        {
                            disponibilidade = true;
                            DadosClientes();
                            break;
                        }
                    }
                    for (int i = 0; i < clientes.Length; i++)
                    {
                        if (disponibilidade == false)
                        {
                            Console.WriteLine("Não existem horários disponiveis.");
                        }
                    }
                    break;
                }
            }
        }
        public  void EscolherFuncao()
        {
            if (OpcaoFuncao == 1)
            {
                Funcao = "Manicure";
            }
            if (OpcaoFuncao == 2)
            {
                Funcao = "Design de sobrancelhas";
            }
            if (OpcaoFuncao == 3)
            {
                Funcao = "Corte de cabelo";
            }
        }
    
    public void LimparDados()
        {
          Nome = null;
          OpcaoFuncao = 0;
          Funcao = null;
          Horario = 0;

        }
    }
}

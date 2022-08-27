using SalaoDeBeleza;

Agendamentos[] clientes = new Agendamentos[9];
bool loop = true, loop2 = true;
string opcaoMenu1;
int opcaoMenu2;

for (int i = 0; i < clientes.Length; i++)
{
    clientes[i] = new Agendamentos();
}
clientes[9].OpcaoFuncao = opcaoMenu2;
while (loop)
{
    
    Console.WriteLine("Seja bem-vindo ao salão Silva&Hoegen! Selecione uma das opções do menu:");
    Console.WriteLine(" 1 - Agendamento\n 2 - Retirar agendamento\n 3 - Consultar disponibilidade\n 4 - Sair\n");
    opcaoMenu1 = Console.ReadLine();

    if (opcaoMenu1 == "1")
    {
        Console.Clear();
        Console.WriteLine("Selecione uma das opções para agendamento");
        Console.WriteLine(" 1 - Manicure\n 2 - Design de sobrancelhas\n 3 - Corte de cabelo\n");
        opcaoMenu2 = Convert.ToInt32(Console.ReadLine());

        if (opcaoMenu2 < 4 && opcaoMenu2 > 0)
        {
            bool disponibilidade = false;
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].Nome == null)
                {
                    disponibilidade = true;
                    clientes[i].DadosClientes(i);
                    break;
                }
            }
            for(int i = 0; i < clientes.Length; i++)
            { 
                if (disponibilidade == false)
                {
                    Console.WriteLine("Não existem horários disponiveis.");
                }
            }
        }
    }
     if (opcaoMenu1 == "2")
        {


        }
        if (opcaoMenu1 == "3")
        {
        Console.Clear();
           for(int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine($"Nome: {clientes[i].Nome} - Horário: - ");
            }
        }
        if (opcaoMenu1 == "4")
        {
            Console.WriteLine("Obrigada por usar o programa do Salão Silva&Hoegen!");
            break;
        }
        else
        {
            loop = true;
        }
    }

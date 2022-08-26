using SalaoDeBeleza;

Agendamentos[] clientes = new Agendamentos[9];
bool loop = true, disponibilidade = true;
string opcaoMenu1, opcaoMenu2;

for (int i = 0; i < clientes.Length; i++)
{
    clientes[i] = new Agendamentos();
}

while (loop)
{
    Console.WriteLine("Seja bem-vindo ao salão Silva&Hoegen! Selecione uma das opções do menu:");
    Console.WriteLine(" 1 - Agendamento\n 2 - Retirar agendamento\n 3 - Consultar disponibilidade\n 4 - Sair\n");
    opcaoMenu1 = Console.ReadLine();

    if (opcaoMenu1 == "1")
    {
        Console.WriteLine("Selecione uma das opções para agendamento");
        Console.WriteLine(" 1 - Manicure\n 2 - Design de sobrancelhas\n 3 - Corte de cabelo\n");
        opcaoMenu2 = Console.ReadLine();

        for (int i = 0; i < clientes.Length; i++)
        {
          if(clientes[i].Nome == null)
            {
                Console.Clear();
                clientes[i].DadosClientes();
            }
        }

     if (opcaoMenu1 == "2")
        {

        }
        else if (opcaoMenu1 == "3")
        {
           
        }
        else if (opcaoMenu1 == "4")
        {
            Console.WriteLine("Obrigada por usar o programa do Salão Silva&Hoegen!");
            break;
        }
    }
}

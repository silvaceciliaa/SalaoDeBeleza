using SalaoDeBeleza;

Agendamentos[] clientes = new Agendamentos[10];
bool loop = true;
string opcaoMenu1;

for (int i = 0; i < clientes.Length; i++)
{
    clientes[i] = new Agendamentos();
}
while (loop) ;
{
    Console.WriteLine("Seja bem-vindo ao salão Silva&Hoegen! Selecione uma das opções do menu:");
    Console.WriteLine(" 1 - Agendamento\n 2 - Retirar agendamento\n 3 - Consultar disponibilidade\n 4 - Sair\n");
    opcaoMenu1 = Console.ReadLine();

    if (opcaoMenu1 == "1")
    {
        Console.Clear();
        for (int i = 0; i < clientes.Length; i++)
        {
            clientes[i].Agendar();
            break;
        }
    }
    if (opcaoMenu1 == "2")
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o nome da funcao que deseja remover");
        string funcao = Console.ReadLine();

        for (int i = 0; i < clientes.Length; i++)
        {
            if (nome == clientes[i].Nome && funcao == clientes[i].Funcao)
            {
                clientes[i].LimparDados();
            }
            else
            {
                Console.WriteLine("Você não foi encontrado no nosso sistema");
            }

        }
    }
    if (opcaoMenu1 == "3")
        {
            Console.Clear();
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine($"Nome: {clientes[i].Nome} - Horário: {clientes[i].Horario}:00 - {clientes[i].Funcao}");
            }
        }
        if (opcaoMenu1 == "4")
        {
            Console.WriteLine("Obrigada por usar o programa do Salão Silva&Hoegen!");
            loop = false;
        }
        else
        {
            loop = true;
        }
}

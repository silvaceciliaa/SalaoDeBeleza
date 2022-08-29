using SalaoDeBeleza;

Agendamentos[] clientes = new Agendamentos[3];
bool loop = true, disponibilidade = false;

for (int i = 0; i < clientes.Length; i++)
{
    clientes[i] = new Agendamentos();

}
while (loop)
{
    Console.WriteLine("Seja bem-vindo ao salão Silva! Selecione uma das opções do menu:");
    Console.WriteLine(" 1 - Agendamento\n 2 - Retirar agendamento\n 3 - Consultar disponibilidade\n 4 - Sair\n");
     string opcaoMenu = Console.ReadLine();

    if (opcaoMenu == "1")
    {
        Console.Clear();
        Console.WriteLine("Selecione uma das opções para agendamento");
        Console.WriteLine(" 1 - Manicure\n 2 - Design de sobrancelhas\n 3 - Corte de cabelo\n");
        int opcaoFuncao = Convert.ToInt32(Console.ReadLine());

        if (opcaoFuncao == 1)
        {
            Console.Clear();
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].NomeM == null)
                {
                    disponibilidade = true;
                    clientes[i].DadosManicure(i);
                    break;
                }
            }
            if (disponibilidade == false)
            {
                Console.WriteLine("Não existem horários disponiveis.");
            }
        }
        if (opcaoFuncao == 2)
        {
            Console.Clear();
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].NomeS == null)
                {
                    disponibilidade = true;
                    clientes[i].DadosSobrancelhas(i);
                    break;
                }
            }
            if (disponibilidade == false)
            {
                Console.WriteLine("Não existem horários disponiveis.");
            }
        }
        if (opcaoFuncao == 3)
        {
            Console.Clear();
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].NomeC == null)
                {
                    disponibilidade = true;
                    clientes[i].DadosCabelo(i);
                    break;
                }
            }
            if (disponibilidade == false)
            {
                Console.WriteLine("Não existem horários disponiveis.");
            }
        }

    }
    if (opcaoMenu == "2")
    {
        Console.Clear();
        Console.WriteLine("Selecione uma das opções para remover");
        Console.WriteLine(" 1 - Manicure\n 2 - Design de sobrancelhas\n 3 - Corte de cabelo\n");
        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            for (int i = 0; i < clientes.Length; i++)
            {
                if (nome == clientes[i].NomeM)
                {
                    clientes[i].LimparDadosM();
                    break;
                }
                else
                {
                    Console.WriteLine("Você não foi encontrado no nosso sistema");
                    break;
                }
            }
        }
        if (opcao == 2)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            for (int i = 0; i < clientes.Length; i++)
            {
                if (nome == clientes[i].NomeS)
                {
                    clientes[i].LimparDadosS();
                    break;
                }
                else
                {
                    Console.WriteLine("Você não foi encontrado no nosso sistema");
                    break;
                }
            }
        }
            if (opcao == 3)
            {
                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();

                for (int i = 0; i < clientes.Length; i++)
                {
                    if (nome == clientes[i].NomeC)
                    {
                        clientes[i].LimparDadosC();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Você não foi encontrado no nosso sistema");
                        break;
                    }
                }
            }
    }
    if (opcaoMenu == "3")
    {
        Console.Clear();
        int horario1 = 9;
        int horario2 = 9;
        int horario3 = 9;
        for (int i = 0; i < clientes.Length; i++)
        {
            horario1++;
            Console.WriteLine($"Nome: {clientes[i].NomeM} - Horário: {horario1}:00 - Manicure");
        }
        for (int i = 0; i < clientes.Length; i++)
        {
            horario2++;
            Console.WriteLine($"Nome: {clientes[i].NomeS} - Horário: {horario2}:00 - Design de sobrancelhas");
        }
        for (int i = 0; i < clientes.Length; i++)
        {
            horario3++;
            Console.WriteLine($"Nome: {clientes[i].NomeC} - Horário: {horario3}:00 - Corte de cabelo");
        }
    }
    if (opcaoMenu == "4")
        {
            Console.Clear();
            Console.WriteLine("Obrigada por usar o programa do Salão Silva!");
            loop = false;
        }
    else
    {
        loop = true;
    }
    
}
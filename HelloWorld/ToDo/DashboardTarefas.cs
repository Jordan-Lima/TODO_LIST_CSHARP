namespace HelloWorld.ToDo;

public class DashboardTarefas
{
    public static void ExecutarAplicacao()
    {
        List<Tarefa> listaTarefas = new List<Tarefa>();
        int opcao = 0;

        do
        {
            Console.WriteLine("Escolha uma ação: \n1 - Criar tarefa\n2 - Iniciar tarefa\n3 - Listar tarefas\n4 - Finalizar tarefa\n5 - Editar tarefa\n6 - Excluir tarefa\n0 - Sair");
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Entrada inválida. Digite um número entre 0 e 6.");
                continue;
            }

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Obrigado por utilizar o nosso TO-DO List");
                    break;

                case 1:
                    var novaTarefa = new Tarefa();
                    novaTarefa.CriarTarefa();
                    listaTarefas.Add(novaTarefa);
                    Console.WriteLine("Tarefa criada com sucesso!");
                    break;

                case 2:
                    Console.Write("Digite o número da tarefa: ");
                    if (int.TryParse(Console.ReadLine(), out int indexInicializar))
                    {
                        if (indexInicializar >= 0 && indexInicializar < listaTarefas.Count)
                        {
                            listaTarefas[indexInicializar].InicializarTarefa(listaTarefas, indexInicializar);
                            Console.WriteLine("Tarefa inicializada.");
                        }
                        else
                        {
                            Console.WriteLine("Índice fora do intervalo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Lista de tarefas:");
                    for (int i = 0; i < listaTarefas.Count; i++)
                    {
                        var t = listaTarefas[i];
                        Console.WriteLine($"Número: {i}");
                        Console.WriteLine($"Título: {t.Titulo}");
                        Console.WriteLine($"Descrição: {t.Descricao}");
                        Console.WriteLine($"Status: {t.Status}");
                        Console.WriteLine($"Início: {t.DataInicio}");
                        Console.WriteLine($"Fim: {(t.DataFim == default ? "Ainda não finalizada" : t.DataFim.ToString())}");
                        Console.WriteLine(new string('-', 30));
                    }
                    break;

                case 4:
                    Console.Write("Digite o número da tarefa: ");
                    if (int.TryParse(Console.ReadLine(), out int indexFinalizar))
                    {
                        if (indexFinalizar >= 0 && indexFinalizar < listaTarefas.Count)
                        {
                            listaTarefas[indexFinalizar].FinalizarTarefa(listaTarefas, indexFinalizar);
                            Console.WriteLine("Tarefa finalizada.");
                        }
                        else
                        {
                            Console.WriteLine("Índice fora do intervalo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                    break;

                case 5:
                    Console.Write("Digite o número da tarefa: ");
                    if (int.TryParse(Console.ReadLine(), out int indexEditar))
                    {
                        if (indexEditar >= 0 && indexEditar < listaTarefas.Count)
                        {
                            listaTarefas[indexEditar].EditarTarefa(listaTarefas, indexEditar);
                        }
                        else
                        {
                            Console.WriteLine("Índice fora do intervalo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                    break;

                case 6:
                    Console.Write("Digite o número da tarefa: ");
                    if (int.TryParse(Console.ReadLine(), out int indexRemover))
                    {
                        if (indexRemover >= 0 && indexRemover < listaTarefas.Count)
                        {
                            listaTarefas[indexRemover].RemoverTarefa(listaTarefas, indexRemover);
                        }
                        else
                        {
                            Console.WriteLine("Índice fora do intervalo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                    break;

                default:
                    Console.WriteLine("Comando inválido.");
                    break;
            }
        } while (opcao != 0);
    }
}

namespace HelloWorld.ToDo;

public class Tarefa
{
    private string titulo;
    private string descricao;
    private int contador;
    private DateTime dataInicio;
    private DateTime dataFim;
    private StatusTarefa status;

    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public int Contador { get; private set; }
    public DateTime DataInicio { get; private set; }
    public DateTime DataFim { get; private set; }
    public StatusTarefa Status { get; private set; }

    public void CriarTarefa()
    {
        Console.Write("Digite o título da tarefa: ");
        Titulo = Console.ReadLine();
        Console.Write("Digite a descrição da tarefa: ");
        Descricao = Console.ReadLine();
        DataInicio = DateTime.Now;
        Status = StatusTarefa.Pendente;
    }

    public void InicializarTarefa(List<Tarefa> lista, int index)
    {
        Contador++;
        lista[index].status = StatusTarefa.Andamento;

    }

    public void FinalizarTarefa(List<Tarefa> lista, int index)
    {
        lista[index].DataFim = DateTime.Now;
        lista[index].status = StatusTarefa.Finalizado;
    }

    public void RemoverTarefa(List<Tarefa> lista, int index)
    {
        Console.WriteLine("Digite o indice da tarefa: que deseja excluir: ");
        if(index >= 0 && index < lista.Count)
        {
            lista.RemoveAt(index);
            Console.WriteLine("Tarefa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido!!");
        }
    }

    public void EditarTarefa(List<Tarefa> lista, int index)
    {
        Console.Write("Novo título (ou Enter para manter): ");
        string novoTitulo = Console.ReadLine();
        lista[index].Titulo = novoTitulo;
        Console.Write("Nova descrição (ou Enter para manter): ");
        string novaDescricao = Console.ReadLine();
        lista[index].Descricao = novaDescricao;


        if (!string.IsNullOrWhiteSpace(novoTitulo))
        {
            Titulo = novoTitulo;
        }

        if (!string.IsNullOrWhiteSpace(novaDescricao))
        {
            Descricao = novaDescricao;
        }
    }
}
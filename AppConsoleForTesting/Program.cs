using DataAccess.Repository;
using System.Runtime.CompilerServices;

private readonly IRepository _repository; 
public Program (IRepository repository)
{
	this._repository = repository;
}

int opcao = 1;
do
{
	Console.WriteLine("[ 1 ] Incluir Cliente");
	Console.WriteLine("[ 2 ] Excluir Cliente");
	Console.WriteLine("[ 3 ] Atualizar Cliente");
	Console.WriteLine("[ 4 ] Listar Clientes");
	Console.WriteLine("[ 0 ] Sair do Programa");
	Console.WriteLine("-------------------------------------");
	Console.Write("Digite uma opção: ");
	opcao = Int32.Parse(Console.ReadLine());
	switch (opcao)
	{
		//case 1:
		//	incluirCliente();
		//	break;
		//case 2:
		//	excluirCliente();
		//	break;
		//case 3:
		//	atualizarCliente();
		//	break;
		case 4:
			listarClientes();
			break;
		default:
			saiPrograma();
			break;
	}
	Console.ReadKey();
	Console.Clear();
}
while (opcao != 0);

static void listarClientes()
{
	using (var bll = new ClienteBusinessLogic())
	{
		var clientes = bll.ListarClientes();
		foreach (var cli in clientes)
		{
			Console.WriteLine($"{cli.ClienteId} - {cli.Nome} - {cli.Email}");
		}
	}
}

static void saiPrograma()
{
	Console.WriteLine();
	Console.WriteLine("Você encerrou o Programa. Clique qq tecla para sair...");
}
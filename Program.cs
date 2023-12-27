using System;
using System.Collections.Generic;
class Program{

    static List<Conta> contas = new List<Conta>();
    static void Main(string[] args){
        
        string opcao = ObterOpcaoUsuario();

        while(opcao.ToUpper() != "X"){
            
            switch(opcao)
            {
                case "1":
                        ListarContas();
                        break;
                case "2":
                        CadastrarConta();
                        break;
                case "3":
                        Transferir();
                        break;
                case "4":
                        Sacar();
                        break;
                case "5":
                        Depositar();
                        break;
                case "C":
                        Console.Clear();
                        break;
                default:
                        throw new ArgumentOutOfRangeException();

            }

            opcao = ObterOpcaoUsuario();
        }
        Console.WriteLine("Obrigado por usar nossos serviços");
        
    }

    public static void Sacar()
    {
        Console.WriteLine("Digite o número da conta -->");
        var numeroConta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor a ser sacado --> ");
        var saque = Convert.ToInt32(Console.ReadLine());

        contas[numeroConta].Saque(saque);
    }
    public static void Depositar()
    {
        Console.WriteLine("Digite o número da conta -->");
        var numeroConta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor a ser depositado --> ");
        var depositado = Convert.ToInt32(Console.ReadLine());

        contas[numeroConta].Depositar(depositado);
    }
    public static void Transferir()
    {
        Console.WriteLine("Digite o número da conta de origem -->");
        var origem = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o número da conta de destino -->");
        var destino = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor a ser transferido--> ");
        var envio = Convert.ToInt32(Console.ReadLine());

        contas[origem].Transferir(envio,contas[destino]);
    }

    public static void ListarContas()
    {
        if(contas.Count == 0)
        {
            Console.WriteLine("Nenhuma conta encontrada");
            return;
        }
        foreach(var conta in contas)
        {
            Console.WriteLine(conta);
        }
    }
    public static void CadastrarConta()
    {
        Console.WriteLine("Informe o tipo de conta -->");
        var tipo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o saldo inicial da conta -->");
        var saldo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o c'rédito da conta -->");
        var credito = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o nome do titular da conta -->");
        var titular = Console.ReadLine();

        Conta newconta = new Conta(tipo,saldo,credito,titular);
        contas.Add(newconta);
    }


    public static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Bank sempre ao seu lado!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar contas");
			Console.WriteLine("2- Inserir nova conta");
			Console.WriteLine("3- Transferir");
			Console.WriteLine("4- Sacar");
			Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

}

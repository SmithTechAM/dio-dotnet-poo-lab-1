using System;

public class Conta // sacar , depositar, transferir
{
    public int TipoConta{get;set;}
    public double Saldo { get; set; }
    public double Credito { get; set; }
    public string Nome { get; set; }

    public Conta(int tipo, double saldo, double credito, string nome)
    {
        this.TipoConta = tipo;
        this.Saldo = saldo;
        this.Credito = credito;
        this.Nome = nome;
    }
    public bool Saque(double valor)
    {
        if(valor > Saldo){
            Console.WriteLine("Saldo Insuficiente");
            return false;
        }
        Saldo = Saldo - valor;
        Console.WriteLine($"Seu saldo atual é {Saldo}, sr.{Nome}");
        return true;
    }
    public void Depositar(int valor){
        Saldo = Saldo + valor;
        Console.WriteLine($"Depósito efetuado com sucesso, seu saldo atual é {Saldo}, sr.{Nome}");
    }

    public bool Transferir(int valorDeposito ,Conta destino)
    {
        if(this.Saldo < valorDeposito || valorDeposito <= 0){
            Console.WriteLine("Saldo Insuficiente, não é possível transferir");
            return false;
        }
        destino.Depositar(valorDeposito);
        this.Saldo = Saldo - valorDeposito;
        Console.WriteLine($"valor transferido para {destino.Nome} de valor {valorDeposito}");
        return true;
    }
    public override string ToString()
		{
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
			return retorno;
		}
}
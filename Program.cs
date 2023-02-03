
int saldodisponivel = 1000;
int saquedisponivel = 0;

int saldo = 1;
int saque = 2;

int valor1 = 5;
int valor2 = 20;
int valor3 = 50;
int valor4 = 100;

Console.WriteLine("Bem vindo ao caixa! Selecione a opção desejada : Para saldo tecle 1 , Para saque tecle 2");
var entrada= Console.ReadLine();

if (saldo == Convert.ToInt32(entrada))
{
    Console.WriteLine($"Seu saldo é de : " + saldodisponivel);
}
else if (saque == Convert.ToInt32(entrada))
{
    Console.WriteLine($"Cédulas disponiveis : {valor1}, {valor2}, {valor3}, {valor4}");
    var saqueValor = Convert.ToInt32(Console.ReadLine());
    if (saldodisponivel >= saqueValor)
        Console.WriteLine("Saldo indisponivel para saque!");
    else
    {
    var resultado = saqueValor % 5;
    
        if (resultado > 0) 
        Console.WriteLine("Não é possível sacar esse valor, deve ser multiplo de 5");
    else 

      while (saqueValor >0)
    {
        saquedisponivel = -saqueValor;
        if (saqueValor == 100)
        {
            Console.WriteLine("100");
            saqueValor = -100;
        }
        if (saqueValor == 50)
        {
            Console.WriteLine("50");
            saqueValor = -50;
        }
        if (saqueValor == 20)
        {
            Console.WriteLine("20");
            saqueValor = -20;
        }
        if (saqueValor == 5)
        {
            Console.WriteLine("5");
            saqueValor = -5;
        }
    }
        }
}
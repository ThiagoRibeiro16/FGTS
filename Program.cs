Console.Clear();

string valorInicial;
double valorSalario;
double FGTS;

Console.Write("Qual é o sálario que vamos calcular o FGTS? ");
valorInicial = Console.ReadLine();

valorSalario = Convert.ToDouble(valorInicial);

FGTS = valorSalario * 0.08;



Console.Write($"com o sálario de {valorSalario} o FGTS será de {FGTS}");

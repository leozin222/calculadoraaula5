Calculadora calc = new Calculadora();

Console.WriteLine("Informe o valor de X: ");

double x = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Informe o Valor de Y: ");

double y = Convert.ToDouble (Console.ReadLine());

double resultadoSoma = calc.Soma(x,y);

Console.WriteLine($"A soma de {x} e {y} é igual á: {resultadoSoma}");


Console.WriteLine($"O resultado da subtração é {calc.Subtracao(x,y)}");

Console.WriteLine($"O resultado da Divisão é {calc.Divisao(x,y)}");

Console.WriteLine($"O resultado da Multiplcação é {calc.Multiplicacao(x,y)}");
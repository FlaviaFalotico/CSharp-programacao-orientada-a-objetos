/*
Fazer um programa para ler as medidas dos lados de dois 
triângulos X e Y (suponha medidas válidas).

Em seguida, mostrar o valor das áreas dos dois triângulos 
e dizer qual dos dois triângulos possui a maior área.

A fórmula para calcular a área de um triângulo a partir das 
medidas de seus lados a, b e c é a seguinte (fórmula de Heron):

area = √ p(p(p-a)(p-b)(p-c)

onde,

p = (a + b + c) / 2

Exemplo:
Entrada                                     Saída
Entre com as medidas do triângulo X:        Área de X = 6.0000
3.00 4.00 5.00                              Área de Y = 7.5638
Entre com as medidas do triângulo Y:        Maior área: Y      
7.50 4.50 4.02
*/
using System.Globalization;
using problemaExemploComOO;

Triangulo X, Y;

X = new Triangulo();
Y = new Triangulo();

Console.Write("Entre com as medidas do triângulo X: ");
string[] trianguloX = Console.ReadLine().Split(' ');
X.Lado1 = double.Parse(trianguloX[0], CultureInfo.InvariantCulture);
X.Lado2 = double.Parse(trianguloX[1], CultureInfo.InvariantCulture);
X.Lado3 = double.Parse(trianguloX[2], CultureInfo.InvariantCulture);

Console.Write("Entre com as medidas do triângulo Y: ");
string[] trianguloY = Console.ReadLine().Split(' ');
Y.Lado1 = double.Parse(trianguloY[0], CultureInfo.InvariantCulture);
Y.Lado2 = double.Parse(trianguloY[1], CultureInfo.InvariantCulture);
Y.Lado3 = double.Parse(trianguloY[2], CultureInfo.InvariantCulture);

double p = (X.Lado1 + X.Lado2 + X.Lado3) / 2.0;
double areaX = Math.Sqrt(p * (p - X.Lado1) * (p - X.Lado2) * (p - X.Lado3));

p = (Y.Lado1 + Y.Lado2 + Y.Lado3) / 2.0;
double areaY = Math.Sqrt(p * (p - Y.Lado1) * (p - Y.Lado2) * (p - Y.Lado2));

Console.WriteLine("Área de Y = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX < areaY)
{
    Console.WriteLine("Maior área: Y");
}
else
{
    Console.WriteLine("Maior área: X");
}
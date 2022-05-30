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

double lado1X, lado2X, lado3X, lado1Y, lado2Y, lado3Y, areaX, areaY, pX, pY;

Console.Write("Entre com as medidas do triângulo X: ");
string[] trianguloX = Console.ReadLine().Split(' ');
lado1X = double.Parse(trianguloX[0], CultureInfo.InvariantCulture);
lado2X = double.Parse(trianguloX[1], CultureInfo.InvariantCulture);
lado3X = double.Parse(trianguloX[2], CultureInfo.InvariantCulture);

Console.Write("Entre com as medidas do triângulo Y: ");
string[] trianguloY = Console.ReadLine().Split(' ');
lado1Y = double.Parse(trianguloY[0], CultureInfo.InvariantCulture);
lado2Y = double.Parse(trianguloY[1], CultureInfo.InvariantCulture);
lado3Y = double.Parse(trianguloY[2], CultureInfo.InvariantCulture);

pX = (lado1X + lado2X + lado3X) / 2.0;
areaX = Math.Sqrt(pX * (pX - lado1X) * (pX - lado2X) * (pX - lado3X));
    
pY = (lado1Y + lado2Y + lado3Y) / 2.0;
areaY = Math.Sqrt(pY * (pY - lado1Y) * (pY - lado2Y) * (pY - lado3Y));

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
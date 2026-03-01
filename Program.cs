//Mostrar la tabla de multiplicar de un número ingresado.

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());

int contador = 0;

while (contador <= 10)
{
    Console.WriteLine(num + " X "+ contador + " = " + (num * contador));
    contador++;
}


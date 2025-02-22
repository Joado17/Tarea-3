using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú Principal");
            Console.WriteLine("1. Calculadora básica");
            Console.WriteLine("2. Validación de contraseña");
            Console.WriteLine("3. Números primos");
            Console.WriteLine("4. Suma de números pares");
            Console.WriteLine("5. Conversión de temperatura");
            Console.WriteLine("6. Contador de vocales");
            Console.WriteLine("7. Cálculo de factorial");
            Console.WriteLine("8. Juego de adivinanza");
            Console.WriteLine("9. Paso por referencia");
            Console.WriteLine("10. Tabla de multiplicar");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");
            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    CalculadoraBasica();
                    break;
                case 2:
                    ValidacionContraseña();
                    break;
                case 3:
                    NumerosPrimos();
                    break;
                case 4:
                    SumaNumerosPares();
                    break;
                case 5:
                    ConversionTemperatura();
                    break;
                case 6:
                    ContadorVocales();
                    break;
                case 7:
                    CalculoFactorial();
                    break;
                case 8:
                    JuegoAdivinanza();
                    break;
                case 9:
                    PasoPorReferencia();
                    break;
                case 10:
                    TablaMultiplicar();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 0);
    }

    static void CalculadoraBasica()
    {
        double num1, num2;
        string operacion;

        Console.Write("Ingrese el primer número: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            Console.Write("Ingrese el primer número: ");
        }

        Console.Write("Ingrese el segundo número: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            Console.Write("Ingrese el segundo número: ");
        }

        Console.Write("Elija la operación (+, -, *, /): ");
        operacion = Console.ReadLine();

        switch (operacion)
        {
            case "+":
                Console.WriteLine($"Resultado: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {num1 * num2}");
                break;
            case "/":
                if (num2 != 0)
                {
                    Console.WriteLine($"Resultado: {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }

    static void ValidacionContraseña()
    {
        string contraseña;
        do
        {
            Console.Write("Ingrese la contraseña: ");
            contraseña = Console.ReadLine();
            if (contraseña != "1234")
            {
                Console.WriteLine("Contraseña incorrecta. Intente de nuevo.");
            }
        } while (contraseña != "1234");
        Console.WriteLine("Acceso concedido.");
    }

    static void NumerosPrimos()
    {
        int num;
        Console.Write("Ingrese un número entero: ");
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            Console.Write("Ingrese un número entero: ");
        }

        if (EsPrimo(num))
        {
            Console.WriteLine($"{num} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{num} no es un número primo.");
        }
    }

    static bool EsPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void SumaNumerosPares()
    {
        int num, suma = 0;
        Console.WriteLine("Ingrese números enteros (0 para terminar): ");
        while (true)
        {
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }
            if (num == 0)
            {
                break;
            }
            if (num % 2 == 0)
            {
                suma += num;
            }
        }
        Console.WriteLine($"La suma de los números pares ingresados es: {suma}");
    }

    static void ConversionTemperatura()
    {
        double temperatura;
        Console.Write("Ingrese la temperatura: ");
        while (!double.TryParse(Console.ReadLine(), out temperatura))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            Console.Write("Ingrese la temperatura: ");
        }

        Console.Write("Elija la conversión (1: Celsius a Fahrenheit, 2: Fahrenheit a Celsius): ");
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion) || (opcion != 1 && opcion != 2))
        {
            Console.WriteLine("Opción inválida. Por favor, elija 1 o 2.");
            Console.Write("Elija la conversión (1: Celsius a Fahrenheit, 2: Fahrenheit a Celsius): ");
        }

        if (opcion == 1)
        {
            Console.WriteLine($"{temperatura}°C equivale a {CelsiusAFahrenheit(temperatura)}°F");
        }
        else
        {
            Console.WriteLine($"{temperatura}°F equivale a {FahrenheitACelsius(temperatura)}°C");
        }
    }

    static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void ContadorVocales()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();
        int contador = ContarVocales(frase);
        Console.WriteLine($"La frase contiene {contador} vocales.");
    }

    static int ContarVocales(string frase)
    {
        int contador = 0;
        foreach (char c in frase.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                contador++;
            }
        }
        return contador;
    }

    static void CalculoFactorial()
    {
        int num;
        Console.Write("Ingrese un número entero: ");
        while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero no negativo.");
            Console.Write("Ingrese un número entero: ");
        }

        Console.WriteLine($"El factorial de {num} es {Factorial(num)}");
    }

    static int Factorial(int num)
    {
        int resultado = 1;
        for (int i = 2; i <= num; i++)
        {
            resultado *= i;
        }
        return resultado;
    }

    static void JuegoAdivinanza()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int intento;
        do
        {
            Console.Write("Adivine el número (entre 1 y 100): ");
            while (!int.TryParse(Console.ReadLine(), out intento) || intento < 1 || intento > 100)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entre 1 y 100.");
                Console.Write("Adivine el número (entre 1 y 100): ");
            }

            if (intento < numeroAleatorio)
            {
                Console.WriteLine("Demasiado bajo.");
            }
            else if (intento > numeroAleatorio)
            {
                Console.WriteLine("Demasiado alto.");
            }
        } while (intento != numeroAleatorio);
        Console.WriteLine("¡Felicidades! Adivinaste el número.");
    }

    static void PasoPorReferencia()
    {
        int num1, num2;
        Console.Write("Ingrese el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            Console.Write("Ingrese el primer número: ");
        }

        Console.Write("Ingrese el segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            Console.Write("Ingrese el segundo número: ");
        }

        Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");
        Intercambiar(ref num1, ref num2);
        Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
    }

    static void Intercambiar(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void TablaMultiplicar()
    {
        int num;
        Console.Write("Ingrese un número: ");
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            Console.Write("Ingrese un número: ");
        }

        Console.WriteLine($"Tabla de multiplicar del {num}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Asientos();        
    }

    //Menú inicial
    static int Menu(List<int> asientos)
    {
        Console.Clear();
        int menu = 0;

        Console.WriteLine("=============================================");
        Console.WriteLine("==-------------  BIENVENIDOS  -------------==");
        Console.WriteLine("=============================================\n");

        Console.WriteLine("  1 - RESERVAR VUELO   ");
        Console.WriteLine("  2 - CANCELAR RESERVA ");
        Console.WriteLine("  3 - MOSTRAR ESTADO DE VUELO ");
        Console.WriteLine("  4 - MOSTRAR ASIENTOS DISPONIBLES Y OCUPADOS");
        Console.WriteLine("  5 - BUSCAR ASIENTOS");
        Console.WriteLine("  6 - SALIR");   

        menu=int.Parse(Console.ReadLine());

        switch (menu) {
            case 1: Reserva(asientos, menu); break;
            case 2: Reserva(asientos, menu); break;                            
            case 3:MostrarTodos(asientos); break;
            case 4:MostrarCantidades(asientos); break;
            case 5:Buscar(asientos); break;
            case 6:Salir(); break;
        }
        return menu;
    }

    //creacion de asientos disponibles
    static List<int> Asientos()
    {
        List<int> asientos = new List<int>();

        for (int i = 0; i < 60; i++)
        {
            asientos.Add(0);
        }

        Menu(asientos);

        return asientos;
    }

    //Funcion para agregar o cancelar reservas
    static List<int> Reserva(List<int> asientos, int menu)
    {
        Console.Clear();
        int seleccion = 0;

        if (menu == 1)
        {
            
            Console.WriteLine("Ingrese el número del asiento que desea reservar");
            
            asientos[int.Parse(Console.ReadLine())] = 1;
        }
        else
        {
            Console.WriteLine("Ingrese el número del asiento reservado que desea cancelar");

            asientos[int.Parse(Console.ReadLine())] = 0;

        }

        Retorno(asientos);


        return asientos;
    }

    //Funcion para mostrar todos los asientos disponibles y ocupados
    static void MostrarTodos(List<int> asientos) {
        Console.Clear();
        int c = 0;
        int c2 = 0;
        foreach (int i in asientos)
        {
            if (i == 0) Console.BackgroundColor = ConsoleColor.Green; else Console.BackgroundColor = ConsoleColor.Red;
            
            Console.Write($"| {i} |");

            c++;
            c2++;

            if (c == 2) { Console.BackgroundColor = ConsoleColor.Black; Console.Write("     "); c = 0; }
            if (c2 == 6) { Console.BackgroundColor = ConsoleColor.Black; Console.WriteLine("\n"); c2 = 0; }
        }

        Retorno(asientos);
    
    }

    //Funcion de retorno al menu principal o salir del programa
    static void Retorno(List<int> asientos) {

        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("Operación Realizada con éxito");
        Console.WriteLine("=============================");

        Console.WriteLine("1 - Volver al menú principal");
        Console.WriteLine("0 - Salir");

        if (int.Parse(Console.ReadLine()) == 1)
        {
            Menu(asientos);
        }
        else
        {
            Salir();
        }

    }

    //Funcion para mostrar la cantidad total de asientos disponibles y ocupados
    static void MostrarCantidades(List<int> asientos)
    {
        Console.Clear();
        int c0 = 0;
        int c1 = 0;

        foreach (int i in asientos)
        {           
            if (i == 0) c0++; else c1++;
        }

        Console.WriteLine($"Hay {c0} disponibles y {c1} ocupados");
        Retorno(asientos) ;
    }

    //Funcion para consultar la disponibilidad de un asiento especifico

    static void Buscar(List<int> asientos)
    {
        Console.Clear();
        int a = 0;

        Console.WriteLine("Ingrese el numero del asiento que desea consultar\n");

        a = int.Parse(Console.ReadLine());

        if (asientos[a] == 1)
        {
            Console.WriteLine($"\nAsiento numero {a} ocupado");
        }
        else
        {
            Console.WriteLine($"\nAsiento numero {a} disponible");
        }
        
        Retorno(asientos);

    }

    static void Salir() {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\r\n████████████████████████████████████████████████████████████\r\n█─▄▄▄▄█▄─▄▄▀██▀▄─██─▄▄▄─█▄─▄██▀▄─██─▄▄▄▄███▄─▄▄─█─▄▄─█▄─▄▄▀█\r\n█─██▄─██─▄─▄██─▀─██─███▀██─███─▀─██▄▄▄▄─████─▄▄▄█─██─██─▄─▄█\r\n▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀\r\n████████████████████████████████████████████████████████████\r\n█▄─▄▄─█▄─▄███▄─▄▄─█─▄▄▄▄█▄─▄█▄─▄▄▀█▄─▀█▄─▄█─▄▄─█─▄▄▄▄█░█░█░█\r\n██─▄█▀██─██▀██─▄█▀█─██▄─██─███─▄─▄██─█▄▀─██─██─█▄▄▄▄─█▄█▄█▄█\r\n▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▄▄▄▄▄▀▄▀▄▀▄▀");
        Console.ForegroundColor= ConsoleColor.White;
        Environment.Exit(0); 
    }

    }
string nota(string tipo)
{
    if (tipo == "dó")
    {Console.ForegroundColor = ConsoleColor.DarkRed;Console.Write("dó, "); Console.Beep(1320, 200);}
    else if (tipo == "ré")
    {Console.ForegroundColor = ConsoleColor.DarkBlue;Console.Write("ré, "); Console.Beep(1485, 200);}
    else if (tipo == "mi")
    {Console.ForegroundColor = ConsoleColor.DarkCyan;Console.Write("mi, "); Console.Beep(1650, 200);}
    else if (tipo == "fá")
    {Console.ForegroundColor = ConsoleColor.DarkGreen;Console.Write("fá, "); Console.Beep(1759, 200);}
     else if (tipo == "sol")
    {Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("sol, "); Console.Beep(1980, 200);}
    return tipo;
}
nota("dó"); nota("ré"); nota("mi"); nota("fá");
Thread.Sleep(500);
nota("fá"); nota("fá");
Thread.Sleep(1000);
Console.WriteLine();
nota("dó"); nota("ré"); nota("dó"); nota("ré");
Thread.Sleep(500);
nota("ré"); nota("ré");
Thread.Sleep(1000);
Console.WriteLine();
nota("dó"); nota("sol"); nota("fá"); nota("mi");
Thread.Sleep(500);
nota("mi"); nota("mi");
Thread.Sleep(1000);
Console.WriteLine();
nota("dó"); nota("ré"); nota("mi"); nota("fá");
Thread.Sleep(500);
nota("fá"); nota("fá");
Console.ResetColor();
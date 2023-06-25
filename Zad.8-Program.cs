using System;

public class Program
{
    public static void Main(string[] args)
    {
        int dolnyPrzedzial = 1;
        int gornyPrzedzial = 20;
        int propozycja;
        string odpowiedz;

        Console.WriteLine("Pomyśl liczbę z przedziału 1-20.");

        while (true)
        {
            propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;
            Console.WriteLine("Czy Twoja liczba to " + propozycja + "? (Odpowiedz używając: -, + lub 0)");

            odpowiedz = Console.ReadLine();

            if (odpowiedz == "0")
            {
                Console.WriteLine("Zgadłem! Twoja liczba to " + propozycja + ".");
                break;
            }
            else if (odpowiedz == "-")
            {
                gornyPrzedzial = propozycja - 1;
            }
            else if (odpowiedz == "+")
            {
                dolnyPrzedzial = propozycja + 1;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa odpowiedź. Odpowiedz ujemną, dodatnią lub 0.");
            }
        }
    }
}


using System;
string password = "2b1";  // Przykładowe hasło
string[] range = { "0", "1", "2", "a", "b", "c" };  // Zakres znaków
string a = "";  // Zmienna przechowująca zgadywane hasło
bool found = false;  // Flaga, która będzie wskazywać, że hasło zostało znalezione

// Sprawdzanie wszystkich kombinacji
for (int i = 0; i < range.Length; i++)
{
    a = range[i]; // Sprawdzamy czy hasło to pojedynczy znak
    if (a == password)
    {
        Console.WriteLine("Password is: " + a);
        found = true;
        break;
    }
    for (int j = 0; j < range.Length; j++)
    {
        a = range[i] + range[j]; // Sprawdzamy czy hasło zawiera 2 znaki
        if (a == password)
        {
            Console.WriteLine("Password is: " + a);
            found = true;
            break;
        }
        for (int k = 0; k < range.Length; k++)
        {
            a = range[i] + range[j] + range[k]; // Sprawdzamy czy hasło zawiera 3 znaki
            Console.WriteLine(a);
            if (a == password)
            {
                Console.WriteLine("Password is: " + a);
                found = true;
                break;
            }
        }
        if (found) break;  // Przerywamy pętlę po znalezieniu hasła
    }
    if (found) break;  // Przerywamy pętlę po znalezieniu hasła
}

if (!found)  // Jeżeli hasło nie zostało znalezione
{
    Console.WriteLine("Password not found.");
}



using System;

//string passwd = "01";
//string[] range = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
//bool hack = true;


string password = "221";  // Przykładowe hasło
string[] range = { "0", "1", "2" };  // Zakres prób
string a = "";  // Zmienna przechowująca zgadywane hasło
bool found = false;  // Flaga, która będzie wskazywać, że hasło zostało znalezione

// Sprawdzanie wszystkich kombinacji
for (int i = 0; i < range.Length; i++)
{
    a = range[i];
    if (a == password)
    {
        Console.WriteLine("Password is: " + a);
        found = true;
        break;  // Przerywamy główną pętlę
    }
    for (int j = 0; j < range.Length; j++)
    {
        a = range[i] + range[j];
        if (a == password)
        {
            Console.WriteLine("Password is: " + a);
            found = true;
            break;  // Przerywamy drugą pętlę
        }
        for (int k = 0; k < range.Length; k++)
        {
            a = range[i] + range[j] + range[k];
            Console.WriteLine(a);
            if (a == password)
            {
                Console.WriteLine("Password is: " + a);
                found = true;
                break;  // Przerywamy trzecią pętlę
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



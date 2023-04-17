// See https://aka.ms/new-console-template for more information

using GestoreEventi;

//Esecuzione programma

Console.WriteLine("Inserisci il titolo dell'evento:");
string titolo = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento (formato gg/mm/aaaa):");
DateTime data = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la capienza massima dell'evento:");
int capienzaMassima = int.Parse(Console.ReadLine());

Evento evento = new Evento(titolo, data, capienzaMassima);

while (true)
{
    Console.WriteLine("Vuoi prenotare dei posti? (s/n)");
    string risposta = Console.ReadLine();
    if (risposta.ToLower() == "s")
    {
        Console.WriteLine("Quanti posti vuoi prenotare?");
        int postiDaPrenotare = int.Parse(Console.ReadLine());
        try
        {
            evento.PrenotaPosti(postiDaPrenotare);
            Console.WriteLine($"Hai prenotato {postiDaPrenotare} posti.");
            Console.WriteLine($"Posti disponibili: {evento.CapienzaMassima - evento.PostiPrenotati}");
            Console.WriteLine($"Posti prenotati: {evento.PostiPrenotati}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else
    {
        break;
    }
}

while (true)
{
    Console.WriteLine("Vuoi disdire dei posti? (s/n)");
    string risposta = Console.ReadLine();
    if (risposta.ToLower() == "s")
    {
        Console.WriteLine("Quanti posti vuoi disdire?");
        int postiDaDisdire = int.Parse(Console.ReadLine());
        try
        {
            evento.DisdiciPosti(postiDaDisdire);
            Console.WriteLine($"Hai disdetto {postiDaDisdire} posti.");
            Console.WriteLine($"Posti disponibili: {evento.CapienzaMassima - evento.PostiPrenotati}");
            Console.WriteLine($"Posti prenotati: {evento.PostiPrenotati}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else
    {
        break;
    }
}

Console.ReadKey();

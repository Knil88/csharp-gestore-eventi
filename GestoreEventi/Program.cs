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





Console.WriteLine("Inserisci il titolo del tuo programma eventi:");
string Titolo = Console.ReadLine();

ProgrammaEventi programmaEventi = new ProgrammaEventi(Titolo);

Console.WriteLine("Quanti eventi vuoi aggiungere?");
int numeroEventi = int.Parse(Console.ReadLine());

for (int i = 0; i < numeroEventi; i++)
{
    Console.WriteLine($"Inserisci il titolo dell'evento {i + 1}:");
    string titoloEvento = Console.ReadLine();

    Console.WriteLine($"Inserisci la data dell'evento {i + 1} (formato gg/mm/aaaa):");
    DateTime dataEvento = DateTime.Parse(Console.ReadLine());

    Evento evento2 = new Evento(titolo, DateTime.Now, 10);

    try
    {
        programmaEventi.AggiungiEvento(evento2);
        Console.WriteLine($"Evento {titoloEvento} aggiunto con successo!");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Errore: {e.Message}");
        i--;
    }
}

Console.WriteLine($"Numero di eventi presenti nel programma: {programmaEventi.NumeroEventi()}\n");

Console.WriteLine("Lista di eventi inseriti nel programma:");
Console.WriteLine(ProgrammaEventi.StampaEventi(programmaEventi.Eventi));

Console.WriteLine("Inserisci una data per visualizzare gli eventi in quella data (formato gg/mm/aaaa):");
DateTime dataCercata = DateTime.Parse(Console.ReadLine());

Console.WriteLine($"Eventi in data {dataCercata}:");
Console.WriteLine(ProgrammaEventi.StampaEventi(programmaEventi.EventiInData(dataCercata)));

programmaEventi.SvuotaEventi();

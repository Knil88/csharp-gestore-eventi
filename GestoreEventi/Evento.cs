using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    //Creiamo la classe evento con i suoi attributi
    public class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int postiPrenotati;

        //Utilizziamo i getter e setter  per fare in modo che alcuni attributi siano disponibili in lettura e scrittura ed altri solo sollo lettura

        public string Titolo

            //nei get mettiamo le exception
        {
            get { return titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Il titolo non può essere vuoto.");
                }
                titolo = value;
            }
        }

        public DateTime Data
        {
            get { return data; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("La data deve essere futura.");
                }
                data = value;
            }
        }

        public int CapienzaMassima
        {
            get { return capienzaMassima; }
        }

        public int PostiPrenotati
        {
            get { return postiPrenotati; }
        }

        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            Titolo = titolo;
            Data = data;
            if (capienzaMassima <= 0)
            {
                throw new ArgumentException("La capienza massima deve essere un numero positivo.");
            }
            this.capienzaMassima = capienzaMassima;
            postiPrenotati = 0;
        }

        public void PrenotaPosti(int postiDaPrenotare)
        {
            if (postiDaPrenotare <= 0)
            {
                throw new ArgumentException("Il numero di posti da prenotare deve essere un numero positivo.");
            }
            if (Data < DateTime.Now)
            {
                throw new InvalidOperationException("L'evento è già passato.");
            }
            if (postiDaPrenotare > capienzaMassima - postiPrenotati)
            {
                throw new InvalidOperationException("Non ci sono abbastanza posti disponibili.");
            }
            postiPrenotati += postiDaPrenotare;
        }

        public void DisdiciPosti(int postiDaDisdire)
        {
            if (postiDaDisdire <= 0)
            {
                throw new ArgumentException("Il numero di posti da disdire deve essere un numero positivo.");
            }
            if (Data < DateTime.Now)
            {
                throw new InvalidOperationException("L'evento è già passato.");
            }
            if (postiDaDisdire > postiPrenotati)
            {
                throw new InvalidOperationException("Non ci sono abbastanza posti prenotati da disdire.");
            }
            postiPrenotati -= postiDaDisdire;
        }

        public override string ToString()
        {
            return $"{data.ToString("dd/MM/yyyy")} - {titolo}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    class ProgrammaEventi
    {
        public string Titolo { get; set; }
        public List<Evento> Eventi { get; set; }

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            Eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
        }

        public List<Evento> EventiInData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();

            foreach (Evento evento in Eventi)
            {
                if (evento.Data == data)
                {
                    eventiInData.Add(evento);
                }
            }

            return eventiInData;
        }

        public static string StampaEventi(List<Evento> eventi)
        {
            string output = "";

            foreach (Evento evento in eventi)
            {
                output += $"{evento.Data} - {evento.Titolo}\n";
            }

            return output;
        }

        public int NumeroEventi()
        {
            return Eventi.Count;
        }

        public void SvuotaEventi()
        {
            Eventi.Clear();
        }

        public override string ToString()
        {
            string output = $"{Titolo}:\n";

            foreach (Evento evento in Eventi)
            {
                output += $"{evento.Data} - {evento.Titolo}\n";
            }

            return output;
        }
    }
}

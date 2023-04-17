using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    class ProgrammaEventi 



    {
        private string titolo;

        private List<Evento> eventi;


        public ProgrammaEventi(string titolo) 
        {
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> EventiInData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();
            foreach (Evento evento in eventi)
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
                output += $"{evento.Data.ToShortDateString()} - {evento.Titolo}\n";
            }
            return output;
        }

        public int NumeroEventi()
        {
            return eventi.Count;
        }

        public void SvuotaEventi()
        {
            eventi.Clear();
        }

        public override string ToString()
        {
            string output = $"{titolo}:\n";
            foreach (Evento evento in eventi)
            {
                output += $"{evento.Data.ToShortDateString()} - {evento.Titolo}\n";
            }
            return output;
        }
    }
}

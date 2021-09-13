using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Testowy_Projekt
{
    class ObrobkaDanych
    {
        public List<ObiektBazy> listaObiektow;
        public ObrobkaDanych(DataTable op)
        {
            relacjaDoObiektu(op);
        }
        private void relacjaDoObiektu(DataTable op)
        {
            listaObiektow = new List<ObiektBazy>();
            int i = 0;
            foreach (DataRow dr in op.Rows)
            {
                Console.WriteLine();
                listaObiektow.Add(new ObiektBazy());
                //listaObiektow[i].Nr = (long)dr["Nr"];
                //listaObiektow[i].ID = (short)dr["Identyfikator osoby"];
                listaObiektow[i].Nazwa = (string)op.Rows[i]["Nazwa"];
                //listaObiektow[i].Organizacja = (string)dr["Organizacja"];
                //listaObiektow[i].Stanowisko = (string)dr["Stanowisko"];
                //listaObiektow[i].Plec = (string)dr["Płeć"];
                listaObiektow[i].Data = (DateTime)op.Rows[i]["Data:"];
                //listaObiektow[i].Tydzien = (string)dr["Tydzień"];
                //listaObiektow[i].Cykl = (string)dr["Cykl"];
                listaObiektow[i].ZalogowanyO = (DateTime)op.Rows[i]["Zalogowany o"];
                listaObiektow[i].WylogowanyO = (DateTime)op.Rows[i]["Wylogowany o"];
                /*listaObiektow[i].Praca = (DateTime)dr["Praca"];
                listaObiektow[i].Nadgodziny = (DateTime)dr["Nadg."];
                listaObiektow[i].Przetwarzanie = (DateTime)dr["Przetwarzanie"];
                listaObiektow[i].Spoznienie = (DateTime)dr["Spóźnienie"];
                listaObiektow[i].WczesniejszeWyjscie = (DateTime)dr["Wczeniejsze wyjście"];
                listaObiektow[i].Nieobecny = (DateTime)dr["Nieobecny"];
                listaObiektow[i].Urlop = (DateTime)dr["Urlop"];
                listaObiektow[i].Stan = (string)dr["Stan"];
                listaObiektow[i].Rekordy = (string)dr["Rekordy"];
                */
                Console.WriteLine(i);
                i++;
            }
        }

    }
}

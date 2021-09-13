using System;
using System.Collections.Generic;
using System.Text;

namespace Testowy_Projekt
{
    class ObiektBazy
    {
        private long nr;//A
        private short iD;//B
        private string nazwa;//C
        private string organizacja;//D
        private string stanowisko;//E
        private string plec;//F
        private DateTime data;//G
        private string tydzien;//H
        private string cykl;//I
        private DateTime zalogowanyO;//J
        private DateTime wylogowanyO;//K
        private DateTime praca;//L
        private DateTime nadgodziny;//M
        private DateTime przetwarzanie;//N
        private DateTime spoznienie;//O
        private DateTime wczesniejszeWyjscie;//P
        private DateTime nieobecny;//Q
        private DateTime urlop;//R
        private string stan;//S
        private string rekordy;//T


        public ObiektBazy()
        {

        }

        public long Nr { get => nr; set => nr = value; }
        public short ID { get => iD; set => iD = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Organizacja { get => organizacja; set => organizacja = value; }
        public string Stanowisko { get => stanowisko; set => stanowisko = value; }
        public string Plec { get => plec; set => plec = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Tydzien { get => tydzien; set => tydzien = value; }
        public string Cykl { get => cykl; set => cykl = value; }
        public DateTime ZalogowanyO { get => zalogowanyO; set => zalogowanyO = value; }
        public DateTime WylogowanyO { get => wylogowanyO; set => wylogowanyO = value; }
        public DateTime Praca { get => praca; set => praca = value; }
        public DateTime Nadgodziny { get => nadgodziny; set => nadgodziny = value; }
        public DateTime Przetwarzanie { get => przetwarzanie; set => przetwarzanie = value; }
        public DateTime Spoznienie { get => spoznienie; set => spoznienie = value; }
        public DateTime WczesniejszeWyjscie { get => wczesniejszeWyjscie; set => wczesniejszeWyjscie = value; }
        public DateTime Nieobecny { get => nieobecny; set => nieobecny = value; }
        public DateTime Urlop { get => urlop; set => urlop = value; }
        public string Stan { get => stan; set => stan = value; }
        public string Rekordy { get => rekordy; set => rekordy = value; }
    }
}

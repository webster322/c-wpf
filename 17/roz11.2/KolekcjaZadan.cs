using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace roz11._2
{
    class KolekcjaZadan : ObservableCollection<Zadanie>
    {
        public KolekcjaZadan()
        {
            Add(new Zadanie
            {
                Nazwa = "Zamówienie",
                Opis = "Zamówić 100 długopisów żelowych",
                Priorytet = 1
            });
            Add(new Zadanie
            {
                Nazwa = "Zaproszenie",
                Opis = "Zaprosić kontrahentów na pokaz nowego produktu",
                Priorytet = 2
            });
            Add(new Zadanie
            {
                Nazwa = "Sprzątanie",
                Opis = "Posprzątać magazyn",
                Priorytet = 3
            });
        }
    }
}

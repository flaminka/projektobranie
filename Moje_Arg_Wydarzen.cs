using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT_CSS
{
    //pomysł z www.dreamincode.net/forums/topic/206458-how-to-get-values-from-form1-to-form2-or-any-other-forms/
    //tworzymy oddzielną klasę odpowiedzialną za przekazywanie argumentów związanych z danym wydarzeniem
    public class Moje_Arg_Wydarzen : EventArgs

    {
        //tworzymy zmienne, które będą przekazywane (są argumentami) i metody set get dla nich za jednym zamachem  "Auto-Implemented Properties"
        public string[] wiersz { get; set; } // do przekazywania rekordów z okien (ankiet) do tabela_glowna
    }
}
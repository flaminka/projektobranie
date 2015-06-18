using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT_CSS
{
    //klasa pochodzi z
    //www.dreamincode.net/forums/topic/206458-how-to-get-values-from-form1-to-form2-or-any-other-forms/
    //tworzymy oddzielną klasę odpowiedzialną za przekazywanie argumentów związanych z danym wydarzeniem
    public class Moje_Arg_Wydarzen : EventArgs

    {
        //tworzymy zmienne, które będą przekazywane(są argumentami)
        public string Name { get; set; }
        public string Nazwa { get; set; }
    }
}
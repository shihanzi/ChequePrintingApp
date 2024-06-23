using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChequePrintingApp
{
    public class PrintSettings
    {
        public float NameX { get; set; }
        public float NameY { get; set; }
        public float DateX { get; set; }
        public float DateY { get; set; }
        public float AmountX { get; set; }
        public float AmountY { get; set; }
        public float WordsX { get; set; }
        public float WordsY { get; set; }
        public float FontSize { get; set; }

        public float accPayeeX { get; set; }
        public float accPayeeY { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acronym
{
    class Acronym
    {
        public string text { get; set; }
        public string acronym { get; set; }

        public Acronym()
        {
            text = Console.ReadLine();
        }

        public void TextToAcr()
        {
            acronym = string.Concat(text.Where(c => c >= 'A' && c <= 'Z'));
            Console.WriteLine(acronym);
        } 
    }
}

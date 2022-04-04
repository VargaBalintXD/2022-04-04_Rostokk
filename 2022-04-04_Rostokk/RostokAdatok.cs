using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_04_04_Rostokk
{
    class RostokAdatok
    {
        public string Megnevezés     { get; set; }
        public string Kategória { get; set; }
        public string Egység { get; set; }
        public double Rost { get; set; }
    
        public RostokAdatok (string sor)
        {
            string[] t = sor.Split(';');
            Megnevezés = t[0];
            Kategória = t[1];
            Egység = t[2];
            Rost = double.Parse(t[3]);


        }
    
    
    
    
    }
    
}

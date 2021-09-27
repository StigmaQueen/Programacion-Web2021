using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activivdad2.Models
{
    public class Promedio
    {
        public int Cal1 { get; set; }
        public int Cal2 { get; set; }
        public int Cal3 { get; set; }
        public int Resultado { get { return (Cal1 + Cal2 + Cal3) / 3; } }
        
    }
}

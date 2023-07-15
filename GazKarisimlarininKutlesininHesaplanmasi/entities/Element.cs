using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazKarisimlarininKutlesininHesaplanmasi.entities
{
    public class Element
    {
        [Key]
        public int IdElement { get; set; }
        public int AtomNoElement { get; set; }
        public string ElementSembolu { get; set; }
        public string ElementAdi { get; set; }
        public decimal AtomAgirligiElement { get; set; }
    
    }


}

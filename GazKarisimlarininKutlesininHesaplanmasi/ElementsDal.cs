using GazKarisimlarininKutlesininHesaplanmasi.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazKarisimlarininKutlesininHesaplanmasi
{
    public class ElementsDal
    {
        public List<entities.Element> GetAll()
        {
            using (ElementsContext context = new ElementsContext())
            {
                return context.Elements.ToList();
            }
        }
    }
}

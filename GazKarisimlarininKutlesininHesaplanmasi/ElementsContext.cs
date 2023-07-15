using GazKarisimlarininKutlesininHesaplanmasi.entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace GazKarisimlarininKutlesininHesaplanmasi
{
    public class ElementsContext : DbContext
    {

        public DbSet<entities.Element> Elements { get; set; }


    }

    
}
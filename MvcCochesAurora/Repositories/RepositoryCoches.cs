using MvcCochesAurora.Data;
using MvcCochesAurora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCochesAurora.Repositories
{
    public class RepositoryCoches
    {
        private CochesContext context;
        public RepositoryCoches(CochesContext context)
        {
            this.context = context;
        }


        public List<Coche> GetCoches()
        {
            return this.context.Coches.ToList();
        }
    }
}

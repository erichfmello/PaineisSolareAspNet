using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaineisSolares.Models;

namespace PaineisSolares.Services
{
    public class AmbientesService
    {
        private readonly PaineisSolaresContext _context;

        public AmbientesService(PaineisSolaresContext context)
        {
            _context = context;
        }

        public List<Ambiente> FindAll()
        {
            return _context.Ambiente.OrderBy(x => x.Name).ToList();
        }

        public void Insert(Ambiente ambiente)
        {
            _context.Add(ambiente);
            _context.SaveChanges();
        }
    }
}

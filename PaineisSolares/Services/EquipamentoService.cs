using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaineisSolares.Models;

namespace PaineisSolares.Services
{
    public class EquipamentoService
    {
        private readonly PaineisSolaresContext _context;

        public EquipamentoService(PaineisSolaresContext context)
        {
            _context = context;
        }

        public List<Equipamento> FindAll()
        {
            return _context.Equipamento.ToList();
        }

        public void Insert(Equipamento equipamento)
        {
            equipamento.Consumos();
            _context.Add(equipamento);
            _context.SaveChanges();
        }

        public Equipamento FindById(int id)
        {
            return _context.Equipamento.Include(obj => obj.Ambiente).FirstOrDefault(obj => obj.Id == id);
        }

        public void Update(Equipamento equipamento)
        {
            _context.Update(equipamento);
            _context.SaveChanges();
        }
    }
}

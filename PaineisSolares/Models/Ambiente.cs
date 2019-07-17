using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineisSolares.Models
{
    public class Ambiente
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public ICollection<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();

        public Ambiente()
        {
        }

        public Ambiente(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddEquipamento(Equipamento equipamento)
        {
            Equipamentos.Add(equipamento);
        }

        public void RemoveEquipamento(Equipamento equipamento)
        {
            Equipamentos.Remove(equipamento);
        }

        public double ConsumoTotal()
        {
            return Equipamentos.Sum(ct => ct.ConsumoTotal);
        }

        public double ConsumoTotalDia()
        {
            return Equipamentos.Sum(ctd => ctd.ConsumoTotalPorDia);
        }
    }
}

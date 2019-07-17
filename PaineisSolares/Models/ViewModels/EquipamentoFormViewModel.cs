using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineisSolares.Models.ViewModels
{
    public class EquipamentoFormViewModel
    {
        public Equipamento Equipamento { get; set; }
        public ICollection<Ambiente> Ambientes { get; set; }
    }
}

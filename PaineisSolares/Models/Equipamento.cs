using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;

namespace PaineisSolares.Models
{
    public class Equipamento
    {
        public int Id { get; private set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public double ConsumoUnitario { get; set; }        
        public int HorasDeUso { get; set; }

        public double ConsumoTotal { get; set; }
        public double ConsumoTotalPorDia { get; set; }

        public Ambiente Ambiente { get; set; }
        public int AmbienteId { get; set; }

        public Equipamento()
        {
        }

        public Equipamento(int id, int quantidade, string descricao, double consumoUnitario, int horasDeUso, Ambiente ambiente)
        {
            Id = id;
            Quantidade = quantidade;
            Descricao = descricao;
            ConsumoUnitario = consumoUnitario;
            HorasDeUso = horasDeUso;
            Ambiente = ambiente;    
        }

        public void Consumos()
        {
            ConsumoTotal = Quantidade * ConsumoUnitario;
            ConsumoTotalPorDia = ConsumoTotal * HorasDeUso;
        }
    }
}

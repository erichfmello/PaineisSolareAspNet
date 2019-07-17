using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaineisSolares.Services;
using PaineisSolares.Models;
using PaineisSolares.Models.ViewModels;

namespace PaineisSolares.Controllers
{
    public class EquipamentosController : Controller
    {
        private readonly EquipamentoService _equipamentoService;
        private readonly AmbientesService _ambientesService;

        public EquipamentosController(EquipamentoService equipamentoService, AmbientesService ambientesService)
        {
            _equipamentoService = equipamentoService;
            _ambientesService = ambientesService;
        }

        public IActionResult Index()
        {
            var list = _equipamentoService.FindAll();

            return View(list);
        }

        public IActionResult Create()
        {
            var ambientes = _ambientesService.FindAll();
            var viewModel = new EquipamentoFormViewModel { Ambientes = ambientes };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Equipamento equipamento)
        {
            _equipamentoService.Insert(equipamento);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateAmbiente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAmbiente(Ambiente ambiente)
        {
            _ambientesService.Insert(ambiente);

            return RedirectToAction(nameof(Create));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _equipamentoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Ambiente> ambientes = _ambientesService.FindAll();
            EquipamentoFormViewModel viewModel = new EquipamentoFormViewModel { Equipamento = obj, Ambientes = ambientes };
            return View(viewModel);
        }
    }
}
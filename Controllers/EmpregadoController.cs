using AppEmpresa.Data;
using AppEmpresa.Data.Interface;
using AppEmpresa.Models;
using AppEmpresa.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AppEmpresa.Controllers
{

    public class EmpregadoController : Controller
    {
        private readonly IEmpregado _emprgado;

        public EmpregadoController(IEmpregado emprgado)
        {
            _emprgado = emprgado;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(EmpregadoViewModel model)
        {
            if(!ModelState.IsValid) return View();

            Empregado empregado = new Empregado();

            empregado.Nome = model.Nome;
            empregado.Sobrenome = model.Sobrenome;
            empregado.CPF_CNPJ = model.CPF_CNPJ;
            empregado.Telefone = model.Telefone;

            _emprgado.AddEmprgado(empregado);

            return RedirectToAction("Index", "Home");
        }
    }
}

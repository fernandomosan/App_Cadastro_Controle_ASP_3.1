using AppEmpresa.Data.Interface;
using AppEmpresa.Models;
using AppEmpresa.Models.ViewModel;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppEmpresa.Data.Repositorio
{
    public class EmpregadoRepositorio : IEmpregado
    {
        private readonly ApplicationDbContext _context;

        public EmpregadoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddEmprgado(Empregado model)
        {            
            _context.Empregados.Add(model);
            _context.SaveChanges();
        }

        public void AtualizaEmprgado(Empregado model)
        {
            var empregadoDb = _context.Empregados.Where(x => x.Id == model.Id).FirstOrDefault();

            empregadoDb.Nome = model.Nome;
            empregadoDb.Sobrenome = model.Sobrenome;
            empregadoDb.CPF_CNPJ = model.CPF_CNPJ;
            empregadoDb.Nome = model.Nome;

            _context.SaveChanges();
        }

        public void DeletaEmprgado(Guid id)
        {
            var empregadoDb = _context.Empregados.Where(x => x.Id == id).FirstOrDefault();

            _context.Empregados.Remove(empregadoDb);
            _context.SaveChanges();
        }
    }
}

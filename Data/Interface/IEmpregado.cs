using AppEmpresa.Models;
using AppEmpresa.Models.ViewModel;
using System;
using System.Threading.Tasks;

namespace AppEmpresa.Data.Interface
{
    public interface IEmpregado
    {
        void AddEmprgado(Empregado id);
        void DeletaEmprgado(Guid id);
        void AtualizaEmprgado(Empregado id);

    }
}

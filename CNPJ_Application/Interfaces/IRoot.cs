using CNPJ_Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ_Application.Interfaces
{
    public interface IRoot
    {
        Task<ResponseGenerics<RootResponse>> BuscarCNPJ(string cnpj);
    }
}

using CNPJ_API.Dtos;
using CNPJ_MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNPJ_API.Interface
{
    public interface IBrasilApi
    {
        Task<ResponseGenerics<Root>> BuscarCNPJ(string cnpj);
       // Task<ResponseGenerics<Root>> AdcBuscarCNPJ(string cnpj);

    }
}

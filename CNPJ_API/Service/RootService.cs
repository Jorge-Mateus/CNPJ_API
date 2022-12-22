using AutoMapper;
using CNPJ_API.Dtos;
using CNPJ_API.Interface;
using CNPJ_MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNPJ_API.Service
{
    public class RootService : IRoot
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public RootService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }
       
        public async Task<ResponseGenerics<RootResponse>> BuscarCNPJ(string cnpj)
        {
            var cnpjs = await _brasilApi.BuscarCNPJ(cnpj);

            return _mapper.Map<ResponseGenerics<RootResponse>>(cnpjs);
        }

      /*  public async Task<ResponseGenerics<RootResponse>> AdcBuscarCNPJ(string cnpj)
        {
            var cnpjs = _mapper.Map<RootResponse>(cnpj);

            _brasilApi.BuscarCNPJ<RootResponse>(cnpj);
        }*/
    }
}

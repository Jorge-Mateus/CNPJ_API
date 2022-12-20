using AutoMapper;
using CNPJ_API.Dtos;
using CNPJ_API.Interface;
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
            var cnpj_1 = await _brasilApi.BuscarCNPJ(cnpj);
            return _mapper.Map<ResponseGenerics<RootResponse>>(cnpj_1);
        }
    }
}

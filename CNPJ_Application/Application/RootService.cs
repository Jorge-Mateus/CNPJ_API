﻿using AutoMapper;
using CNPJ_Application.Dtos;
using CNPJ_Application.Interfaces;
using CNPJ_MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ_Application.Application
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
    }
}
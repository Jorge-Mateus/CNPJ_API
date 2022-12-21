using AutoMapper;
using CNPJ_API.Dtos;
using CNPJ_MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNPJ_API.Mapping
{
    public class RootMapping : Profile
    {
        public RootMapping()
        {
            CreateMap(typeof(ResponseGenerics<>), typeof(ResponseGenerics<>));
            CreateMap<RootResponse, Root>();
            CreateMap<Root, RootResponse>();
            CreateMap<Qsa, QsaResponse>();
            CreateMap<QsaResponse, Qsa>();
            CreateMap<CnaesSecundarioResponse, CnaesSecundario>();
            CreateMap<CnaesSecundario, CnaesSecundarioResponse>();
        }
    }
}

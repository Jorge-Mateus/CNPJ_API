﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CNPJ_API.Dtos
{
    public class ResponseGenerics<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErroRetono { get; set; }
        
        
        //public  Add { get; set; }
        /*public void Update<T>(T Entity) where T : class;
        public void Delete<T>(T Entity) where T : class;
        public void DeleteRange<T>(T[] Entity) where T : class;
        Task<bool> SaveChangesAsyncs();*/
    }
}

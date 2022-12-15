﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ_MODELS
{
    public class Root
    {
        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("identificador_matriz_filial")]
        public int IdentificadorMatrizFilial { get; set; }

        [JsonPropertyName("descricao_matriz_filial")]
        public string DescricaoMatrizFilial { get; set; }

        [JsonPropertyName("razao_social")]
        public string RazaoSocial { get; set; }

        [JsonPropertyName("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [JsonPropertyName("situacao_cadastral")]
        public int SituacaoCadastral { get; set; }

        [JsonPropertyName("descricao_situacao_cadastral")]
        public string DescricaoSituacaoCadastral { get; set; }

        [JsonPropertyName("data_situacao_cadastral")]
        public string DataSituacaoCadastral { get; set; }

        [JsonPropertyName("motivo_situacao_cadastral")]
        public int MotivoSituacaoCadastral { get; set; }

        [JsonPropertyName("nome_cidade_exterior")]
        public object NomeCidadeExterior { get; set; }

        [JsonPropertyName("codigo_natureza_juridica")]
        public int CodigoNaturezaJuridica { get; set; }

        [JsonPropertyName("data_inicio_atividade")]
        public string DataInicioAtividade { get; set; }

        [JsonPropertyName("cnae_fiscal")]
        public int CnaeFiscal { get; set; }

        [JsonPropertyName("cnae_fiscal_descricao")]
        public string CnaeFiscalDescricao { get; set; }

        [JsonPropertyName("descricao_tipo_logradouro")]
        public string DescricaoTipoLogradouro { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("cep")]
        public int Cep { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("codigo_municipio")]
        public int CodigoMunicipio { get; set; }

        [JsonPropertyName("municipio")]
        public string Municipio { get; set; }

        [JsonPropertyName("ddd_telefone_1")]
        public string DddTelefone1 { get; set; }

        [JsonPropertyName("ddd_telefone_2")]
        public object DddTelefone2 { get; set; }

        [JsonPropertyName("ddd_fax")]
        public object DddFax { get; set; }

        [JsonPropertyName("qualificacao_do_responsavel")]
        public int QualificacaoDoResponsavel { get; set; }

        [JsonPropertyName("capital_social")]
        public int CapitalSocial { get; set; }

        [JsonPropertyName("porte")]
        public int Porte { get; set; }

        [JsonPropertyName("descricao_porte")]
        public string DescricaoPorte { get; set; }

        [JsonPropertyName("opcao_pelo_simples")]
        public bool OpcaoPeloSimples { get; set; }

        [JsonPropertyName("data_opcao_pelo_simples")]
        public object DataOpcaoPeloSimples { get; set; }

        [JsonPropertyName("data_exclusao_do_simples")]
        public object DataExclusaoDoSimples { get; set; }

        [JsonPropertyName("opcao_pelo_mei")]
        public bool OpcaoPeloMei { get; set; }

        [JsonPropertyName("situacao_especial")]
        public object SituacaoEspecial { get; set; }

        [JsonPropertyName("data_situacao_especial")]
        public object DataSituacaoEspecial { get; set; }

        [JsonPropertyName("cnaes_secundarios")]
        public List<CnaesSecundario> CnaesSecundarios { get; set; }

        [JsonPropertyName("qsa")]
        public List<Qsa> Qsa { get; set; }
    }
}

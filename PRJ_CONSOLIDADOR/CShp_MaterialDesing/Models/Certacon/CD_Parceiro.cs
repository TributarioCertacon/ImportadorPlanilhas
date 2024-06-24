using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_CONSOLIDADOR.Models.Certacon
{
    public class CD_Parceiro
    {
        [Key]
        public int ID_PARCEIRO { get; set; }
        public int? ID_PARCEIRO_MASTER { get; set; }
        public string CD_PARCEIRO { get; set; }
        public string NM_PARCEIRO { get; set; } 
        public string ENDERECO { get; set; }
        public string ENDERECO_NUMERO { get; set; }
        public string ENDERECO_COMPLEMENTO { get; set; }
        public string ENDERECO_CEP { get; set; }
        public string ENDERECO_BAIRRO { get; set; }
        public int? CD_CIDADE { get; set; }
        public string CNPJ { get; set; }
        public string IM_BOLETO_MARKTING { get; set; }
        public string MSG_BOLETO_MARKETING { get; set; }
        public string NM_SKIN { get; set; }
        public string DS_HELP_DESK { get; set; }
        public int? ID_PARCEIRO_CATALAGO { get; set; }
        public decimal? PERC_MAX_CARGA { get; set; }
        public string IND_PERM_PROD_PRECO_PARC_PAI { get; set; }
        public string IND_CONTROLA_NIVEL_ALCADA { get; set; }
        public string IND_VISUALIZAR_LOGO_REPORT { get; set; }
        public string PREFIXO_INTEGRADOR { get; set; }
        public decimal? PERC_PRECO_MENOS { get; set; }
        public decimal? PERC_PRECO_MAIS { get; set; }
        public DateTime? DT_ALTERACAO { get; set; }
        public string NM_ESTIPULANTE { get; set; }
        public string FISCAL_UF { get; set; }
        public int? FISCAL_COD_MUNICIPIO_IBGE { get; set; }
        public string FISCAL_IE { get; set; }
        public string FISCAL_IM { get; set; }
        public string FISCAL_SUFRAMA { get; set; }
        public string FISCAL_PERFIL_AP_ARQ_FISCAL { get; set; }
        public string FISCAL_INDICADOR_ATIVIDADE { get; set; }
        public string FISCAL_OPTANTE_SIMPLES_NACIONAL { get; set; }
        public string FISCAL_INCENTIVADOR_CULTURAL { get; set; }
        public string FISCAL_TIPO_CERTIFICADO_DIGITAL { get; set; }
        public string FISCAL_ASSINATURA_DIGITAL { get; set; }
        public string IND_ATIVO { get; set; }
        public string NM_MOTIVO { get; set; }
        public DateTime? DT_STATUS { get; set; }
        public long? ID_USUARIO_STATUS { get; set; }
        public string CD_ORIGEM { get; set; }
        public string IM_LOGO_REPORT { get; set; }
        public string IM_LOGO_LOGIN { get; set; }
        public string IM_LOGO_DESKTOP { get; set; }
        public string IM_ICON_FAVE { get; set; }
        public int? TP_PARCEIRO { get; set; }
        public string NR_TELEFONE { get; set; }
        public int? ID_TIPO_PARCEIRO { get; set; }


    }
}

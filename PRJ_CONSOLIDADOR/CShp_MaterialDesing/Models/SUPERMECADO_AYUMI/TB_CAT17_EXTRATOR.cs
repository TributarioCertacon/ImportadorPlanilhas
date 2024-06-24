using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_CONSOLIDADOR.Models
{
    public class TB_CAT17_EXTRATOR
    {
        [CopyToDataRow]
        public string ID_Parceiro { get; set; }
        [CopyToDataRow]
        public string DT_Periodo { get; set; }
        [CopyToDataRow]
        public string NUM_DOC { get; set; }
        [CopyToDataRow]
        public string SERIE { get; set; }
        [CopyToDataRow]
        public string Modelo { get; set; }
        [CopyToDataRow]
        public string ITEM { get; set; }
        [CopyToDataRow]
        public string IND_ES { get; set; }
        [CopyToDataRow]
        public string DT_FATO_GERADOR { get; set; }
        [CopyToDataRow]
        public string DT_EMISSAO { get; set; }
        [CopyToDataRow]
        public string CODIGO_EMITENTE { get; set; }
        [CopyToDataRow]
        public string EMITENTE { get; set; }
        [CopyToDataRow]
        public string UF_ORIGEM { get; set; }
        [CopyToDataRow]
        public string CODIGO_REMETENTE { get; set; }
        [CopyToDataRow]
        public string REMETENTE { get; set; }
        [CopyToDataRow]
        public string CODIGO_DESTINATARIO { get; set; }
        [CopyToDataRow]
        public string DESTINATARIO { get; set; }
        [CopyToDataRow]
        public string UF_DESTINO { get; set; }
        [CopyToDataRow]
        public string CODIGO_ITEM { get; set; }
        [CopyToDataRow]
        public string DESCRICAO_ITEM { get; set; }
        [CopyToDataRow]
        public string DESCRICAO_ITEM_2 { get; set; }
        [CopyToDataRow]
        public string CFOP { get; set; }
        [CopyToDataRow]
        public string NCM { get; set; }
        [CopyToDataRow]
        public string UNID { get; set; }
        [CopyToDataRow]
        public string ALIQ_INTERNA_ICMS { get; set; }
        [CopyToDataRow]
        public string ALIQ_IPI { get; set; }
        [CopyToDataRow]
        public string MVA { get; set; }
        [CopyToDataRow]
        public string ICMS_ORIG { get; set; }
        [CopyToDataRow]
        public string ICMS_CST { get; set; }
        [CopyToDataRow]
        public string CHAVE_NFE { get; set; }
        [CopyToDataRow]
        public string QTD { get; set; }
        [CopyToDataRow]
        public string VALOR_UNITARIO_ITEM { get; set; }
        [CopyToDataRow]
        public string VALOR_TOTAL_ITEM { get; set; }
        [CopyToDataRow]
        public string ICMS_PREDBC { get; set; }
        [CopyToDataRow]
        public string ICMS_VBC { get; set; }
        [CopyToDataRow]
        public string ICMS_PICMS { get; set; }
        [CopyToDataRow]
        public string ICMS_VICMS { get; set; }
        [CopyToDataRow]
        public string ICMS_VBCFCP { get; set; }
        [CopyToDataRow]
        public string ICMS_PFCP { get; set; }
        [CopyToDataRow]
        public string ICMS_VFCP { get; set; }
        [CopyToDataRow]
        public string ICMS_PMVAST { get; set; }
        [CopyToDataRow]
        public string ICMS_PREDBCST { get; set; }
        [CopyToDataRow]
        public string ICMS_VBCST { get; set; }
        [CopyToDataRow]
        public string ICMS_PICMSST { get; set; }
        [CopyToDataRow]
        public string ICMS_VICMSST { get; set; }
        [CopyToDataRow]
        public string ICMS_VBCFCPST { get; set; }
        [CopyToDataRow]
        public string ICMS_PFCPST { get; set; }
        [CopyToDataRow]
        public string ICMS_VFCPST { get; set; }
        [CopyToDataRow]
        public string ICMS_VBCSTRET { get; set; }
        [CopyToDataRow]
        public string ICMS_VICMSSTRET { get; set; }
        [CopyToDataRow]
        public string ICMS_VBCFCPSTRET { get; set; }
        [CopyToDataRow]
        public string ICMS_PFCPSTRET { get; set; }
        [CopyToDataRow]
        public string ICMS_VFCPSTRET { get; set; }
        [CopyToDataRow]
        public string IPI_VIPI { get; set; }
        [CopyToDataRow]
        public string PIS_VBC { get; set; }
        [CopyToDataRow]
        public string PIS_PPIS { get; set; }
        [CopyToDataRow]
        public string PIS_VPIS { get; set; }
        [CopyToDataRow]
        public string COFINS_VBC { get; set; }
        [CopyToDataRow]
        public string COFINS_PCOFINS { get; set; }
        [CopyToDataRow]
        public string COFINS_VCOFINS { get; set; }
        [CopyToDataRow]
        public string COD_CEST { get; set; }
        [CopyToDataRow]
        public string CodigoProdutoEfetivado { get; set; }
        [CopyToDataRow]
        public string CodigoProdutoEAN { get; set; }
        [CopyToDataRow]
        public string CodigoProdutoEANTrib { get; set; }
        [CopyToDataRow]
        public string FatorConvEstoque { get; set; }
        [CopyToDataRow]
        public string COLEC_MVA { get; set; }
        [CopyToDataRow]
        public string COLEC_PREDBC { get; set; }
        [CopyToDataRow]
        public string COLEC_PICMS { get; set; }
        [CopyToDataRow]
        public string COLEC_IPI { get; set; }
        [CopyToDataRow]
        public string COLEC_PAUTA { get; set; }
        [CopyToDataRow]
        public string SituacaoUsoC100 { get; set; }
        [CopyToDataRow]
        public string SituacaoUsoCAT { get; set; }
        [CopyToDataRow]
        public string SPED_COD_PART { get; set; }
        [CopyToDataRow]
        public string SPED_CNPJ_CPF { get; set; }
        [CopyToDataRow]
        public string SPED_CHAVE_NFe { get; set; }
        [CopyToDataRow]
        public string SPED_IND_OPER { get; set; }
        [CopyToDataRow]
        public string SPED_IND_EMIT { get; set; }
        [CopyToDataRow]
        public string SPED_IE { get; set; }
        [CopyToDataRow]
        public string SPED_COD_MUN { get; set; }
        [CopyToDataRow]
        public string SPED_END { get; set; }
        [CopyToDataRow]
        public string SPED_NUM { get; set; }
        [CopyToDataRow]
        public string SPED_COMPL { get; set; }
        [CopyToDataRow]
        public string SPED_BAIRRO { get; set; }
        [CopyToDataRow]
        public string SPED_COD_PAIS { get; set; }
        [CopyToDataRow]
        public string SPED_COD_SIT { get; set; }
        [CopyToDataRow]
        public string SPED_VL_DOC { get; set; }
        [CopyToDataRow]
        public string SPED_COD_MOD { get; set; }
        [CopyToDataRow]
        public string BASE_RET_USUAL { get; set; }
        [CopyToDataRow]
        public string ICMS_RETIDO_USUAL { get; set; }
        [CopyToDataRow]
        public string OBS_BASE { get; set; }
        [CopyToDataRow]
        public string VALOR_ITEM_USUAL { get; set; }
        [CopyToDataRow]
        public string CodigoItem_USUAL { get; set; }
        [CopyToDataRow]
        public string CFOP_USUAL { get; set; }
        [CopyToDataRow]
        public string QTD_USUAL { get; set; }
        [CopyToDataRow]
        public string OBS_ORIGEM { get; set; }
        [CopyToDataRow]
        public string DESCONTO { get; set; }
        [CopyToDataRow]
        public string SPED_NOME_PARTICIPANTE { get; set; }
        [CopyToDataRow]
        public string NOME_ARQUIVO { get; set; }

        public string NUMCFE { get; set; }

        [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
        sealed class CopyToDataRowAttribute : Attribute { }

        public static void CopyToDataRow(TB_CAT17_EXTRATOR source, DataRow destination)
        {
            foreach (var property in typeof(TB_CAT17_EXTRATOR).GetProperties())
            {
                if (property.GetCustomAttribute<CopyToDataRowAttribute>() != null)
                {
                    destination[property.Name] = property.GetValue(source);
                }
            }
        }

    }
}

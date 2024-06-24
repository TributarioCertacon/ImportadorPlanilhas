using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using PRJ_CONSOLIDADOR.Models;
using System.Reflection;
using OfficeOpenXml;

namespace PRJ_CONSOLIDADOR.Controllers
{
    class LeituraController
    {

        public static object GetDefaultValue(Type type)
        {
            if (type.IsValueType)
            {
                return Activator.CreateInstance(type);
            }
            else
            {
                return null;
            }
        }

        public static void mapRow(DataRow newRow, Models.TB_CAT17_EXTRATOR objeto_leitura)
        {
            newRow["ID_Parceiro"] = objeto_leitura.ID_Parceiro;//1
            objeto_leitura.ID_Parceiro = null;
            newRow["DT_Periodo"] = objeto_leitura.DT_Periodo;//2
            objeto_leitura.DT_Periodo = null;
            newRow["NUM_DOC"] = objeto_leitura.NUM_DOC;//3
            objeto_leitura.NUM_DOC = null;
            newRow["SERIE"] = objeto_leitura.SERIE;//4
            objeto_leitura.SERIE = null;
            newRow["Modelo"] = objeto_leitura.Modelo;//5
            objeto_leitura.Modelo = null;
            newRow["ITEM"] = objeto_leitura.ITEM;//6
            objeto_leitura.ITEM = "0";
            newRow["IND_ES"] = objeto_leitura.IND_ES;//7
            objeto_leitura.IND_ES = "0";
            newRow["DT_FATO_GERADOR"] = objeto_leitura.DT_FATO_GERADOR;//8
            objeto_leitura.DT_FATO_GERADOR = null;
            newRow["DT_EMISSAO"] = objeto_leitura.DT_EMISSAO;//9
            objeto_leitura.DT_EMISSAO = null;
            newRow["CODIGO_EMITENTE"] = objeto_leitura.CODIGO_EMITENTE;//10
            objeto_leitura.CODIGO_EMITENTE = null;
            newRow["EMITENTE"] = objeto_leitura.EMITENTE;//11
            objeto_leitura.EMITENTE = null;
            newRow["UF_ORIGEM"] = objeto_leitura.UF_ORIGEM;//12
            objeto_leitura.UF_ORIGEM = null;
            newRow["CODIGO_REMETENTE"] = objeto_leitura.CODIGO_REMETENTE;//13
            objeto_leitura.CODIGO_REMETENTE = null;
            newRow["REMETENTE"] = objeto_leitura.REMETENTE;//14
            objeto_leitura.REMETENTE = null;
            newRow["CODIGO_DESTINATARIO"] = objeto_leitura.CODIGO_DESTINATARIO;//15
            objeto_leitura.CODIGO_DESTINATARIO = null;
            newRow["DESTINATARIO"] = objeto_leitura.DESTINATARIO;//16
            objeto_leitura.DESTINATARIO = null;
            newRow["UF_DESTINO"] = objeto_leitura.UF_DESTINO;//17
            objeto_leitura.UF_DESTINO = null;
            newRow["CODIGO_ITEM"] = objeto_leitura.CODIGO_ITEM;//18
            objeto_leitura.CODIGO_ITEM = null;
            newRow["DESCRICAO_ITEM"] = objeto_leitura.DESCRICAO_ITEM;//19
            objeto_leitura.DESCRICAO_ITEM = null;
            newRow["DESCRICAO_ITEM_2"] = objeto_leitura.DESCRICAO_ITEM_2;//20
            objeto_leitura.DESCRICAO_ITEM_2 = null;
            newRow["CFOP"] = objeto_leitura.CFOP;//21
            objeto_leitura.CFOP = null;
            newRow["NCM"] = objeto_leitura.NCM;//22
            objeto_leitura.NCM = null;
            newRow["UNID"] = objeto_leitura.UNID;//23
            objeto_leitura.UNID = null;
            newRow["ALIQ_INTERNA_ICMS"] = objeto_leitura.ALIQ_INTERNA_ICMS;//24
            objeto_leitura.ALIQ_INTERNA_ICMS = "";
            newRow["ALIQ_IPI"] = objeto_leitura.ALIQ_IPI;//25
            objeto_leitura.ALIQ_IPI = "";
            newRow["MVA"] = objeto_leitura.MVA;//26
            objeto_leitura.MVA = "";
            newRow["ICMS_ORIG"] = objeto_leitura.ICMS_ORIG;//27
            objeto_leitura.ICMS_ORIG = null;
            newRow["ICMS_CST"] = objeto_leitura.ICMS_CST;//28
            objeto_leitura.ICMS_CST = null;
            newRow["CHAVE_NFE"] = objeto_leitura.CHAVE_NFE;//29
            objeto_leitura.CHAVE_NFE = null;
            newRow["QTD"] = objeto_leitura.QTD;//30
            objeto_leitura.QTD = null;
            newRow["VALOR_UNITARIO_ITEM"] = objeto_leitura.VALOR_UNITARIO_ITEM;//31
            objeto_leitura.VALOR_UNITARIO_ITEM = null;
            newRow["VALOR_TOTAL_ITEM"] = objeto_leitura.VALOR_TOTAL_ITEM;//32
            objeto_leitura.VALOR_TOTAL_ITEM = null;
            newRow["ICMS_PREDBC"] = objeto_leitura.ICMS_PREDBC;//33
            objeto_leitura.ICMS_PREDBC = null;
            newRow["ICMS_VBC"] = objeto_leitura.ICMS_VBC;//34
            objeto_leitura.ICMS_VBC = null;
            newRow["ICMS_PICMS"] = objeto_leitura.ICMS_PICMS;//35
            objeto_leitura.ICMS_PICMS = null;
            newRow["ICMS_VICMS"] = objeto_leitura.ICMS_VICMS;//36
            objeto_leitura.ICMS_VICMS = null;
            newRow["ICMS_VBCFCP"] = objeto_leitura.ICMS_VBCFCP;//37
            objeto_leitura.ICMS_VBCFCP = "";
            newRow["ICMS_PFCP"] = objeto_leitura.ICMS_PFCP;//38
            objeto_leitura.ICMS_PFCP = "";
            newRow["ICMS_VFCP"] = objeto_leitura.ICMS_VFCP;//39
            objeto_leitura.ICMS_VFCP = "";
            newRow["ICMS_PMVAST"] = objeto_leitura.ICMS_PMVAST;//40
            objeto_leitura.ICMS_PMVAST = "";
            newRow["ICMS_PREDBCST"] = objeto_leitura.ICMS_PREDBCST;//41
            objeto_leitura.ICMS_PREDBCST = "";
            newRow["ICMS_VBCST"] = objeto_leitura.ICMS_VBCST;//42
            objeto_leitura.ICMS_VBCST = null;
            newRow["ICMS_PICMSST"] = objeto_leitura.ICMS_PICMSST;//43
            objeto_leitura.ICMS_PICMSST = "";
            newRow["ICMS_VICMSST"] = objeto_leitura.ICMS_VICMSST;//44
            objeto_leitura.ICMS_VICMSST = null;
            newRow["ICMS_VBCFCPST"] = objeto_leitura.ICMS_VBCFCPST;//45
            objeto_leitura.ICMS_VBCFCPST = "";
            newRow["ICMS_PFCPST"] = objeto_leitura.ICMS_PFCPST;//46
            objeto_leitura.ICMS_PFCPST = "";
            newRow["ICMS_VFCPST"] = objeto_leitura.ICMS_VFCPST;//47
            objeto_leitura.ICMS_VFCPST = "";
            newRow["ICMS_VBCSTRET"] = objeto_leitura.ICMS_VBCSTRET;//48
            objeto_leitura.ICMS_VBCSTRET = null;
            newRow["ICMS_VICMSSTRET"] = objeto_leitura.ICMS_VICMSSTRET;//49
            objeto_leitura.ICMS_VICMSSTRET = null;
            newRow["ICMS_VBCFCPSTRET"] = objeto_leitura.ICMS_VBCFCPSTRET;//50
            objeto_leitura.ICMS_VBCFCPSTRET = null;
            newRow["ICMS_PFCPSTRET"] = objeto_leitura.ICMS_PFCPSTRET;//51
            objeto_leitura.ICMS_PFCPSTRET = "";
            newRow["ICMS_VFCPSTRET"] = objeto_leitura.ICMS_VFCPSTRET;//52
            objeto_leitura.ICMS_VFCPSTRET = "";
            newRow["IPI_VIPI"] = objeto_leitura.IPI_VIPI;//53
            objeto_leitura.IPI_VIPI = "";
            newRow["PIS_VBC"] = objeto_leitura.PIS_VBC;//54
            objeto_leitura.PIS_VBC = "";
            newRow["PIS_PPIS"] = objeto_leitura.PIS_PPIS;//55
            objeto_leitura.PIS_PPIS = "";
            newRow["PIS_VPIS"] = objeto_leitura.PIS_VPIS;//56
            objeto_leitura.PIS_VPIS = "0";
            newRow["COFINS_VBC"] = objeto_leitura.COFINS_VBC;//57
            objeto_leitura.COFINS_VBC = "";
            newRow["COFINS_PCOFINS"] = objeto_leitura.COFINS_PCOFINS;//58
            objeto_leitura.COFINS_PCOFINS = "";
            newRow["COFINS_VCOFINS"] = objeto_leitura.COFINS_VCOFINS;//59
            objeto_leitura.COFINS_VCOFINS = "0";
            newRow["COD_CEST"] = objeto_leitura.COD_CEST;//60
            objeto_leitura.COD_CEST = null;
            newRow["CodigoProdutoEfetivado"] = objeto_leitura.CodigoProdutoEfetivado;//61
            objeto_leitura.CodigoProdutoEfetivado = null;
            newRow["CodigoProdutoEAN"] = objeto_leitura.CodigoProdutoEAN;//62
            objeto_leitura.CodigoProdutoEAN = null;
            newRow["CodigoProdutoEANTrib"] = objeto_leitura.CodigoProdutoEANTrib;//63
            objeto_leitura.CodigoProdutoEANTrib = null;
            newRow["FatorConvEstoque"] = objeto_leitura.FatorConvEstoque;//64
            objeto_leitura.FatorConvEstoque = "";
            newRow["COLEC_MVA"] = objeto_leitura.COLEC_MVA;//65
            objeto_leitura.COLEC_MVA = "";
            newRow["COLEC_PREDBC"] = objeto_leitura.COLEC_PREDBC;//66
            objeto_leitura.COLEC_PREDBC = "";
            newRow["COLEC_PICMS"] = objeto_leitura.COLEC_PICMS;//67
            objeto_leitura.COLEC_PICMS = "";
            newRow["COLEC_IPI"] = objeto_leitura.COLEC_IPI;//68
            objeto_leitura.COLEC_IPI = "";
            newRow["COLEC_PAUTA"] = objeto_leitura.COLEC_PAUTA;//69
            objeto_leitura.COLEC_PAUTA = "";
            newRow["SituacaoUsoC100"] = objeto_leitura.SituacaoUsoC100;//70
            objeto_leitura.SituacaoUsoC100 = null;
            newRow["SituacaoUsoCAT"] = objeto_leitura.SituacaoUsoCAT;//71
            objeto_leitura.SituacaoUsoCAT = null;
            newRow["SPED_COD_PART"] = objeto_leitura.SPED_COD_PART;//72
            objeto_leitura.SPED_COD_PART = null;
            newRow["SPED_CNPJ_CPF"] = objeto_leitura.SPED_CNPJ_CPF;//73
            objeto_leitura.SPED_CNPJ_CPF = null;
            newRow["SPED_CHAVE_NFe"] = objeto_leitura.SPED_CHAVE_NFe;//74
            objeto_leitura.SPED_CHAVE_NFe = null;
            newRow["SPED_IND_OPER"] = objeto_leitura.SPED_IND_OPER;//75
            objeto_leitura.SPED_IND_OPER = null;
            newRow["SPED_IND_EMIT"] = objeto_leitura.SPED_IND_EMIT;//76
            objeto_leitura.SPED_IND_EMIT = null;
            newRow["SPED_IE"] = objeto_leitura.SPED_IE;//77
            objeto_leitura.SPED_IE = null;
            newRow["SPED_COD_MUN"] = objeto_leitura.SPED_COD_MUN;//78
            objeto_leitura.SPED_COD_MUN = null;
            newRow["SPED_END"] = objeto_leitura.SPED_END;//79
            objeto_leitura.SPED_END = null;
            newRow["SPED_NUM"] = objeto_leitura.SPED_NUM;//80
            objeto_leitura.SPED_NUM = null;
            newRow["SPED_COMPL"] = objeto_leitura.SPED_COMPL;//81
            objeto_leitura.SPED_COMPL = null;
            newRow["SPED_BAIRRO"] = objeto_leitura.SPED_BAIRRO;//82
            objeto_leitura.SPED_BAIRRO = null;
            newRow["SPED_COD_PAIS"] = objeto_leitura.SPED_COD_PAIS;//83
            objeto_leitura.SPED_COD_PAIS = null;
            newRow["SPED_COD_SIT"] = objeto_leitura.SPED_COD_SIT;//84
            objeto_leitura.SPED_COD_SIT = null;
            newRow["SPED_VL_DOC"] = objeto_leitura.SPED_VL_DOC;//85
            objeto_leitura.SPED_VL_DOC = null;
            newRow["SPED_COD_MOD"] = objeto_leitura.SPED_COD_MOD;//86
            objeto_leitura.SPED_COD_MOD = null;
            newRow["BASE_RET_USUAL"] = objeto_leitura.BASE_RET_USUAL;//87
            objeto_leitura.BASE_RET_USUAL = null;
            newRow["ICMS_RETIDO_USUAL"] = objeto_leitura.ICMS_RETIDO_USUAL;//88
            objeto_leitura.ICMS_RETIDO_USUAL = null;
            newRow["OBS_BASE"] = objeto_leitura.OBS_BASE;//89
            objeto_leitura.OBS_BASE = null;
            newRow["VALOR_ITEM_USUAL"] = objeto_leitura.VALOR_ITEM_USUAL;//90
            objeto_leitura.VALOR_ITEM_USUAL = null;
            newRow["CodigoItem_USUAL"] = objeto_leitura.CodigoItem_USUAL;//91
            objeto_leitura.CodigoItem_USUAL = null;
            newRow["CFOP_USUAL"] = objeto_leitura.CFOP_USUAL;//92
            objeto_leitura.CFOP_USUAL = null;
            newRow["QTD_USUAL"] = objeto_leitura.QTD_USUAL;//93
            objeto_leitura.QTD_USUAL = "";
            newRow["OBS_ORIGEM"] = objeto_leitura.OBS_ORIGEM;//94
            objeto_leitura.OBS_ORIGEM = null;
            newRow["SPED_NOME_PARTICIPANTE"] = objeto_leitura.SPED_NOME_PARTICIPANTE;//95
            objeto_leitura.SPED_NOME_PARTICIPANTE = null;
            newRow["DESCONTO"] = objeto_leitura.DESCONTO;//95
            objeto_leitura.DESCONTO = null;
            newRow["NOME_ARQUIVO"] = objeto_leitura.NOME_ARQUIVO;//96
            objeto_leitura.NOME_ARQUIVO = null;
            newRow["NUMCFE"] = objeto_leitura.NUMCFE;//97
            objeto_leitura.NUMCFE = null;
        }

        public void ler_form(FileInfo file, Leitura leitura, DataTable dataTableMain)
        {
            Models.TB_CAT17_EXTRATOR objeto_leitura = new Models.TB_CAT17_EXTRATOR();

            Dictionary<string, Action<string>> propertyMap = new Dictionary<string, Action<string>>()
            {
                { "ID_Parceiro", value => objeto_leitura.ID_Parceiro =  value },
                { "DT_Periodo", value => objeto_leitura.DT_Periodo = value },
                { "NUM_DOC", value => objeto_leitura.NUM_DOC = value },
                { "SERIE", value => objeto_leitura.SERIE = value },
                { "Modelo", value => objeto_leitura.Modelo = value },
                { "ITEM", value => objeto_leitura.ITEM = value },
                { "IND_ES", value => objeto_leitura.IND_ES =value },
                { "DT_FATO_GERADOR", value => objeto_leitura.DT_FATO_GERADOR = value },
                { "DT_EMISSAO", value => objeto_leitura.DT_EMISSAO = value },
                { "CODIGO_EMITENTE", value => objeto_leitura.CODIGO_EMITENTE = value },
                { "EMITENTE", value => objeto_leitura.EMITENTE = value },
                { "UF_ORIGEM", value => objeto_leitura.UF_ORIGEM = value },
                { "CODIGO_REMETENTE", value => objeto_leitura.CODIGO_REMETENTE = value },
                { "REMETENTE", value => objeto_leitura.REMETENTE = value },
                { "CODIGO_DESTINATARIO", value => objeto_leitura.CODIGO_DESTINATARIO = value },
                { "DESTINATARIO", value => objeto_leitura.DESTINATARIO = value },
                { "UF_DESTINO", value => objeto_leitura.UF_DESTINO = value },
                { "CODIGO_ITEM", value => objeto_leitura.CODIGO_ITEM = value },
                { "DESCRICAO_ITEM", value => objeto_leitura.DESCRICAO_ITEM = value },
                { "DESCRICAO_ITEM_2", value => objeto_leitura.DESCRICAO_ITEM_2 = value },
                { "CFOP", value => objeto_leitura.CFOP = value },
                { "NCM", value => objeto_leitura.NCM = value },
                { "UNID", value => objeto_leitura.UNID = value },
                { "ALIQ_INTERNA_ICMS", value => objeto_leitura.ALIQ_INTERNA_ICMS = value /*Convert.ToDouble(value)*/ },
                { "ALIQ_IPI", value => objeto_leitura.ALIQ_IPI =value /*Convert.ToDouble(value)*/},
                { "MVA", value => objeto_leitura.MVA =value /*Convert.ToDouble(value)*/ },
                { "ICMS_ORIG", value => objeto_leitura.ICMS_ORIG = value },
                { "ICMS_CST", value => objeto_leitura.ICMS_CST = value },
                { "CHAVE_NFE", value => objeto_leitura.CHAVE_NFE = value },
                { "QTD", value => objeto_leitura.QTD = value },
                { "VALOR_UNITARIO_ITEM", value => objeto_leitura.VALOR_UNITARIO_ITEM = value },
                { "VALOR_TOTAL_ITEM", value => objeto_leitura.VALOR_TOTAL_ITEM = value },
                { "ICMS_PREDBC", value => objeto_leitura.ICMS_PREDBC = value },
                { "ICMS_VBC", value => objeto_leitura.ICMS_VBC = value },
                { "ICMS_PICMS", value => objeto_leitura.ICMS_PICMS = value },
                { "ICMS_VICMS", value => objeto_leitura.ICMS_VICMS = value },
                { "ICMS_VBCFCP", value => objeto_leitura.ICMS_VBCFCP =value /*Convert.ToDouble(value)*/ },
                { "ICMS_PFCP", value => objeto_leitura.ICMS_PFCP =             value /*Convert.ToDouble(value)*/ },
                { "ICMS_VFCP", value => objeto_leitura.ICMS_VFCP =             value /*Convert.ToDouble(value)*/ },
                { "ICMS_PMVAST", value => objeto_leitura.ICMS_PMVAST =         value /*Convert.ToDouble(value)*/ },
                { "ICMS_PREDBCST", value => objeto_leitura.ICMS_PREDBCST =     value /*Convert.ToDouble(value)*/ },
                { "ICMS_VBCST", value => objeto_leitura.ICMS_VBCST = value },
                { "ICMS_PICMSST", value => objeto_leitura.ICMS_PICMSST = value /*Convert.ToDouble(value)*/ },
                { "ICMS_VICMSST", value => objeto_leitura.ICMS_VICMSST = value },
                { "ICMS_VBCFCPST", value => objeto_leitura.ICMS_VBCFCPST = value /*Convert.ToDouble(value)*/ },
                { "ICMS_PFCPST", value => objeto_leitura.ICMS_PFCPST = value /*Convert.ToDouble(value)*/ },
                { "ICMS_VFCPST", value => objeto_leitura.ICMS_VFCPST =value /*Convert.ToDouble(value)*/ },
                { "ICMS_VBCSTRET", value => objeto_leitura.ICMS_VBCSTRET = value },
                { "ICMS_VICMSSTRET", value => objeto_leitura.ICMS_VICMSSTRET = value },
                { "ICMS_VBCFCPSTRET", value => objeto_leitura.ICMS_VBCFCPSTRET = value },
                { "ICMS_PFCPSTRET", value => objeto_leitura.ICMS_PFCPSTRET = value /*Convert.ToDouble(value)*/ },
                { "ICMS_VFCPSTRET", value => objeto_leitura.ICMS_VFCPSTRET = value /*Convert.ToDouble(value)*/ },
                { "IPI_VIPI", value => objeto_leitura.IPI_VIPI = value /*Convert.ToDouble(value)*/ },
                { "PIS_VBC", value => objeto_leitura.PIS_VBC = value /*Convert.ToDouble(value)*/ },
                { "PIS_PPIS", value => objeto_leitura.PIS_PPIS = value /*Convert.ToDouble(value)*/ },
                { "PIS_VPIS", value => objeto_leitura.PIS_VPIS = value },
                { "COFINS_VBC", value => objeto_leitura.COFINS_VBC = value /*Convert.ToDouble(value)*/ },
                { "COFINS_PCOFINS", value => objeto_leitura.COFINS_PCOFINS = value /*Convert.ToDouble(value)*/ },
                { "COFINS_VCOFINS", value => objeto_leitura.COFINS_VCOFINS = value },
                { "COD_CEST", value => objeto_leitura.COD_CEST = value },
                { "CodigoProdutoEfetivado", value => objeto_leitura.CodigoProdutoEfetivado = value },
                { "CodigoProdutoEAN", value => objeto_leitura.CodigoProdutoEAN = value },
                { "CodigoProdutoEANTrib", value => objeto_leitura.CodigoProdutoEANTrib = value },
                { "FatorConvEstoque", value => objeto_leitura.FatorConvEstoque =value /*Convert.ToDouble(value)*/ },
                { "COLEC_MVA", value => objeto_leitura.COLEC_MVA = value },
                { "COLEC_PREDBC", value => objeto_leitura.COLEC_PREDBC = value},
                { "COLEC_PICMS", value => objeto_leitura.COLEC_PICMS =value },
                { "COLEC_IPI", value => objeto_leitura.COLEC_IPI = value },
                { "COLEC_PAUTA", value => objeto_leitura.COLEC_PAUTA = value },
                { "SituacaoUsoC100", value => objeto_leitura.SituacaoUsoC100 = value },
                { "SituacaoUsoCAT", value => objeto_leitura.SituacaoUsoCAT = value },
                { "SPED_COD_PART", value => objeto_leitura.SPED_COD_PART = value },
                { "SPED_CNPJ_CPF", value => objeto_leitura.SPED_CNPJ_CPF = value },
                { "SPED_CHAVE_NFe", value => objeto_leitura.SPED_CHAVE_NFe = value },
                { "SPED_IND_OPER", value => objeto_leitura.SPED_IND_OPER = value },
                { "SPED_IND_EMIT", value => objeto_leitura.SPED_IND_EMIT = value },
                { "SPED_IE", value => objeto_leitura.SPED_IE = value },
                { "SPED_COD_MUN", value => objeto_leitura.SPED_COD_MUN = value },
                { "SPED_END", value => objeto_leitura.SPED_END = value },
                { "SPED_NUM", value => objeto_leitura.SPED_NUM = value },
                { "SPED_COMPL", value => objeto_leitura.SPED_COMPL = value },
                { "SPED_BAIRRO", value => objeto_leitura.SPED_BAIRRO = value },
                { "SPED_COD_PAIS", value => objeto_leitura.SPED_COD_PAIS = value },
                { "SPED_COD_SIT", value => objeto_leitura.SPED_COD_SIT = value },
                { "SPED_VL_DOC", value => objeto_leitura.SPED_VL_DOC = value },
                { "SPED_COD_MOD", value => objeto_leitura.SPED_COD_MOD = value },
                { "BASE_RET_USUAL", value => objeto_leitura.BASE_RET_USUAL = value },
                { "ICMS_RETIDO_USUAL", value => objeto_leitura.ICMS_RETIDO_USUAL = value },
                { "OBS_BASE", value => objeto_leitura.OBS_BASE = value },
                { "VALOR_ITEM_USUAL", value => objeto_leitura.VALOR_ITEM_USUAL = value },
                { "CodigoItem_USUAL", value => objeto_leitura.CodigoItem_USUAL = value },
                { "CFOP_USUAL", value => objeto_leitura.CFOP_USUAL = value },
                { "QTD_USUAL", value => objeto_leitura.QTD_USUAL = value /*Convert.ToDouble(value)*/ },
                { "OBS_ORIGEM", value => objeto_leitura.OBS_ORIGEM = value },
                { "SPED_NOME_PARTICIPANTE", value => objeto_leitura.SPED_NOME_PARTICIPANTE = value },
                { "DESCONTO", value => objeto_leitura.DESCONTO = value },
                { "NOME_ARQUIVO", value => objeto_leitura.NOME_ARQUIVO = value },
                { "NUMCFE", value => objeto_leitura.NUMCFE = value }
            };

            List<DE_PARA> ListaDoObejetoLeitura = new List<DE_PARA>();
            List<COLUNA_x_ARRAY> coluna_x_array = new List<COLUNA_x_ARRAY>();
            DirectoryInfo diretorios_layout = new DirectoryInfo(leitura.textBox2.Text);

            //VERIFICANDO ARQUIVOS EXISTENTES
            if (diretorios_layout.Exists)
            {
                FileInfo[] rgFiles = diretorios_layout.GetFiles("*.xlsx");


                //INICIANDO LEITURA DO LAYOUT DEFINIDO EM PLANILHA
                foreach (FileInfo fi in rgFiles)
                {
                    try
                    {
                        //Abrindo conexão para leitura do excel
                        FileStream layout = File.Open(fi.FullName, FileMode.Open, FileAccess.Read);

                        using (var reader = ExcelReaderFactory.CreateReader(layout))
                        {
                            var result = reader.AsDataSet();
                            var dataTable = result.Tables[0];

                            for (int col = 0; col < dataTable.Columns.Count; col++)
                            {
                                var layout_plan = dataTable.Rows[0][col].ToString();
                                var doc_plan = dataTable.Rows[1][col].ToString();

                                ListaDoObejetoLeitura.Add(new DE_PARA() { PLANILHA_LAYOUT = layout_plan, PLANILHA_DOC = doc_plan });
                            }
                        }


                    }
                    catch (Exception ext)
                    {
                        string a = ext.Message;
                    }


                    if (file.Name.EndsWith(".xlsx") || file.Name.EndsWith(".xlsb") || file.Name.EndsWith(".xls") || file.Name.EndsWith(".csv") || file.Name.EndsWith(".txt"))
                    {
                        int countRowCabecalho = 0;

                        try
                        {

                            FileStream stream = File.Open(file.FullName, FileMode.Open, FileAccess.Read);

                            /*
                             * ##############################################################################################################################################
                             *                                                   PARA ARQUIVOS CSV
                             *###############################################################################################################################################                                                 
                             */

                            DataTable batchTable = new DataTable();

                            if (leitura.domainUpDown2.SelectedItem.ToString() == "CSV")
                            {
                                using (var reader = ExcelReaderFactory.CreateCsvReader(stream, null))
                                {
                                    bool isFirstBatch = true;
                                    do
                                    {

                                        int batchSize = 100000;

                                        // Leitura do próximo lote de linhas
                                        for (int i = 0; i < batchSize; i++)
                                        {
                                            if (!reader.Read())
                                            {
                                                reader.Close();
                                                continue;
                                            }
                                            if (isFirstBatch)
                                            {
                                                // Crie as colunas do DataTable no primeiro lote
                                                for (int col = 0; col < reader.FieldCount; col++)
                                                {
                                                    batchTable.Columns.Add(reader[col].ToString());
                                                }
                                                isFirstBatch = false;
                                            }

                                            DataRow row = batchTable.NewRow();
                                            for (int col = 0; col < reader.FieldCount; col++)
                                            {
                                                row[col] = reader[col];
                                            }
                                            batchTable.Rows.Add(row);
                                        }
                                    } while (!reader.IsClosed);
                                }


                                foreach (DataRow linha in batchTable.Rows)
                                {

                                    if (countRowCabecalho == 0)
                                    {
                                        // para cada coluna da linha atual
                                        foreach (var itemLista in ListaDoObejetoLeitura)
                                        {

                                            if (linha.ItemArray.Contains(itemLista.PLANILHA_DOC.ToString()))
                                            {
                                                int index = -1; // Variável para armazenar o índice da coluna

                                                // Encontrar o índice da coluna correspondente
                                                for (int i = 0; i < linha.ItemArray.Length; i++)
                                                {
                                                    if (linha.ItemArray[i].ToString() == itemLista.PLANILHA_DOC.ToString())
                                                    {
                                                        index = i;
                                                        coluna_x_array.Add(new COLUNA_x_ARRAY() { POSICAO = index, COLUNA = itemLista.PLANILHA_LAYOUT.ToString() }); ;

                                                    }
                                                }

                                            }

                                        }

                                        countRowCabecalho++;
                                    }

                                    if (countRowCabecalho > 1)
                                    {


                                        foreach (var itemLista in coluna_x_array)
                                        {
                                            if (propertyMap.TryGetValue(itemLista.COLUNA.ToString(), out var action))
                                            {
                                                if (linha.ItemArray[itemLista.POSICAO].ToString().Replace('"', ' ') == null)
                                                    continue;
                                                else
                                                    action.Invoke(linha.ItemArray[itemLista.POSICAO].ToString().Replace('"', ' '));
                                            }
                                        }
                                        objeto_leitura.NOME_ARQUIVO = file.Name;

                                        var properties = typeof(Models.TB_CAT17_EXTRATOR).GetProperties();

                                        foreach (var property in properties)
                                        {
                                            var value = property.GetValue(objeto_leitura);
                                            if (value == null || string.IsNullOrEmpty(value.ToString()))
                                            {
                                                property.SetValue(objeto_leitura, GetDefaultValue(property.PropertyType));
                                            }
                                        }

                                        try
                                        {
                                            DataRow newRow = dataTableMain.NewRow();
                                            mapRow(newRow, objeto_leitura);
                                            // TB_CAT17_EXTRATOR.CopyToDataRow(objeto_leitura, newRow);
                                            dataTableMain.Rows.Add(newRow);
                                        }
                                        catch (Exception ex)
                                        {
                                            string e = ex.Message;
                                        }
                                    }

                                    countRowCabecalho++;
                                }
                            }

                            else if (leitura.domainUpDown2.SelectedItem.ToString() == "XLSX")
                            {
                                using (var reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                                {
                                    bool isFirstBatch = true;
                                    do
                                    {
                                        int batchSize = 100000;

                                        // Reading the next batch of rows
                                        for (int i = 0; i < batchSize; i++)
                                        {
                                            if (!reader.Read())
                                            {
                                                reader.Close();
                                                break;
                                            }

                                            if (isFirstBatch)
                                            {
                                                // Create DataTable columns in the first batch
                                                for (int col = 0; col < reader.FieldCount; col++)
                                                {
                                                    batchTable.Columns.Add(reader[col].ToString());
                                                }
                                                isFirstBatch = false;
                                            }

                                            DataRow row = batchTable.NewRow();
                                            for (int col = 0; col < reader.FieldCount; col++)
                                            {
                                                row[col] = reader[col];
                                            }
                                            batchTable.Rows.Add(row);
                                        }
                                    } while (!reader.IsClosed);
                                }


                                foreach (DataRow linha in batchTable.Rows)
                                {

                                    if (countRowCabecalho == 0)
                                    {
                                        // para cada coluna da linha atual
                                        foreach (var itemLista in ListaDoObejetoLeitura)
                                        {

                                            if (linha.ItemArray.Contains(itemLista.PLANILHA_DOC.ToString()))
                                            {
                                                int index = -1; // Variável para armazenar o índice da coluna

                                                // Encontrar o índice da coluna correspondente
                                                for (int i = 0; i < linha.ItemArray.Length; i++)
                                                {
                                                    if (linha.ItemArray[i].ToString() == itemLista.PLANILHA_DOC.ToString())
                                                    {
                                                        index = i;
                                                        coluna_x_array.Add(new COLUNA_x_ARRAY() { POSICAO = index, COLUNA = itemLista.PLANILHA_LAYOUT.ToString() }); ;
                                                        break;
                                                    }
                                                }

                                            }

                                        }

                                        countRowCabecalho++;

                                    }

                                    if (countRowCabecalho > 1)
                                    {

                                        foreach (var itemLista in coluna_x_array)
                                        {
                                            if (propertyMap.TryGetValue(itemLista.COLUNA.ToString(), out var action))
                                            {
                                                action.Invoke(linha.ItemArray[itemLista.POSICAO].ToString());
                                            }
                                        }

                                        objeto_leitura.NOME_ARQUIVO = file.Name;

                                        var properties = typeof(Models.TB_CAT17_EXTRATOR).GetProperties();

                                        foreach (var property in properties)
                                        {
                                            var value = property.GetValue(objeto_leitura);
                                            if (value == null || string.IsNullOrEmpty(value.ToString()))
                                            {
                                                property.SetValue(objeto_leitura, GetDefaultValue(property.PropertyType));
                                            }
                                        }

                                        try
                                        {
                                            DataRow newRow = dataTableMain.NewRow();
                                            mapRow(newRow, objeto_leitura);
                                            // TB_CAT17_EXTRATOR.CopyToDataRow(objeto_leitura, newRow);
                                            dataTableMain.Rows.Add(newRow);
                                        }
                                        catch (Exception ex)
                                        {
                                            string e = ex.Message;
                                        }
                                    }

                                    countRowCabecalho++;
                                }
                            }

                            else if (leitura.domainUpDown2.SelectedItem.ToString() == "XLS")
                            {
                                using (var package = new ExcelPackage(stream))
                                {
                                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming you are reading from the first worksheet

                                    bool isFirstBatch = true;
                                    int batchSize = 100000;

                                    do
                                    {
                                        for (int i = 1; i <= batchSize; i++)
                                        {
                                            if (worksheet.Dimension == null || i > worksheet.Dimension.End.Row)
                                            {
                                                break;
                                            }

                                            if (isFirstBatch)
                                            {
                                                // Create DataTable columns in the first batch
                                                for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                                                {
                                                    batchTable.Columns.Add(worksheet.Cells[1, col].Text);
                                                }

                                                isFirstBatch = false;
                                            }

                                            DataRow row = batchTable.NewRow();
                                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                                            {
                                                row[col - 1] = worksheet.Cells[i, col].Value;
                                            }
                                            batchTable.Rows.Add(row);
                                        }
                                    } while (batchTable.Rows.Count > 0);
                                }


                                foreach (DataRow linha in batchTable.Rows)
                                {

                                    if (countRowCabecalho == 0)
                                    {
                                        // para cada coluna da linha atual
                                        foreach (var itemLista in ListaDoObejetoLeitura)
                                        {

                                            if (linha.ItemArray.Contains(itemLista.PLANILHA_DOC.ToString()))
                                            {
                                                int index = -1; // Variável para armazenar o índice da coluna

                                                // Encontrar o índice da coluna correspondente
                                                for (int i = 0; i < linha.ItemArray.Length; i++)
                                                {
                                                    if (linha.ItemArray[i].ToString() == itemLista.PLANILHA_DOC.ToString())
                                                    {
                                                        index = i;
                                                        coluna_x_array.Add(new COLUNA_x_ARRAY() { POSICAO = index, COLUNA = itemLista.PLANILHA_LAYOUT.ToString() }); ;

                                                    }
                                                }

                                            }

                                        }

                                        countRowCabecalho++;

                                    }

                                    if (countRowCabecalho > 1)
                                    {

                                        foreach (var itemLista in coluna_x_array)
                                        {
                                            if (propertyMap.TryGetValue(itemLista.COLUNA.ToString(), out var action))
                                            {
                                                action.Invoke(linha.ItemArray[itemLista.POSICAO].ToString());
                                            }
                                        }

                                        objeto_leitura.NOME_ARQUIVO = file.Name;

                                        var properties = typeof(Models.TB_CAT17_EXTRATOR).GetProperties();

                                        foreach (var property in properties)
                                        {
                                            var value = property.GetValue(objeto_leitura);
                                            if (value == null || string.IsNullOrEmpty(value.ToString()))
                                            {
                                                property.SetValue(objeto_leitura, GetDefaultValue(property.PropertyType));
                                            }
                                        }

                                        try
                                        {
                                            DataRow newRow = dataTableMain.NewRow();
                                            mapRow(newRow, objeto_leitura);
                                            // TB_CAT17_EXTRATOR.CopyToDataRow(objeto_leitura, newRow);
                                            dataTableMain.Rows.Add(newRow);
                                        }
                                        catch (Exception ex)
                                        {
                                            string e = ex.Message;
                                        }
                                    }

                                    countRowCabecalho++;
                                }
                            }

                            if (leitura.domainUpDown2.SelectedItem.ToString() == "TXT")
                            {
                                using (var reader = new StreamReader(stream))
                                {
                                    bool isFirstBatch = true;
                                    do
                                    {
                                        int batchSize = 100000;
                                        int currentBatchCount = 0;

                                        // Leitura do próximo lote de linhas
                                        for (int i = 0; i < batchSize; i++)
                                        {
                                            string line = reader.ReadLine();
                                            if (line == null)
                                            {
                                                continue;
                                            }
                                            string[] values = line.Split(';'); // Altere o delimitador conforme necessário

                                            if (isFirstBatch)
                                            {
                                                // Crie as colunas do DataTable no primeiro lote
                                                for (int col = 0; col < values.Length; col++)
                                                {
                                                    batchTable.Columns.Add(values[col].ToString());
                                                }

                                                // Adicione a linha do cabeçalho como uma row
                                                DataRow headerRow = batchTable.NewRow();
                                                for (int col = 0; col < values.Length; col++)
                                                {
                                                    headerRow[col] = values[col];
                                                }
                                                batchTable.Rows.Add(headerRow);

                                                isFirstBatch = false;
                                                continue; // Pule para a próxima iteração para não adicionar a linha de cabeçalho novamente
                                            }

                                            DataRow row = batchTable.NewRow();
                                            for (int col = 0; col < values.Length; col++)
                                            {
                                                row[col] = values[col];
                                            }
                                            batchTable.Rows.Add(row);
                                            currentBatchCount++;
                                        }
                                    } while (!reader.EndOfStream);
                                }
                                foreach (DataRow linha in batchTable.Rows)
                                {

                                    if (countRowCabecalho == 0)
                                    {
                                        // para cada coluna da linha atual
                                        foreach (var itemLista in ListaDoObejetoLeitura)
                                        {

                                            if (linha.ItemArray.Contains(itemLista.PLANILHA_DOC.ToString()))
                                            {
                                                int index = -1; // Variável para armazenar o índice da coluna

                                                // Encontrar o índice da coluna correspondente
                                                for (int i = 0; i < linha.ItemArray. Length; i++)
                                                {
                                                    if (linha.ItemArray[i].ToString() == itemLista.PLANILHA_DOC.ToString())
                                                    {
                                                        index = i;
                                                        coluna_x_array.Add(new COLUNA_x_ARRAY() { POSICAO = index, COLUNA = itemLista.PLANILHA_LAYOUT.ToString() }); ;

                                                    }
                                                }

                                            }

                                        }

                                        countRowCabecalho++;
                                    }

                                    if (countRowCabecalho > 1)
                                    {


                                        foreach (var itemLista in coluna_x_array)
                                        {
                                            if (propertyMap.TryGetValue(itemLista.COLUNA.ToString(), out var action))
                                            {
                                                if (linha.ItemArray[itemLista.POSICAO].ToString().Replace('"', ' ') == null)
                                                    continue;
                                                else
                                                    action.Invoke(linha.ItemArray[itemLista.POSICAO].ToString().Replace('"', ' '));
                                            }
                                        }
                                        objeto_leitura.NOME_ARQUIVO = file.Name;

                                        var properties = typeof(Models.TB_CAT17_EXTRATOR).GetProperties();

                                        foreach (var property in properties)
                                        {
                                            var value = property.GetValue(objeto_leitura);
                                            if (value == null || string.IsNullOrEmpty(value.ToString()))
                                            {
                                                property.SetValue(objeto_leitura, GetDefaultValue(property.PropertyType));
                                            }
                                        }

                                        try
                                        {
                                            DataRow newRow = dataTableMain.NewRow();
                                            mapRow(newRow, objeto_leitura);
                                            // TB_CAT17_EXTRATOR.CopyToDataRow(objeto_leitura, newRow);
                                            dataTableMain.Rows.Add(newRow);
                                        }
                                        catch (Exception ex)
                                        {
                                            string e = ex.Message;
                                        }
                                    }

                                    countRowCabecalho++;
                                }
                            }
                        }
                        catch (Exception ext)
                        {
                            string a = ext.Message;
                        }

                    }
                }

            }
        }
    }
}
//FECHAMENTO ler_form

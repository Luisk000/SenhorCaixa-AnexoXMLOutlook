﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportXml.Models
{
    public class XmlFile
    {
        [Key]
        public string nfeProc_NFe_infNFe_____Id { get; set; } //propriedade

        public string XmlName { get; set; }
        public string xml____version { get; set; }
        public string xml____encoding { get; set; }


        public string nfeProc____versao { get; set; } //propriedade
        public string nfeProc____xmlns { get; set; } //propriedade
        public string nfeProc_Nfe_infNFe____versao { get; set; } //propriedade


        public string nfeProc_NFe_infNFe_ide_cUF { get; set; }
        public string nfeProc_NFe_infNFe_ide_cNF { get; set; }
        public string nfeProc_NFe_infNFe_ide_natOp { get; set; }
        public string nfeProc_NFe_infNFe_ide_indPag { get; set; }
        public string nfeProc_NFe_infNFe_ide_mod { get; set; }
        public string nfeProc_NFe_infNFe_ide_serie { get; set; }
        public string nfeProc_NFe_infNFe_ide_nNF { get; set; }
        public string nfeProc_NFe_infNFe_ide_dhEmi { get; set; } //DateTime
        public string nfeProc_NFe_infNFe_ide_dhSaiEnt { get; set; } //novo
        public string nfeProc_NFe_infNFe_ide_tpNF { get; set; }
        public string nfeProc_NFe_infNFe_ide_idDest { get; set; }
        public string nfeProc_NFe_infNFe_ide_cMunFG { get; set; }
        public string nfeProc_NFe_infNFe_ide_tpImp { get; set; }
        public string nfeProc_NFe_infNFe_ide_tpEmis { get; set; }
        public string nfeProc_NFe_infNFe_ide_cDV { get; set; }
        public string nfeProc_NFe_infNFe_ide_tpAmb { get; set; }
        public string nfeProc_NFe_infNFe_ide_finNFe { get; set; }
        public string nfeProc_NFe_infNFe_ide_indFinal { get; set; }
        public string nfeProc_NFe_infNFe_ide_indPres { get; set; }
        public string nfeProc_NFe_infNFe_ide_indIntermed { get; set; } //novo   
        public string nfeProc_NFe_infNFe_ide_procEmi { get; set; }
        public string nfeProc_NFe_infNFe_ide_verProc { get; set; }



        public string nfeProc_NFe_infNFe_emit_CNPJ { get; set; }
        public string nfeProc_NFe_infNFe_emit_xNome { get; set; }
        public string nfeProc_NFe_infNFe_emit_xFant { get; set; }

        public string nfeProc_NFe_infNFe_emit_enderEmit_xLgr { get; set; }
        public string nfeProc_NFe_infNFe_emit_enderEmit_nro { get; set; }
        public string nfeProc_NFe_infNFe_emit_enderEmit_xBairro { get; set; }
        public string nfeProc_NFe_infNFe_emit_enderEmit_cMun { get; set; }
        public string nfeProc_NFe_infNFe_emit_enderEmit_xMun { get; set; }
        public string nfeProc_NFe_infNFe_emit_enderEmit_UF { get; set; }
        public string nfeProc_NFe_infNFe_emit_enderEmit_CEP { get; set; }
        public string nfeProc_NFe_infNFe_emit_enderEmit_cPais { get; set; }
        public string nfeProc_NFe_infNFe_emit_enderEmit_xPais { get; set; }
        public string nfeProc_NFe_infNFe_emit_enderEmit_fone { get; set; }

        public string nfeProc_NFe_infNFe_emit_IE { get; set; }
        public string nfeProc_NFe_infNFe_emit_IM { get; set; }
        public string nfeProc_NFe_infNFe_emit_CNAE { get; set; }
        public string nfeProc_NFe_infNFe_emit_CRT { get; set; }



        public string nfeProc_NFe_infNFe_dest_CNPJ { get; set; }
        public string nfeProc_NFe_infNFe_dest_xNome { get; set; }

        public string nfeProc_NFe_infNFe_dest_enderDest_xLgr { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_nro { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_xCpl { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_xBairro { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_cMun { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_xMun { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_UF { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_CEP { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_cPais { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_xPais { get; set; }
        public string nfeProc_NFe_infNFe_dest_enderDest_fone { get; set; }

        public string nfeProc_NFe_infNFe_dest_indIEDest { get; set; }
        public string nfeProc_NFe_infNFe_dest_IE { get; set; }
        public string nfeProc_NFe_infNFe_dest_email { get; set; }



        public string nfeProc_NFe_infNFe_total_ICMSTot_vBC { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vICMS { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vICMSDeson { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vFCPUFDest { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vICMSUFDest { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vICMSUFRemet { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vFCP { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vBCST { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vST { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vFCPST { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vFCPSTRet { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vProd { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vFrete { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vSeg { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vDesc { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vII { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vIPI { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vIPIDevol { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vPIS { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vCOFINS { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vOutro { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vNF { get; set; }
        public string nfeProc_NFe_infNFe_total_ICMSTot_vTotTrib { get; set; }



        public string nfeProc_NFe_infNFe_transp_modFrete { get; set; }
        public string nfeProc_NFe_infNFe_pag_detPag_indPag { get; set; }
        public string nfeProc_NFe_infNFe_pag_detPag_tPag { get; set; }
        public string nfeProc_NFe_infNFe_pag_detPag_vPag { get; set; }
        public string nfeProc_NFe_infNFe_infAdic_infCpl { get; set; }
        public string nfeProc_NFe_infNFe_infRespTec_CNPJ { get; set; }
        public string nfeProc_NFe_infNFe_infRespTec_xContato { get; set; }
        public string nfeProc_NFe_infNFe_infRespTec_email { get; set; }
        public string nfeProc_NFe_infNFe_infRespTec_fone { get; set; }



        public string nfeProc_NFe_Signature____xmlns { get; set; } //propriedade
        public string nfeProc_NFe_Signature_SignedInfo_CanonicalizationMethod____Algorithm { get; set; } //propriedade 
        public string nfeProc_NFe_Signature_SignedInfo_SignatureMethod____Algorithm { get; set; } //propriedade 
        public string nfeProc_NFe_Signature_SignedInfo_Reference____URI { get; set; } //propriedade
        //Algorithms
        public string nfeProc_NFe_Signature_SignedInfo_Reference_DigestMethod____Algorithm { get; set; } //propriedade
        public string nfeProc_NFe_Signature_SignedInfo_Reference_DigestValue { get; set; }
        public string nfeProc_NFe_Signature_SignatureValue { get; set; }
        public string nfeProc_NFe_Signature_KeyInfo_X509Data_X509Certificate { get; set; }



        public string nfeProc_protNFe____versao { get; set; } //propriedade
        public string nfeProc_protNFe_infProt_tpAmb { get; set; }
        public string nfeProc_protNFe_infProt_verAplic { get; set; }
        public string nfeProc_protNFe_infProt_chNFe { get; set; }
        public string nfeProc_protNFe_infProt_dhRecbto { get; set; }
        public string nfeProc_protNFe_infProt_nProt { get; set; }
        public string nfeProc_protNFe_infProt_digVal { get; set; }
        public string nfeProc_protNFe_infProt_cStat { get; set; }
        public string nfeProc_protNFe_infProt_xMotivo { get; set; }
    }
}



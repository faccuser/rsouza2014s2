﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.18444
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.Collections.Generic;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class retornoEnvio
{

    public retornoEnvio()
    {
        retornoOperacao = new List<retornoEnvioRetornoOperacao>();
    }

    private List<retornoEnvioRetornoOperacao> retornoOperacaoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("retornoOperacao")]
    public List<retornoEnvioRetornoOperacao> retornoOperacao
    {
        get
        {
            return this.retornoOperacaoField;
        }
        set
        {
            this.retornoOperacaoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class retornoEnvioRetornoOperacao
{

    private string statusField;

    private string mensagemField;

    private string detalheErroField;

    private string idRetornoField;

    /// <remarks/>
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    public string mensagem
    {
        get
        {
            return this.mensagemField;
        }
        set
        {
            this.mensagemField = value;
        }
    }

    /// <remarks/>
    public string detalheErro
    {
        get
        {
            return this.detalheErroField;
        }
        set
        {
            this.detalheErroField = value;
        }
    }

    /// <remarks/>
    public string idRetorno
    {
        get
        {
            return this.idRetornoField;
        }
        set
        {
            this.idRetornoField = value;
        }
    }
}

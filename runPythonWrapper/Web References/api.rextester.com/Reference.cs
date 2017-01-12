// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace runPythonWrapper.api.rextester.com {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://rextester.com/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// CodeRemarks
        public Service() {
            this.Url = "http://83.169.3.96/Service.asmx";
        }
        
        public Service(string url) {
            this.Url = url;
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/DoWork", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Result DoWork(string Program, string Input, Languages Language, string user, string pass, string compiler_args, bool bytes, bool programCompressed, bool inputCompressed) {
            object[] results = this.Invoke("DoWork", new object[] {
                        Program,
                        Input,
                        Language,
                        user,
                        pass,
                        compiler_args,
                        bytes,
                        programCompressed,
                        inputCompressed});
            return ((Result)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginDoWork(string Program, string Input, Languages Language, string user, string pass, string compiler_args, bool bytes, bool programCompressed, bool inputCompressed, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DoWork", new object[] {
                        Program,
                        Input,
                        Language,
                        user,
                        pass,
                        compiler_args,
                        bytes,
                        programCompressed,
                        inputCompressed}, callback, asyncState);
        }
        
        /// CodeRemarks
        public Result EndDoWork(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Result)(results[0]));
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/Sum", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Sum(int a, int b) {
            object[] results = this.Invoke("Sum", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginSum(int a, int b, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Sum", new object[] {
                        a,
                        b}, callback, asyncState);
        }
        
        /// CodeRemarks
        public int EndSum(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/Diff", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DiffResult Diff(string left, string right, string user, string pass) {
            object[] results = this.Invoke("Diff", new object[] {
                        left,
                        right,
                        user,
                        pass});
            return ((DiffResult)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginDiff(string left, string right, string user, string pass, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Diff", new object[] {
                        left,
                        right,
                        user,
                        pass}, callback, asyncState);
        }
        
        /// CodeRemarks
        public DiffResult EndDiff(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((DiffResult)(results[0]));
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/GetPythonDotCompletions", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetPythonDotCompletions(string source, int line, int column) {
            this.Invoke("GetPythonDotCompletions", new object[] {
                        source,
                        line,
                        column});
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginGetPythonDotCompletions(string source, int line, int column, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPythonDotCompletions", new object[] {
                        source,
                        line,
                        column}, callback, asyncState);
        }
        
        /// CodeRemarks
        public void EndGetPythonDotCompletions(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/GetPythonParenCompletions", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetPythonParenCompletions(string source, int line, int column) {
            this.Invoke("GetPythonParenCompletions", new object[] {
                        source,
                        line,
                        column});
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginGetPythonParenCompletions(string source, int line, int column, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPythonParenCompletions", new object[] {
                        source,
                        line,
                        column}, callback, asyncState);
        }
        
        /// CodeRemarks
        public void EndGetPythonParenCompletions(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://rextester.com/GetCPPCompletions", RequestNamespace="http://rextester.com/", ResponseNamespace="http://rextester.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCPPCompletions(string source, int line, int column) {
            object[] results = this.Invoke("GetCPPCompletions", new object[] {
                        source,
                        line,
                        column});
            return ((string)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginGetCPPCompletions(string source, int line, int column, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCPPCompletions", new object[] {
                        source,
                        line,
                        column}, callback, asyncState);
        }
        
        /// CodeRemarks
        public string EndGetCPPCompletions(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://rextester.com/")]
    public enum Languages {
        
        /// <remarks/>
        Java,
        
        /// <remarks/>
        Python,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        CPP,
        
        /// <remarks/>
        Php,
        
        /// <remarks/>
        Pascal,
        
        /// <remarks/>
        ObjectiveC,
        
        /// <remarks/>
        Haskell,
        
        /// <remarks/>
        Ruby,
        
        /// <remarks/>
        Perl,
        
        /// <remarks/>
        Lua,
        
        /// <remarks/>
        Nasm,
        
        /// <remarks/>
        Javascript,
        
        /// <remarks/>
        Lisp,
        
        /// <remarks/>
        Prolog,
        
        /// <remarks/>
        Go,
        
        /// <remarks/>
        Scala,
        
        /// <remarks/>
        Scheme,
        
        /// <remarks/>
        Nodejs,
        
        /// <remarks/>
        Python3,
        
        /// <remarks/>
        Octave,
        
        /// <remarks/>
        CClang,
        
        /// <remarks/>
        CppClang,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        Tcl,
        
        /// <remarks/>
        Swift,
        
        /// <remarks/>
        FSharp,
        
        /// <remarks/>
        Bash,
        
        /// <remarks/>
        Rust,
        
        /// <remarks/>
        Ada,
        
        /// <remarks/>
        Erlang,
        
        /// <remarks/>
        Elixir,
        
        /// <remarks/>
        Ocaml,
        
        /// <remarks/>
        Clojure,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://rextester.com/")]
    public partial class Result {
        
        /// <remarks/>
        public string Errors;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Errors_Bytes;
        
        /// <remarks/>
        public string Warnings;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Warnings_Bytes;
        
        /// <remarks/>
        public string Output;
        
        /// <remarks/>
        public bool IsOutputCompressed;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Output_Bytes;
        
        /// <remarks/>
        public string Stats;
        
        /// <remarks/>
        public string Exit_Status;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Exit_Code;
        
        /// <remarks/>
        public string System_Error;
        
        /// <remarks/>
        public byte[][] Files;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://rextester.com/")]
    public partial class DiffResult {
        
        /// <remarks/>
        public bool IsError;
        
        /// <remarks/>
        public string Result;
    }
}

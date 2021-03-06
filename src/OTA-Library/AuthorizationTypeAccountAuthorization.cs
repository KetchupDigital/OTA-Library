namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AuthorizationTypeAccountAuthorization
    {
        
        private AuthorizationTypeAccountAuthorizationAccountInfo _accountInfo;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private string _nonISO_CurrencyCode;
        
        public AuthorizationTypeAccountAuthorization()
        {
            this._accountInfo = new AuthorizationTypeAccountAuthorizationAccountInfo();
        }
        
        public AuthorizationTypeAccountAuthorizationAccountInfo AccountInfo
        {
            get
            {
                return this._accountInfo;
            }
            set
            {
                this._accountInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NonISO_CurrencyCode
        {
            get
            {
                return this._nonISO_CurrencyCode;
            }
            set
            {
                this._nonISO_CurrencyCode = value;
            }
        }
    }
}
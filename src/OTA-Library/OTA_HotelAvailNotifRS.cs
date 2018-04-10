using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
// ReSharper disable InconsistentNaming

namespace MLSoftware.OTA
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    [XmlRoot(Namespace = "http://www.opentravel.org/OTA/2003/05", IsNullable = false)]
    public class OTA_HotelAvailNotifRS
    {
        private List<object> _items;
        
        private string _echoToken;
        
        private DateTime _timeStamp;
        
        private MessageAcknowledgementTypeTarget _target;
        
        private string _targetName;
        
        private decimal _version;
        
        private string _transactionIdentifier;
        
        private string _sequenceNmbr;
        
        private MessageAcknowledgementTypeTransactionStatusCode _transactionStatusCode;
        
        private bool _retransmissionIndicator;
        
        private string _correlationID;
        
        private string _primaryLangID;
        
        private string _altLangID;
        
        private string _messageContentCode;
        
        public OTA_HotelAvailNotifRS()
        {
            _items = new List<object>();
        }
        
        [XmlElement("Errors", typeof(ErrorsType))]
        [XmlElement("Inventories", typeof(InvCountType))]
        [XmlElement("Success", typeof(SuccessType))]
        [XmlElement("TPA_Extensions", typeof(TPA_ExtensionsType))]
        [XmlElement("Warnings", typeof(WarningsType))]
        public List<object> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        
        [XmlAttribute]
        public string EchoToken
        {
            get
            {
                return _echoToken;
            }
            set
            {
                _echoToken = value;
            }
        }
        
        [XmlAttribute]
        public DateTime TimeStamp
        {
            get
            {
                return _timeStamp;
            }
            set
            {
                _timeStamp = value;
            }
        }
        
        [XmlAttribute]
        public MessageAcknowledgementTypeTarget Target
        {
            get
            {
                return _target;
            }
            set
            {
                _target = value;
            }
        }
        
        [XmlAttribute]
        public string TargetName
        {
            get
            {
                return _targetName;
            }
            set
            {
                _targetName = value;
            }
        }
        
        [XmlAttribute]
        public decimal Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
        
        [XmlAttribute]
        public string TransactionIdentifier
        {
            get
            {
                return _transactionIdentifier;
            }
            set
            {
                _transactionIdentifier = value;
            }
        }
        
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string SequenceNmbr
        {
            get
            {
                return _sequenceNmbr;
            }
            set
            {
                _sequenceNmbr = value;
            }
        }
        
        [XmlAttribute]
        public MessageAcknowledgementTypeTransactionStatusCode TransactionStatusCode
        {
            get
            {
                return _transactionStatusCode;
            }
            set
            {
                _transactionStatusCode = value;
            }
        }
        
        [XmlAttribute]
        public bool RetransmissionIndicator
        {
            get
            {
                return _retransmissionIndicator;
            }
            set
            {
                _retransmissionIndicator = value;
            }
        }
        
        [XmlAttribute]
        public string CorrelationID
        {
            get
            {
                return _correlationID;
            }
            set
            {
                _correlationID = value;
            }
        }
        
        [XmlAttribute(DataType = "language")]
        public string PrimaryLangID
        {
            get
            {
                return _primaryLangID;
            }
            set
            {
                _primaryLangID = value;
            }
        }
        
        [XmlAttribute(DataType = "language")]
        public string AltLangID
        {
            get
            {
                return _altLangID;
            }
            set
            {
                _altLangID = value;
            }
        }
        
        [XmlAttribute]
        public string MessageContentCode
        {
            get
            {
                return _messageContentCode;
            }
            set
            {
                _messageContentCode = value;
            }
        }
    }
}
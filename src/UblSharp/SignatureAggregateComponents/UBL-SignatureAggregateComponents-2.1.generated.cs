// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp.SignatureAggregateComponents
{
    using UblSharp.SignatureBasicComponents;
    using UblSharp.UnqualifiedDataTypes;
    using UblSharp.XmlDigitalSignature;
    using UblSharp.Xades;
    
    
    /// <summary>
    /// This class captures a single signature and optionally associates to a signature in the document with the corresponding identifier.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Signature Information. Details
    /// <para />ObjectClass: Signature Information
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2", IsNullable=false)]
    public partial class SignatureInformationType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public UnqualifiedDataTypes.IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedSignatureID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2", Order=1)]
        public UnqualifiedDataTypes.IdentifierType @__ReferencedSignatureID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", Order=2)]
        public XmlSignatureType @__Signature;
        
        /// <summary>
        /// This specifies the identifier of the signature distinguishing it from other signatures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Signature Information. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Signature Information
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public UnqualifiedDataTypes.IdentifierType ID
        {
            get
            {
                if (__ID == null) { __ID = new UnqualifiedDataTypes.IdentifierType(); }
                return __ID;
            }
            set
            {
                __ID = value;
            }
        }

        
        /// <summary>
        /// This associates this signature with the identifier of a signature business object in the document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Signature Information. Referenced Signature Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Signature Information
        /// <para />PropertyTerm: Referenced Signature Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public UnqualifiedDataTypes.IdentifierType ReferencedSignatureID
        {
            get
            {
                if (__ReferencedSignatureID == null) { __ReferencedSignatureID = new UnqualifiedDataTypes.IdentifierType(); }
                return __ReferencedSignatureID;
            }
            set
            {
                __ReferencedSignatureID = value;
            }
        }

        
        /// <summary>
        /// This is a single digital signature as defined by the W3C specification.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public XmlSignatureType Signature
        {
            get
            {
                if (__Signature == null) { __Signature = new XmlSignatureType(); }
                return __Signature;
            }
            set
            {
                __Signature = value;
            }
        }

    }
}

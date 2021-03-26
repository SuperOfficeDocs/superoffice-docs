---
uid: services85-document-substitutemergedocumenttemplatevariablesex2
title: Services85.DocumentAgent.SubstituteMergeDocumentTemplateVariablesEx2 SOAP
Generated: true
---

# Services85 Document SubstituteMergeDocumentTemplateVariablesEx2 SOAP

SOAP request and response examples **Remote/Services85/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx2">SuperOffice.Services85.IDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx2</see> method.

## SubstituteMergeDocumentTemplateVariablesEx2

Parse the source document, and replace any template variable tags with their values, based on the provided identifiers.&lt;p/&gt; The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.

* **mergeDocumentId:** The document id that refers to the binary data (document)
* **contactId:** The contact identifier to use for template substitution
* **personId:** The person identifier to use for template substitution
* **projectId:** The project identifier to use for template substitution
* **selectionId:** The selection identifier to use for template substitution
* **appointmentId:** The appointment identifier to use for template substitution
* **documentId:** The document identifier to use for template substitution
* **saleId:** The sale identifier to use for template substitution
* **customTags:** Dictionary of custom tag names and values. Each name should have exactly four characters. There should be exactly one value for each tag

**Returns:** The document as a Stream


[WSDL file for Services85/Document](../Services85-Document.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SubstituteMergeDocumentTemplateVariablesEx2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:SubstituteMergeDocumentTemplateVariablesEx2>
    <Document:MergeDocumentId xsi:type="xsd:int">0</Document:MergeDocumentId>
    <Document:ContactId xsi:type="xsd:int">0</Document:ContactId>
    <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
    <Document:ProjectId xsi:type="xsd:int">0</Document:ProjectId>
    <Document:SelectionId xsi:type="xsd:int">0</Document:SelectionId>
    <Document:AppointmentId xsi:type="xsd:int">0</Document:AppointmentId>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:SaleId xsi:type="xsd:int">0</Document:SaleId>
    <Document:CustomTags xsi:type="Document:StringDictionary">
     <Document:StringKeyValuePair>
      <Document:Key xsi:type="xsd:string"></Document:Key>
      <Document:Value xsi:type="xsd:string"></Document:Value>
     </Document:StringKeyValuePair>
    </Document:CustomTags>
   </Document:SubstituteMergeDocumentTemplateVariablesEx2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SubstituteMergeDocumentTemplateVariablesEx2 Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Document:SubstituteMergeDocumentTemplateVariablesEx2Response>
   <Document:Response xsi:type="xsd:base64Binary"></Document:Response>
  </Document:SubstituteMergeDocumentTemplateVariablesEx2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


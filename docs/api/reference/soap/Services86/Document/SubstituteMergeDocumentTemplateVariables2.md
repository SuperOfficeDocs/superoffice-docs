---
title: Services86.DocumentAgent.SubstituteMergeDocumentTemplateVariables2 SOAP
generated: 1
uid: Services86-Document-SubstituteMergeDocumentTemplateVariables2
---

# Services86 Document SubstituteMergeDocumentTemplateVariables2

SOAP request and response examples **Remote/Services86/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDocumentAgent.SubstituteMergeDocumentTemplateVariables2">SuperOffice.Services86.IDocumentAgent.SubstituteMergeDocumentTemplateVariables2</see> method.

## SubstituteMergeDocumentTemplateVariables2

Parse the source document, and replace any template variable tags with their values, based on the associate Id.&lt;p/&gt; The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.

* **documentId:** The document id that refers to the binary data (document)
* **associateId:** The associateId used to subsitute tags in the document.
* **customTags:** Dictionary of custom tag names and values. Each name should have exactly four characters. There should be exactly one value for each tag.

**Returns:** The document as a Stream


[WSDL file for Services86/Document](../Services86-Document.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SubstituteMergeDocumentTemplateVariables2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:SubstituteMergeDocumentTemplateVariables2>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
    <Document:CustomTags xsi:type="Document:StringDictionary">
     <Document:StringKeyValuePair>
      <Document:Key xsi:type="xsd:string"></Document:Key>
      <Document:Value xsi:type="xsd:string"></Document:Value>
     </Document:StringKeyValuePair>
    </Document:CustomTags>
   </Document:SubstituteMergeDocumentTemplateVariables2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SubstituteMergeDocumentTemplateVariables2 Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Document:SubstituteMergeDocumentTemplateVariables2Response>
   <Document:Response xsi:type="xsd:base64Binary"></Document:Response>
  </Document:SubstituteMergeDocumentTemplateVariables2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


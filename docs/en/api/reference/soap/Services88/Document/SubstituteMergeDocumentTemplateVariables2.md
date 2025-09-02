---
title: Services88.DocumentAgent.SubstituteMergeDocumentTemplateVariables2 SOAP
generated: true
uid: Services88-Document-SubstituteMergeDocumentTemplateVariables2
content_type: reference
---

# Services88 Document SubstituteMergeDocumentTemplateVariables2

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.SubstituteMergeDocumentTemplateVariables2">SuperOffice.Services88.IDocumentAgent.SubstituteMergeDocumentTemplateVariables2</see> method.

## SubstituteMergeDocumentTemplateVariables2





[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SubstituteMergeDocumentTemplateVariables2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Document:SubstituteMergeDocumentTemplateVariables2Response>
   <Document:Response xsi:type="xsd:base64Binary"></Document:Response>
  </Document:SubstituteMergeDocumentTemplateVariables2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


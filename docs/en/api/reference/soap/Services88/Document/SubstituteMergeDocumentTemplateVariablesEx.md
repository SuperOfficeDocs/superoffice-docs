---
title: Services88.DocumentAgent.SubstituteMergeDocumentTemplateVariablesEx SOAP
generated: true
uid: Services88-Document-SubstituteMergeDocumentTemplateVariablesEx
content_type: reference
---

# Services88 Document SubstituteMergeDocumentTemplateVariablesEx

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx">SuperOffice.Services88.IDocumentAgent.SubstituteMergeDocumentTemplateVariablesEx</see> method.

## SubstituteMergeDocumentTemplateVariablesEx





[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SubstituteMergeDocumentTemplateVariablesEx Request

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
   <Document:SubstituteMergeDocumentTemplateVariablesEx>
    <Document:MergeDocumentId xsi:type="xsd:int">0</Document:MergeDocumentId>
    <Document:ContactId xsi:type="xsd:int">0</Document:ContactId>
    <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
    <Document:ProjectId xsi:type="xsd:int">0</Document:ProjectId>
    <Document:SelectionId xsi:type="xsd:int">0</Document:SelectionId>
    <Document:AppointmentId xsi:type="xsd:int">0</Document:AppointmentId>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:SaleId xsi:type="xsd:int">0</Document:SaleId>
    <Document:CustomTags xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Document:CustomTags>
    <Document:CustomValues xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Document:CustomValues>
   </Document:SubstituteMergeDocumentTemplateVariablesEx>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SubstituteMergeDocumentTemplateVariablesEx Response

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
  <Document:SubstituteMergeDocumentTemplateVariablesExResponse>
   <Document:Response xsi:type="xsd:base64Binary"></Document:Response>
  </Document:SubstituteMergeDocumentTemplateVariablesExResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


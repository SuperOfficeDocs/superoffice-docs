---
uid: services88-document-createdefaultdocumentpreview
title: Services88.DocumentAgent.CreateDefaultDocumentPreview SOAP
Generated: true
---

# Services88 Document CreateDefaultDocumentPreview SOAP

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.CreateDefaultDocumentPreview">SuperOffice.Services88.IDocumentAgent.CreateDefaultDocumentPreview</see> method.

## CreateDefaultDocumentPreview

Loading default values into a new DocumentPreview.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New DocumentPreview with default values


[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultDocumentPreview Request

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
   <Document:CreateDefaultDocumentPreview>
   </Document:CreateDefaultDocumentPreview>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultDocumentPreview Response

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
  <Document:CreateDefaultDocumentPreviewResponse>
   <Document:Response xsi:type="Document:DocumentPreview">
    <Document:Name xsi:type="xsd:string"></Document:Name>
    <Document:Type xsi:type="xsd:string"></Document:Type>
    <Document:Size xsi:type="xsd:int">0</Document:Size>
    <Document:Stream xsi:type="xsd:base64Binary"></Document:Stream>
   </Document:Response>
  </Document:CreateDefaultDocumentPreviewResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


---
title: Services88.DocumentAgent.GetUnsanitizedPreviewDocumentStream SOAP
generated: 1
uid: Services88-Document-GetUnsanitizedPreviewDocumentStream
---

# Services88 Document GetUnsanitizedPreviewDocumentStream

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.GetUnsanitizedPreviewDocumentStream">SuperOffice.Services88.IDocumentAgent.GetUnsanitizedPreviewDocumentStream</see> method.

## GetUnsanitizedPreviewDocumentStream

Get the preview version of the document content as a stream. Retrieves an unsanitized version. This has less CPU impact but the caller must sanitize the content before presenting it to the user.

* **documentId:** SuperOffice document id

**Returns:** Unsanitized preview version of the document


[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUnsanitizedPreviewDocumentStream Request

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
   <Document:GetUnsanitizedPreviewDocumentStream>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
   </Document:GetUnsanitizedPreviewDocumentStream>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUnsanitizedPreviewDocumentStream Response

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
  <Document:GetUnsanitizedPreviewDocumentStreamResponse>
   <Document:Response xsi:type="Document:DocumentPreview">
    <Document:Name xsi:type="xsd:string"></Document:Name>
    <Document:Type xsi:type="xsd:string"></Document:Type>
    <Document:Size xsi:type="xsd:int">0</Document:Size>
    <Document:Stream xsi:type="xsd:base64Binary"></Document:Stream>
   </Document:Response>
  </Document:GetUnsanitizedPreviewDocumentStreamResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


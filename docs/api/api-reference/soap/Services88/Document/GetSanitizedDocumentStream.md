---
uid: services88-document-getsanitizeddocumentstream
title: Services88.DocumentAgent.GetSanitizedDocumentStream SOAP
Generated: true
---

# Services88 Document GetSanitizedDocumentStream SOAP

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.GetSanitizedDocumentStream">SuperOffice.Services88.IDocumentAgent.GetSanitizedDocumentStream</see> method.

## GetSanitizedDocumentStream

Get the document content as a stream. Retrieves a sanitized version if possible

* **documentId:** SuperOffice document id

**Returns:** The document as a Stream. This stream can be read once and clients should not assume it remains valid after a ReadToEnd or Close.


[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSanitizedDocumentStream Request

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
   <Document:GetSanitizedDocumentStream>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
   </Document:GetSanitizedDocumentStream>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSanitizedDocumentStream Response

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
  <Document:GetSanitizedDocumentStreamResponse>
   <Document:Response xsi:type="xsd:base64Binary"></Document:Response>
  </Document:GetSanitizedDocumentStreamResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


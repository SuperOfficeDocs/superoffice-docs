---
uid: services80-document-gettempfile
title: Services80.DocumentAgent.GetTempFile SOAP
Generated: true
---

# Services80 Document GetTempFile SOAP

SOAP request and response examples **Remote/Services80/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IDocumentAgent.GetTempFile">SuperOffice.Services80.IDocumentAgent.GetTempFile</see> method.

## GetTempFile

Get data stream for temporary file created with CreateTempFile.

* **filename:** Name of temporary file to retrieve.

**Returns:** The document as a Stream


[WSDL file for Services80/Document](../Services80-Document.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTempFile Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetTempFile>
    <Document:Filename xsi:type="xsd:string"></Document:Filename>
   </Document:GetTempFile>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTempFile Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Document:GetTempFileResponse>
   <Document:Response xsi:type="xsd:base64Binary"></Document:Response>
  </Document:GetTempFileResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


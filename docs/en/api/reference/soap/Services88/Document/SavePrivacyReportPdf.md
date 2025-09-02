---
title: Services88.DocumentAgent.SavePrivacyReportPdf SOAP
generated: true
uid: Services88-Document-SavePrivacyReportPdf
content_type: reference
---

# Services88 Document SavePrivacyReportPdf

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.SavePrivacyReportPdf">SuperOffice.Services88.IDocumentAgent.SavePrivacyReportPdf</see> method.

## SavePrivacyReportPdf





[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SavePrivacyReportPdf Request

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
   <Document:SavePrivacyReportPdf>
    <Document:Stream xsi:type="xsd:base64Binary"></Document:Stream>
    <Document:Title xsi:type="xsd:string"></Document:Title>
    <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
   </Document:SavePrivacyReportPdf>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SavePrivacyReportPdf Response

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
  <Document:SavePrivacyReportPdfResponse>
   <Document:Response xsi:type="xsd:int">0</Document:Response>
  </Document:SavePrivacyReportPdfResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


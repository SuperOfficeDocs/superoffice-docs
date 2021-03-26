---
uid: services86-document-saveprivacyreport
title: Services86.DocumentAgent.SavePrivacyReport SOAP
Generated: true
---

# Services86 Document SavePrivacyReport SOAP

SOAP request and response examples **Remote/Services86/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDocumentAgent.SavePrivacyReport">SuperOffice.Services86.IDocumentAgent.SavePrivacyReport</see> method.

## SavePrivacyReport

Generates a Pdf from HTML and makes a document

* **htmlReport:** Html to convert
* **title:** Title of report
* **personId:** Person id associated with the report

**Returns:** Document id of saved report


[WSDL file for Services86/Document](../Services86-Document.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SavePrivacyReport Request

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
   <Document:SavePrivacyReport>
    <Document:HtmlReport xsi:type="xsd:string"></Document:HtmlReport>
    <Document:Title xsi:type="xsd:string"></Document:Title>
    <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
   </Document:SavePrivacyReport>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SavePrivacyReport Response

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
  <Document:SavePrivacyReportResponse>
   <Document:Response xsi:type="xsd:int">0</Document:Response>
  </Document:SavePrivacyReportResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


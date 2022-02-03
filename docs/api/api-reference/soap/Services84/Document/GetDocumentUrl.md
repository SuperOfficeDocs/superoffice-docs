---
title: Services84.DocumentAgent.GetDocumentUrl SOAP
generated: 1
uid: Services84-Document-GetDocumentUrl
---

# Services84 Document GetDocumentUrl

SOAP request and response examples **Remote/Services84/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IDocumentAgent.GetDocumentUrl">SuperOffice.Services84.IDocumentAgent.GetDocumentUrl</see> method.

## GetDocumentUrl

Get a URL referring to the given document content.&lt;para/&gt;This URL may be passed to the ultimate client (text editor of some kind?), which is then responsible for all further operations.&lt;para/&gt;The returned string is a fully qualified URL.&lt;para/&gt;Not all documents and document plugins support this feature.

* **documentId:** SuperOffice document primary key
* **versionId:** Version ID if applicable/desired; a blank value implies "latest" version and is always acceptable.
* **writeableUrl:** If true, then a URL that supports saving is requested. Som edocument plugins may not support read-only URLs, so there is no guarantee that a False value will actually yield a read-only URL, and vice versa.

**Returns:** Fully resolved URL referring to the document. May be NULL or blank if plugin does not support URLs.


[WSDL file for Services84/Document](../Services84-Document.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetDocumentUrl>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:VersionId xsi:type="xsd:string"></Document:VersionId>
    <Document:WriteableUrl xsi:type="xsd:boolean">false</Document:WriteableUrl>
   </Document:GetDocumentUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Document:GetDocumentUrlResponse>
   <Document:Response xsi:type="xsd:string"></Document:Response>
  </Document:GetDocumentUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


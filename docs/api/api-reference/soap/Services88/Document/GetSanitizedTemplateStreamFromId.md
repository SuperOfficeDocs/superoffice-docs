---
uid: services88-document-getsanitizedtemplatestreamfromid
title: Services88.DocumentAgent.GetSanitizedTemplateStreamFromId SOAP
Generated: true
---

# Services88 Document GetSanitizedTemplateStreamFromId SOAP

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.GetSanitizedTemplateStreamFromId">SuperOffice.Services88.IDocumentAgent.GetSanitizedTemplateStreamFromId</see> method.

## GetSanitizedTemplateStreamFromId

Retrieve a stream to a document template based on its id. Sanitizes the contents if possible.

* **templateId:** Id of template to retrieve
* **uiCulture:** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** Open stream to the template


[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSanitizedTemplateStreamFromId Request

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
   <Document:GetSanitizedTemplateStreamFromId>
    <Document:TemplateId xsi:type="xsd:int">0</Document:TemplateId>
    <Document:UiCulture xsi:type="xsd:string"></Document:UiCulture>
   </Document:GetSanitizedTemplateStreamFromId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSanitizedTemplateStreamFromId Response

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
  <Document:GetSanitizedTemplateStreamFromIdResponse>
   <Document:Response xsi:type="xsd:base64Binary"></Document:Response>
  </Document:GetSanitizedTemplateStreamFromIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


---
uid: services84-document-gettemplatestream
title: Services84.DocumentAgent.GetTemplateStream SOAP
Generated: true
---

# Services84 Document GetTemplateStream SOAP

SOAP request and response examples **Remote/Services84/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IDocumentAgent.GetTemplateStream">SuperOffice.Services84.IDocumentAgent.GetTemplateStream</see> method.

## GetTemplateStream

Retrieve a stream to a mail template based on its name

* **templateName:** Filename of mail template to retrieve
* **allowPersonal:** If true, try looking up template in personal area before looking in shared document template area
* **uiCulture:** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** Open stream to the mail template


[WSDL file for Services84/Document](../Services84-Document.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTemplateStream Request

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
   <Document:GetTemplateStream>
    <Document:TemplateName xsi:type="xsd:string"></Document:TemplateName>
    <Document:AllowPersonal xsi:type="xsd:boolean">false</Document:AllowPersonal>
    <Document:UiCulture xsi:type="xsd:string"></Document:UiCulture>
   </Document:GetTemplateStream>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTemplateStream Response

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
  <Document:GetTemplateStreamResponse>
   <Document:Response xsi:type="xsd:base64Binary"></Document:Response>
  </Document:GetTemplateStreamResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


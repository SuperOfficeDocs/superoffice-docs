---
uid: services83-document-settemplatestream
title: Services83.DocumentAgent.SetTemplateStream SOAP
Generated: true
---

# Services83 Document SetTemplateStream SOAP

SOAP request and response examples **Remote/Services83/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IDocumentAgent.SetTemplateStream">SuperOffice.Services83.IDocumentAgent.SetTemplateStream</see> method.

## SetTemplateStream

Save a mail signature template to the document archive

* **filename:** Filename of template.
* **personal:** If true, save the template in the user area, instead of in shared template area.
* **stream:** The signature template content as a stream.

**Returns:** This method has no return value


[WSDL file for Services83/Document](../Services83-Document.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetTemplateStream Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:SetTemplateStream>
    <Document:Filename xsi:type="xsd:string"></Document:Filename>
    <Document:Personal xsi:type="xsd:boolean">false</Document:Personal>
    <Document:Stream xsi:type="xsd:base64Binary"></Document:Stream>
   </Document:SetTemplateStream>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetTemplateStream Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Document:SetTemplateStreamResponse>
  </Document:SetTemplateStreamResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


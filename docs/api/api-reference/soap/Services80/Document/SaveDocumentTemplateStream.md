---
uid: services80-document-savedocumenttemplatestream
title: Services80.DocumentAgent.SaveDocumentTemplateStream SOAP
Generated: true
---

# Services80 Document SaveDocumentTemplateStream SOAP

SOAP request and response examples **Remote/Services80/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IDocumentAgent.SaveDocumentTemplateStream">SuperOffice.Services80.IDocumentAgent.SaveDocumentTemplateStream</see> method.

## SaveDocumentTemplateStream

Saves content in stream to document template file

* **documentTemplateId:** Identifier for document template
* **content:** Stream containing content to be saved to document template file
* **languageCode:** Language code
* **pluginId:** Plugin id

**Returns:** Template info


[WSDL file for Services80/Document](../Services80-Document.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDocumentTemplateStream Request

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
   <Document:SaveDocumentTemplateStream>
    <Document:DocumentTemplateId xsi:type="xsd:int">0</Document:DocumentTemplateId>
    <Document:Content xsi:type="xsd:base64Binary"></Document:Content>
    <Document:LanguageCode xsi:type="xsd:string"></Document:LanguageCode>
    <Document:PluginId xsi:type="xsd:int">0</Document:PluginId>
   </Document:SaveDocumentTemplateStream>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveDocumentTemplateStream Response

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
  <Document:SaveDocumentTemplateStreamResponse>
   <Document:Response xsi:type="Document:TemplateInfo">
    <Document:Name xsi:type="xsd:string"></Document:Name>
    <Document:Description xsi:type="xsd:string"></Document:Description>
    <Document:ExternalReference xsi:type="xsd:string"></Document:ExternalReference>
    <Document:PluginId xsi:type="xsd:int">0</Document:PluginId>
   </Document:Response>
  </Document:SaveDocumentTemplateStreamResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


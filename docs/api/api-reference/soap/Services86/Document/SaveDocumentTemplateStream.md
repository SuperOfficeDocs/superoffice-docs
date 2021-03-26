---
uid: services86-document-savedocumenttemplatestream
title: Services86.DocumentAgent.SaveDocumentTemplateStream SOAP
Generated: true
---

# Services86 Document SaveDocumentTemplateStream SOAP

SOAP request and response examples **Remote/Services86/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDocumentAgent.SaveDocumentTemplateStream">SuperOffice.Services86.IDocumentAgent.SaveDocumentTemplateStream</see> method.

## SaveDocumentTemplateStream

Saves content in stream to document template file

* **documentTemplateId:** Identifier for document template
* **content:** Stream containing content to be saved to document template file
* **languageCode:** Language variation of template to update. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
* **pluginId:** Plugin id. Use -1 to use the plugin specified in the template.

**Returns:** Template info


[WSDL file for Services86/Document](../Services86-Document.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDocumentTemplateStream Request

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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services86">
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


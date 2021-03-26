---
uid: services83-list-getdocumenttemplatelanguages
title: Services83.ListAgent.GetDocumentTemplateLanguages SOAP
Generated: true
---

# Services83 List GetDocumentTemplateLanguages SOAP

SOAP request and response examples **Remote/Services83/List.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IListAgent.GetDocumentTemplateLanguages">SuperOffice.Services83.IListAgent.GetDocumentTemplateLanguages</see> method.

## GetDocumentTemplateLanguages

Get the supported language variations for a document template

* **documentTemplateId:** The id of the document template

**Returns:** Returns the list of languages as ISO cultures (en-US, no, sv, etc)


[WSDL file for Services83/List](../Services83-List.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentTemplateLanguages Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetDocumentTemplateLanguages>
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
   </List:GetDocumentTemplateLanguages>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentTemplateLanguages Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <List:GetDocumentTemplateLanguagesResponse>
   <List:Response xsi:type="NetServerServices832:ArrayOfstring">
    <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
   </List:Response>
  </List:GetDocumentTemplateLanguagesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


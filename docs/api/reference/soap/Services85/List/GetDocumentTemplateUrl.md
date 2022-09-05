---
title: Services85.ListAgent.GetDocumentTemplateUrl SOAP
generated: 1
uid: Services85-List-GetDocumentTemplateUrl
---

# Services85 List GetDocumentTemplateUrl

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.GetDocumentTemplateUrl">SuperOffice.Services85.IListAgent.GetDocumentTemplateUrl</see> method.

## GetDocumentTemplateUrl

Get a url to the document template

* **documentTemplateId:** The id of the template
* **writableUrl:** Get a writeable url to the document template?
* **languageCode:** The language code ('en-US', 'nb-NO', etc). Use empty string if not supported or used.

**Returns:** The URL to the document template


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentTemplateUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetDocumentTemplateUrl>
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
    <List:WritableUrl xsi:type="xsd:boolean">false</List:WritableUrl>
    <List:LanguageCode xsi:type="xsd:string"></List:LanguageCode>
   </List:GetDocumentTemplateUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentTemplateUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:GetDocumentTemplateUrlResponse>
   <List:Response xsi:type="xsd:string"></List:Response>
  </List:GetDocumentTemplateUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


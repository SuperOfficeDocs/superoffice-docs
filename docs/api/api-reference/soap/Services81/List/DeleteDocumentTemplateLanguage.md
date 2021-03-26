---
uid: services81-list-deletedocumenttemplatelanguage
title: Services81.ListAgent.DeleteDocumentTemplateLanguage SOAP
Generated: true
---

# Services81 List DeleteDocumentTemplateLanguage SOAP

SOAP request and response examples **Remote/Services81/List.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IListAgent.DeleteDocumentTemplateLanguage">SuperOffice.Services81.IListAgent.DeleteDocumentTemplateLanguage</see> method.

## DeleteDocumentTemplateLanguage

Deletes language variant of the document template

* **documentTemplateId:** The id of the document template
* **languageCode:** The language code ('en-US, 'nb-NO', etc)



[WSDL file for Services81/List](../Services81-List.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDocumentTemplateLanguage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:DeleteDocumentTemplateLanguage>
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
    <List:LanguageCode xsi:type="xsd:string"></List:LanguageCode>
   </List:DeleteDocumentTemplateLanguage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteDocumentTemplateLanguage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <List:DeleteDocumentTemplateLanguageResponse>
  </List:DeleteDocumentTemplateLanguageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


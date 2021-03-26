---
uid: services82-list-getdocumenttemplateentity
title: Services82.ListAgent.GetDocumentTemplateEntity SOAP
Generated: true
---

# Services82 List GetDocumentTemplateEntity SOAP

SOAP request and response examples **Remote/Services82/List.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IListAgent.GetDocumentTemplateEntity">SuperOffice.Services82.IListAgent.GetDocumentTemplateEntity</see> method.

## GetDocumentTemplateEntity

Gets a DocumentTemplateEntity object.

* **documentTemplateEntityId:** The identifier of the DocumentTemplateEntity object

**Returns:** DocumentTemplateEntity


[WSDL file for Services82/List](../Services82-List.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentTemplateEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetDocumentTemplateEntity>
    <List:DocumentTemplateEntityId xsi:type="xsd:int">0</List:DocumentTemplateEntityId>
   </List:GetDocumentTemplateEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentTemplateEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <List:GetDocumentTemplateEntityResponse>
   <List:Response xsi:type="List:DocumentTemplateEntity">
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:SaveInDb xsi:type="xsd:short">0</List:SaveInDb>
    <List:Filename xsi:type="xsd:string"></List:Filename>
    <List:DefaultOref xsi:type="xsd:string"></List:DefaultOref>
    <List:RecordType xsi:type="List:DocTmplType">Unknown</List:RecordType>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:Direction xsi:type="List:DocTmplDirection">Unknown</List:Direction>
    <List:AutoeventId xsi:type="xsd:int">0</List:AutoeventId>
    <List:IntentId xsi:type="xsd:int">0</List:IntentId>
    <List:IsDefaultPublished xsi:type="xsd:boolean">false</List:IsDefaultPublished>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:LoadTemplateFromPlugin xsi:type="xsd:int">0</List:LoadTemplateFromPlugin>
    <List:MimeType xsi:type="xsd:string"></List:MimeType>
    <List:IsInUseInGuides xsi:type="xsd:boolean">false</List:IsInUseInGuides>
    <List:DocumentTypeKey xsi:type="xsd:int">0</List:DocumentTypeKey>
    <List:QuoteDocType xsi:type="List:DocTmplQuoteType">None</List:QuoteDocType>
   </List:Response>
  </List:GetDocumentTemplateEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


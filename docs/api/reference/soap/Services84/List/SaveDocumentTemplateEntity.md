---
title: Services84.ListAgent.SaveDocumentTemplateEntity SOAP
generated: 1
uid: Services84-List-SaveDocumentTemplateEntity
---

# Services84 List SaveDocumentTemplateEntity

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.SaveDocumentTemplateEntity">SuperOffice.Services84.IListAgent.SaveDocumentTemplateEntity</see> method.

## SaveDocumentTemplateEntity

Updates the existing DocumentTemplateEntity or creates a new DocumentTemplateEntity if the id parameter is 0.

* **documentTemplateEntity:** The DocumentTemplateEntity that is saved.

**Returns:** New or updated DocumentTemplateEntity


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDocumentTemplateEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SaveDocumentTemplateEntity>
    <List:DocumentTemplateEntity xsi:type="List:DocumentTemplateEntity">
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
     <List:PrivacyDocType xsi:type="List:DocTmplPrivacyType">None</List:PrivacyDocType>
     <List:EmailSubject xsi:type="xsd:string"></List:EmailSubject>
    </List:DocumentTemplateEntity>
   </List:SaveDocumentTemplateEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveDocumentTemplateEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <List:SaveDocumentTemplateEntityResponse>
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
    <List:PrivacyDocType xsi:type="List:DocTmplPrivacyType">None</List:PrivacyDocType>
    <List:EmailSubject xsi:type="xsd:string"></List:EmailSubject>
   </List:Response>
  </List:SaveDocumentTemplateEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


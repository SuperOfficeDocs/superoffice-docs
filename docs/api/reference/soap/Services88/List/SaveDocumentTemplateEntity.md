---
title: Services88.ListAgent.SaveDocumentTemplateEntity SOAP
generated: 1
uid: Services88-List-SaveDocumentTemplateEntity
---

# Services88 List SaveDocumentTemplateEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SaveDocumentTemplateEntity">SuperOffice.Services88.IListAgent.SaveDocumentTemplateEntity</see> method.

## SaveDocumentTemplateEntity

Updates the existing DocumentTemplateEntity or creates a new DocumentTemplateEntity if the id parameter is 0.

* **documentTemplateEntity:** The DocumentTemplateEntity that is saved.

**Returns:** New or updated DocumentTemplateEntity


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDocumentTemplateEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
     <List:IncludeSignature xsi:type="xsd:boolean">false</List:IncludeSignature>
     <List:ShowCurrents xsi:type="xsd:boolean">false</List:ShowCurrents>
     <List:SenderEmailMode xsi:type="List:SenderMailMode">UseDefaultSender</List:SenderEmailMode>
     <List:SenderEmailAddress xsi:type="xsd:string"></List:SenderEmailAddress>
     <List:InvitationDocType xsi:type="List:DocTmplInvitationType">None</List:InvitationDocType>
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
    <List:IncludeSignature xsi:type="xsd:boolean">false</List:IncludeSignature>
    <List:ShowCurrents xsi:type="xsd:boolean">false</List:ShowCurrents>
    <List:SenderEmailMode xsi:type="List:SenderMailMode">UseDefaultSender</List:SenderEmailMode>
    <List:SenderEmailAddress xsi:type="xsd:string"></List:SenderEmailAddress>
    <List:InvitationDocType xsi:type="List:DocTmplInvitationType">None</List:InvitationDocType>
   </List:Response>
  </List:SaveDocumentTemplateEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


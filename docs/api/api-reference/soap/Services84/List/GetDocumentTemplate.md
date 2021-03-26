---
uid: services84-list-getdocumenttemplate
title: Services84.ListAgent.GetDocumentTemplate SOAP
Generated: true
---

# Services84 List GetDocumentTemplate SOAP

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.GetDocumentTemplate">SuperOffice.Services84.IListAgent.GetDocumentTemplate</see> method.

## GetDocumentTemplate

Gets a DocumentTemplate object.

* **documentTemplateId:** The identifier of the DocumentTemplate object

**Returns:** DocumentTemplate


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentTemplate Request

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
   <List:GetDocumentTemplate>
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
   </List:GetDocumentTemplate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentTemplate Response

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
  <List:GetDocumentTemplateResponse>
   <List:Response xsi:type="List:DocumentTemplate">
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:SaveInDb xsi:type="xsd:short">0</List:SaveInDb>
    <List:Filename xsi:type="xsd:string"></List:Filename>
    <List:DefaultOref xsi:type="xsd:string"></List:DefaultOref>
    <List:RecordType xsi:type="List:DocTmplType">Unknown</List:RecordType>
    <List:Deleted xsi:type="xsd:short">0</List:Deleted>
    <List:Direction xsi:type="List:DocTmplDirection">Unknown</List:Direction>
    <List:AutoeventId xsi:type="xsd:int">0</List:AutoeventId>
    <List:QuoteDocType xsi:type="List:DocTmplQuoteType">None</List:QuoteDocType>
   </List:Response>
  </List:GetDocumentTemplateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


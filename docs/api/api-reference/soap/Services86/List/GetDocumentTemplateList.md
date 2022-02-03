---
title: Services86.ListAgent.GetDocumentTemplateList SOAP
generated: 1
uid: Services86-List-GetDocumentTemplateList
---

# Services86 List GetDocumentTemplateList

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.GetDocumentTemplateList">SuperOffice.Services86.IListAgent.GetDocumentTemplateList</see> method.

## GetDocumentTemplateList

Gets an array of DocumentTemplate objects.

* **documentTemplateIds:** The identifiers of the DocumentTemplate object

**Returns:** Array of DocumentTemplate objects


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentTemplateList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetDocumentTemplateList>
    <List:DocumentTemplateIds xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
    </List:DocumentTemplateIds>
   </List:GetDocumentTemplateList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentTemplateList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <List:GetDocumentTemplateListResponse>
   <List:Response xsi:type="List:ArrayOfDocumentTemplate">
    <List:DocumentTemplate xsi:type="List:DocumentTemplate">
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
    </List:DocumentTemplate>
   </List:Response>
  </List:GetDocumentTemplateListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


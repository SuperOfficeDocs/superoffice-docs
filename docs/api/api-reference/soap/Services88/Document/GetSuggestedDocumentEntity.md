---
title: Services88.DocumentAgent.GetSuggestedDocumentEntity SOAP
generated: 1
uid: Services88-Document-GetSuggestedDocumentEntity
---

# Services88 Document GetSuggestedDocumentEntity

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.GetSuggestedDocumentEntity">SuperOffice.Services88.IDocumentAgent.GetSuggestedDocumentEntity</see> method.

## GetSuggestedDocumentEntity

Gets a SuggestedDocumentEntity object.

* **suggestedDocumentEntityId:** The identifier of the SuggestedDocumentEntity object

**Returns:** SuggestedDocumentEntity


[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSuggestedDocumentEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetSuggestedDocumentEntity>
    <Document:SuggestedDocumentEntityId xsi:type="xsd:int">0</Document:SuggestedDocumentEntityId>
   </Document:GetSuggestedDocumentEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSuggestedDocumentEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Document:GetSuggestedDocumentEntityResponse>
   <Document:Response xsi:type="Document:SuggestedDocumentEntity">
    <Document:SuggestedDocumentId xsi:type="xsd:int">0</Document:SuggestedDocumentId>
    <Document:Name xsi:type="xsd:string"></Document:Name>
    <Document:Tooltip xsi:type="xsd:string"></Document:Tooltip>
    <Document:Rank xsi:type="xsd:short">0</Document:Rank>
    <Document:DoctmplId xsi:type="xsd:int">0</Document:DoctmplId>
    <Document:Header xsi:type="xsd:string"></Document:Header>
    <Document:OurRef xsi:type="xsd:string"></Document:OurRef>
    <Document:Deleted xsi:type="xsd:boolean">false</Document:Deleted>
    <Document:DocTmpl xsi:type="Document:DocumentTemplate">
     <Document:DocumentTemplateId xsi:type="xsd:int">0</Document:DocumentTemplateId>
     <Document:Name xsi:type="xsd:string"></Document:Name>
     <Document:Tooltip xsi:type="xsd:string"></Document:Tooltip>
     <Document:SaveInDb xsi:type="xsd:short">0</Document:SaveInDb>
     <Document:Filename xsi:type="xsd:string"></Document:Filename>
     <Document:DefaultOref xsi:type="xsd:string"></Document:DefaultOref>
     <Document:RecordType xsi:type="Document:DocTmplType">Unknown</Document:RecordType>
     <Document:Deleted xsi:type="xsd:short">0</Document:Deleted>
     <Document:Direction xsi:type="Document:DocTmplDirection">Unknown</Document:Direction>
     <Document:AutoeventId xsi:type="xsd:int">0</Document:AutoeventId>
     <Document:QuoteDocType xsi:type="Document:DocTmplQuoteType">None</Document:QuoteDocType>
    </Document:DocTmpl>
    <Document:ProjectTypeStatusLink xsi:type="Document:ProjectTypeStatusLink">
     <Document:ProjectTypeStatusLinkId xsi:type="xsd:int">0</Document:ProjectTypeStatusLinkId>
     <Document:ProjTypeId xsi:type="xsd:int">0</Document:ProjTypeId>
     <Document:ProjTypeName xsi:type="xsd:string"></Document:ProjTypeName>
     <Document:ProjTypeTooltip xsi:type="xsd:string"></Document:ProjTypeTooltip>
     <Document:ProjStatusId xsi:type="xsd:int">0</Document:ProjStatusId>
     <Document:ProjStatusName xsi:type="xsd:string"></Document:ProjStatusName>
     <Document:ProjStatusTooltip xsi:type="xsd:string"></Document:ProjStatusTooltip>
    </Document:ProjectTypeStatusLink>
    <Document:SaleTypeStageLink xsi:type="Document:SaleTypeStageLink">
     <Document:SaleTypeStageLinkId xsi:type="xsd:int">0</Document:SaleTypeStageLinkId>
     <Document:SaleTypeId xsi:type="xsd:int">0</Document:SaleTypeId>
     <Document:SaleTypeName xsi:type="xsd:string"></Document:SaleTypeName>
     <Document:SaleTypeTooltip xsi:type="xsd:string"></Document:SaleTypeTooltip>
     <Document:ProbId xsi:type="xsd:int">0</Document:ProbId>
     <Document:ProbName xsi:type="xsd:string"></Document:ProbName>
     <Document:ProbTooltip xsi:type="xsd:string"></Document:ProbTooltip>
     <Document:Probability xsi:type="xsd:short">0</Document:Probability>
    </Document:SaleTypeStageLink>
   </Document:Response>
  </Document:GetSuggestedDocumentEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


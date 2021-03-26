---
uid: services81-document-createdefaultsuggesteddocumententity
title: Services81.DocumentAgent.CreateDefaultSuggestedDocumentEntity SOAP
Generated: true
---

# Services81 Document CreateDefaultSuggestedDocumentEntity SOAP

SOAP request and response examples **Remote/Services81/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IDocumentAgent.CreateDefaultSuggestedDocumentEntity">SuperOffice.Services81.IDocumentAgent.CreateDefaultSuggestedDocumentEntity</see> method.

## CreateDefaultSuggestedDocumentEntity

Loading default values into a new SuggestedDocumentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New SuggestedDocumentEntity with default values


[WSDL file for Services81/Document](../Services81-Document.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultSuggestedDocumentEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:CreateDefaultSuggestedDocumentEntity>
   </Document:CreateDefaultSuggestedDocumentEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultSuggestedDocumentEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Document:CreateDefaultSuggestedDocumentEntityResponse>
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
  </Document:CreateDefaultSuggestedDocumentEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


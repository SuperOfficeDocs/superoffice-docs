---
uid: services87-list-getallsaletypeentities
title: Services87.ListAgent.GetAllSaleTypeEntities SOAP
Generated: true
---

# Services87 List GetAllSaleTypeEntities SOAP

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.GetAllSaleTypeEntities">SuperOffice.Services87.IListAgent.GetAllSaleTypeEntities</see> method.

## GetAllSaleTypeEntities

Returns all sale types as entities with stakeholders, guide and quote properties

* **includeDeleted:** Include deleted items in result?

**Returns:** Array of sale type entities with stakeholders, guide and quote properties


[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllSaleTypeEntities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetAllSaleTypeEntities>
    <List:IncludeDeleted xsi:type="xsd:boolean">false</List:IncludeDeleted>
   </List:GetAllSaleTypeEntities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllSaleTypeEntities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <List:GetAllSaleTypeEntitiesResponse>
   <List:Response xsi:type="List:ArrayOfSaleTypeEntity">
    <List:SaleTypeEntity xsi:type="List:SaleTypeEntity">
     <List:SaleTypeId xsi:type="xsd:int">0</List:SaleTypeId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:DurationUnit xsi:type="List:DurationUnit">Unknown</List:DurationUnit>
     <List:SaleDuration xsi:type="xsd:int">0</List:SaleDuration>
     <List:SaleTypeCatId xsi:type="xsd:int">0</List:SaleTypeCatId>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:HasGuide xsi:type="xsd:boolean">false</List:HasGuide>
     <List:HasStakeholders xsi:type="xsd:boolean">false</List:HasStakeholders>
     <List:IsAutoAdvance xsi:type="xsd:boolean">false</List:IsAutoAdvance>
     <List:AllowQuoteAlternatives xsi:type="xsd:boolean">false</List:AllowQuoteAlternatives>
     <List:DefaultQuoteValidity xsi:type="xsd:int">0</List:DefaultQuoteValidity>
     <List:QuoteLinesTemplate xsi:type="xsd:int">0</List:QuoteLinesTemplate>
     <List:ConfirmationLinesTemplate xsi:type="xsd:int">0</List:ConfirmationLinesTemplate>
     <List:MaxDiscountPercentSet xsi:type="xsd:boolean">false</List:MaxDiscountPercentSet>
     <List:MinEarningPercentSet xsi:type="xsd:boolean">false</List:MinEarningPercentSet>
     <List:MaxDiscountPercent xsi:type="xsd:int">0</List:MaxDiscountPercent>
     <List:MinEarningPercent xsi:type="xsd:int">0</List:MinEarningPercent>
     <List:GroupQuoteLinesBy xsi:type="xsd:int">0</List:GroupQuoteLinesBy>
     <List:SortGroupLinesBy xsi:type="xsd:int">0</List:SortGroupLinesBy>
     <List:Stages xsi:type="List:ArrayOfSelectableMDOListItem">
      <List:SelectableMDOListItem xsi:type="List:SelectableMDOListItem">
       <List:Id xsi:type="xsd:int">0</List:Id>
       <List:Name xsi:type="xsd:string"></List:Name>
       <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
       <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
       <List:Rank xsi:type="xsd:int">0</List:Rank>
       <List:Type xsi:type="xsd:string"></List:Type>
       <List:ColorBlock xsi:type="xsd:int">0</List:ColorBlock>
       <List:IconHint xsi:type="xsd:string"></List:IconHint>
       <List:Selected xsi:type="xsd:boolean">false</List:Selected>
       <List:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:36Z</List:LastChanged>
       <List:ChildItems xsi:type="List:ArrayOfSelectableMDOListItem">
        <List:SelectableMDOListItem xsi:type="List:SelectableMDOListItem">
         <List:Id xsi:type="xsd:int">0</List:Id>
         <List:Name xsi:type="xsd:string"></List:Name>
         <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
         <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
         <List:Rank xsi:type="xsd:int">0</List:Rank>
         <List:Type xsi:type="xsd:string"></List:Type>
         <List:ColorBlock xsi:type="xsd:int">0</List:ColorBlock>
         <List:IconHint xsi:type="xsd:string"></List:IconHint>
         <List:Selected xsi:type="xsd:boolean">false</List:Selected>
         <List:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:36Z</List:LastChanged>
         <List:ChildItems xsi:type="List:ArrayOfSelectableMDOListItem">
          <List:SelectableMDOListItem xsi:nil="true"></List:SelectableMDOListItem>
         </List:ChildItems>
         <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
         <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
         <List:Hidden xsi:type="xsd:boolean">false</List:Hidden>
         <List:FullName xsi:type="xsd:string"></List:FullName>
        </List:SelectableMDOListItem>
       </List:ChildItems>
       <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
       <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
       <List:Hidden xsi:type="xsd:boolean">false</List:Hidden>
       <List:FullName xsi:type="xsd:string"></List:FullName>
      </List:SelectableMDOListItem>
     </List:Stages>
    </List:SaleTypeEntity>
   </List:Response>
  </List:GetAllSaleTypeEntitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


---
title: Services86.ListAgent.GetSaleTypeEntity SOAP
generated: 1
uid: Services86-List-GetSaleTypeEntity
---

# Services86 List GetSaleTypeEntity

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.GetSaleTypeEntity">SuperOffice.Services86.IListAgent.GetSaleTypeEntity</see> method.

## GetSaleTypeEntity

Gets a SaleTypeEntity object.

* **saleTypeEntityId:** The identifier of the SaleTypeEntity object

**Returns:** SaleTypeEntity


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSaleTypeEntity Request

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
   <List:GetSaleTypeEntity>
    <List:SaleTypeEntityId xsi:type="xsd:int">0</List:SaleTypeEntityId>
   </List:GetSaleTypeEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSaleTypeEntity Response

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
  <List:GetSaleTypeEntityResponse>
   <List:Response xsi:type="List:SaleTypeEntity">
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
      <List:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:55:19Z</List:LastChanged>
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
        <List:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:55:19Z</List:LastChanged>
        <List:ChildItems xsi:type="List:ArrayOfSelectableMDOListItem">
         <List:SelectableMDOListItem xsi:type="List:SelectableMDOListItem">
          <List:Id xsi:nil="true"></List:Id>
          <List:Name xsi:type="xsd:string"></List:Name>
          <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
          <List:Deleted xsi:nil="true"></List:Deleted>
          <List:Rank xsi:nil="true"></List:Rank>
          <List:Type xsi:type="xsd:string"></List:Type>
          <List:ColorBlock xsi:nil="true"></List:ColorBlock>
          <List:IconHint xsi:type="xsd:string"></List:IconHint>
          <List:Selected xsi:nil="true"></List:Selected>
          <List:LastChanged xsi:nil="true"></List:LastChanged>
          <List:ChildItems xsi:nil="true"></List:ChildItems>
          <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
          <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
          <List:Hidden xsi:nil="true"></List:Hidden>
          <List:FullName xsi:type="xsd:string"></List:FullName>
         </List:SelectableMDOListItem>
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
   </List:Response>
  </List:GetSaleTypeEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


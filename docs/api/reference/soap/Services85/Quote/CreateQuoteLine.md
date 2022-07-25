---
title: Services85.QuoteAgent.CreateQuoteLine SOAP
generated: 1
uid: Services85-Quote-CreateQuoteLine
---

# Services85 Quote CreateQuoteLine

SOAP request and response examples **Remote/Services85/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IQuoteAgent.CreateQuoteLine">SuperOffice.Services85.IQuoteAgent.CreateQuoteLine</see> method.

## CreateQuoteLine

Create a quoteline based on a product key.

* **quoteAlternativeId:** Primary key of the alternative
* **eRPProductKey:** Primary key of the product in the ProductProvider

**Returns:** The updated quote line.

[WSDL file for Services85/Quote](../Services85-Quote.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateQuoteLine Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:CreateQuoteLine>
    <Quote:QuoteAlternativeId xsi:type="xsd:int">0</Quote:QuoteAlternativeId>
    <Quote:ERPProductKey xsi:type="xsd:string"></Quote:ERPProductKey>
   </Quote:CreateQuoteLine>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## CreateQuoteLine Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Quote:CreateQuoteLineResponse>
   <Quote:Response xsi:type="Quote:QuoteLine">
    <Quote:QuoteLineId xsi:type="xsd:int">0</Quote:QuoteLineId>
    <Quote:ERPQuoteLineKey xsi:type="xsd:string"></Quote:ERPQuoteLineKey>
    <Quote:QuoteAlternativeId xsi:type="xsd:int">0</Quote:QuoteAlternativeId>
    <Quote:ERPProductKey xsi:type="xsd:string"></Quote:ERPProductKey>
    <Quote:Status xsi:type="Quote:QuoteStatus">Ok</Quote:Status>
    <Quote:Reason xsi:type="xsd:string"></Quote:Reason>
    <Quote:Quantity xsi:type="xsd:double">0.0</Quote:Quantity>
    <Quote:DeliveredQuantity xsi:type="xsd:double">0.0</Quote:DeliveredQuantity>
    <Quote:Rank xsi:type="xsd:int">0</Quote:Rank>
    <Quote:Name xsi:type="xsd:string"></Quote:Name>
    <Quote:Description xsi:type="xsd:string"></Quote:Description>
    <Quote:Code xsi:type="xsd:string"></Quote:Code>
    <Quote:QuantityUnit xsi:type="xsd:string"></Quote:QuantityUnit>
    <Quote:PriceUnit xsi:type="xsd:string"></Quote:PriceUnit>
    <Quote:ItemNumber xsi:type="xsd:string"></Quote:ItemNumber>
    <Quote:Url xsi:type="xsd:string"></Quote:Url>
    <Quote:ProductCategoryKey xsi:type="xsd:string"></Quote:ProductCategoryKey>
    <Quote:ProductFamilyKey xsi:type="xsd:string"></Quote:ProductFamilyKey>
    <Quote:ProductTypeKey xsi:type="xsd:string"></Quote:ProductTypeKey>
    <Quote:Supplier xsi:type="xsd:string"></Quote:Supplier>
    <Quote:SupplierCode xsi:type="xsd:string"></Quote:SupplierCode>
    <Quote:Thumbnail xsi:type="xsd:string"></Quote:Thumbnail>
    <Quote:VATInfo xsi:type="xsd:string"></Quote:VATInfo>
    <Quote:VAT xsi:type="xsd:double">0.0</Quote:VAT>
    <Quote:UnitCost xsi:type="xsd:double">0.0</Quote:UnitCost>
    <Quote:UnitMinimumPrice xsi:type="xsd:double">0.0</Quote:UnitMinimumPrice>
    <Quote:UnitListPrice xsi:type="xsd:double">0.0</Quote:UnitListPrice>
    <Quote:ExtraInfo xsi:type="Quote:ArrayOfProductExtraDataField">
     <Quote:ProductExtraDataField xsi:type="Quote:ProductExtraDataField">
      <Quote:Name xsi:type="xsd:string"></Quote:Name>
      <Quote:Value xsi:type="xsd:string"></Quote:Value>
      <Quote:Type xsi:type="Quote:ExtraDataFieldType">String</Quote:Type>
     </Quote:ProductExtraDataField>
    </Quote:ExtraInfo>
    <Quote:RawExtraInfo xsi:type="xsd:string"></Quote:RawExtraInfo>
    <Quote:IsSubscription xsi:type="xsd:boolean">false</Quote:IsSubscription>
    <Quote:SubscriptionUnit xsi:type="xsd:string"></Quote:SubscriptionUnit>
    <Quote:SubscriptionQuantity xsi:type="xsd:double">0.0</Quote:SubscriptionQuantity>
    <Quote:SubscriptionStart xsi:type="xsd:dateTime">2021-11-30T13:22:40Z</Quote:SubscriptionStart>
    <Quote:ERPDiscountPercent xsi:type="xsd:double">0.0</Quote:ERPDiscountPercent>
    <Quote:ERPDiscountAmount xsi:type="xsd:double">0.0</Quote:ERPDiscountAmount>
    <Quote:DiscountPercent xsi:type="xsd:double">0.0</Quote:DiscountPercent>
    <Quote:DiscountAmount xsi:type="xsd:double">0.0</Quote:DiscountAmount>
    <Quote:UserValueOverride xsi:type="Quote:ValueOverride">None</Quote:UserValueOverride>
    <Quote:EarningPercent xsi:type="xsd:double">0.0</Quote:EarningPercent>
    <Quote:EarningAmount xsi:type="xsd:double">0.0</Quote:EarningAmount>
    <Quote:SubTotal xsi:type="xsd:double">0.0</Quote:SubTotal>
    <Quote:TotalPrice xsi:type="xsd:double">0.0</Quote:TotalPrice>
    <Quote:Rights xsi:type="xsd:string"></Quote:Rights>
    <Quote:Rule xsi:type="xsd:string"></Quote:Rule>
    <Quote:ExtraField1 xsi:type="xsd:string"></Quote:ExtraField1>
    <Quote:ExtraField2 xsi:type="xsd:string"></Quote:ExtraField2>
    <Quote:ExtraField3 xsi:type="xsd:string"></Quote:ExtraField3>
    <Quote:ExtraField4 xsi:type="xsd:string"></Quote:ExtraField4>
    <Quote:ExtraField5 xsi:type="xsd:string"></Quote:ExtraField5>
   </Quote:Response>
  </Quote:CreateQuoteLineResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

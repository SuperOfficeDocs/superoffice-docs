---
uid: services87-quote-getquotefromsaleid
title: Services87.QuoteAgent.GetQuoteFromSaleId SOAP
Generated: true
---

# Services87 Quote GetQuoteFromSaleId SOAP

SOAP request and response examples **Remote/Services87/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IQuoteAgent.GetQuoteFromSaleId">SuperOffice.Services87.IQuoteAgent.GetQuoteFromSaleId</see> method.

## GetQuoteFromSaleId

Get a Quote for a sale

* **saleId:** SaleId of the Quote to get.

**Returns:** The Quote


[WSDL file for Services87/Quote](../Services87-Quote.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuoteFromSaleId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetQuoteFromSaleId>
    <Quote:SaleId xsi:type="xsd:int">0</Quote:SaleId>
   </Quote:GetQuoteFromSaleId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetQuoteFromSaleId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Quote:GetQuoteFromSaleIdResponse>
   <Quote:Response xsi:type="Quote:Quote">
    <Quote:QuoteId xsi:type="xsd:int">0</Quote:QuoteId>
    <Quote:SaleId xsi:type="xsd:int">0</Quote:SaleId>
    <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
    <Quote:ERPQuoteKey xsi:type="xsd:string"></Quote:ERPQuoteKey>
    <Quote:ERPOrderKey xsi:type="xsd:string"></Quote:ERPOrderKey>
    <Quote:ActiveQuoteVersionId xsi:type="xsd:int">0</Quote:ActiveQuoteVersionId>
    <Quote:AcceptedQuoteAlternativeId xsi:type="xsd:int">0</Quote:AcceptedQuoteAlternativeId>
    <Quote:UseValuesFromQuote xsi:type="xsd:short">0</Quote:UseValuesFromQuote>
    <Quote:DocumentId xsi:type="xsd:int">0</Quote:DocumentId>
    <Quote:PoNumber xsi:type="xsd:string"></Quote:PoNumber>
    <Quote:OrderComment xsi:type="xsd:string"></Quote:OrderComment>
    <Quote:PreferredEmailCulture xsi:type="xsd:string"></Quote:PreferredEmailCulture>
    <Quote:ActiveQuoteVersion xsi:type="Quote:QuoteVersion">
     <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
     <Quote:ERPQuoteVersionKey xsi:type="xsd:string"></Quote:ERPQuoteVersionKey>
     <Quote:QuoteId xsi:type="xsd:int">0</Quote:QuoteId>
     <Quote:Description xsi:type="xsd:string"></Quote:Description>
     <Quote:Number xsi:type="xsd:string"></Quote:Number>
     <Quote:State xsi:type="Quote:QuoteVersionState">Unknown</Quote:State>
     <Quote:ArchivedState xsi:type="Quote:QuoteVersionState">Unknown</Quote:ArchivedState>
     <Quote:Status xsi:type="Quote:QuoteStatus">Ok</Quote:Status>
     <Quote:Reason xsi:type="xsd:string"></Quote:Reason>
     <Quote:LikelyQuoteAlternativeId xsi:type="xsd:int">0</Quote:LikelyQuoteAlternativeId>
     <Quote:SentDate xsi:type="xsd:dateTime">2021-03-25T21:36:42Z</Quote:SentDate>
     <Quote:FollowupId xsi:type="xsd:int">0</Quote:FollowupId>
     <Quote:ExpirationDate xsi:type="xsd:dateTime">2021-03-25T21:36:42Z</Quote:ExpirationDate>
     <Quote:DeliveryCountryId xsi:type="xsd:int">0</Quote:DeliveryCountryId>
     <Quote:HasOwnDeliveryAddress xsi:type="xsd:boolean">false</Quote:HasOwnDeliveryAddress>
     <Quote:InvoiceCountryId xsi:type="xsd:int">0</Quote:InvoiceCountryId>
     <Quote:HasOwnInvoiceAddress xsi:type="xsd:boolean">false</Quote:HasOwnInvoiceAddress>
     <Quote:ERPPaymentTermsKey xsi:type="xsd:string"></Quote:ERPPaymentTermsKey>
     <Quote:ERPPaymentTypeKey xsi:type="xsd:string"></Quote:ERPPaymentTypeKey>
     <Quote:ERPDeliveryTermsKey xsi:type="xsd:string"></Quote:ERPDeliveryTermsKey>
     <Quote:ERPDeliveryTypeKey xsi:type="xsd:string"></Quote:ERPDeliveryTypeKey>
     <Quote:Rank xsi:type="xsd:int">0</Quote:Rank>
     <Quote:ApprovedBy xsi:type="xsd:int">0</Quote:ApprovedBy>
     <Quote:ApprovedText xsi:type="xsd:string"></Quote:ApprovedText>
     <Quote:ApprovedRegisteredBy xsi:type="xsd:int">0</Quote:ApprovedRegisteredBy>
     <Quote:ApprovedRegisteredDate xsi:type="xsd:dateTime">2021-03-25T21:36:42Z</Quote:ApprovedRegisteredDate>
     <Quote:ExtraField1 xsi:type="xsd:string"></Quote:ExtraField1>
     <Quote:ExtraField2 xsi:type="xsd:string"></Quote:ExtraField2>
     <Quote:ExtraField3 xsi:type="xsd:string"></Quote:ExtraField3>
     <Quote:ExtraField4 xsi:type="xsd:string"></Quote:ExtraField4>
     <Quote:ExtraField5 xsi:type="xsd:string"></Quote:ExtraField5>
     <Quote:LastRecalculated xsi:type="xsd:dateTime">2021-03-25T21:36:42Z</Quote:LastRecalculated>
     <Quote:Updated xsi:type="xsd:dateTime">2021-03-25T21:36:42Z</Quote:Updated>
     <Quote:UpdatedAssociateId xsi:type="xsd:int">0</Quote:UpdatedAssociateId>
     <Quote:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:42Z</Quote:Registered>
     <Quote:RegisteredAssociateId xsi:type="xsd:int">0</Quote:RegisteredAssociateId>
     <Quote:QuoteAlternatives xsi:type="Quote:ArrayOfQuoteAlternative">
      <Quote:QuoteAlternative xsi:type="Quote:QuoteAlternative">
       <Quote:QuoteAlternativeId xsi:type="xsd:int">0</Quote:QuoteAlternativeId>
       <Quote:ERPQuoteAlternativeKey xsi:type="xsd:string"></Quote:ERPQuoteAlternativeKey>
       <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
       <Quote:Name xsi:type="xsd:string"></Quote:Name>
       <Quote:Description xsi:type="xsd:string"></Quote:Description>
       <Quote:Status xsi:type="Quote:QuoteStatus">Ok</Quote:Status>
       <Quote:Reason xsi:type="xsd:string"></Quote:Reason>
       <Quote:ERPDiscountPercent xsi:type="xsd:double">0.0</Quote:ERPDiscountPercent>
       <Quote:ERPDiscountAmount xsi:type="xsd:double">0.0</Quote:ERPDiscountAmount>
       <Quote:DiscountPercent xsi:type="xsd:double">0.0</Quote:DiscountPercent>
       <Quote:DiscountAmount xsi:type="xsd:double">0.0</Quote:DiscountAmount>
       <Quote:UserValueOverride xsi:type="Quote:ValueOverride">None</Quote:UserValueOverride>
       <Quote:VATInfo xsi:type="xsd:string"></Quote:VATInfo>
       <Quote:VAT xsi:type="xsd:double">0.0</Quote:VAT>
       <Quote:EarningPercent xsi:type="xsd:double">0.0</Quote:EarningPercent>
       <Quote:EarningAmount xsi:type="xsd:double">0.0</Quote:EarningAmount>
       <Quote:SubTotal xsi:type="xsd:double">0.0</Quote:SubTotal>
       <Quote:TotalPrice xsi:type="xsd:double">0.0</Quote:TotalPrice>
       <Quote:ExtraField1 xsi:type="xsd:string"></Quote:ExtraField1>
       <Quote:ExtraField2 xsi:type="xsd:string"></Quote:ExtraField2>
       <Quote:ExtraField3 xsi:type="xsd:string"></Quote:ExtraField3>
       <Quote:ExtraField4 xsi:type="xsd:string"></Quote:ExtraField4>
       <Quote:ExtraField5 xsi:type="xsd:string"></Quote:ExtraField5>
      </Quote:QuoteAlternative>
     </Quote:QuoteAlternatives>
    </Quote:ActiveQuoteVersion>
    <Quote:FavoriteQuoteAlternative xsi:type="Quote:QuoteAlternative">
     <Quote:QuoteAlternativeId xsi:type="xsd:int">0</Quote:QuoteAlternativeId>
     <Quote:ERPQuoteAlternativeKey xsi:type="xsd:string"></Quote:ERPQuoteAlternativeKey>
     <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
     <Quote:Name xsi:type="xsd:string"></Quote:Name>
     <Quote:Description xsi:type="xsd:string"></Quote:Description>
     <Quote:Status xsi:type="Quote:QuoteStatus">Ok</Quote:Status>
     <Quote:Reason xsi:type="xsd:string"></Quote:Reason>
     <Quote:ERPDiscountPercent xsi:type="xsd:double">0.0</Quote:ERPDiscountPercent>
     <Quote:ERPDiscountAmount xsi:type="xsd:double">0.0</Quote:ERPDiscountAmount>
     <Quote:DiscountPercent xsi:type="xsd:double">0.0</Quote:DiscountPercent>
     <Quote:DiscountAmount xsi:type="xsd:double">0.0</Quote:DiscountAmount>
     <Quote:UserValueOverride xsi:type="Quote:ValueOverride">None</Quote:UserValueOverride>
     <Quote:VATInfo xsi:type="xsd:string"></Quote:VATInfo>
     <Quote:VAT xsi:type="xsd:double">0.0</Quote:VAT>
     <Quote:EarningPercent xsi:type="xsd:double">0.0</Quote:EarningPercent>
     <Quote:EarningAmount xsi:type="xsd:double">0.0</Quote:EarningAmount>
     <Quote:SubTotal xsi:type="xsd:double">0.0</Quote:SubTotal>
     <Quote:TotalPrice xsi:type="xsd:double">0.0</Quote:TotalPrice>
     <Quote:ExtraField1 xsi:type="xsd:string"></Quote:ExtraField1>
     <Quote:ExtraField2 xsi:type="xsd:string"></Quote:ExtraField2>
     <Quote:ExtraField3 xsi:type="xsd:string"></Quote:ExtraField3>
     <Quote:ExtraField4 xsi:type="xsd:string"></Quote:ExtraField4>
     <Quote:ExtraField5 xsi:type="xsd:string"></Quote:ExtraField5>
    </Quote:FavoriteQuoteAlternative>
   </Quote:Response>
  </Quote:GetQuoteFromSaleIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


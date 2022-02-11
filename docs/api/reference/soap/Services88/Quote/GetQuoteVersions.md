---
title: Services88.QuoteAgent.GetQuoteVersions SOAP
generated: 1
uid: Services88-Quote-GetQuoteVersions
---

# Services88 Quote GetQuoteVersions

SOAP request and response examples **Remote/Services88/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IQuoteAgent.GetQuoteVersions">SuperOffice.Services88.IQuoteAgent.GetQuoteVersions</see> method.

## GetQuoteVersions

Get all quote versions for a sale

* **quoteId:** QuoteId of the quote to get versions from

**Returns:** Array of Quote versions


[WSDL file for Services88/Quote](../Services88-Quote.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuoteVersions Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetQuoteVersions>
    <Quote:QuoteId xsi:type="xsd:int">0</Quote:QuoteId>
   </Quote:GetQuoteVersions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetQuoteVersions Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Quote:GetQuoteVersionsResponse>
   <Quote:Response xsi:type="Quote:ArrayOfQuoteVersion">
    <Quote:QuoteVersion xsi:type="Quote:QuoteVersion">
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
     <Quote:SentDate xsi:type="xsd:dateTime">2021-11-30T13:23:49Z</Quote:SentDate>
     <Quote:FollowupId xsi:type="xsd:int">0</Quote:FollowupId>
     <Quote:ExpirationDate xsi:type="xsd:dateTime">2021-11-30T13:23:49Z</Quote:ExpirationDate>
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
     <Quote:ApprovedRegisteredDate xsi:type="xsd:dateTime">2021-11-30T13:23:49Z</Quote:ApprovedRegisteredDate>
     <Quote:ExtraField1 xsi:type="xsd:string"></Quote:ExtraField1>
     <Quote:ExtraField2 xsi:type="xsd:string"></Quote:ExtraField2>
     <Quote:ExtraField3 xsi:type="xsd:string"></Quote:ExtraField3>
     <Quote:ExtraField4 xsi:type="xsd:string"></Quote:ExtraField4>
     <Quote:ExtraField5 xsi:type="xsd:string"></Quote:ExtraField5>
     <Quote:LastRecalculated xsi:type="xsd:dateTime">2021-11-30T13:23:49Z</Quote:LastRecalculated>
     <Quote:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:49Z</Quote:Updated>
     <Quote:UpdatedAssociateId xsi:type="xsd:int">0</Quote:UpdatedAssociateId>
     <Quote:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:49Z</Quote:Registered>
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
    </Quote:QuoteVersion>
   </Quote:Response>
  </Quote:GetQuoteVersionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


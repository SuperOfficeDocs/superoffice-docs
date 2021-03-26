---
uid: services75-quote-updatequoteversionprices
title: Services75.QuoteAgent.UpdateQuoteVersionPrices SOAP
Generated: true
---

# Services75 Quote UpdateQuoteVersionPrices SOAP

SOAP request and response examples **Remote/Services75/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IQuoteAgent.UpdateQuoteVersionPrices">SuperOffice.Services75.IQuoteAgent.UpdateQuoteVersionPrices</see> method.

## UpdateQuoteVersionPrices

Update price on the all the quotelines for each alternative in the current quote version

* **quoteVersionId:** The version to be update prices for

**Returns:** The updated quote version.


[WSDL file for Services75/Quote](../Services75-Quote.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateQuoteVersionPrices Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:UpdateQuoteVersionPrices>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
   </Quote:UpdateQuoteVersionPrices>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateQuoteVersionPrices Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Quote:UpdateQuoteVersionPricesResponse>
   <Quote:Response xsi:type="Quote:QuoteVersionValidated">
    <Quote:IsOk xsi:type="xsd:boolean">false</Quote:IsOk>
    <Quote:UserExplanation xsi:type="xsd:string"></Quote:UserExplanation>
    <Quote:TechExplanation xsi:type="xsd:string"></Quote:TechExplanation>
    <Quote:ErrorCode xsi:type="xsd:string"></Quote:ErrorCode>
    <Quote:ChangedSale xsi:type="Quote:Sale">
     <Quote:ContactName xsi:type="xsd:string"></Quote:ContactName>
     <Quote:SaleDate xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:SaleDate>
     <Quote:SaleId xsi:type="xsd:int">0</Quote:SaleId>
     <Quote:Probability xsi:type="xsd:short">0</Quote:Probability>
     <Quote:Title xsi:type="xsd:string"></Quote:Title>
     <Quote:Amount xsi:type="xsd:double">0.0</Quote:Amount>
     <Quote:Currency xsi:type="xsd:string"></Quote:Currency>
     <Quote:ProjectName xsi:type="xsd:string"></Quote:ProjectName>
     <Quote:AssociateFullName xsi:type="xsd:string"></Quote:AssociateFullName>
     <Quote:Description xsi:type="xsd:string"></Quote:Description>
     <Quote:Status xsi:type="Quote:SaleStatus">Unknown</Quote:Status>
     <Quote:WeightedAmount xsi:type="xsd:double">0.0</Quote:WeightedAmount>
     <Quote:ProjectId xsi:type="xsd:int">0</Quote:ProjectId>
     <Quote:EarningPercent xsi:type="xsd:double">0.0</Quote:EarningPercent>
     <Quote:Earning xsi:type="xsd:double">0.0</Quote:Earning>
     <Quote:ContactId xsi:type="xsd:int">0</Quote:ContactId>
     <Quote:AssociateId xsi:type="xsd:int">0</Quote:AssociateId>
     <Quote:PersonId xsi:type="xsd:int">0</Quote:PersonId>
     <Quote:SaleTypeId xsi:type="xsd:int">0</Quote:SaleTypeId>
     <Quote:SaleTypeName xsi:type="xsd:string"></Quote:SaleTypeName>
     <Quote:PersonFullName xsi:type="xsd:string"></Quote:PersonFullName>
     <Quote:Completed xsi:type="Quote:ActivityStatus">Unknown</Quote:Completed>
     <Quote:ActiveErpLinks xsi:type="xsd:int">0</Quote:ActiveErpLinks>
    </Quote:ChangedSale>
    <Quote:ChangedQuote xsi:type="Quote:Quote">
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
      <Quote:SentDate xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:SentDate>
      <Quote:FollowupId xsi:type="xsd:int">0</Quote:FollowupId>
      <Quote:ExpirationDate xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:ExpirationDate>
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
      <Quote:ApprovedRegisteredDate xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:ApprovedRegisteredDate>
      <Quote:ExtraField1 xsi:type="xsd:string"></Quote:ExtraField1>
      <Quote:ExtraField2 xsi:type="xsd:string"></Quote:ExtraField2>
      <Quote:ExtraField3 xsi:type="xsd:string"></Quote:ExtraField3>
      <Quote:ExtraField4 xsi:type="xsd:string"></Quote:ExtraField4>
      <Quote:ExtraField5 xsi:type="xsd:string"></Quote:ExtraField5>
      <Quote:LastRecalculated xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:LastRecalculated>
      <Quote:Updated xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:Updated>
      <Quote:UpdatedAssociateId xsi:type="xsd:int">0</Quote:UpdatedAssociateId>
      <Quote:Registered xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:Registered>
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
    </Quote:ChangedQuote>
    <Quote:ChangedQuoteVersion xsi:type="Quote:QuoteVersion">
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
     <Quote:SentDate xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:SentDate>
     <Quote:FollowupId xsi:type="xsd:int">0</Quote:FollowupId>
     <Quote:ExpirationDate xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:ExpirationDate>
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
     <Quote:ApprovedRegisteredDate xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:ApprovedRegisteredDate>
     <Quote:ExtraField1 xsi:type="xsd:string"></Quote:ExtraField1>
     <Quote:ExtraField2 xsi:type="xsd:string"></Quote:ExtraField2>
     <Quote:ExtraField3 xsi:type="xsd:string"></Quote:ExtraField3>
     <Quote:ExtraField4 xsi:type="xsd:string"></Quote:ExtraField4>
     <Quote:ExtraField5 xsi:type="xsd:string"></Quote:ExtraField5>
     <Quote:LastRecalculated xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:LastRecalculated>
     <Quote:Updated xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:Updated>
     <Quote:UpdatedAssociateId xsi:type="xsd:int">0</Quote:UpdatedAssociateId>
     <Quote:Registered xsi:type="xsd:dateTime">2021-03-25T21:32:30Z</Quote:Registered>
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
    </Quote:ChangedQuoteVersion>
    <Quote:ChangedQuoteAlternatives xsi:type="Quote:ArrayOfQuoteAlternativeRecalculated">
     <Quote:QuoteAlternativeRecalculated xsi:type="Quote:QuoteAlternativeRecalculated">
      <Quote:QuoteLinesHasChanged xsi:type="xsd:boolean">false</Quote:QuoteLinesHasChanged>
      <Quote:ChangedQuoteAlternative xsi:type="Quote:QuoteAlternative">
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
      </Quote:ChangedQuoteAlternative>
      <Quote:Changes xsi:type="Quote:ChangedData">
       <Quote:AddedRecords xsi:type="Quote:ArrayOfChangedDataItem">
        <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
         <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
         <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
        </Quote:ChangedDataItem>
       </Quote:AddedRecords>
       <Quote:UpdatedRecords xsi:type="Quote:ArrayOfChangedDataItem">
        <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
         <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
         <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
        </Quote:ChangedDataItem>
       </Quote:UpdatedRecords>
       <Quote:DeletedRecords xsi:type="Quote:ArrayOfChangedDataItem">
        <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
         <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
         <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
        </Quote:ChangedDataItem>
       </Quote:DeletedRecords>
      </Quote:Changes>
     </Quote:QuoteAlternativeRecalculated>
    </Quote:ChangedQuoteAlternatives>
   </Quote:Response>
  </Quote:UpdateQuoteVersionPricesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


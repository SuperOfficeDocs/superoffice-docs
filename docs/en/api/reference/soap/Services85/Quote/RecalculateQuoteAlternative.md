---
title: Services85.QuoteAgent.RecalculateQuoteAlternative SOAP
generated: 1
uid: Services85-Quote-RecalculateQuoteAlternative
---

# Services85 Quote RecalculateQuoteAlternative

SOAP request and response examples **Remote/Services85/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IQuoteAgent.RecalculateQuoteAlternative">SuperOffice.Services85.IQuoteAgent.RecalculateQuoteAlternative</see> method.

## RecalculateQuoteAlternative

[WSDL file for Services85/Quote](../Services85-Quote.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RecalculateQuoteAlternative Request

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
   <Quote:RecalculateQuoteAlternative>
    <Quote:QuoteAlternative xsi:type="xsd:int">0</Quote:QuoteAlternative>
   </Quote:RecalculateQuoteAlternative>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## RecalculateQuoteAlternative Response

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
  <Quote:RecalculateQuoteAlternativeResponse>
   <Quote:Response xsi:type="Quote:QuoteAlternativeRecalculated">
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
   </Quote:Response>
  </Quote:RecalculateQuoteAlternativeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

---
uid: services75-quote-getquotealternatives
title: Services75.QuoteAgent.GetQuoteAlternatives SOAP
Generated: true
---

# Services75 Quote GetQuoteAlternatives SOAP

SOAP request and response examples **Remote/Services75/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IQuoteAgent.GetQuoteAlternatives">SuperOffice.Services75.IQuoteAgent.GetQuoteAlternatives</see> method.

## GetQuoteAlternatives

Get all quote alternatives for a quote version

* **quoteVersionId:** QuoteVersionId of the revison to get alternatives for.

**Returns:** Array of Quote alternatives


[WSDL file for Services75/Quote](../Services75-Quote.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuoteAlternatives Request

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
   <Quote:GetQuoteAlternatives>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
   </Quote:GetQuoteAlternatives>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetQuoteAlternatives Response

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
  <Quote:GetQuoteAlternativesResponse>
   <Quote:Response xsi:type="Quote:ArrayOfQuoteAlternative">
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
   </Quote:Response>
  </Quote:GetQuoteAlternativesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


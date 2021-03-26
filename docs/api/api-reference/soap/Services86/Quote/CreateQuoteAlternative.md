---
uid: services86-quote-createquotealternative
title: Services86.QuoteAgent.CreateQuoteAlternative SOAP
Generated: true
---

# Services86 Quote CreateQuoteAlternative SOAP

SOAP request and response examples **Remote/Services86/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IQuoteAgent.CreateQuoteAlternative">SuperOffice.Services86.IQuoteAgent.CreateQuoteAlternative</see> method.

## CreateQuoteAlternative

Create a new quote alternative on a version.

* **quoteVersionId:** QuoteVersionId of the version to create the alternative on.
* **quoteAlternativeName:** The name to set on the new alternative.
* **quoteAlternativeDescription:** The description to set on the new alternative.

**Returns:** The newly created QuoteAlternative.


[WSDL file for Services86/Quote](../Services86-Quote.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateQuoteAlternative Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:CreateQuoteAlternative>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
    <Quote:QuoteAlternativeName xsi:type="xsd:string"></Quote:QuoteAlternativeName>
    <Quote:QuoteAlternativeDescription xsi:type="xsd:string"></Quote:QuoteAlternativeDescription>
   </Quote:CreateQuoteAlternative>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateQuoteAlternative Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Quote:CreateQuoteAlternativeResponse>
   <Quote:Response xsi:type="Quote:QuoteAlternative">
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
   </Quote:Response>
  </Quote:CreateQuoteAlternativeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


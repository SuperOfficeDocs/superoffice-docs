---
title: Services88.QuoteAgent.CopySuperOfficePriceList SOAP
generated: true
uid: Services88-Quote-CopySuperOfficePriceList
---

# Services88 Quote CopySuperOfficePriceList

SOAP request and response examples **Remote/Services88/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IQuoteAgent.CopySuperOfficePriceList">SuperOffice.Services88.IQuoteAgent.CopySuperOfficePriceList</see> method.

## CopySuperOfficePriceList





[WSDL file for Services88/Quote](../Services88-Quote.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CopySuperOfficePriceList Request

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
   <Quote:CopySuperOfficePriceList>
    <Quote:OriginalPriceListId xsi:type="xsd:int">0</Quote:OriginalPriceListId>
    <Quote:NewName xsi:type="xsd:string"></Quote:NewName>
    <Quote:ValidFrom xsi:type="xsd:dateTime">2025-06-26T01:44:40Z</Quote:ValidFrom>
    <Quote:ValidTo xsi:type="xsd:dateTime">2025-06-26T01:44:40Z</Quote:ValidTo>
    <Quote:NewCurrencyId xsi:type="xsd:int">0</Quote:NewCurrencyId>
    <Quote:ConvertCurrency xsi:type="xsd:boolean">false</Quote:ConvertCurrency>
   </Quote:CopySuperOfficePriceList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CopySuperOfficePriceList Response

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
  <Quote:CopySuperOfficePriceListResponse>
   <Quote:Response xsi:type="Quote:PriceList">
    <Quote:PriceListId xsi:type="xsd:int">0</Quote:PriceListId>
    <Quote:ERPPriceListKey xsi:type="xsd:string"></Quote:ERPPriceListKey>
    <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
    <Quote:Name xsi:type="xsd:string"></Quote:Name>
    <Quote:Description xsi:type="xsd:string"></Quote:Description>
    <Quote:Currency xsi:type="xsd:string"></Quote:Currency>
    <Quote:CurrencyName xsi:type="xsd:string"></Quote:CurrencyName>
    <Quote:ValidFrom xsi:type="xsd:dateTime">2025-06-26T01:44:40Z</Quote:ValidFrom>
    <Quote:ValidTo xsi:type="xsd:dateTime">2025-06-26T01:44:40Z</Quote:ValidTo>
    <Quote:IsActive xsi:type="xsd:boolean">false</Quote:IsActive>
   </Quote:Response>
  </Quote:CopySuperOfficePriceListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


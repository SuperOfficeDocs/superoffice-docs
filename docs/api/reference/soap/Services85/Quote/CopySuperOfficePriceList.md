---
title: Services85.QuoteAgent.CopySuperOfficePriceList SOAP
generated: 1
uid: Services85-Quote-CopySuperOfficePriceList
---

# Services85 Quote CopySuperOfficePriceList

SOAP request and response examples **Remote/Services85/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IQuoteAgent.CopySuperOfficePriceList">SuperOffice.Services85.IQuoteAgent.CopySuperOfficePriceList</see> method.

## CopySuperOfficePriceList

Create a copy of a PriceList in the SuperOffice database

* **originalPriceListId:** Id of the PriceList to be copied
* **newName:** Name of the copied PriceList
* **validFrom:** Start date for the new pricelist.
* **validTo:** End date for the new pricelist.
* **newCurrencyId:** Currency id of the copied PriceList. If 0 or the same as the original the copied products will keep their prices and the currency will be the same as the original.
* **convertCurrency:** If true, product prices will be recalculated to the new currency. If false, product prices will be set to zero.

**Returns:** The copied PriceList


[WSDL file for Services85/Quote](../Services85-Quote.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CopySuperOfficePriceList Request

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
   <Quote:CopySuperOfficePriceList>
    <Quote:OriginalPriceListId xsi:type="xsd:int">0</Quote:OriginalPriceListId>
    <Quote:NewName xsi:type="xsd:string"></Quote:NewName>
    <Quote:ValidFrom xsi:type="xsd:dateTime">2022-08-26T08:53:33Z</Quote:ValidFrom>
    <Quote:ValidTo xsi:type="xsd:dateTime">2022-08-26T08:53:33Z</Quote:ValidTo>
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services85">
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
    <Quote:ValidFrom xsi:type="xsd:dateTime">2022-08-26T08:53:33Z</Quote:ValidFrom>
    <Quote:ValidTo xsi:type="xsd:dateTime">2022-08-26T08:53:33Z</Quote:ValidTo>
    <Quote:IsActive xsi:type="xsd:boolean">false</Quote:IsActive>
   </Quote:Response>
  </Quote:CopySuperOfficePriceListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


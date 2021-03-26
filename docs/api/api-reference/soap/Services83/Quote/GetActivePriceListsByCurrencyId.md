---
uid: services83-quote-getactivepricelistsbycurrencyid
title: Services83.QuoteAgent.GetActivePriceListsByCurrencyId SOAP
Generated: true
---

# Services83 Quote GetActivePriceListsByCurrencyId SOAP

SOAP request and response examples **Remote/Services83/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IQuoteAgent.GetActivePriceListsByCurrencyId">SuperOffice.Services83.IQuoteAgent.GetActivePriceListsByCurrencyId</see> method.

## GetActivePriceListsByCurrencyId

Gets the available active PriceLists in a specific currency. Will return empty array if there is no PriceList with the stated currency available.

* **quoteConnectionId:** Primary key of the connection
* **currencyId:** SuperOffice currency id.

**Returns:** The PriceLists that supports a specific currency


[WSDL file for Services83/Quote](../Services83-Quote.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetActivePriceListsByCurrencyId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetActivePriceListsByCurrencyId>
    <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
    <Quote:CurrencyId xsi:type="xsd:int">0</Quote:CurrencyId>
   </Quote:GetActivePriceListsByCurrencyId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetActivePriceListsByCurrencyId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Quote:GetActivePriceListsByCurrencyIdResponse>
   <Quote:Response xsi:type="Quote:ArrayOfPriceList">
    <Quote:PriceList xsi:type="Quote:PriceList">
     <Quote:PriceListId xsi:type="xsd:int">0</Quote:PriceListId>
     <Quote:ERPPriceListKey xsi:type="xsd:string"></Quote:ERPPriceListKey>
     <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
     <Quote:Name xsi:type="xsd:string"></Quote:Name>
     <Quote:Description xsi:type="xsd:string"></Quote:Description>
     <Quote:Currency xsi:type="xsd:string"></Quote:Currency>
     <Quote:CurrencyName xsi:type="xsd:string"></Quote:CurrencyName>
     <Quote:ValidFrom xsi:type="xsd:dateTime">2021-03-25T21:35:13Z</Quote:ValidFrom>
     <Quote:ValidTo xsi:type="xsd:dateTime">2021-03-25T21:35:13Z</Quote:ValidTo>
     <Quote:IsActive xsi:type="xsd:boolean">false</Quote:IsActive>
    </Quote:PriceList>
   </Quote:Response>
  </Quote:GetActivePriceListsByCurrencyIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

